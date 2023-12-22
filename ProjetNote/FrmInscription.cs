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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetNote
{
    public partial class FrmInscription : Form
    {

        public FrmInscription()
        {
            InitializeComponent();
        }


        private void BtnInscription_Click(object sender, EventArgs e)
        {
            // Variables
            string nom = TxtNomInscription.Text;
            string prenom = TxtPrenomInscription.Text;
            string motDePasse = TxtMdpInscription.Text;
            string confirmationMDP = TxtConfirmationInscription.Text;
            string email = TxtMailInscription.Text;
            DateTime dateDeNaissance;
            DateOnly DateDeNaissanceSQL;
            string motDePasseHache;

            // Contrôle des informations saisies par l'utilisateur
            if (!SaisieValideChaine(nom) || !SaisieValideChaine(prenom) || CalendrierDateDeNaissance.SelectionStart == DateTime.MinValue || !SaisieValideChaine(motDePasse) || !SaisieValideChaine(confirmationMDP) || !SaisieValideChaine(email))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!motDePasse.Equals(confirmationMDP))
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Adresse email invalide.");
                return;
            }

            if (!DateTime.TryParseExact(CalendrierDateDeNaissance.SelectionStart.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateDeNaissance))
            {
                MessageBox.Show("Date de naissance invalide.");
                return;
            }

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

                    //MessageBox.Show("Inscription réussie !");

                    //FrmQuestionnaire frmQuestionnaire = new FrmQuestionnaire(NouveauDonneur);

                    //frmQuestionnaire.Show();

                    //ferme ce formulaire
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }


        //permet de voir si la chaine est vide ou non
        private bool SaisieValideChaine(string valeurSasie)
        {
            if (string.IsNullOrWhiteSpace(valeurSasie))
            {
                return false;
            }

            else return true;

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
    }
}
