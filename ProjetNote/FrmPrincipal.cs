using ProjetNote.Models;

namespace ProjetNote
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConnecterDonneur_Click(object sender, EventArgs e)
        {
            string email = TxtEmailDonneur.Text;
            string motDePasse = TxtMDPDonneur.Text;

            if (!String.IsNullOrWhiteSpace(email))
            {
                if (!String.IsNullOrEmpty(motDePasse))
                {
                    try
                    {
                        using (EtablissementFrancaisDonOasisContext db = new EtablissementFrancaisDonOasisContext())
                        {
                            // Recherche l'utilisateur par adresse e-mail
                            Donneur NouveauDonneur = db.Donneurs.FirstOrDefault(d => d.AdresseEmail.ToLower() == email.ToLower());

                            if (NouveauDonneur != null)
                            {
                                // V�rifie le mot de passe hach�
                                if (BCrypt.Net.BCrypt.Verify(motDePasse, NouveauDonneur.MotDePasse))
                                {
                                    FrmQuestionnaire frmQuestionnaire = new FrmQuestionnaire(this, NouveauDonneur);
                                    frmQuestionnaire.Show();

                                    // On cache ce formulaire (On ne peut pas le fermer il s'agit de la vue principale)
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Mot de passe incorrect.");
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Aucun compte trouv� avec cet adresse email.\nVeuillez vous inscrire.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur � la connexion : " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner votre mot de passe");
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner votre adresse email");
            }
        }

        private void BtnInscriptionDonneur_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire d'inscription
            FrmInscription formInscription = new FrmInscription(this);
            formInscription.Show();

            // Cache le formulaire principal
            this.Hide();
        }

        private void BtnConnecterMedecin_Click(object sender, EventArgs e)
        {
            string MdpMedecin = "Medecin@01";
            string MdpMedecinSaisie = TxtMDPMedecin.Text;

            // Si quelque choise est saisie dans le champs mot de passe medecin TxtMDPMedecin
            if (!string.IsNullOrEmpty(MdpMedecinSaisie))
            {
                // V�rification du mot de passe avant de se connecter et renvoyer vers le form Consultation
                if (MdpMedecin == MdpMedecinSaisie)
                {
                    // Afficher le formulaire Consultation des medecins
                    FrmDonneurs consultation = new FrmDonneurs(this);
                    consultation.Show();

                    // Cache le formulaire principal
                    this.Hide();
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
            // Afficher le texte brut (non masqu�) lorsque la souris survole l'ic�ne
            TxtMDPMedecin.PasswordChar = '\0';
        }
        private void cacherMDPDonneur(object sender, EventArgs e)
        {
            // Masque � nouveau le texte lorsque la souris quitte l'ic�ne
            TxtMDPDonneur.PasswordChar = '*';
        }

        private void voirMDPDonneur(object sender, EventArgs e)
        {
            // Afficher le texte brut (non masqu�) lorsque la souris survole l'ic�ne
            TxtMDPDonneur.PasswordChar = '\0';
        }

        private void cacherMDPMedecin(object sender, EventArgs e)
        {
            // Masque � nouveau le texte lorsque la souris quitte l'ic�ne
            TxtMDPMedecin.PasswordChar = '*';
        }

        private void labelInscription_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire d'inscription
            FrmInscription formInscription = new FrmInscription(this);
            formInscription.Show();

            // Cache le formulaire principal
            this.Hide();
        }

        private void labelIci_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire d'inscription
            FrmInscription formInscription = new FrmInscription(this);
            formInscription.Show();

            // Cache le formulaire principal
            this.Hide();
        }
    }
}
