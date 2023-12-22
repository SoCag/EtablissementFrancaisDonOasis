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
            SuspendLayout();
            // 
            // labelQN
            // 
            labelQN.AutoSize = true;
            labelQN.BackColor = Color.Transparent;
            labelQN.Font = new Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQN.ForeColor = Color.MidnightBlue;
            labelQN.Location = new Point(211, 54);
            labelQN.Name = "labelQN";
            labelQN.Size = new Size(133, 39);
            labelQN.TabIndex = 0;
            labelQN.Text = "Question n°";
            // 
            // labelOrdreQuestion
            // 
            labelOrdreQuestion.AutoSize = true;
            labelOrdreQuestion.BackColor = Color.Transparent;
            labelOrdreQuestion.Font = new Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdreQuestion.ForeColor = Color.MidnightBlue;
            labelOrdreQuestion.Location = new Point(339, 50);
            labelOrdreQuestion.Name = "labelOrdreQuestion";
            labelOrdreQuestion.Size = new Size(35, 45);
            labelOrdreQuestion.TabIndex = 1;
            labelOrdreQuestion.Text = "1";
            // 
            // buttonSuivant
            // 
            buttonSuivant.BackColor = Color.Gainsboro;
            buttonSuivant.Enabled = false;
            buttonSuivant.ForeColor = Color.Black;
            buttonSuivant.Location = new Point(250, 489);
            buttonSuivant.Margin = new Padding(3, 4, 3, 4);
            buttonSuivant.Name = "buttonSuivant";
            buttonSuivant.Size = new Size(133, 59);
            buttonSuivant.TabIndex = 2;
            buttonSuivant.Text = "Suivant";
            buttonSuivant.UseVisualStyleBackColor = false;
            buttonSuivant.Click += buttonSuivant_Click;
            // 
            // buttonPrecedent
            // 
            buttonPrecedent.BackColor = Color.Gainsboro;
            buttonPrecedent.Enabled = false;
            buttonPrecedent.Location = new Point(64, 489);
            buttonPrecedent.Margin = new Padding(3, 4, 3, 4);
            buttonPrecedent.Name = "buttonPrecedent";
            buttonPrecedent.Size = new Size(133, 59);
            buttonPrecedent.TabIndex = 3;
            buttonPrecedent.Text = "Précédent";
            buttonPrecedent.UseVisualStyleBackColor = false;
            buttonPrecedent.Click += buttonPrecedent_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.BackColor = Color.Transparent;
            labelQuestion.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.ForeColor = Color.MidnightBlue;
            labelQuestion.Location = new Point(286, 165);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(77, 29);
            labelQuestion.TabIndex = 4;
            labelQuestion.Text = "Question";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSousQuestion
            // 
            labelSousQuestion.AutoSize = true;
            labelSousQuestion.BackColor = Color.Transparent;
            labelSousQuestion.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSousQuestion.ForeColor = Color.MidnightBlue;
            labelSousQuestion.Location = new Point(268, 233);
            labelSousQuestion.Name = "labelSousQuestion";
            labelSousQuestion.Size = new Size(115, 29);
            labelSousQuestion.TabIndex = 5;
            labelSousQuestion.Text = "Sous-question";
            labelSousQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOrdreSousQuestion
            // 
            labelOrdreSousQuestion.AutoSize = true;
            labelOrdreSousQuestion.BackColor = Color.Transparent;
            labelOrdreSousQuestion.Font = new Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdreSousQuestion.ForeColor = Color.MidnightBlue;
            labelOrdreSousQuestion.Location = new Point(372, 55);
            labelOrdreSousQuestion.Name = "labelOrdreSousQuestion";
            labelOrdreSousQuestion.Size = new Size(32, 39);
            labelOrdreSousQuestion.TabIndex = 9;
            labelOrdreSousQuestion.Text = "A";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.BackColor = Color.Transparent;
            labelCategorie.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategorie.ForeColor = Color.MidnightBlue;
            labelCategorie.Location = new Point(283, 106);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(82, 29);
            labelCategorie.TabIndex = 10;
            labelCategorie.Text = "Catégorie";
            labelCategorie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioOui
            // 
            radioOui.AutoSize = true;
            radioOui.BackColor = Color.Transparent;
            radioOui.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioOui.ForeColor = Color.MidnightBlue;
            radioOui.Location = new Point(293, 306);
            radioOui.Margin = new Padding(3, 4, 3, 4);
            radioOui.Name = "radioOui";
            radioOui.Size = new Size(59, 33);
            radioOui.TabIndex = 11;
            radioOui.TabStop = true;
            radioOui.Text = "Oui";
            radioOui.UseVisualStyleBackColor = false;
            // 
            // radioNon
            // 
            radioNon.AutoSize = true;
            radioNon.BackColor = Color.Transparent;
            radioNon.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNon.ForeColor = Color.MidnightBlue;
            radioNon.Location = new Point(417, 306);
            radioNon.Margin = new Padding(3, 4, 3, 4);
            radioNon.Name = "radioNon";
            radioNon.Size = new Size(64, 33);
            radioNon.TabIndex = 12;
            radioNon.TabStop = true;
            radioNon.Text = "Non";
            radioNon.UseVisualStyleBackColor = false;
            // 
            // radioSaisPas
            // 
            radioSaisPas.AutoSize = true;
            radioSaisPas.BackColor = Color.Transparent;
            radioSaisPas.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioSaisPas.ForeColor = Color.MidnightBlue;
            radioSaisPas.Location = new Point(111, 306);
            radioSaisPas.Margin = new Padding(3, 4, 3, 4);
            radioSaisPas.Name = "radioSaisPas";
            radioSaisPas.Size = new Size(129, 33);
            radioSaisPas.TabIndex = 13;
            radioSaisPas.TabStop = true;
            radioSaisPas.Text = "Je ne sais pas";
            radioSaisPas.UseVisualStyleBackColor = false;
            // 
            // textComplement
            // 
            textComplement.Enabled = false;
            textComplement.Location = new Point(212, 375);
            textComplement.Margin = new Padding(3, 4, 3, 4);
            textComplement.Multiline = true;
            textComplement.Name = "textComplement";
            textComplement.Size = new Size(218, 73);
            textComplement.TabIndex = 14;
            textComplement.Visible = false;
            // 
            // FrmQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 630);
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
            Margin = new Padding(3, 4, 3, 4);
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