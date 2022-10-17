namespace ESIEE_2_Campagne_Mail
{
    partial class EnvoiCampagne
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
            this.sendingTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSendTryResultContent = new System.Windows.Forms.Label();
            this.labelSendTryResult = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReady = new System.Windows.Forms.Label();
            this.labelConfirmCampagneReadyForSend = new System.Windows.Forms.Label();
            labelSendTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSendTry
            // 
            labelSendTry.AutoSize = true;
            labelSendTry.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSendTry.Location = new System.Drawing.Point(37, 108);
            labelSendTry.Name = "labelSendTry";
            labelSendTry.Size = new System.Drawing.Size(139, 25);
            labelSendTry.TabIndex = 3;
            labelSendTry.Text = "Email d\'essai";
            labelSendTry.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSendCampaign
            // 
            this.labelSendCampaign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendCampaign.Location = new System.Drawing.Point(37, 409);
            this.labelSendCampaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelSendCampaign.Name = "labelSendCampaign";
            this.labelSendCampaign.Size = new System.Drawing.Size(178, 76);
            this.labelSendCampaign.TabIndex = 0;
            this.labelSendCampaign.Text = "Envoyer la campagne";
            this.labelSendCampaign.UseVisualStyleBackColor = true;
            this.labelSendCampaign.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendingTest
            // 
            this.sendingTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendingTest.Location = new System.Drawing.Point(396, 163);
            this.sendingTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendingTest.Name = "sendingTest";
            this.sendingTest.Size = new System.Drawing.Size(248, 31);
            this.sendingTest.TabIndex = 1;
            this.sendingTest.Text = "Effectuer le test d\'envoi";
            this.sendingTest.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "mail@mail.com";
            this.textBox1.Size = new System.Drawing.Size(335, 27);
            this.textBox1.TabIndex = 2;
            // 
            // labelSendTryResultContent
            // 
            this.labelSendTryResultContent.AutoSize = true;
            this.labelSendTryResultContent.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSendTryResultContent.Location = new System.Drawing.Point(286, 237);
            this.labelSendTryResultContent.Name = "labelSendTryResultContent";
            this.labelSendTryResultContent.Size = new System.Drawing.Size(395, 33);
            this.labelSendTryResultContent.TabIndex = 10;
            this.labelSendTryResultContent.Text = "-ici le résultat de l\'essai de l\'envoi-";
            // 
            // labelSendTryResult
            // 
            this.labelSendTryResult.AutoSize = true;
            this.labelSendTryResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSendTryResult.Location = new System.Drawing.Point(37, 236);
            this.labelSendTryResult.Name = "labelSendTryResult";
            this.labelSendTryResult.Size = new System.Drawing.Size(243, 32);
            this.labelSendTryResult.TabIndex = 11;
            this.labelSendTryResult.Text = "Résultat de l\'essai :";
            // 
            // labelConfirmCampagneReady
            // 
            this.labelConfirmCampagneReady.AutoSize = true;
            this.labelConfirmCampagneReady.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReady.Location = new System.Drawing.Point(37, 38);
            this.labelConfirmCampagneReady.Name = "labelConfirmCampagneReady";
            this.labelConfirmCampagneReady.Size = new System.Drawing.Size(288, 33);
            this.labelConfirmCampagneReady.TabIndex = 12;
            this.labelConfirmCampagneReady.Text = "❌ Campagne non prête";
            // 
            // labelConfirmCampagneReadyForSend
            // 
            this.labelConfirmCampagneReadyForSend.AutoSize = true;
            this.labelConfirmCampagneReadyForSend.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmCampagneReadyForSend.Location = new System.Drawing.Point(37, 326);
            this.labelConfirmCampagneReadyForSend.Name = "labelConfirmCampagneReadyForSend";
            this.labelConfirmCampagneReadyForSend.Size = new System.Drawing.Size(273, 33);
            this.labelConfirmCampagneReadyForSend.TabIndex = 13;
            this.labelConfirmCampagneReadyForSend.Text = "❌ Test d\'envoi valider";
            // 
            // EnvoiCampagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.labelConfirmCampagneReadyForSend);
            this.Controls.Add(this.labelConfirmCampagneReady);
            this.Controls.Add(this.labelSendTryResult);
            this.Controls.Add(this.labelSendTryResultContent);
            this.Controls.Add(labelSendTry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendingTest);
            this.Controls.Add(this.labelSendCampaign);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnvoiCampagne";
            this.Text = "EnvoiCampagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button labelSendCampaign;
        private Button sendingTest;
        private TextBox textBox1;
        private Label labelSendTry;
        private Label labelSendTryResultContent;
        private Label labelSendTryResult;
        private Label labelConfirmCampagneReady;
        private Label labelConfirmCampagneReadyForSend;
    }
}