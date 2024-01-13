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
            labelQN.Location = new Point(169, 12);
            labelQN.Name = "labelQN";
            labelQN.Size = new Size(148, 29);
            labelQN.TabIndex = 0;
            labelQN.Text = "Question n°";
            // 
            // labelOrdreQuestion
            // 
            labelOrdreQuestion.AutoSize = true;
            labelOrdreQuestion.BackColor = Color.Transparent;
            labelOrdreQuestion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdreQuestion.ForeColor = Color.RoyalBlue;
            labelOrdreQuestion.Location = new Point(312, 12);
            labelOrdreQuestion.Name = "labelOrdreQuestion";
            labelOrdreQuestion.Size = new Size(27, 29);
            labelOrdreQuestion.TabIndex = 1;
            labelOrdreQuestion.Text = "1";
            // 
            // buttonSuivant
            // 
            buttonSuivant.BackColor = Color.RoyalBlue;
            buttonSuivant.Cursor = Cursors.Hand;
            buttonSuivant.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuivant.ForeColor = Color.White;
            buttonSuivant.Location = new Point(312, 561);
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
            buttonPrecedent.BackColor = Color.RoyalBlue;
            buttonPrecedent.Cursor = Cursors.Hand;
            buttonPrecedent.Enabled = false;
            buttonPrecedent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrecedent.ForeColor = Color.White;
            buttonPrecedent.Location = new Point(150, 561);
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
            labelQuestion.AutoEllipsis = true;
            labelQuestion.AutoSize = true;
            labelQuestion.BackColor = Color.Transparent;
            labelQuestion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestion.ForeColor = Color.RoyalBlue;
            labelQuestion.Location = new Point(64, 148);
            labelQuestion.MaximumSize = new Size(446, 107);
            labelQuestion.MinimumSize = new Size(446, 107);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(446, 107);
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
            labelSousQuestion.Location = new Point(64, 279);
            labelSousQuestion.MaximumSize = new Size(446, 107);
            labelSousQuestion.MinimumSize = new Size(446, 107);
            labelSousQuestion.Name = "labelSousQuestion";
            labelSousQuestion.Size = new Size(446, 107);
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
            labelOrdreSousQuestion.Location = new Point(343, 12);
            labelOrdreSousQuestion.Name = "labelOrdreSousQuestion";
            labelOrdreSousQuestion.Size = new Size(29, 29);
            labelOrdreSousQuestion.TabIndex = 9;
            labelOrdreSousQuestion.Text = "A";
            // 
            // labelCategorie
            // 
            labelCategorie.AutoSize = true;
            labelCategorie.BackColor = Color.Transparent;
            labelCategorie.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategorie.ForeColor = Color.RoyalBlue;
            labelCategorie.Location = new Point(64, 60);
            labelCategorie.MaximumSize = new Size(446, 67);
            labelCategorie.MinimumSize = new Size(446, 67);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(446, 67);
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
            radioOui.Location = new Point(64, 389);
            radioOui.Margin = new Padding(3, 4, 3, 4);
            radioOui.Name = "radioOui";
            radioOui.Size = new Size(59, 24);
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
            radioNon.Location = new Point(447, 389);
            radioNon.Margin = new Padding(3, 4, 3, 4);
            radioNon.Name = "radioNon";
            radioNon.Size = new Size(63, 24);
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
            radioSaisPas.Location = new Point(222, 389);
            radioSaisPas.Margin = new Padding(3, 4, 3, 4);
            radioSaisPas.Name = "radioSaisPas";
            radioSaisPas.Size = new Size(153, 24);
            radioSaisPas.TabIndex = 13;
            radioSaisPas.TabStop = true;
            radioSaisPas.Text = "Je ne sais pas";
            radioSaisPas.UseVisualStyleBackColor = false;
            // 
            // textComplement
            // 
            textComplement.Enabled = false;
            textComplement.Location = new Point(64, 425);
            textComplement.Margin = new Padding(3, 4, 3, 4);
            textComplement.Multiline = true;
            textComplement.Name = "textComplement";
            textComplement.Size = new Size(443, 73);
            textComplement.TabIndex = 14;
            textComplement.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(535, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(27, 31);
            button1.TabIndex = 18;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(574, 655);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(592, 702);
            MinimumSize = new Size(592, 702);
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