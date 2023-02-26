namespace ESIEE_2_Campagne_Mail
{
    partial class Home
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
            this.labelCampagneName = new System.Windows.Forms.Label();
            this.labelCamapagneNameContent = new System.Windows.Forms.Label();
            this.labelConfirmEmailReady = new System.Windows.Forms.Label();
            this.labelConfirmMessageReady = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReady = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Button();
            this.Send_campaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCampagneName
            // 
            this.labelCampagneName.AutoSize = true;
            this.labelCampagneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCampagneName.ForeColor = System.Drawing.Color.White;
            this.labelCampagneName.Location = new System.Drawing.Point(31, 34);
            this.labelCampagneName.Name = "labelCampagneName";
            this.labelCampagneName.Size = new System.Drawing.Size(224, 28);
            this.labelCampagneName.TabIndex = 7;
            this.labelCampagneName.Text = "Nom de la campagne :";
            // 
            // labelCamapagneNameContent
            // 
            this.labelCamapagneNameContent.AutoSize = true;
            this.labelCamapagneNameContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCamapagneNameContent.ForeColor = System.Drawing.Color.White;
            this.labelCamapagneNameContent.Location = new System.Drawing.Point(279, 34);
            this.labelCamapagneNameContent.Name = "labelCamapagneNameContent";
            this.labelCamapagneNameContent.Size = new System.Drawing.Size(276, 28);
            this.labelCamapagneNameContent.TabIndex = 9;
            this.labelCamapagneNameContent.Text = "-ici le nom de la campagne-";
            // 
            // labelConfirmEmailReady
            // 
            this.labelConfirmEmailReady.AutoSize = true;
            this.labelConfirmEmailReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmEmailReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmEmailReady.Location = new System.Drawing.Point(31, 95);
            this.labelConfirmEmailReady.Name = "labelConfirmEmailReady";
            this.labelConfirmEmailReady.Size = new System.Drawing.Size(203, 28);
            this.labelConfirmEmailReady.TabIndex = 10;
            this.labelConfirmEmailReady.Text = "❌ Emails non prêts";
            // 
            // labelConfirmMessageReady
            // 
            this.labelConfirmMessageReady.AutoSize = true;
            this.labelConfirmMessageReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmMessageReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmMessageReady.Location = new System.Drawing.Point(31, 143);
            this.labelConfirmMessageReady.Name = "labelConfirmMessageReady";
            this.labelConfirmMessageReady.Size = new System.Drawing.Size(215, 28);
            this.labelConfirmMessageReady.TabIndex = 11;
            this.labelConfirmMessageReady.Text = "❌ Message non prêt";
            // 
            // labelConfirmCampagneReady
            // 
            this.labelConfirmCampagneReady.AutoSize = true;
            this.labelConfirmCampagneReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmCampagneReady.Location = new System.Drawing.Point(31, 190);
            this.labelConfirmCampagneReady.Name = "labelConfirmCampagneReady";
            this.labelConfirmCampagneReady.Size = new System.Drawing.Size(243, 28);
            this.labelConfirmCampagneReady.TabIndex = 13;
            this.labelConfirmCampagneReady.Text = "❌ Campagne non prête";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.Email.FlatAppearance.BorderSize = 0;
            this.Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(369, 95);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(299, 113);
            this.Email.TabIndex = 0;
            this.Email.Text = "Emails\r\n\r\nSélection la liste des emails à contacter";
            this.Email.UseVisualStyleBackColor = false;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.Message.FlatAppearance.BorderSize = 0;
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(369, 233);
            this.Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(299, 113);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message\r\n\r\nEdition du contenu de l\'email";
            this.Message.UseVisualStyleBackColor = false;
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // Send_campaign
            // 
            this.Send_campaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.Send_campaign.FlatAppearance.BorderSize = 0;
            this.Send_campaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_campaign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Send_campaign.ForeColor = System.Drawing.Color.White;
            this.Send_campaign.Location = new System.Drawing.Point(31, 270);
            this.Send_campaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_campaign.Name = "Send_campaign";
            this.Send_campaign.Size = new System.Drawing.Size(299, 112);
            this.Send_campaign.TabIndex = 2;
            this.Send_campaign.Text = "Envoi\r\n\r\nTest et envoi de la campagne";
            this.Send_campaign.UseVisualStyleBackColor = false;
            this.Send_campaign.Click += new System.EventHandler(this.EnvoiCampagne_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(780, 437);
            this.Controls.Add(this.labelConfirmCampagneReady);
            this.Controls.Add(this.labelConfirmMessageReady);
            this.Controls.Add(this.labelConfirmEmailReady);
            this.Controls.Add(this.labelCamapagneNameContent);
            this.Controls.Add(this.labelCampagneName);
            this.Controls.Add(this.Send_campaign);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Email);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelCampagneName;
        private Label labelCamapagneNameContent;
        private Label labelConfirmEmailReady;
        private Label labelConfirmMessageReady;
        private Label labelConfirmCampagneReady;
        private Button Email;
        private Button Message;
        private Button Send_campaign;
    }
}