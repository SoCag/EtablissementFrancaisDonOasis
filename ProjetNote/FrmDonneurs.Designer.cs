namespace ProjetNote
{
    partial class FrmDonneurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonneurs));
            lsbDonneurs = new ListBox();
            TxtRecherche = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbDonneurs
            // 
            lsbDonneurs.BackColor = SystemColors.Window;
            lsbDonneurs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsbDonneurs.ForeColor = Color.RoyalBlue;
            lsbDonneurs.FormattingEnabled = true;
            lsbDonneurs.ItemHeight = 25;
            lsbDonneurs.Location = new Point(227, 95);
            lsbDonneurs.Name = "lsbDonneurs";
            lsbDonneurs.Size = new Size(245, 429);
            lsbDonneurs.TabIndex = 0;
            lsbDonneurs.DoubleClick += lsbDonneurs_DoubleClick;
            // 
            // TxtRecherche
            // 
            TxtRecherche.Location = new Point(227, 37);
            TxtRecherche.Name = "TxtRecherche";
            TxtRecherche.Size = new Size(245, 27);
            TxtRecherche.TabIndex = 1;
            TxtRecherche.TextChanged += rechercheDonneurTexteChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(245, 12);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 2;
            label1.Text = "Rechercher un donneur";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(672, 9);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(27, 31);
            button1.TabIndex = 19;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmDonneurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(711, 544);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TxtRecherche);
            Controls.Add(lsbDonneurs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(729, 591);
            MinimumSize = new Size(729, 591);
            Name = "FrmDonneurs";
            Text = "Liste des donneurs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbDonneurs;
        private TextBox TxtRecherche;
        private Label label1;
        private Button button1;
    }
}
