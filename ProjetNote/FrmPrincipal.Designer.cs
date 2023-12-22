namespace ProjetNote
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BtnConnecterMedecin = new Button();
            label1 = new Label();
            BtnConnecterDonneur = new Button();
            TxtMDPMedecin = new TextBox();
            label2 = new Label();
            TxtEmailDonneur = new TextBox();
            TxtMDPDonneur = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BtnInscriptionDonneur = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnConnecterMedecin
            // 
            BtnConnecterMedecin.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnConnecterMedecin.FlatAppearance.BorderSize = 0;
            BtnConnecterMedecin.FlatStyle = FlatStyle.System;
            BtnConnecterMedecin.Location = new Point(91, 403);
            BtnConnecterMedecin.Name = "BtnConnecterMedecin";
            BtnConnecterMedecin.Size = new Size(280, 41);
            BtnConnecterMedecin.TabIndex = 1;
            BtnConnecterMedecin.Text = "Connecter en tant que Medecin";
            BtnConnecterMedecin.UseVisualStyleBackColor = true;
            BtnConnecterMedecin.Click += BtnConnecterMedecin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 19);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Connexion";
            // 
            // BtnConnecterDonneur
            // 
            BtnConnecterDonneur.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnConnecterDonneur.FlatAppearance.BorderSize = 0;
            BtnConnecterDonneur.FlatStyle = FlatStyle.System;
            BtnConnecterDonneur.Location = new Point(99, 159);
            BtnConnecterDonneur.Name = "BtnConnecterDonneur";
            BtnConnecterDonneur.Size = new Size(280, 41);
            BtnConnecterDonneur.TabIndex = 3;
            BtnConnecterDonneur.Text = "Connecter en tant que Donneur";
            BtnConnecterDonneur.UseVisualStyleBackColor = true;
            BtnConnecterDonneur.Click += BtnConnecterDonneur_Click;
            // 
            // TxtMDPMedecin
            // 
            TxtMDPMedecin.Location = new Point(91, 360);
            TxtMDPMedecin.Name = "TxtMDPMedecin";
            TxtMDPMedecin.Size = new Size(274, 27);
            TxtMDPMedecin.TabIndex = 4;
            TxtMDPMedecin.TextChanged += TxtMDPMedecin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 320);
            label2.Name = "label2";
            label2.Size = new Size(210, 20);
            label2.TabIndex = 5;
            label2.Text = "Mot de Passe pour connexion :";
            // 
            // TxtEmailDonneur
            // 
            TxtEmailDonneur.Location = new Point(99, 54);
            TxtEmailDonneur.Name = "TxtEmailDonneur";
            TxtEmailDonneur.Size = new Size(274, 27);
            TxtEmailDonneur.TabIndex = 6;
            // 
            // TxtMDPDonneur
            // 
            TxtMDPDonneur.Location = new Point(100, 110);
            TxtMDPDonneur.Name = "TxtMDPDonneur";
            TxtMDPDonneur.Size = new Size(274, 27);
            TxtMDPDonneur.TabIndex = 7;
            TxtMDPDonneur.TextChanged += TxtMDPDonneur_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 31);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 87);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 9;
            label4.Text = "Mot de passe";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(38, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 3);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += voirMDPDonneur;
            pictureBox1.MouseLeave += cacherMDPDonneur;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(378, 360);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += voirMDPMedecin;
            pictureBox2.MouseLeave += cacherMDPMedecin;
            // 
            // BtnInscriptionDonneur
            // 
            BtnInscriptionDonneur.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnInscriptionDonneur.FlatAppearance.BorderSize = 0;
            BtnInscriptionDonneur.FlatStyle = FlatStyle.System;
            BtnInscriptionDonneur.Location = new Point(99, 220);
            BtnInscriptionDonneur.Name = "BtnInscriptionDonneur";
            BtnInscriptionDonneur.Size = new Size(280, 41);
            BtnInscriptionDonneur.TabIndex = 13;
            BtnInscriptionDonneur.Text = "S'inscrire en tant que Donneur";
            BtnInscriptionDonneur.UseVisualStyleBackColor = true;
            BtnInscriptionDonneur.Click += BtnInscriptionDonneur_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 545);
            Controls.Add(BtnInscriptionDonneur);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtMDPDonneur);
            Controls.Add(TxtEmailDonneur);
            Controls.Add(label2);
            Controls.Add(TxtMDPMedecin);
            Controls.Add(BtnConnecterDonneur);
            Controls.Add(label1);
            Controls.Add(BtnConnecterMedecin);
            Name = "FrmPrincipal";
            Text = "Logiciel EFS";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnConnecterMedecin;
        private Label label1;
        private Button BtnConnecterDonneur;
        private TextBox TxtMDPMedecin;
        private Label label2;
        private TextBox TxtEmailDonneur;
        private TextBox TxtMDPDonneur;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BtnInscriptionDonneur;
    }
}
