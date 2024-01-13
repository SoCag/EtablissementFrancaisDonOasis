using Microsoft.EntityFrameworkCore;
using ProjetNote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNote
{
    public partial class FrmQuestionnaire : Form
    {
        FrmPrincipal application;
        Questionnaire questionnaireEnCours;
        Categorie categorie;
        Question questionEnCours;
        List<SousQuestion> sousQuestion;
        int indexSousQuestionEnCours;
        SousQuestion sousQuestionEnCours;
        ReponseQuestionnaire? reponseQuestionnaireEnCours = null;
        Donneur donneurEnCours;
        public FrmQuestionnaire(FrmPrincipal pApplication, Donneur pDonneurEnCours)
        {
            InitializeComponent();
            application = pApplication;
            donneurEnCours = pDonneurEnCours;
            // On créer le questionnaire
            createQuestionnaire();
            // On récupère la première question
            searchQuestion("First");
            buttonSuivant.Enabled = true;
        }

        // Créer le questionnaire
        private void createQuestionnaire()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    questionnaireEnCours = new Questionnaire
                    {
                        DateQuestionnaire = DateTime.Now,
                        AccordPartage = false,
                        IdDonneur = donneurEnCours.IdDonneur,
                        // Dépend de l'entretien
                        IdTypeResultat = 3
                    };
                    context.Add(questionnaireEnCours);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la création du questionnaire : \n" + ex.Message);
            }
        }

        private void majStatut()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // On regarde s'il y a une réponse à "Oui" qui est rend impossible le don
                    List<int> listRendImpossible = context.SousQuestions
                        .Where(sq => sq.RendImpossible == true)
                        .Select(sq => sq.IdSousQuestion)
                        .ToList();

                    int nbImpossible = context.ReponseQuestionnaires
                        .Where(rq => listRendImpossible.Contains(rq.IdSousQuestion) && rq.IdReponse == 1 && rq.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire)
                        .Count();

                    if (nbImpossible == 0)
                    {
                        // Je compte le nombre de "Je sais pas" ou "Oui"
                        int nbAutre = context.ReponseQuestionnaires
                            .Where(rq => (rq.IdReponse == 1 || rq.IdReponse == 3) && rq.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire)
                            .Count();

                        if (nbAutre == 0)
                        {
                            // Sinon le formulaire est confirmé
                            questionnaireEnCours.IdTypeResultat = 1;
                        }
                        else
                        {
                            questionnaireEnCours.IdTypeResultat = 3;
                        }
                    }
                    else
                    {
                        questionnaireEnCours.IdTypeResultat = 2;
                    }
                    context.Entry(questionnaireEnCours).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la mise à jour du statut :\n" + ex.Message);
            }
        }

        // Récupère les informations en cours
        private void searchQuestion(string TypeSearch)
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    switch (TypeSearch)
                    {
                        case "First":
                            // On récupère la première question
                            questionEnCours = context.Questions
                                .Where(q => q.Ordre == 1)
                                .First();
                            // On récupère sa catégorie
                            categorie = context.Categories
                                .Where(c => c.IdCategorie == questionEnCours.IdCategorie)
                                .First();
                            // On récupère la liste de sous questions
                            sousQuestion = context.SousQuestions
                                .Where(sq => sq.IdQuestion == questionEnCours.IdQuestion)
                                .OrderBy(sq => sq.Ordre)
                                .ToList();
                            // On met l'index à 0
                            indexSousQuestionEnCours = 0;
                            // On récupère la première sous question
                            sousQuestionEnCours = sousQuestion[indexSousQuestionEnCours];
                            break;

                        case "Next":
                            // On regarde si on est à la dernière sous question de la question
                            // Si oui, on passe à la question suivante
                            if (sousQuestionEnCours == sousQuestion.Last())
                            {
                                // On regarde si on est à la dernière question
                                if (questionEnCours.Ordre == context.Questions.Max(q => q.Ordre))
                                {
                                    // Alors on récolte l'accord utilisateur// Afficher une boîte de dialogue avec des boutons de choix (Yes/No)
                                    DialogResult choix = MessageBox.Show("Donnez-vous votre accord pour utiliser votre questionnaire à des fins de recherche, d'enseignement et un usage non thérapeutique ?", "Accord", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    // Vérifier la réponse de l'utilisateur
                                    if (choix == DialogResult.Yes)
                                    {
                                        // On passe l'accord à vrai
                                        questionnaireEnCours.AccordPartage = true;
                                        context.Entry(questionnaireEnCours).State = EntityState.Modified;
                                        context.SaveChanges();
                                    }

                                    majStatut();

                                    TypeResultat resultat = context.TypeResultats
                                        .Where(tr => tr.IdTypeResultat == questionnaireEnCours.IdTypeResultat)
                                        .First();

                                    MessageBox.Show("Votre questionnaire a été enregistré ! Son résultat est : \n" + resultat.Statut.ToString());
                                    // Puis on quitte le formulaire et l'application
                                    application.Close();
                                }
                                // Sinon on passe récupère la question suivante
                                else
                                {
                                    // On récupère la question suivante
                                    questionEnCours = context.Questions
                                        .Where(q => q.Ordre == questionEnCours.Ordre + 1)
                                        .First();
                                    // On récupère sa catégorie
                                    categorie = context.Categories
                                        .Where(c => c.IdCategorie == questionEnCours.IdCategorie)
                                        .First();
                                    // On récupère la liste de sous questions
                                    sousQuestion = context.SousQuestions
                                        .Where(sq => sq.IdQuestion == questionEnCours.IdQuestion)
                                        .OrderBy(sq => sq.Ordre)
                                        .ToList();
                                    // On met l'index à 0
                                    indexSousQuestionEnCours = 0;
                                    // On récupère la première sous question
                                    sousQuestionEnCours = sousQuestion[indexSousQuestionEnCours];
                                }
                            }
                            // Sinon on passe juste à la sous question suivante
                            else
                            {
                                indexSousQuestionEnCours++;
                                sousQuestionEnCours = sousQuestion[indexSousQuestionEnCours];
                            }
                            break;

                        case "Previous":
                            // On regarde si on est à la première sous question de la question
                            // Si oui, on passe à la question précédente
                            if (sousQuestionEnCours == sousQuestion.First())
                            {
                                // On récupère la question suivante
                                questionEnCours = context.Questions
                                    .Where(q => q.Ordre == questionEnCours.Ordre - 1)
                                    .First();
                                // On récupère sa catégorie
                                categorie = context.Categories
                                    .Where(c => c.IdCategorie == questionEnCours.IdCategorie)
                                    .First();
                                // On récupère la liste de sous questions
                                sousQuestion = context.SousQuestions
                                    .Where(sq => sq.IdQuestion == questionEnCours.IdQuestion)
                                    .OrderBy(sq => sq.Ordre)
                                    .ToList();
                                // On met l'index à 0
                                indexSousQuestionEnCours = 0;
                                // On récupère la première sous question
                                sousQuestionEnCours = sousQuestion[indexSousQuestionEnCours];
                            }
                            // Sinon on passe juste à la sous question précédente
                            else
                            {
                                indexSousQuestionEnCours--;
                                sousQuestionEnCours = sousQuestion[indexSousQuestionEnCours];
                            }
                            break;
                    }

                    // On regarde si une réponse existe pour la sous question dans le questionnaire
                    List<ReponseQuestionnaire> reponseQ = context.ReponseQuestionnaires
                        .Where(rq => rq.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire && rq.IdSousQuestion == sousQuestionEnCours.IdSousQuestion)
                        .ToList();

                    if (reponseQ.Count == 1)
                    {
                        reponseQuestionnaireEnCours = reponseQ[0];
                    }
                    else
                    {
                        reponseQuestionnaireEnCours = null;
                    }

                    // On met à jour la vue
                    UpdateData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur au chargement du formulaire :\n" + ex.Message);
            }
        }

        // Met à jour la vue avec les données en cours
        private void UpdateData()
        {
            // On reset la textBox
            textComplement.Text = "";

            // Si l'ordre de la question = 1, on bloque le bouton précédent
            if (questionEnCours.Ordre == 1)
            {
                buttonPrecedent.Enabled = false;
            }
            else
            {
                buttonPrecedent.Enabled = true;
            }

            // On met à jour le numéro de question et sous question
            labelOrdreQuestion.Text = questionEnCours.Ordre.ToString();

            // On met à jour la catégorie
            labelCategorie.Text = categorie.Categorie1;

            // On met à jour la question
            labelQuestion.Text = questionEnCours.Enonce;

            // Si la question nécessite un complément, on affiche la textBox
            if (sousQuestionEnCours.NecessiteComplement)
            {
                textComplement.Visible = true;
            }
            else
            {
                textComplement.Visible = false;
            }

            // Si la question n'a pas de sous question
            if (sousQuestionEnCours.Ordre == "1")
            {
                labelOrdreSousQuestion.Text = "";
                labelSousQuestion.Text = "";
            }
            else
            {
                labelOrdreSousQuestion.Text = sousQuestionEnCours.Ordre;
                labelSousQuestion.Text = sousQuestionEnCours.Enonce;
            }

            // Si une réponse questionnaire est en cours (Pour changer sa réponse)
            if (reponseQuestionnaireEnCours != null)
            {
                switch (reponseQuestionnaireEnCours.IdReponse)
                {
                    // Cas "Oui"
                    case 1:
                        radioOui.Checked = true;
                        // Si la question a besoin d'un complément, on le récupère
                        if (sousQuestionEnCours.NecessiteComplement)
                        {
                            textComplement.Text = reponseQuestionnaireEnCours.Complement;
                        }
                        break;

                    // Cas "Non"
                    case 2:
                        radioNon.Checked = true;
                        break;

                    // Cas "Je ne sais pas"
                    case 3:
                        radioSaisPas.Checked = true;
                        break;
                }
            }
        }

        private int getCheck()
        {
            if (radioOui.Checked)
            {
                return 1;
            }
            else if (radioNon.Checked)
            {
                return 2;
            }
            else if (radioSaisPas.Checked)
            {
                return 3;
            }
            else
            {
                return -1;
            }
        }

        private void saveChange()
        {
            int idReponse = getCheck();
            try
            {
                string complement = "";
                // Si la réponse nécessite un complément
                if (sousQuestionEnCours.NecessiteComplement)
                {
                    // Si la réponse est oui, je met ce que l'utilisateur a rentré
                    if (idReponse == 1)
                    {
                        complement = textComplement.Text;
                    }
                }

                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // Si la réponse existe, je la met à jour
                    if (reponseQuestionnaireEnCours != null)
                    {
                        // Je met à jour la réponse
                        reponseQuestionnaireEnCours.IdReponse = idReponse;
                        reponseQuestionnaireEnCours.Complement = complement;
                        context.Entry(reponseQuestionnaireEnCours).State = EntityState.Modified;
                    }
                    // Sinon je la crée
                    else
                    {
                        reponseQuestionnaireEnCours = new ReponseQuestionnaire
                        {
                            IdSousQuestion = sousQuestionEnCours.IdSousQuestion,
                            IdQuestionnaire = questionnaireEnCours.IdQuestionnaire,
                            IdReponse = idReponse,
                            Complement = complement
                        };
                        context.Add(reponseQuestionnaireEnCours);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'enregistrement de la réponse :\n" + ex.Message);
            }
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            // Si la question à un complément alors il doit obligatoirement compléter le complement avant de faire suivant
            if (sousQuestionEnCours.NecessiteComplement && string.IsNullOrEmpty(textComplement.Text) && radioOui.Checked)
            {
                MessageBox.Show("Merci de compléter votre réponse");
            }
            // Sinon il peut faire suivant
            else
            {
                int idReponse = getCheck();

                // Si l'utilisateur n'a rien coché, on lui demande de cocher
                if (idReponse == -1)
                {
                    MessageBox.Show("Veuillez sélectionner une réponse");
                }
                else
                {
                    // J'enregistre les modifications
                    saveChange();

                    // Si non, je passe à la question suivante
                    searchQuestion("Next");
                }
            }
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            int idReponse = getCheck();

            // Si l'utilisateur n'a rien coché, on lui demande de cocher
            if (idReponse == -1)
            {
                MessageBox.Show("Veuillez sélectionner une réponse");
            }
            else
            {
                // J'enregistre les modifications
                saveChange();

                // Si non, je passe à la question suivante
                searchQuestion("Previous");
            }
        }

        private void radioOui_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOui.Checked)
            {
                if (textComplement.Visible)
                {
                    textComplement.Enabled = true;
                }
                else
                {
                    textComplement.Enabled = false;
                }
            }
            else
            {
                textComplement.Enabled = false;
            }
        }

        private void DeleteQuestionnaire()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // Je récupère toutes les réponses au questionnaire
                    List<ReponseQuestionnaire> listReponse = context.ReponseQuestionnaires
                        .Where(rq => rq.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire)
                        .ToList();

                    // Je supprime chaque réponse
                    foreach(ReponseQuestionnaire reponse in listReponse)
                    {
                        context.Remove(reponse);
                        context.SaveChanges();
                    }

                    // Puis je supprime le questionnaire
                    context.Remove(questionnaireEnCours);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite à la suppression :\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult quitter = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?\nVotre questionnaire sera supprimé...", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (quitter == DialogResult.Yes)
            {
                DeleteQuestionnaire();
                application.Close();
            }
        }
    }
}
