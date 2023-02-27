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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEXP
            // 
            this.labelEXP.AutoSize = true;
            this.labelEXP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEXP.ForeColor = System.Drawing.Color.White;
            this.labelEXP.Location = new System.Drawing.Point(22, 26);
            this.labelEXP.Name = "labelEXP";
            this.labelEXP.Size = new System.Drawing.Size(48, 28);
            this.labelEXP.TabIndex = 0;
            this.labelEXP.Text = "EXP";
            this.labelEXP.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEXP
            // 
            this.textBoxEXP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEXP.Location = new System.Drawing.Point(89, 26);
            this.textBoxEXP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEXP.Name = "textBoxEXP";
            this.textBoxEXP.PlaceholderText = "mail@mail.com";
            this.textBoxEXP.Size = new System.Drawing.Size(320, 34);
            this.textBoxEXP.TabIndex = 1;
            this.textBoxEXP.TextChanged += new System.EventHandler(this.textBoxEXP_TextChanged);
            // 
            // textBoxRebound
            // 
            this.textBoxRebound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRebound.Location = new System.Drawing.Point(571, 27);
            this.textBoxRebound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRebound.Name = "textBoxRebound";
            this.textBoxRebound.PlaceholderText = "mail@mail.com";
            this.textBoxRebound.Size = new System.Drawing.Size(320, 34);
            this.textBoxRebound.TabIndex = 3;
            this.textBoxRebound.TextChanged += new System.EventHandler(this.textBoxRebound_TextChanged);
            // 
            // labelRebound
            // 
            this.labelRebound.AutoSize = true;
            this.labelRebound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRebound.ForeColor = System.Drawing.Color.White;
            this.labelRebound.Location = new System.Drawing.Point(461, 26);
            this.labelRebound.Name = "labelRebound";
            this.labelRebound.Size = new System.Drawing.Size(96, 28);
            this.labelRebound.TabIndex = 2;
            this.labelRebound.Text = "Rebound";
            this.labelRebound.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitre.Location = new System.Drawing.Point(89, 86);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.PlaceholderText = "Titre de l\'email";
            this.textBoxTitre.Size = new System.Drawing.Size(320, 34);
            this.textBoxTitre.TabIndex = 5;
            this.textBoxTitre.TextChanged += new System.EventHandler(this.textBoxTitre_TextChanged);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.ForeColor = System.Drawing.Color.White;
            this.labelTitre.Location = new System.Drawing.Point(22, 86);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(57, 28);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "Titre";
            this.labelTitre.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(22, 28);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(94, 28);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(22, 72);
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
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(22, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 62);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEXP);
            this.panel1.Controls.Add(this.labelEXP);
            this.panel1.Controls.Add(this.labelRebound);
            this.panel1.Controls.Add(this.textBoxRebound);
            this.panel1.Controls.Add(this.textBoxTitre);
            this.panel1.Controls.Add(this.labelTitre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 145);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxMessage);
            this.panel2.Controls.Add(this.labelMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 335);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 121);
            this.panel3.TabIndex = 11;
            // 
            // EditionMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1022, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditionMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edition du message de la campagne";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}