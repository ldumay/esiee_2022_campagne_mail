namespace ESIEE_2_Campagne_Mail
{
    partial class EditionMessage
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
            this.labelEXP = new System.Windows.Forms.Label();
            this.textBoxEXP = new System.Windows.Forms.TextBox();
            this.textBoxRebound = new System.Windows.Forms.TextBox();
            this.labelRebound = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEXP
            // 
            this.labelEXP.AutoSize = true;
            this.labelEXP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEXP.Location = new System.Drawing.Point(29, 30);
            this.labelEXP.Name = "labelEXP";
            this.labelEXP.Size = new System.Drawing.Size(57, 25);
            this.labelEXP.TabIndex = 0;
            this.labelEXP.Text = "EXP";
            this.labelEXP.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEXP
            // 
            this.textBoxEXP.Location = new System.Drawing.Point(96, 30);
            this.textBoxEXP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEXP.Name = "textBoxEXP";
            this.textBoxEXP.PlaceholderText = "mail@mail.com";
            this.textBoxEXP.Size = new System.Drawing.Size(320, 27);
            this.textBoxEXP.TabIndex = 1;
            this.textBoxEXP.TextChanged += new System.EventHandler(this.textBoxEXP_TextChanged);
            // 
            // textBoxRebound
            // 
            this.textBoxRebound.Location = new System.Drawing.Point(578, 31);
            this.textBoxRebound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRebound.Name = "textBoxRebound";
            this.textBoxRebound.PlaceholderText = "mail@mail.com";
            this.textBoxRebound.Size = new System.Drawing.Size(320, 27);
            this.textBoxRebound.TabIndex = 3;
            this.textBoxRebound.TextChanged += new System.EventHandler(this.textBoxRebound_TextChanged);
            // 
            // labelRebound
            // 
            this.labelRebound.AutoSize = true;
            this.labelRebound.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRebound.Location = new System.Drawing.Point(468, 30);
            this.labelRebound.Name = "labelRebound";
            this.labelRebound.Size = new System.Drawing.Size(104, 25);
            this.labelRebound.TabIndex = 2;
            this.labelRebound.Text = "Rebound";
            this.labelRebound.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(96, 93);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.PlaceholderText = "Titre de l\'email";
            this.textBoxTitre.Size = new System.Drawing.Size(320, 27);
            this.textBoxTitre.TabIndex = 5;
            this.textBoxTitre.TextChanged += new System.EventHandler(this.textBoxTitre_TextChanged);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(29, 93);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(61, 25);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Titre";
            this.labelTitre.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(29, 155);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(99, 25);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(29, 199);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.PlaceholderText = "Contenu de l\'email";
            this.textBoxMessage.Size = new System.Drawing.Size(869, 219);
            this.textBoxMessage.TabIndex = 7;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(751, 439);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 62);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // EditionMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxTitre);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.textBoxRebound);
            this.Controls.Add(this.labelRebound);
            this.Controls.Add(this.textBoxEXP);
            this.Controls.Add(this.labelEXP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditionMessage";
            this.Text = "EditionMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEXP;
        private TextBox textBoxEXP;
        private TextBox textBoxRebound;
        private Label labelRebound;
        private TextBox textBoxTitre;
        private Label labelTitre;
        private Label labelMessage;
        private TextBox textBoxMessage;
        private Button buttonSave;
    }
}