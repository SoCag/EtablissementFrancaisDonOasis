using ProjetNote.Models;

namespace ProjetNote
{
    public partial class Consultation : Form
    {
        List<Donneur> donneurs;
        public Consultation()
        {
            InitializeComponent();

            Charge();
        }
        private void Charge()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    donneurs = context.Donneurs.OrderBy(d => d.Nom).ThenBy(d => d.Prenom).ToList();
                    lsbDonneurs.DataSource = donneurs;
                    lsbDonneurs.DisplayMember = nameof(Donneur.Nom);
                    lsbDonneurs.ValueMember = nameof(Donneur.IdDonneur);
                    //if (idDonneurSelected != 0)
                    //{
                    //    lsbDonneurs.SelectedValue = idDonneurSelected; 
                    //}
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
                    // recherche tout les donneurs en fonction de leur nom et prenom
                    donneurs = context.Donneurs.Where(d => d.Nom.Contains(text) || d.Prenom.Contains(text)).ToList();

                    //rajoute tous les donneurs dans la ListBox
                    lsbDonneurs.DataSource = donneurs;

                    //si nous avons qu'un seul resultat alors afficher le 1er donneur de la list 
                    if (donneurs.Count == 1)
                    {
                        Donneur donneur = donneurs[0];
                        lsbDonneurs.SelectedValue = donneur.IdDonneur;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void rechercheDonneurTexteChanged(object sender, EventArgs e)
        {
            string donneurRechercher = TxtRecherche.Text;


            // si c'est vide alors on charge tout les donneurs
            if (String.IsNullOrEmpty(donneurRechercher))
            {
                Charge();
            }
            else
            {
                //sinon on cherche le ou les donneur par nom et prenom
                searchDonneur(donneurRechercher);
            }
        }

        //charge la grille lorsque je selectionne un id (élement) de la listBox
        private void chargerGrileDonneeDonateur(object sender, EventArgs e)
        {
            //chercher le donnateur selectionnee
            Donneur DonnateurSelectionner = (Donneur)lsbDonneurs.SelectedItem;

            // Afficher le form grille
            //GrilleDonnées grilleForm = new GrilleDonnées(Donneur);
            //grilleForm.ShowDialog(); // Utilisez ShowDialog pour bloquer l'accès au formulaire principal jusqu'à ce que le formulaire d'inscription soit fermé

        }


        //private void rechercheDonneur(object sender, KeyEventArgs e)
        //{
        //    string donneurRechercher = TxtRecherche.Text;

        //    //lorsque l'utilisateur saisie au clavier
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        // Il recherche un donnateur dans la bdd
        //        searchDonneur(donneurRechercher);

        //        //il charge l'utilisateur 
        //    }

        //    // si c'est vide alors on charge
        //    if (String.IsNullOrEmpty(TxtRecherche.Text))
        //    {
        //        Charge();
        //    }
        //    else
        //    {
        //        searchDonneur(donneurRechercher);
        //    }
        //}


        //private void txtrecherche(object sender, eventargs e)
        //{
        //    if (string.isnullorempty(txtrecherche.text))
        //    {
        //        charge();
        //    }
        //    else
        //    {
        //        searchdonneur(txtrecherche.text);
        //    }
        //}
    }
}
