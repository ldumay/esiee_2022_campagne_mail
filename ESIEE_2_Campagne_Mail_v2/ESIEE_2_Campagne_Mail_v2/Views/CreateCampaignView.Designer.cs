namespace ESIEE_2_Campagne_Mail
{
    partial class CreateCampaignView
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
            this.textBoxNewCampaignContent = new System.Windows.Forms.TextBox();
            this.labelNewCampaignContent = new System.Windows.Forms.Label();
            this.labelNewCampaignTop = new System.Windows.Forms.Label();
            this.buttonNewCampaign = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.panelNewCampaignTop = new System.Windows.Forms.Panel();
            this.panelNewCampaignContent = new System.Windows.Forms.Panel();
            this.panelNewCampaignBottom = new System.Windows.Forms.Panel();
            this.panelNewCampaignTop.SuspendLayout();
            this.panelNewCampaignContent.SuspendLayout();
            this.panelNewCampaignBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNewCampaignContent
            // 
            this.textBoxNewCampaignContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewCampaignContent.Location = new System.Drawing.Point(20, 70);
            this.textBoxNewCampaignContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNewCampaignContent.Name = "textBoxNewCampaignContent";
            this.textBoxNewCampaignContent.Size = new System.Drawing.Size(447, 34);
            this.textBoxNewCampaignContent.TabIndex = 7;
            // 
            // labelNewCampaignContent
            // 
            this.labelNewCampaignContent.AutoSize = true;
            this.labelNewCampaignContent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewCampaignContent.ForeColor = System.Drawing.Color.White;
            this.labelNewCampaignContent.Location = new System.Drawing.Point(20, 30);
            this.labelNewCampaignContent.Name = "labelNewCampaignContent";
            this.labelNewCampaignContent.Size = new System.Drawing.Size(312, 38);
            this.labelNewCampaignContent.TabIndex = 6;
            this.labelNewCampaignContent.Text = "Nom de la campagne :";
            // 
            // labelNewCampaignTop
            // 
            this.labelNewCampaignTop.AutoSize = true;
            this.labelNewCampaignTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewCampaignTop.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewCampaignTop.ForeColor = System.Drawing.Color.White;
            this.labelNewCampaignTop.Location = new System.Drawing.Point(0, 0);
            this.labelNewCampaignTop.Name = "labelNewCampaignTop";
            this.labelNewCampaignTop.Size = new System.Drawing.Size(583, 54);
            this.labelNewCampaignTop.TabIndex = 8;
            this.labelNewCampaignTop.Text = "Créer une nouvelle campagne";
            // 
            // buttonNewCampaign
            // 
            this.buttonNewCampaign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(108)))), ((int)(((byte)(130)))));
            this.buttonNewCampaign.FlatAppearance.BorderSize = 0;
            this.buttonNewCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewCampaign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewCampaign.ForeColor = System.Drawing.Color.White;
            this.buttonNewCampaign.Location = new System.Drawing.Point(20, 20);
            this.buttonNewCampaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewCampaign.Name = "buttonNewCampaign";
            this.buttonNewCampaign.Size = new System.Drawing.Size(269, 68);
            this.buttonNewCampaign.TabIndex = 9;
            this.buttonNewCampaign.Text = "Valider le nom";
            this.buttonNewCampaign.UseVisualStyleBackColor = false;
            this.buttonNewCampaign.Click += new System.EventHandler(this.buttonCreateCampagneClick);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(20, 121);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(160, 28);
            this.labelWarning.TabIndex = 10;
            this.labelWarning.Text = "[temp-warning]";
            // 
            // panelNewCampaignTop
            // 
            this.panelNewCampaignTop.Controls.Add(this.labelNewCampaignTop);
            this.panelNewCampaignTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewCampaignTop.Location = new System.Drawing.Point(0, 0);
            this.panelNewCampaignTop.Name = "panelNewCampaignTop";
            this.panelNewCampaignTop.Size = new System.Drawing.Size(764, 64);
            this.panelNewCampaignTop.TabIndex = 11;
            // 
            // panelNewCampaignContent
            // 
            this.panelNewCampaignContent.Controls.Add(this.labelNewCampaignContent);
            this.panelNewCampaignContent.Controls.Add(this.textBoxNewCampaignContent);
            this.panelNewCampaignContent.Controls.Add(this.labelWarning);
            this.panelNewCampaignContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewCampaignContent.Location = new System.Drawing.Point(0, 64);
            this.panelNewCampaignContent.Name = "panelNewCampaignContent";
            this.panelNewCampaignContent.Size = new System.Drawing.Size(764, 187);
            this.panelNewCampaignContent.TabIndex = 12;
            // 
            // panelNewCampaignBottom
            // 
            this.panelNewCampaignBottom.Controls.Add(this.buttonNewCampaign);
            this.panelNewCampaignBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCampaignBottom.Location = new System.Drawing.Point(0, 251);
            this.panelNewCampaignBottom.Name = "panelNewCampaignBottom";
            this.panelNewCampaignBottom.Size = new System.Drawing.Size(764, 115);
            this.panelNewCampaignBottom.TabIndex = 13;
            // 
            // CreateCampaignView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(764, 366);
            this.Controls.Add(this.panelNewCampaignBottom);
            this.Controls.Add(this.panelNewCampaignContent);
            this.Controls.Add(this.panelNewCampaignTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateCampaignView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle campagne";
            this.panelNewCampaignTop.ResumeLayout(false);
            this.panelNewCampaignTop.PerformLayout();
            this.panelNewCampaignContent.ResumeLayout(false);
            this.panelNewCampaignContent.PerformLayout();
            this.panelNewCampaignBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxNewCampaignContent;
        private Label labelNewCampaignContent;
        private Label labelNewCampaignTop;
        private Label labelWarning;
        private Button buttonNewCampaign;
        private Panel panelNewCampaignTop;
        private Panel panelNewCampaignContent;
        private Panel panelNewCampaignBottom;
    }
}