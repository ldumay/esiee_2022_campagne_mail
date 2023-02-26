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
            this.buttonSaveSMTPConfiguration = new System.Windows.Forms.Button();
            this.textBoxSMTPAddressIP = new System.Windows.Forms.TextBox();
            this.labelSMTPAddressIP = new System.Windows.Forms.Label();
            this.textBoxSMTPPort = new System.Windows.Forms.TextBox();
            this.labelSMTPPort = new System.Windows.Forms.Label();
            this.textBoxSMTPUserLogin = new System.Windows.Forms.TextBox();
            this.labelSMTPUserLogin = new System.Windows.Forms.Label();
            this.textBoxSMTPUserMDP = new System.Windows.Forms.TextBox();
            this.labelSMTPUserMDP = new System.Windows.Forms.Label();
            this.labelCampagneName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveSMTPConfiguration
            // 
            this.buttonSaveSMTPConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.buttonSaveSMTPConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonSaveSMTPConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSMTPConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSMTPConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSMTPConfiguration.Location = new System.Drawing.Point(37, 403);
            this.buttonSaveSMTPConfiguration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveSMTPConfiguration.Name = "buttonSaveSMTPConfiguration";
            this.buttonSaveSMTPConfiguration.Size = new System.Drawing.Size(178, 76);
            this.buttonSaveSMTPConfiguration.TabIndex = 1;
            this.buttonSaveSMTPConfiguration.Text = "Enregistrer";
            this.buttonSaveSMTPConfiguration.UseVisualStyleBackColor = false;
            this.buttonSaveSMTPConfiguration.Click += new System.EventHandler(this.buttonSaveSMTPConfiguration_Click);
            // 
            // textBoxSMTPAddressIP
            // 
            this.textBoxSMTPAddressIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSMTPAddressIP.Location = new System.Drawing.Point(190, 121);
            this.textBoxSMTPAddressIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSMTPAddressIP.Name = "textBoxSMTPAddressIP";
            this.textBoxSMTPAddressIP.PlaceholderText = "255.255.255.255";
            this.textBoxSMTPAddressIP.Size = new System.Drawing.Size(402, 34);
            this.textBoxSMTPAddressIP.TabIndex = 3;
            // 
            // labelSMTPAddressIP
            // 
            this.labelSMTPAddressIP.AutoSize = true;
            this.labelSMTPAddressIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSMTPAddressIP.ForeColor = System.Drawing.Color.White;
            this.labelSMTPAddressIP.Location = new System.Drawing.Point(37, 121);
            this.labelSMTPAddressIP.Name = "labelSMTPAddressIP";
            this.labelSMTPAddressIP.Size = new System.Drawing.Size(121, 28);
            this.labelSMTPAddressIP.TabIndex = 2;
            this.labelSMTPAddressIP.Text = "Adresse IP :";
            // 
            // textBoxSMTPPort
            // 
            this.textBoxSMTPPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSMTPPort.Location = new System.Drawing.Point(128, 178);
            this.textBoxSMTPPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSMTPPort.Name = "textBoxSMTPPort";
            this.textBoxSMTPPort.PlaceholderText = "000";
            this.textBoxSMTPPort.Size = new System.Drawing.Size(464, 34);
            this.textBoxSMTPPort.TabIndex = 5;
            // 
            // labelSMTPPort
            // 
            this.labelSMTPPort.AutoSize = true;
            this.labelSMTPPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSMTPPort.ForeColor = System.Drawing.Color.White;
            this.labelSMTPPort.Location = new System.Drawing.Point(37, 177);
            this.labelSMTPPort.Name = "labelSMTPPort";
            this.labelSMTPPort.Size = new System.Drawing.Size(63, 28);
            this.labelSMTPPort.TabIndex = 4;
            this.labelSMTPPort.Text = "Port :";
            // 
            // textBoxSMTPUserLogin
            // 
            this.textBoxSMTPUserLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSMTPUserLogin.Location = new System.Drawing.Point(272, 240);
            this.textBoxSMTPUserLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSMTPUserLogin.Name = "textBoxSMTPUserLogin";
            this.textBoxSMTPUserLogin.PlaceholderText = "user";
            this.textBoxSMTPUserLogin.Size = new System.Drawing.Size(320, 34);
            this.textBoxSMTPUserLogin.TabIndex = 7;
            // 
            // labelSMTPUserLogin
            // 
            this.labelSMTPUserLogin.AutoSize = true;
            this.labelSMTPUserLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSMTPUserLogin.ForeColor = System.Drawing.Color.White;
            this.labelSMTPUserLogin.Location = new System.Drawing.Point(37, 239);
            this.labelSMTPUserLogin.Name = "labelSMTPUserLogin";
            this.labelSMTPUserLogin.Size = new System.Drawing.Size(197, 28);
            this.labelSMTPUserLogin.TabIndex = 6;
            this.labelSMTPUserLogin.Text = "User SMTP - Login :";
            // 
            // textBoxSMTPUserMDP
            // 
            this.textBoxSMTPUserMDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSMTPUserMDP.Location = new System.Drawing.Point(272, 307);
            this.textBoxSMTPUserMDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSMTPUserMDP.Name = "textBoxSMTPUserMDP";
            this.textBoxSMTPUserMDP.PasswordChar = '*';
            this.textBoxSMTPUserMDP.PlaceholderText = "****";
            this.textBoxSMTPUserMDP.Size = new System.Drawing.Size(320, 34);
            this.textBoxSMTPUserMDP.TabIndex = 9;
            // 
            // labelSMTPUserMDP
            // 
            this.labelSMTPUserMDP.AutoSize = true;
            this.labelSMTPUserMDP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSMTPUserMDP.ForeColor = System.Drawing.Color.White;
            this.labelSMTPUserMDP.Location = new System.Drawing.Point(37, 306);
            this.labelSMTPUserMDP.Name = "labelSMTPUserMDP";
            this.labelSMTPUserMDP.Size = new System.Drawing.Size(188, 28);
            this.labelSMTPUserMDP.TabIndex = 8;
            this.labelSMTPUserMDP.Text = "User SMPT - Mdp :";
            // 
            // labelCampagneName
            // 
            this.labelCampagneName.AutoSize = true;
            this.labelCampagneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCampagneName.ForeColor = System.Drawing.Color.White;
            this.labelCampagneName.Location = new System.Drawing.Point(37, 42);
            this.labelCampagneName.Name = "labelCampagneName";
            this.labelCampagneName.Size = new System.Drawing.Size(310, 28);
            this.labelCampagneName.TabIndex = 10;
            this.labelCampagneName.Text = "Configuration du serveur SMTP";
            // 
            // ConfigServerSMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.labelCampagneName);
            this.Controls.Add(this.textBoxSMTPUserMDP);
            this.Controls.Add(this.labelSMTPUserMDP);
            this.Controls.Add(this.textBoxSMTPUserLogin);
            this.Controls.Add(this.labelSMTPUserLogin);
            this.Controls.Add(this.textBoxSMTPPort);
            this.Controls.Add(this.labelSMTPPort);
            this.Controls.Add(this.textBoxSMTPAddressIP);
            this.Controls.Add(this.labelSMTPAddressIP);
            this.Controls.Add(this.buttonSaveSMTPConfiguration);
            this.Name = "ConfigServerSMTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigServerSMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSaveSMTPConfiguration;
        private TextBox textBoxSMTPAddressIP;
        private Label labelSMTPAddressIP;
        private TextBox textBoxSMTPPort;
        private Label labelSMTPPort;
        private TextBox textBoxSMTPUserLogin;
        private Label labelSMTPUserLogin;
        private TextBox textBoxSMTPUserMDP;
        private Label labelSMTPUserMDP;
        private Label labelCampagneName;
    }
}