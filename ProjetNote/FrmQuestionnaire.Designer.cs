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
            SuspendLayout();
            // 
            // labelQN
            // 
            labelQN.AutoSize = true;
            labelQN.Location = new Point(352, 9);
            labelQN.Name = "labelQN";
            labelQN.Size = new Size(70, 15);
            labelQN.TabIndex = 0;
            labelQN.Text = "Question n°";
            // 
            // labelOrdreQuestion
            // 
            labelOrdreQuestion.AutoSize = true;
            labelOrdreQuestion.Location = new Point(428, 9);
            labelOrdreQuestion.Name = "labelOrdreQuestion";
            labelOrdreQuestion.Size = new Size(13, 15);
            labelOrdreQuestion.TabIndex = 1;
            labelOrdreQuestion.Text = "1";
            // 
            // buttonSuivant
            // 
            buttonSuivant.Enabled = false;
            buttonSuivant.Location = new Point(414, 394);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(116, 44);
            buttonSuivant.TabIndex = 2;
            buttonSuivant.Text = "Suivant";
            buttonSuivant.UseVisualStyleBackColor = true;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.Enabled = false;
            buttonPrecedent.Location = new Point(283, 394);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(116, 44);
            buttonPrecedent.TabIndex = 3;
            buttonPrecedent.Text = "Précédent";
            buttonPrecedent.UseVisualStyleBackColor = true;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(386, 135);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(55, 15);
            labelQuestion.TabIndex = 4;
            labelQuestion.Text = "Question";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSousQuestion
            // 
            labelSousQuestion.AutoSize = true;
            labelSousQuestion.Location = new Point(370, 188);
            labelSousQuestion.Name = "labelSousQuestion";
            labelSousQuestion.Size = new Size(83, 15);
            labelSousQuestion.TabIndex = 5;
            labelSousQuestion.Text = "Sous-question";
            labelSousQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOrdreSousQuestion
            // 
            labelOrdreSousQuestion.AutoSize = true;
            labelOrdreSousQuestion.Location = new Point(447, 9);
            labelOrdreSousQuestion.Name = "labelOrdreSousQuestion";
            labelOrdreSousQuestion.Size = new Size(15, 15);
            labelOrdreSousQuestion.TabIndex = 9;
            labelOrdreSousQuestion.Text = "A";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.Location = new Point(383, 84);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(58, 15);
            labelCategorie.TabIndex = 10;
            labelCategorie.Text = "Catégorie";
            labelCategorie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioOui
            // 
            radioOui.AutoSize = true;
            radioOui.Location = new Point(386, 273);
            radioOui.Name = "radioOui";
            radioOui.Size = new Size(44, 19);
            radioOui.TabIndex = 11;
            radioOui.TabStop = true;
            radioOui.Text = "Oui";
            radioOui.UseVisualStyleBackColor = true;
            // 
            // radioNon
            // 
            radioNon.AutoSize = true;
            radioNon.Location = new Point(553, 273);
            radioNon.Name = "radioNon";
            radioNon.Size = new Size(48, 19);
            radioNon.TabIndex = 12;
            radioNon.TabStop = true;
            radioNon.Text = "Non";
            radioNon.UseVisualStyleBackColor = true;
            // 
            // radioSaisPas
            // 
            radioSaisPas.AutoSize = true;
            radioSaisPas.Location = new Point(190, 273);
            radioSaisPas.Name = "radioSaisPas";
            radioSaisPas.Size = new Size(94, 19);
            radioSaisPas.TabIndex = 13;
            radioSaisPas.TabStop = true;
            radioSaisPas.Text = "Je ne sais pas";
            radioSaisPas.UseVisualStyleBackColor = true;
            // 
            // textComplement
            // 
            textComplement.Enabled = false;
            textComplement.Location = new Point(314, 298);
            textComplement.Multiline = true;
            textComplement.Name = "textComplement";
            textComplement.Size = new Size(191, 56);
            textComplement.TabIndex = 14;
            textComplement.Visible = false;
            // 
            // FrmQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}