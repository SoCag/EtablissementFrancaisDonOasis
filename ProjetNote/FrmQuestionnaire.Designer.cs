namespace ProjetNote
{
    partial class FrmQuestionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestionnaire));
            labelQN = new Label();
            labelOrdreQuestion = new Label();
            buttonSuivant = new Button();
            buttonPrecedent = new Button();
            labelQuestion = new Label();
            labelSousQuestion = new Label();
            labelOrdreSousQuestion = new Label();
            labelCategorie = new Label();
            radioOui = new RadioButton();
            radioNon = new RadioButton();
            radioSaisPas = new RadioButton();
            textComplement = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelQN
            // 
            labelQN.AutoSize = true;
            labelQN.BackColor = Color.Transparent;
            labelQN.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQN.ForeColor = Color.RoyalBlue;
            labelQN.Location = new Point(148, 9);
            labelQN.Name = "labelQN";
            labelQN.Size = new Size(119, 24);
            labelQN.TabIndex = 0;
            labelQN.Text = "Question n°";
            // 
            // labelOrdreQuestion
            // 
            labelOrdreQuestion.AutoSize = true;
            labelOrdreQuestion.BackColor = Color.Transparent;
            labelOrdreQuestion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdreQuestion.ForeColor = Color.RoyalBlue;
            labelOrdreQuestion.Location = new Point(273, 9);
            labelOrdreQuestion.Name = "labelOrdreQuestion";
            labelOrdreQuestion.Size = new Size(21, 24);
            labelOrdreQuestion.TabIndex = 1;
            labelOrdreQuestion.Text = "1";
            // 
            // buttonSuivant
            // 
            buttonSuivant.BackColor = Color.RoyalBlue;
            buttonSuivant.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuivant.ForeColor = Color.White;
            buttonSuivant.Location = new Point(273, 421);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(116, 44);
            buttonSuivant.TabIndex = 2;
            buttonSuivant.Text = "Suivant";
            buttonSuivant.UseVisualStyleBackColor = false;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.BackColor = Color.RoyalBlue;
            buttonPrecedent.Enabled = false;
            buttonPrecedent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrecedent.ForeColor = Color.White;
            buttonPrecedent.Location = new Point(131, 421);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(116, 44);
            buttonPrecedent.TabIndex = 3;
            buttonPrecedent.Text = "Précédent";
            buttonPrecedent.UseVisualStyleBackColor = false;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoEllipsis = true;
            labelQuestion.AutoSize = true;
            labelQuestion.BackColor = Color.Transparent;
            labelQuestion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.ForeColor = Color.RoyalBlue;
            labelQuestion.Location = new Point(56, 106);
            labelQuestion.MaximumSize = new Size(390, 0);
            labelQuestion.MinimumSize = new Size(390, 0);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(390, 20);
            labelQuestion.TabIndex = 4;
            labelQuestion.Text = "Question";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSousQuestion
            // 
            labelSousQuestion.AutoSize = true;
            labelSousQuestion.BackColor = Color.Transparent;
            labelSousQuestion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSousQuestion.ForeColor = Color.RoyalBlue;
            labelSousQuestion.Location = new Point(56, 169);
            labelSousQuestion.MaximumSize = new Size(390, 0);
            labelSousQuestion.MinimumSize = new Size(390, 0);
            labelSousQuestion.Name = "labelSousQuestion";
            labelSousQuestion.Size = new Size(390, 18);
            labelSousQuestion.TabIndex = 5;
            labelSousQuestion.Text = "Sous-question";
            labelSousQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOrdreSousQuestion
            // 
            labelOrdreSousQuestion.AutoSize = true;
            labelOrdreSousQuestion.BackColor = Color.Transparent;
            labelOrdreSousQuestion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdreSousQuestion.ForeColor = Color.RoyalBlue;
            labelOrdreSousQuestion.Location = new Point(300, 9);
            labelOrdreSousQuestion.Name = "labelOrdreSousQuestion";
            labelOrdreSousQuestion.Size = new Size(24, 24);
            labelOrdreSousQuestion.TabIndex = 9;
            labelOrdreSousQuestion.Text = "A";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.BackColor = Color.Transparent;
            labelCategorie.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategorie.ForeColor = Color.RoyalBlue;
            labelCategorie.Location = new Point(54, 45);
            labelCategorie.MaximumSize = new Size(390, 0);
            labelCategorie.MinimumSize = new Size(390, 0);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(390, 24);
            labelCategorie.TabIndex = 10;
            labelCategorie.Text = "Catégorie";
            labelCategorie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioOui
            // 
            radioOui.AutoSize = true;
            radioOui.BackColor = Color.Transparent;
            radioOui.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioOui.ForeColor = Color.RoyalBlue;
            radioOui.Location = new Point(56, 292);
            radioOui.Name = "radioOui";
            radioOui.Size = new Size(51, 21);
            radioOui.TabIndex = 11;
            radioOui.TabStop = true;
            radioOui.Text = "Oui";
            radioOui.UseVisualStyleBackColor = true;
            radioOui.CheckedChanged += radioOui_CheckedChanged;
            // 
            // radioNon
            // 
            radioNon.AutoSize = true;
            radioNon.BackColor = Color.Transparent;
            radioNon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNon.ForeColor = Color.RoyalBlue;
            radioNon.Location = new Point(391, 292);
            radioNon.Name = "radioNon";
            radioNon.Size = new Size(55, 21);
            radioNon.TabIndex = 12;
            radioNon.TabStop = true;
            radioNon.Text = "Non";
            radioNon.UseVisualStyleBackColor = false;
            // 
            // radioSaisPas
            // 
            radioSaisPas.AutoSize = true;
            radioSaisPas.BackColor = Color.Transparent;
            radioSaisPas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioSaisPas.ForeColor = Color.RoyalBlue;
            radioSaisPas.Location = new Point(194, 292);
            radioSaisPas.Name = "radioSaisPas";
            radioSaisPas.Size = new Size(131, 21);
            radioSaisPas.TabIndex = 13;
            radioSaisPas.TabStop = true;
            radioSaisPas.Text = "Je ne sais pas";
            radioSaisPas.UseVisualStyleBackColor = false;
            // 
            // textComplement
            // 
            textComplement.Enabled = false;
            textComplement.Location = new Point(56, 319);
            textComplement.Multiline = true;
            textComplement.Name = "textComplement";
            textComplement.Size = new Size(388, 56);
            textComplement.TabIndex = 14;
            textComplement.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(468, 12);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(504, 501);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(textComplement);
            Controls.Add(radioSaisPas);
            Controls.Add(radioNon);
            Controls.Add(radioOui);
            Controls.Add(labelCategorie);
            Controls.Add(labelOrdreSousQuestion);
            Controls.Add(labelSousQuestion);
            Controls.Add(labelQuestion);
            Controls.Add(buttonPrecedent);
            Controls.Add(buttonSuivant);
            Controls.Add(labelOrdreQuestion);
            Controls.Add(labelQN);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(520, 540);
            MinimumSize = new Size(520, 540);
            Name = "FrmQuestionnaire";
            Text = "Questionnaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQN;
        private Label labelOrdreQuestion;
        private Button buttonSuivant;
        private Button buttonPrecedent;
        private Label labelQuestion;
        private Label labelSousQuestion;
        private Label labelOrdreSousQuestion;
        private Label labelCategorie;
        private RadioButton radioOui;
        private RadioButton radioNon;
        private RadioButton radioSaisPas;
        private TextBox textComplement;
        private Button button1;
    }
}