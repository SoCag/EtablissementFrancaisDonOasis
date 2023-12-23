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
            lsbDonneurs.ItemHeight = 20;
            lsbDonneurs.Location = new Point(199, 71);
            lsbDonneurs.Margin = new Padding(3, 2, 3, 2);
            lsbDonneurs.Name = "lsbDonneurs";
            lsbDonneurs.Size = new Size(215, 324);
            lsbDonneurs.TabIndex = 0;
            lsbDonneurs.DoubleClick += lsbDonneurs_DoubleClick;
            // 
            // TxtRecherche
            // 
            TxtRecherche.Location = new Point(199, 28);
            TxtRecherche.Margin = new Padding(3, 2, 3, 2);
            TxtRecherche.Name = "TxtRecherche";
            TxtRecherche.Size = new Size(215, 23);
            TxtRecherche.TabIndex = 1;
            TxtRecherche.TextChanged += rechercheDonneurTexteChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 17);
            label1.TabIndex = 2;
            label1.Text = "Rechercher un donneur";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(588, 7);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 19;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmDonneurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(624, 416);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TxtRecherche);
            Controls.Add(lsbDonneurs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(640, 455);
            MinimumSize = new Size(640, 455);
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
