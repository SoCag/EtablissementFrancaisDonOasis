using ProjetNote.Models;

namespace ProjetNote
{
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }
        private void Charge()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    List<Donneur> donneurs = context.Donneurs.OrderBy(d => d.Nom).ThenBy(d => d.Prenom).ToList();
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
//        private void TxtRecherche(object sender, EventArgs e)
//        {
//            if(String.IsNullOrEmpty(TxtRecherche.Text))
//           {
//                Charge();
 //           }
//            else
//            {
 //               searchDonneur(TxtRecherche.Text);
 //           }
 //       }

 //       private void searchDonneur(string text)
//        {
 //           try
//            {
//                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
 //               {
//                    List<Donneur> donneurs = context.Donneurs.Where(d => d.Nom.Contains(text) || d.Prenom.Contains(text)).ToList();
 //                   lsbDonneurs.DataSource = donneurs;

//                    if(donneurs.Count == 1)
 //                   {
//                        Donneur = donneurs[0];
 //                       idDonneurSelected = Donneur.IdDonneur;
//                        lsbDonneurs.SelectedValue = Donneur.IdDonneur;
 //                   }
 //               }
//            }
 //           catch 
//            {
 //               MessageBox.Show("Erreur ");
//            }
///        }
    }
}
