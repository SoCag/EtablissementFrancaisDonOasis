using ProjetNote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetNote
{
    public partial class FrmInscription : Form
    {
        FrmPrincipal application;
        public FrmInscription(FrmPrincipal pApplication)
        {
            InitializeComponent();
            application = pApplication;
        }

        private string[] controleSaisie()
        {
            string[] resultat = { "1", "" };

            if (String.IsNullOrEmpty(TxtNomInscription.Text))
            {
                resultat[0] = "0";
                resultat[1] += "Veuillez saisir votre nom\n";
            }
            if (String.IsNullOrEmpty(TxtPrenomInscription.Text))
            {
                resultat[0] = "0";
                resultat[1] += "Veuillez saisir votre prénom\n";
            }
            if (String.IsNullOrEmpty(TxtMdpInscription.Text) || String.IsNullOrEmpty(TxtConfirmationInscription.Text))
            {
                resultat[0] = "0";
                resultat[1] += "Veuillez saisir votre mot de passe\n";
            }
            else
            {
                if (!(TxtMdpInscription.Text).Equals(TxtConfirmationInscription.Text))
                {
                    resultat[0] = "0";
                    resultat[1] += "Les mots de passe ne correspondent pas\n";
                }
            }
            if (String.IsNullOrEmpty(TxtMailInscription.Text))
            {
                resultat[0] = "0";
                resultat[1] += "Veuillez saisir votre adresse email\n";
            }
            else
            {
                if (!IsValidEmail(TxtMailInscription.Text))
                {
                    resultat[0] = "0";
                    resultat[1] += "L'adresse email saisie n'est pas valide\n";
                }
            }
            if (!DateTime.TryParseExact(CalendrierDateDeNaissance.SelectionStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateDeNaissance))
            {
                resultat[0] = "0";
                resultat[1] += "La date de naissance saisie n'est pas valide\n";
            }

            return resultat;
        }


        private void BtnInscription_Click(object sender, EventArgs e)
        {
            // Variables
            string nom = TxtNomInscription.Text;
            string prenom = TxtPrenomInscription.Text;
            string motDePasse = TxtMdpInscription.Text;
            string confirmationMDP = TxtConfirmationInscription.Text;
            string email = TxtMailInscription.Text;
            DateOnly DateDeNaissanceSQL;
            string motDePasseHache;
            DateTime.TryParseExact(CalendrierDateDeNaissance.SelectionStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateDeNaissance);

            string[] resultat = controleSaisie();

            if (resultat[0] == "1")
            {
                // Hachage du mot de passe avant de le stocker dans la base de données
                motDePasseHache = BCrypt.Net.BCrypt.HashPassword(motDePasse);

                /*Enregistrement du Donneur */
                try
                {
                    using (EtablissementFrancaisDonOasisContext db = new EtablissementFrancaisDonOasisContext())
                    {
                        // Vérification si l'adresse email existe déjà (en ignorant la casse)
                        if (db.Donneurs.Any(j => j.AdresseEmail.ToLower() == email.ToLower()))
                        {
                            MessageBox.Show("L'adresse email existe déjà.");
                            return;
                        }

                        // Créer un nouveau Donneur
                        DateDeNaissanceSQL = DateOnly.FromDateTime(dateDeNaissance);

                        Donneur NouveauDonneur = new Donneur
                        {
                            Nom = nom,
                            Prenom = prenom,
                            MotDePasse = motDePasseHache,
                            DateDeNaissance = DateDeNaissanceSQL,
                            AdresseEmail = email,
                        };

                        // Ajouter l'utilisateur à la base de données
                        db.Donneurs.Add(NouveauDonneur);

                        // Enregistrer les modifications dans la base de données
                        db.SaveChanges();

                        FrmQuestionnaire frmQuestionnaire = new FrmQuestionnaire(application, NouveauDonneur);
                        frmQuestionnaire.Show();

                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur à l'inscription : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(resultat[1]);
            }
        }

        //permet de valider si le string saisie est un email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Utilisation de l'expression régulière pour la validation de l'email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void TxtMdpChanged(object sender, EventArgs e)
        {
            TxtMdpInscription.PasswordChar = '*';
        }

        private void TxtConfirmationMdpChanged(object sender, EventArgs e)
        {
            TxtConfirmationInscription.PasswordChar = '*';
        }

        private void voirMDP(object sender, EventArgs e)
        {
            // Affiche le texte brut (non masqué) lorsque la souris survole l'icône
            TxtMdpInscription.PasswordChar = '\0';
        }

        private void cacherMDP(object sender, EventArgs e)
        {
            // Masque à nouveau le texte lorsque la souris quitte l'icône
            TxtMdpInscription.PasswordChar = '*';
        }

        private void cacherConfirmationMDP(object sender, EventArgs e)
        {
            // Masque à nouveau le texte lorsque la souris quitte l'icône
            TxtConfirmationInscription.PasswordChar = '*';
        }

        private void afficherConfirmationMDP(object sender, EventArgs e)
        {
            // Affiche le texte brut (non masqué) lorsque la souris survole l'icône
            TxtConfirmationInscription.PasswordChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult quitter = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(quitter == DialogResult.Yes)
            {
                application.Close();
            }
        }
    }
}
