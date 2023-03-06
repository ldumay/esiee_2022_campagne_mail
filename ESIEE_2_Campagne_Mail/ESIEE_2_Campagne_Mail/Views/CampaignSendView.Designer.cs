namespace ESIEE_2_Campagne_Mail
{
    partial class CampaignSendView
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
            System.Windows.Forms.Label labelSendTry;
            this.labelSendCampaign = new System.Windows.Forms.Button();
            this.buttonCampagneSendingTest = new System.Windows.Forms.Button();
            this.textBoxMailTest = new System.Windows.Forms.TextBox();
            this.labelSendTryResultContent = new System.Windows.Forms.Label();
            this.labelSendTryResult = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReady = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReadyForSend = new System.Windows.Forms.Label();
            this.labelConfirmStatutSMTP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            labelSendTry = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSendTry
            // 
            labelSendTry.AutoSize = true;
            labelSendTry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSendTry.ForeColor = System.Drawing.Color.White;
            labelSendTry.Location = new System.Drawing.Point(25, 21);
            labelSendTry.Name = "labelSendTry";
            labelSendTry.Size = new System.Drawing.Size(134, 28);
            labelSendTry.TabIndex = 3;
            labelSendTry.Text = "Email d\'essai";
            // 
            // labelSendCampaign
            // 
            this.labelSendCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.labelSendCampaign.FlatAppearance.BorderSize = 0;
            this.labelSendCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSendCampaign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendCampaign.ForeColor = System.Drawing.Color.White;
            this.labelSendCampaign.Location = new System.Drawing.Point(25, 31);
            this.labelSendCampaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelSendCampaign.Name = "labelSendCampaign";
            this.labelSendCampaign.Size = new System.Drawing.Size(235, 47);
            this.labelSendCampaign.TabIndex = 0;
            this.labelSendCampaign.Text = "Envoyer la campagne";
            this.labelSendCampaign.UseVisualStyleBackColor = false;
            this.labelSendCampaign.Click += new System.EventHandler(this.envoiDeLaCampagne);
            // 
            // buttonCampagneSendingTest
            // 
            this.buttonCampagneSendingTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.buttonCampagneSendingTest.FlatAppearance.BorderSize = 0;
            this.buttonCampagneSendingTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCampagneSendingTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCampagneSendingTest.ForeColor = System.Drawing.Color.White;
            this.buttonCampagneSendingTest.Location = new System.Drawing.Point(370, 65);
            this.buttonCampagneSendingTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCampagneSendingTest.Name = "buttonCampagneSendingTest";
            this.buttonCampagneSendingTest.Size = new System.Drawing.Size(261, 47);
            this.buttonCampagneSendingTest.TabIndex = 1;
            this.buttonCampagneSendingTest.Text = "Effectuer le test d\'envoi";
            this.buttonCampagneSendingTest.UseVisualStyleBackColor = false;
            this.buttonCampagneSendingTest.Click += new System.EventHandler(this.testDuServeurSMTP);
            // 
            // textBoxMailTest
            // 
            this.textBoxMailTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMailTest.Location = new System.Drawing.Point(25, 71);
            this.textBoxMailTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMailTest.Name = "textBoxMailTest";
            this.textBoxMailTest.PlaceholderText = "mail@mail.com";
            this.textBoxMailTest.Size = new System.Drawing.Size(322, 34);
            this.textBoxMailTest.TabIndex = 2;
            // 
            // labelSendTryResultContent
            // 
            this.labelSendTryResultContent.AutoSize = true;
            this.labelSendTryResultContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSendTryResultContent.ForeColor = System.Drawing.Color.White;
            this.labelSendTryResultContent.Location = new System.Drawing.Point(238, 70);
            this.labelSendTryResultContent.Name = "labelSendTryResultContent";
            this.labelSendTryResultContent.Size = new System.Drawing.Size(310, 28);
            this.labelSendTryResultContent.TabIndex = 10;
            this.labelSendTryResultContent.Text = "-ici le résultat de l\'essai de l\'envoi-";
            // 
            // labelSendTryResult
            // 
            this.labelSendTryResult.AutoSize = true;
            this.labelSendTryResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendTryResult.ForeColor = System.Drawing.Color.White;
            this.labelSendTryResult.Location = new System.Drawing.Point(25, 70);
            this.labelSendTryResult.Name = "labelSendTryResult";
            this.labelSendTryResult.Size = new System.Drawing.Size(194, 28);
            this.labelSendTryResult.TabIndex = 11;
            this.labelSendTryResult.Text = "Résultat de l\'essai :";
            // 
            // labelConfirmCampagneReady
            // 
            this.labelConfirmCampagneReady.AutoSize = true;
            this.labelConfirmCampagneReady.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReady.ForeColor = System.Drawing.Color.White;
            this.labelConfirmCampagneReady.Location = new System.Drawing.Point(25, 20);
            this.labelConfirmCampagneReady.Name = "labelConfirmCampagneReady";
            this.labelConfirmCampagneReady.Size = new System.Drawing.Size(243, 28);
            this.labelConfirmCampagneReady.TabIndex = 12;
            this.labelConfirmCampagneReady.Text = "❌ Campagne non prête";
            // 
            // labelConfirmCampagneReadyForSend
            // 
            this.labelConfirmCampagneReadyForSend.AutoSize = true;
            this.labelConfirmCampagneReadyForSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReadyForSend.ForeColor = System.Drawing.Color.White;
            this.labelConfirmCampagneReadyForSend.Location = new System.Drawing.Point(25, 23);
            this.labelConfirmCampagneReadyForSend.Name = "labelConfirmCampagneReadyForSend";
            this.labelConfirmCampagneReadyForSend.Size = new System.Drawing.Size(231, 28);
            this.labelConfirmCampagneReadyForSend.TabIndex = 13;
            this.labelConfirmCampagneReadyForSend.Text = "❌ Test d\'envoi valider";
            // 
            // labelConfirmStatutSMTP
            // 
            this.labelConfirmStatutSMTP.AutoSize = true;
            this.labelConfirmStatutSMTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmStatutSMTP.ForeColor = System.Drawing.Color.White;
            this.labelConfirmStatutSMTP.Location = new System.Drawing.Point(285, 20);
            this.labelConfirmStatutSMTP.Name = "labelConfirmStatutSMTP";
            this.labelConfirmStatutSMTP.Size = new System.Drawing.Size(431, 28);
            this.labelConfirmStatutSMTP.TabIndex = 15;
            this.labelConfirmStatutSMTP.Text = "❌ Configuration du serveur SMTP non prêt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelConfirmCampagneReady);
            this.panel1.Controls.Add(this.labelConfirmStatutSMTP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 69);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(labelSendTry);
            this.panel2.Controls.Add(this.textBoxMailTest);
            this.panel2.Controls.Add(this.buttonCampagneSendingTest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 135);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelSendTryResult);
            this.panel3.Controls.Add(this.labelSendTryResultContent);
            this.panel3.Controls.Add(this.labelConfirmCampagneReadyForSend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 186);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelSendCampaign);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 110);
            this.panel4.TabIndex = 19;
            // 
            // CampaignSendView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(912, 500);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CampaignSendView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Envoi de la campagne";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button labelSendCampaign;
        private Button buttonCampagneSendingTest;
        private TextBox textBoxMailTest;
        private Label labelSendTry;
        private Label labelSendTryResultContent;
        private Label labelSendTryResult;
        private Label labelConfirmCampagneReady;
        private Label labelConfirmCampagneReadyForSend;
        private Label labelConfirmStatutSMTP;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}