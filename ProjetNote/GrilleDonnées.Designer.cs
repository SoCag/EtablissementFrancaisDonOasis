namespace ProjetNote
{
    partial class GrilleDonnées
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrilleDonnées));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            labelNom = new Label();
            labelPrenom = new Label();
            label3 = new Label();
            labelDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 152);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(125, 76);
            label1.Name = "label1";
            label1.Size = new Size(56, 29);
            label1.TabIndex = 1;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 105);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 2;
            label2.Text = "Prénom :";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(187, 79);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(50, 20);
            labelNom.TabIndex = 3;
            labelNom.Text = "label3";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(187, 110);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(50, 20);
            labelPrenom.TabIndex = 4;
            labelPrenom.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 135);
            label3.Name = "label3";
            label3.Size = new Size(151, 29);
            label3.TabIndex = 5;
            label3.Text = "Date de Naissance :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(187, 138);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(50, 20);
            labelDate.TabIndex = 6;
            labelDate.Text = "label5";
            // 
            // GrilleDonnées
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(848, 475);
            Controls.Add(labelDate);
            Controls.Add(label3);
            Controls.Add(labelPrenom);
            Controls.Add(labelNom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GrilleDonnées";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label labelNom;
        private Label labelPrenom;
        private Label label3;
        private Label labelDate;
    }
}