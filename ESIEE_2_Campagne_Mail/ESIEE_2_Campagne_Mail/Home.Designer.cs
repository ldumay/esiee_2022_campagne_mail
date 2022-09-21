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
            this.Email = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Button();
            this.Send_campaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(51, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(185, 62);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            this.Email.UseVisualStyleBackColor = true;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message.Location = new System.Drawing.Point(295, 149);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(185, 62);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            this.Message.UseVisualStyleBackColor = true;
            this.Message.Click += new System.EventHandler(this.Message_Click);
            // 
            // Send_campaign
            // 
            this.Send_campaign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Send_campaign.Location = new System.Drawing.Point(539, 149);
            this.Send_campaign.Name = "Send_campaign";
            this.Send_campaign.Size = new System.Drawing.Size(185, 62);
            this.Send_campaign.TabIndex = 2;
            this.Send_campaign.Text = "Envoi Campagne";
            this.Send_campaign.UseVisualStyleBackColor = true;
            this.Send_campaign.Click += new System.EventHandler(this.EnvoiCampagne_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send_campaign);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Email);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Email;
        private Button Message;
        private Button Send_campaign;
    }
}