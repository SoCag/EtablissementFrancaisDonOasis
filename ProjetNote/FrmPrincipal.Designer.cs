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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BtnInscriptionDonneur = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnConnecterMedecin
            // 
            BtnConnecterMedecin.Anchor = AnchorStyles.None;
            BtnConnecterMedecin.BackColor = Color.RoyalBlue;
            BtnConnecterMedecin.FlatAppearance.BorderColor = Color.RoyalBlue;
            BtnConnecterMedecin.FlatAppearance.BorderSize = 0;
            BtnConnecterMedecin.ForeColor = Color.White;
            BtnConnecterMedecin.Location = new Point(60, 427);
            BtnConnecterMedecin.Margin = new Padding(3, 2, 3, 2);
            BtnConnecterMedecin.Name = "BtnConnecterMedecin";
            BtnConnecterMedecin.Size = new Size(380, 36);
            BtnConnecterMedecin.TabIndex = 1;
            BtnConnecterMedecin.Text = "Se connecter à l'espace médecin";
            BtnConnecterMedecin.UseVisualStyleBackColor = false;
            BtnConnecterMedecin.Click += BtnConnecterMedecin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(60, 32);
            label1.MinimumSize = new Size(380, 30);
            label1.Name = "label1";
            label1.Size = new Size(380, 30);
            label1.TabIndex = 2;
            label1.Text = "Espace Donneur";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnConnecterDonneur
            // 
            BtnConnecterDonneur.BackColor = Color.RoyalBlue;
            BtnConnecterDonneur.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnConnecterDonneur.FlatAppearance.BorderSize = 0;
            BtnConnecterDonneur.ForeColor = Color.White;
            BtnConnecterDonneur.Location = new Point(60, 233);
            BtnConnecterDonneur.Margin = new Padding(3, 2, 3, 2);
            BtnConnecterDonneur.Name = "BtnConnecterDonneur";
            BtnConnecterDonneur.Size = new Size(380, 36);
            BtnConnecterDonneur.TabIndex = 3;
            BtnConnecterDonneur.Text = "Se connecter à l'espace donneur";
            BtnConnecterDonneur.UseVisualStyleBackColor = false;
            BtnConnecterDonneur.Click += BtnConnecterDonneur_Click;
            // 
            // TxtMDPMedecin
            // 
            TxtMDPMedecin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMDPMedecin.Location = new Point(60, 369);
            TxtMDPMedecin.Margin = new Padding(3, 2, 3, 2);
            TxtMDPMedecin.Name = "TxtMDPMedecin";
            TxtMDPMedecin.Size = new Size(344, 29);
            TxtMDPMedecin.TabIndex = 4;
            TxtMDPMedecin.TextChanged += TxtMDPMedecin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(60, 320);
            label2.MinimumSize = new Size(380, 30);
            label2.Name = "label2";
            label2.Size = new Size(380, 30);
            label2.TabIndex = 5;
            label2.Text = "Espace Médecin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtEmailDonneur
            // 
            TxtEmailDonneur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmailDonneur.Location = new Point(60, 81);
            TxtEmailDonneur.Margin = new Padding(3, 2, 3, 2);
            TxtEmailDonneur.Name = "TxtEmailDonneur";
            TxtEmailDonneur.Size = new Size(380, 29);
            TxtEmailDonneur.TabIndex = 6;
            // 
            // TxtMDPDonneur
            // 
            TxtMDPDonneur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMDPDonneur.Location = new Point(60, 138);
            TxtMDPDonneur.Margin = new Padding(3, 2, 3, 2);
            TxtMDPDonneur.Name = "TxtMDPDonneur";
            TxtMDPDonneur.Size = new Size(344, 29);
            TxtMDPDonneur.TabIndex = 7;
            TxtMDPDonneur.TextChanged += TxtMDPDonneur_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(60, 62);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(60, 119);
            label4.Name = "label4";
            label4.Size = new Size(105, 17);
            label4.TabIndex = 9;
            label4.Text = "Mot de passe";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(410, 138);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += voirMDPDonneur;
            pictureBox1.MouseLeave += cacherMDPDonneur;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(410, 369);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += voirMDPMedecin;
            pictureBox2.MouseLeave += cacherMDPMedecin;
            // 
            // BtnInscriptionDonneur
            // 
            BtnInscriptionDonneur.BackColor = Color.RoyalBlue;
            BtnInscriptionDonneur.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            BtnInscriptionDonneur.FlatAppearance.BorderSize = 0;
            BtnInscriptionDonneur.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            BtnInscriptionDonneur.ForeColor = Color.White;
            BtnInscriptionDonneur.Location = new Point(60, 190);
            BtnInscriptionDonneur.Margin = new Padding(3, 2, 3, 2);
            BtnInscriptionDonneur.Name = "BtnInscriptionDonneur";
            BtnInscriptionDonneur.Size = new Size(380, 39);
            BtnInscriptionDonneur.TabIndex = 13;
            BtnInscriptionDonneur.Text = "S'inscrire à l'espace donneur";
            BtnInscriptionDonneur.UseVisualStyleBackColor = false;
            BtnInscriptionDonneur.Click += BtnInscriptionDonneur_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(108, 283);
            label5.Name = "label5";
            label5.Size = new Size(332, 15);
            label5.TabIndex = 14;
            label5.Text = "_________________________________________________________________";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(504, 501);
            Controls.Add(label5);
            Controls.Add(BtnInscriptionDonneur);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtMDPDonneur);
            Controls.Add(TxtEmailDonneur);
            Controls.Add(label2);
            Controls.Add(TxtMDPMedecin);
            Controls.Add(BtnConnecterDonneur);
            Controls.Add(label1);
            Controls.Add(BtnConnecterMedecin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(520, 540);
            MinimumSize = new Size(520, 540);
            Name = "FrmPrincipal";
            Text = "Logiciel EFS";
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BtnInscriptionDonneur;
        private Label label5;
    }
}
