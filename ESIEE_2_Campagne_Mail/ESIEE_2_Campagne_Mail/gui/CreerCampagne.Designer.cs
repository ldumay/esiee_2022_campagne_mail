namespace ESIEE_2_Campagne_Mail
{
    partial class CreerCampagne
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateCampagne = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(381, 245);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(422, 27);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de la campagne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 95);
            this.label1.TabIndex = 8;
            this.label1.Text = "Créer une campagne";
            // 
            // buttonCreateCampagne
            // 
            this.buttonCreateCampagne.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateCampagne.Location = new System.Drawing.Point(314, 325);
            this.buttonCreateCampagne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateCampagne.Name = "buttonCreateCampagne";
            this.buttonCreateCampagne.Size = new System.Drawing.Size(269, 76);
            this.buttonCreateCampagne.TabIndex = 9;
            this.buttonCreateCampagne.Text = "Valider le nom";
            this.buttonCreateCampagne.UseVisualStyleBackColor = true;
            this.buttonCreateCampagne.Click += new System.EventHandler(this.buttonCreateCampagneClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(234, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // CreerCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.buttonCreateCampagne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreerCampagne";
            this.Text = "CreerCampagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button buttonCreateCampagne;
    }
}