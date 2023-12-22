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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCOnfirmationMDP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Inscription";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 380);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Date de Naissance :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 62);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Nom :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 62);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Prénom :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 235);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Mot de Passe :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 154);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Adresse mail :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 310);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 6;
            label7.Text = "Confirmation :";
            // 
            // TxtPrenomInscription
            // 
            TxtPrenomInscription.Location = new Point(58, 85);
            TxtPrenomInscription.Name = "TxtPrenomInscription";
            TxtPrenomInscription.Size = new Size(180, 27);
            TxtPrenomInscription.TabIndex = 7;
            // 
            // TxtNomInscription
            // 
            TxtNomInscription.Location = new Point(266, 85);
            TxtNomInscription.Name = "TxtNomInscription";
            TxtNomInscription.Size = new Size(155, 27);
            TxtNomInscription.TabIndex = 8;
            // 
            // TxtMailInscription
            // 
            TxtMailInscription.Location = new Point(60, 177);
            TxtMailInscription.Name = "TxtMailInscription";
            TxtMailInscription.Size = new Size(361, 27);
            TxtMailInscription.TabIndex = 9;
            // 
            // TxtMdpInscription
            // 
            TxtMdpInscription.Location = new Point(60, 267);
            TxtMdpInscription.Name = "TxtMdpInscription";
            TxtMdpInscription.Size = new Size(361, 27);
            TxtMdpInscription.TabIndex = 10;
            TxtMdpInscription.TextChanged += TxtMdpChanged;
            // 
            // TxtConfirmationInscription
            // 
            TxtConfirmationInscription.Location = new Point(60, 333);
            TxtConfirmationInscription.Name = "TxtConfirmationInscription";
            TxtConfirmationInscription.Size = new Size(361, 27);
            TxtConfirmationInscription.TabIndex = 11;
            TxtConfirmationInscription.TextChanged += TxtConfirmationMdpChanged;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(64, 643);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(357, 29);
            BtnInscription.TabIndex = 13;
            BtnInscription.Text = "S'inscrire";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(427, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += this.voirMDP;
            pictureBox1.MouseLeave += cacherMDP;
            // 
            // pictureCOnfirmationMDP
            // 
            pictureCOnfirmationMDP.Image = (Image)resources.GetObject("pictureCOnfirmationMDP.Image");
            pictureCOnfirmationMDP.Location = new Point(427, 333);
            pictureCOnfirmationMDP.Name = "pictureCOnfirmationMDP";
            pictureCOnfirmationMDP.Size = new Size(32, 27);
            pictureCOnfirmationMDP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCOnfirmationMDP.TabIndex = 15;
            pictureCOnfirmationMDP.TabStop = false;
            pictureCOnfirmationMDP.MouseLeave += cacherConfirmationMDP;
            pictureCOnfirmationMDP.MouseHover += afficherConfirmationMDP;
            // 
            // CalendrierDateDeNaissance
            // 
            CalendrierDateDeNaissance.Location = new Point(118, 409);
            CalendrierDateDeNaissance.Name = "CalendrierDateDeNaissance";
            CalendrierDateDeNaissance.TabIndex = 16;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 703);
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
            Name = "FrmInscription";
            Text = "FormInscription";
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
    }
}