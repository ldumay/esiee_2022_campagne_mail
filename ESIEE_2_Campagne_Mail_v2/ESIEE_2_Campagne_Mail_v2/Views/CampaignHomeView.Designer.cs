namespace ESIEE_2_Campagne_Mail_v2
{
    partial class CampaignHomeView
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
            this.labelConfirmServerSMTPReady = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReady = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCampagneName
            // 
            this.labelCampagneName.AutoSize = true;
            this.labelCampagneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCampagneName.ForeColor = System.Drawing.Color.White;
            this.labelCampagneName.Location = new System.Drawing.Point(27, 26);
            this.labelCampagneName.Name = "labelCampagneName";
            this.labelCampagneName.Size = new System.Drawing.Size(181, 21);
            this.labelCampagneName.TabIndex = 7;
            this.labelCampagneName.Text = "Nom de la campagne :";
            // 
            // labelCamapagneNameContent
            // 
            this.labelCamapagneNameContent.AutoSize = true;
            this.labelCamapagneNameContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCamapagneNameContent.ForeColor = System.Drawing.Color.White;
            this.labelCamapagneNameContent.Location = new System.Drawing.Point(244, 26);
            this.labelCamapagneNameContent.Name = "labelCamapagneNameContent";
            this.labelCamapagneNameContent.Size = new System.Drawing.Size(222, 21);
            this.labelCamapagneNameContent.TabIndex = 9;
            this.labelCamapagneNameContent.Text = "-ici le nom de la campagne-";
            // 
            // labelConfirmEmailReady
            // 
            this.labelConfirmEmailReady.AutoSize = true;
            this.labelConfirmEmailReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmEmailReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmEmailReady.Location = new System.Drawing.Point(27, 71);
            this.labelConfirmEmailReady.Name = "labelConfirmEmailReady";
            this.labelConfirmEmailReady.Size = new System.Drawing.Size(163, 21);
            this.labelConfirmEmailReady.TabIndex = 10;
            this.labelConfirmEmailReady.Text = "❌ Emails non prêts";
            // 
            // labelConfirmMessageReady
            // 
            this.labelConfirmMessageReady.AutoSize = true;
            this.labelConfirmMessageReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmMessageReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmMessageReady.Location = new System.Drawing.Point(27, 107);
            this.labelConfirmMessageReady.Name = "labelConfirmMessageReady";
            this.labelConfirmMessageReady.Size = new System.Drawing.Size(172, 21);
            this.labelConfirmMessageReady.TabIndex = 11;
            this.labelConfirmMessageReady.Text = "❌ Message non prêt";
            // 
            // labelConfirmServerSMTPReady
            // 
            this.labelConfirmServerSMTPReady.AutoSize = true;
            this.labelConfirmServerSMTPReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmServerSMTPReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmServerSMTPReady.Location = new System.Drawing.Point(27, 142);
            this.labelConfirmServerSMTPReady.Name = "labelConfirmServerSMTPReady";
            this.labelConfirmServerSMTPReady.Size = new System.Drawing.Size(221, 21);
            this.labelConfirmServerSMTPReady.TabIndex = 13;
            this.labelConfirmServerSMTPReady.Text = "❌ Serveur SMTP non prête";
            // 
            // labelConfirmCampagneReady
            // 
            this.labelConfirmCampagneReady.AutoSize = true;
            this.labelConfirmCampagneReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmCampagneReady.Location = new System.Drawing.Point(27, 179);
            this.labelConfirmCampagneReady.Name = "labelConfirmCampagneReady";
            this.labelConfirmCampagneReady.Size = new System.Drawing.Size(197, 21);
            this.labelConfirmCampagneReady.TabIndex = 14;
            this.labelConfirmCampagneReady.Text = "❌ Campagne non prête";
            // 
            // CampaignHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(682, 328);
            this.Controls.Add(this.labelConfirmCampagneReady);
            this.Controls.Add(this.labelConfirmServerSMTPReady);
            this.Controls.Add(this.labelConfirmMessageReady);
            this.Controls.Add(this.labelConfirmEmailReady);
            this.Controls.Add(this.labelCamapagneNameContent);
            this.Controls.Add(this.labelCampagneName);
            this.Name = "CampaignHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelCampagneName;
        private Label labelCamapagneNameContent;
        private Label labelConfirmEmailReady;
        private Label labelConfirmMessageReady;
        private Label labelConfirmServerSMTPReady;
        private Label labelConfirmCampagneReady;
    }
}