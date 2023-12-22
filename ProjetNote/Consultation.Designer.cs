namespace ProjetNote
{
    partial class Consultation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultation));
            lsbDonneurs = new ListBox();
            TxtRecherche = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lsbDonneurs
            // 
            lsbDonneurs.BackColor = SystemColors.Window;
            lsbDonneurs.ForeColor = SystemColors.WindowText;
            lsbDonneurs.FormattingEnabled = true;
            lsbDonneurs.Location = new Point(195, 150);
            lsbDonneurs.Name = "lsbDonneurs";
            lsbDonneurs.Size = new Size(245, 244);
            lsbDonneurs.TabIndex = 0;
            lsbDonneurs.SelectedIndexChanged += chargerGrileDonneeDonateur;
            // 
            // TxtRecherche
            // 
            TxtRecherche.Location = new Point(195, 63);
            TxtRecherche.Name = "TxtRecherche";
            TxtRecherche.Size = new Size(245, 27);
            TxtRecherche.TabIndex = 1;
            TxtRecherche.TextChanged += rechercheDonneurTexteChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 31);
            label1.Name = "label1";
            label1.Size = new Size(189, 29);
            label1.TabIndex = 2;
            label1.Text = "Rechercher un donneur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Dubai", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 118);
            label2.Name = "label2";
            label2.Size = new Size(154, 29);
            label2.TabIndex = 3;
            label2.Text = "Liste des donneurs :";
            // 
            // Consultation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(623, 413);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtRecherche);
            Controls.Add(lsbDonneurs);
            Name = "Consultation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbDonneurs;
        private TextBox TxtRecherche;
        private Label label1;
        private Label label2;
    }
}
