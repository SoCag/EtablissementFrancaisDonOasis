namespace ProjetNote
{
    partial class FrmInscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscription));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtPrenomInscription = new TextBox();
            TxtNomInscription = new TextBox();
            TxtMailInscription = new TextBox();
            TxtMdpInscription = new TextBox();
            TxtConfirmationInscription = new TextBox();
            BtnInscription = new Button();
            pictureBox1 = new PictureBox();
            pictureCOnfirmationMDP = new PictureBox();
            CalendrierDateDeNaissance = new MonthCalendar();
            buttonQuitter = new Button();
            buttonRetour = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCOnfirmationMDP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 1);
            label1.MinimumSize = new Size(460, 30);
            label1.Name = "label1";
            label1.Size = new Size(460, 30);
            label1.TabIndex = 0;
            label1.Text = "INSCRIPTION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(66, 230);
            label2.Name = "label2";
            label2.Size = new Size(153, 17);
            label2.TabIndex = 1;
            label2.Text = "Date de naissance :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(275, 37);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Nom :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(66, 37);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Prénom :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(66, 134);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 4;
            label5.Text = "Mot de passe :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(66, 85);
            label6.Name = "label6";
            label6.Size = new Size(111, 17);
            label6.TabIndex = 5;
            label6.Text = "Adresse mail :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(66, 182);
            label7.Name = "label7";
            label7.Size = new Size(109, 17);
            label7.TabIndex = 6;
            label7.Text = "Confirmation :";
            // 
            // TxtPrenomInscription
            // 
            TxtPrenomInscription.Location = new Point(66, 56);
            TxtPrenomInscription.Margin = new Padding(3, 2, 3, 2);
            TxtPrenomInscription.Multiline = true;
            TxtPrenomInscription.Name = "TxtPrenomInscription";
            TxtPrenomInscription.Size = new Size(183, 27);
            TxtPrenomInscription.TabIndex = 7;
            // 
            // TxtNomInscription
            // 
            TxtNomInscription.Location = new Point(275, 56);
            TxtNomInscription.Margin = new Padding(3, 2, 3, 2);
            TxtNomInscription.Multiline = true;
            TxtNomInscription.Name = "TxtNomInscription";
            TxtNomInscription.Size = new Size(169, 27);
            TxtNomInscription.TabIndex = 8;
            // 
            // TxtMailInscription
            // 
            TxtMailInscription.Location = new Point(66, 104);
            TxtMailInscription.Margin = new Padding(3, 2, 3, 2);
            TxtMailInscription.Multiline = true;
            TxtMailInscription.Name = "TxtMailInscription";
            TxtMailInscription.Size = new Size(378, 27);
            TxtMailInscription.TabIndex = 9;
            // 
            // TxtMdpInscription
            // 
            TxtMdpInscription.Location = new Point(66, 153);
            TxtMdpInscription.Margin = new Padding(3, 2, 3, 2);
            TxtMdpInscription.Multiline = true;
            TxtMdpInscription.Name = "TxtMdpInscription";
            TxtMdpInscription.Size = new Size(345, 27);
            TxtMdpInscription.TabIndex = 10;
            TxtMdpInscription.TextChanged += TxtMdpChanged;
            // 
            // TxtConfirmationInscription
            // 
            TxtConfirmationInscription.Location = new Point(66, 201);
            TxtConfirmationInscription.Margin = new Padding(3, 2, 3, 2);
            TxtConfirmationInscription.Multiline = true;
            TxtConfirmationInscription.Name = "TxtConfirmationInscription";
            TxtConfirmationInscription.Size = new Size(345, 27);
            TxtConfirmationInscription.TabIndex = 11;
            TxtConfirmationInscription.TextChanged += TxtConfirmationMdpChanged;
            // 
            // BtnInscription
            // 
            BtnInscription.BackColor = Color.RoyalBlue;
            BtnInscription.Cursor = Cursors.Hand;
            BtnInscription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnInscription.ForeColor = Color.White;
            BtnInscription.Location = new Point(66, 421);
            BtnInscription.Margin = new Padding(3, 2, 3, 2);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(378, 44);
            BtnInscription.TabIndex = 13;
            BtnInscription.Text = "S'inscrire";
            BtnInscription.UseVisualStyleBackColor = false;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 153);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += voirMDP;
            pictureBox1.MouseLeave += cacherMDP;
            // 
            // pictureCOnfirmationMDP
            // 
            pictureCOnfirmationMDP.Image = (Image)resources.GetObject("pictureCOnfirmationMDP.Image");
            pictureCOnfirmationMDP.Location = new Point(416, 201);
            pictureCOnfirmationMDP.Margin = new Padding(3, 2, 3, 2);
            pictureCOnfirmationMDP.Name = "pictureCOnfirmationMDP";
            pictureCOnfirmationMDP.Size = new Size(28, 27);
            pictureCOnfirmationMDP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCOnfirmationMDP.TabIndex = 15;
            pictureCOnfirmationMDP.TabStop = false;
            pictureCOnfirmationMDP.MouseLeave += cacherConfirmationMDP;
            pictureCOnfirmationMDP.MouseHover += afficherConfirmationMDP;
            // 
            // CalendrierDateDeNaissance
            // 
            CalendrierDateDeNaissance.Location = new Point(142, 254);
            CalendrierDateDeNaissance.Margin = new Padding(8, 7, 8, 7);
            CalendrierDateDeNaissance.Name = "CalendrierDateDeNaissance";
            CalendrierDateDeNaissance.TabIndex = 16;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.IndianRed;
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(468, 12);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(24, 23);
            buttonQuitter.TabIndex = 17;
            buttonQuitter.Text = "X";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonRetour
            // 
            buttonRetour.BackColor = Color.IndianRed;
            buttonRetour.ForeColor = Color.White;
            buttonRetour.Location = new Point(468, 41);
            buttonRetour.Name = "buttonRetour";
            buttonRetour.Size = new Size(24, 23);
            buttonRetour.TabIndex = 19;
            buttonRetour.Text = "←";
            buttonRetour.UseVisualStyleBackColor = false;
            buttonRetour.Click += buttonRetour_Click;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(504, 499);
            ControlBox = false;
            Controls.Add(buttonRetour);
            Controls.Add(buttonQuitter);
            Controls.Add(CalendrierDateDeNaissance);
            Controls.Add(pictureCOnfirmationMDP);
            Controls.Add(pictureBox1);
            Controls.Add(BtnInscription);
            Controls.Add(TxtConfirmationInscription);
            Controls.Add(TxtMdpInscription);
            Controls.Add(TxtMailInscription);
            Controls.Add(TxtNomInscription);
            Controls.Add(TxtPrenomInscription);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(520, 538);
            MinimumSize = new Size(520, 538);
            Name = "FrmInscription";
            Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCOnfirmationMDP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtPrenomInscription;
        private TextBox TxtNomInscription;
        private TextBox TxtMailInscription;
        private TextBox TxtMdpInscription;
        private TextBox TxtConfirmationInscription;
        private Button BtnInscription;
        private PictureBox pictureBox1;
        private PictureBox pictureCOnfirmationMDP;
        private MonthCalendar CalendrierDateDeNaissance;
        private Button buttonQuitter;
        private Button buttonRetour;
    }
}