namespace ESIEE_2_Campagne_Mail.gui
{
    partial class ConfigServerSMTP
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
            this.labelSendCampaign = new System.Windows.Forms.Button();
            this.textBoxEXP = new System.Windows.Forms.TextBox();
            this.labelEXP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCampagneName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSendCampaign
            // 
            this.labelSendCampaign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendCampaign.Location = new System.Drawing.Point(37, 403);
            this.labelSendCampaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelSendCampaign.Name = "labelSendCampaign";
            this.labelSendCampaign.Size = new System.Drawing.Size(178, 76);
            this.labelSendCampaign.TabIndex = 1;
            this.labelSendCampaign.Text = "Enregistrer";
            this.labelSendCampaign.UseVisualStyleBackColor = true;
            // 
            // textBoxEXP
            // 
            this.textBoxEXP.Location = new System.Drawing.Point(190, 121);
            this.textBoxEXP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEXP.Name = "textBoxEXP";
            this.textBoxEXP.PlaceholderText = "mail@mail.com";
            this.textBoxEXP.Size = new System.Drawing.Size(402, 27);
            this.textBoxEXP.TabIndex = 3;
            // 
            // labelEXP
            // 
            this.labelEXP.AutoSize = true;
            this.labelEXP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEXP.Location = new System.Drawing.Point(37, 121);
            this.labelEXP.Name = "labelEXP";
            this.labelEXP.Size = new System.Drawing.Size(134, 25);
            this.labelEXP.TabIndex = 2;
            this.labelEXP.Text = "Adresse IP :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 178);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "mail@mail.com";
            this.textBox1.Size = new System.Drawing.Size(464, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 240);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "mail@mail.com";
            this.textBox2.Size = new System.Drawing.Size(320, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "User SMTP - Login :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 307);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "mail@mail.com";
            this.textBox3.Size = new System.Drawing.Size(320, 27);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "User SMPT - Mdp :";
            // 
            // labelCampagneName
            // 
            this.labelCampagneName.AutoSize = true;
            this.labelCampagneName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCampagneName.Location = new System.Drawing.Point(37, 42);
            this.labelCampagneName.Name = "labelCampagneName";
            this.labelCampagneName.Size = new System.Drawing.Size(403, 32);
            this.labelCampagneName.TabIndex = 10;
            this.labelCampagneName.Text = "Configuration du serveur SMTP";
            // 
            // ConfigServerSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.labelCampagneName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEXP);
            this.Controls.Add(this.labelEXP);
            this.Controls.Add(this.labelSendCampaign);
            this.Name = "ConfigServerSMTP";
            this.Text = "ConfigServerSMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button labelSendCampaign;
        private TextBox textBoxEXP;
        private Label labelEXP;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label labelCampagneName;
    }
}