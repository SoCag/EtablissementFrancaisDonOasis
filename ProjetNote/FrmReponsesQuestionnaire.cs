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
    public partial class FrmReponsesQuestionnaire : Form
    {
        Donneur donneurEnCours;
        Questionnaire questionnaireEnCours;
        TypeResultat resultatQuestionnaire;
        List<ViewDataGridQuestionnaire> listVueEnCours;
        public FrmReponsesQuestionnaire(Donneur pDonneur)
        {
            InitializeComponent();
            donneurEnCours = pDonneur;
            getVueEnCours();

            DataGridViewTextBoxColumn Question = new DataGridViewTextBoxColumn
            {
                HeaderText = "Question",
                Name = "Question",
                ReadOnly = true
            };
            dataGVDonneur.Columns.Add(Question);

            DataGridViewTextBoxColumn Reponse = new DataGridViewTextBoxColumn
            {
                HeaderText = "Réponse",
                Name = "Reponse",
                ReadOnly = true
            };
            dataGVDonneur.Columns.Add(Reponse);

            DataGridViewTextBoxColumn Complement = new DataGridViewTextBoxColumn
            {
                HeaderText = "Complément",
                Name = "Complement",
                ReadOnly = true
            };
            dataGVDonneur.Columns.Add(Complement);

            DataGridViewCheckBoxColumn rendImpossible = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Rend impossible",
                Name = "RendImpossible",
                ReadOnly = true
            };
            dataGVDonneur.Columns.Add(rendImpossible);

            Charge();
        }

        public void Charge()
        {
            dataGVDonneur.Rows.Clear();

            foreach (ViewDataGridQuestionnaire view in listVueEnCours)
            {
                dataGVDonneur.Rows.Add(
                    view.Question,
                    view.Reponse,
                    view.Complement,
                    view.RendImpossible
                );
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

                    // Je récupère le résultat
                    resultatQuestionnaire = context.TypeResultats
                        .Where(tr => tr.IdTypeResultat == questionnaireEnCours.IdTypeResultat)
                        .First();

                    listVueEnCours = context.ViewDataGridQuestionnaires
                        .Where(vdg => vdg.IdQuestionnaire == questionnaireEnCours.IdQuestionnaire)
                        .OrderByDescending(vdg => vdg.IdQuestionnaire)
                        .ToList();
                }

                UpdateData();
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
            labelDateQuestionnaire.Text = questionnaireEnCours.DateQuestionnaire.ToShortDateString();
            labelResultat.Text = resultatQuestionnaire.Statut;
            checkAccord.Checked = questionnaireEnCours.AccordPartage;
        }
    }
}
