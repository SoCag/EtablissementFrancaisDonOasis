using ProjetNote.Models;

namespace ProjetNote
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void BtnConnecterDonneur_Click(object sender, EventArgs e)
        {
            string email = TxtEmailDonneur.Text;
            string motDePasse = TxtMDPDonneur.Text;

            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("veuilliez remplir tout les champs");
                return;
            }
            try
            {
                using (EtablissementFrancaisDonOasisContext db = new EtablissementFrancaisDonOasisContext())
                {
                    // Recherche l'utilisateur par adresse e-mail
                    Donneur utilisateur = db.Donneurs.FirstOrDefault(j => j.AdresseEmail.ToLower() == email.ToLower());

                    if (utilisateur != null)
                    {
                        // Vérifie le mot de passe haché
                        if (BCrypt.Net.BCrypt.Verify(motDePasse, utilisateur.MotDePasse))
                        {
                            //MessageBox.Show(" Renvoie au questionnaire !");

                            //FrmQuestionnaire frmQuestionnaire = new FrmQuestionnaire(NouveauDonneur);

                            //frmQuestionnaire.Show();

                            //cache ce formulaire
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe est incorrect.");
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Aucun compte trouvé avec cet email, veuilliez vous inscrire");
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }

        private void BtnInscriptionDonneur_Click(object sender, EventArgs e)
        {
            // Cacher le formulaire principal (de connexion)
            this.Hide();

            // Afficher le formulaire d'inscription
            FrmInscription formInscription = new FrmInscription();
            formInscription.ShowDialog(); // Utilisez ShowDialog pour bloquer l'accès au formulaire principal jusqu'à ce que le formulaire d'inscription soit fermé
        }

        private void BtnConnecterMedecin_Click(object sender, EventArgs e)
        {
            string MdpMedecin = "Medecin@01";
            string MdpMedecinSaisie = TxtMDPMedecin.Text;

            // si quelque choise est saisie dans le champs mot de passe medecin TxtMDPMedecin
            if (!string.IsNullOrWhiteSpace(MdpMedecinSaisie))
            {
                //verification du mot de passe avant de se connecter et renvoyer vers le form Consultation
                if (MdpMedecin == MdpMedecinSaisie)
                {
                    /*renvoie vers le fom Consultation */
                    // Cacher le formulaire principal (de connexion)
                    this.Hide();

                    // Afficher le formulaire Consultation des medecin
                    //FrmInscription consultation = new Consultation();
                    //consultation.ShowDialog(); // Utilisez ShowDialog pour bloquer l'accès au formulaire principal jusqu'à ce que le formulaire d'inscription soit fermé
                    //MessageBox.Show("Renvoyer vers consultation");
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                    return;
                }
            }


        }
        private void TxtMDPMedecin_TextChanged(object sender, EventArgs e)
        {
            TxtMDPMedecin.PasswordChar = '*';
        }

        private void TxtMDPDonneur_TextChanged(object sender, EventArgs e)
        {
            TxtMDPDonneur.PasswordChar = '*';
        }

        private void voirMDPMedecin(object sender, EventArgs e)
        {
            // Afficher le texte brut (non masqué) lorsque la souris survole l'icône
            TxtMDPMedecin.PasswordChar = '\0';
        }
        private void cacherMDPDonneur(object sender, EventArgs e)
        {
            // Masque à nouveau le texte lorsque la souris quitte l'icône
            TxtMDPDonneur.PasswordChar = '*';
        }

        private void voirMDPDonneur(object sender, EventArgs e)
        {
            // Afficher le texte brut (non masqué) lorsque la souris survole l'icône
            TxtMDPDonneur.PasswordChar = '\0';
        }
        

        private void cacherMDPMedecin(object sender, EventArgs e)
        {
            // Masque à nouveau le texte lorsque la souris quitte l'icône
            TxtMDPMedecin.PasswordChar = '*';
        }
    }
}
