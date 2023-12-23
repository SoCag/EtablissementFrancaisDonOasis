using ProjetNote.Models;

namespace ProjetNote
{
    public partial class FrmDonneurs : Form
    {
        FrmPrincipal application;
        List<Donneur> donneurs;
        public FrmDonneurs(FrmPrincipal pApplication)
        {
            InitializeComponent();
            application = pApplication;
            Charge();
        }
        private void Charge()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // On récupère la liste donneurs qui ont fait au moins un questionnaire
                    List<int> listIdDonneurs = context.Questionnaires
                        .Select(q => q.IdDonneur)
                        .ToList();

                    donneurs = context.Donneurs
                        .Where(d => listIdDonneurs.Contains(d.IdDonneur))
                        .OrderBy(d => d.Nom).ThenBy(d => d.Prenom).
                        ToList();
                    lsbDonneurs.DataSource = donneurs;
                    lsbDonneurs.DisplayMember = nameof(Donneur.NomComplet);
                    lsbDonneurs.ValueMember = nameof(Donneur.IdDonneur);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la récupération du donneur :\n" + ex);
            }
        }



        private void searchDonneur(string text)
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // Recherche tout les donneurs en fonction de leur nom et prenom
                    donneurs = context.Donneurs.Where(d => d.Nom.Contains(text) || d.Prenom.Contains(text)).ToList();

                    // Rajoute tous les donneurs dans la ListBox
                    lsbDonneurs.DataSource = donneurs;

                    // Si nous avons qu'un seul resultat alors afficher le 1er donneur de la list 
                    if (donneurs.Count == 1)
                    {
                        Donneur donneur = donneurs[0];
                        lsbDonneurs.SelectedValue = donneur.IdDonneur;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la recherche de donneur :\n" + ex.Message);
            }
        }

        private void rechercheDonneurTexteChanged(object sender, EventArgs e)
        {
            string donneurRechercher = TxtRecherche.Text;

            // Si c'est vide alors on charge tout les donneurs
            if (String.IsNullOrEmpty(donneurRechercher))
            {
                Charge();
            }
            // Sinon on cherche le ou les donneur par nom et prénom
            else
            {
                searchDonneur(donneurRechercher);
            }
        }

        private void lsbDonneurs_DoubleClick(object sender, EventArgs e)
        {
            // Si on double clique sur un donneur, alors on ouvre la page GrilleDonnees
            if (lsbDonneurs.SelectedItem != null)
            {
                Donneur donneurSelected = lsbDonneurs.SelectedItem as Donneur ?? new Donneur();

                FrmReponsesQuestionnaire frmReponsesQuestionnaire = new FrmReponsesQuestionnaire(donneurSelected);
                frmReponsesQuestionnaire.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            application.Close();
        }
    }
}
