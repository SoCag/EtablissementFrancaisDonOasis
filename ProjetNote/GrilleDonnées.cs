using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ProjetNote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNote
{
    public partial class GrilleDonnées : Form
    {
        Donneur donneurEnCours;
        Questionnaire questionnaireEnCours;
        List<ViewDataGridQuestionnaire> listVueEnCours;
        public GrilleDonnées(Donneur pDonneur)
        {
            InitializeComponent();
            donneurEnCours = pDonneur;
            getVueEnCours();

            DataGridViewTextBoxColumn Question = new DataGridViewTextBoxColumn
            {
                HeaderText = "Question",
                Name = "question"
            };
            dataGVDonneur.Columns.Add(Question);

            DataGridViewTextBoxColumn Reponse = new DataGridViewTextBoxColumn
            {
                HeaderText = "Réponse",
                Name = "reponse"
            };
            dataGVDonneur.Columns.Add(Reponse);

            DataGridViewTextBoxColumn Complement = new DataGridViewTextBoxColumn
            {
                HeaderText = "Complément",
                Name = "complement"
            };
            dataGVDonneur.Columns.Add(Complement);

            DataGridViewTextBoxColumn rendImpossible = new DataGridViewTextBoxColumn
            {
                HeaderText = "Rend impossible",
                Name = "rendImpossible"
            };
            dataGVDonneur.Columns.Add(rendImpossible);

            Charge();
        }

        public void Charge()
        {
            dataGVDonneur.Rows.Clear();

            foreach (ViewDataGridQuestionnaire view in listVueEnCours)
            {
                dataGVDonneur.Rows.Add(view);
            }
        }

        public void getVueEnCours()
        {
            try
            {
                using (EtablissementFrancaisDonOasisContext context = new EtablissementFrancaisDonOasisContext())
                {
                    // Je récupère le dernier questionnaire du donneur
                    questionnaireEnCours = context.Questionnaires
                        .Where(q => q.IdDonneur == donneurEnCours.IdDonneur)
                        .OrderByDescending(q => q.DateQuestionnaire)
                        .First();

                    listVueEnCours = context.ViewDataGridQuestionnaires
                        .Where(vdg => vdg.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire)
                        .OrderByDescending(vdg => vdg.IdQuestionnaire)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la récupération de la vue :\n" + ex.Message);
            }
        }

        public void UpdateData()
        {
            labelNom.Text = donneurEnCours.Nom;
            labelPrenom.Text = donneurEnCours.Prenom;
            labelDate.Text = donneurEnCours.DateDeNaissance.ToShortDateString();
            labelAdresseMail.Text = donneurEnCours.AdresseEmail;
        }
    }
}
