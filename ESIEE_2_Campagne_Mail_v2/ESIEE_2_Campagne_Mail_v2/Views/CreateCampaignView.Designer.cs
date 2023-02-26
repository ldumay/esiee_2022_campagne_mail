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
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBoxNewCampaignContent.Location = new System.Drawing.Point(20, 70);
            this.textBoxNewCampaignContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNewCampaignContent.Name = "textBoxNewCampaignContent";
            this.textBoxNewCampaignContent.Size = new System.Drawing.Size(447, 27);
            this.textBoxNewCampaignContent.TabIndex = 7;
            // 
            // labelNewCampaignContent
            // 
            this.labelNewCampaignContent.AutoSize = true;
            this.labelNewCampaignContent.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewCampaignContent.Location = new System.Drawing.Point(20, 30);
            this.labelNewCampaignContent.Name = "labelNewCampaignContent";
            this.labelNewCampaignContent.Size = new System.Drawing.Size(277, 32);
            this.labelNewCampaignContent.TabIndex = 6;
            this.labelNewCampaignContent.Text = "Nom de la campagne :";
            // 
            // labelNewCampaignTop
            // 
            this.labelNewCampaignTop.AutoSize = true;
            this.labelNewCampaignTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewCampaignTop.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewCampaignTop.Location = new System.Drawing.Point(0, 0);
            this.labelNewCampaignTop.Name = "labelNewCampaignTop";
            this.labelNewCampaignTop.Size = new System.Drawing.Size(583, 54);
            this.labelNewCampaignTop.TabIndex = 8;
            this.labelNewCampaignTop.Text = "Créer une nouvelle campagne";
            // 
            // buttonNewCampaign
            // 
            this.buttonNewCampaign.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewCampaign.Location = new System.Drawing.Point(20, 20);
            this.buttonNewCampaign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewCampaign.Name = "buttonNewCampaign";
            this.buttonNewCampaign.Size = new System.Drawing.Size(269, 68);
            this.buttonNewCampaign.TabIndex = 9;
            this.buttonNewCampaign.Text = "Valider le nom";
            this.buttonNewCampaign.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(234, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // panelNewCampaignTop
            // 
            this.panelNewCampaignTop.Controls.Add(this.labelNewCampaignTop);
            this.panelNewCampaignTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewCampaignTop.Location = new System.Drawing.Point(0, 0);
            this.panelNewCampaignTop.Name = "panelNewCampaignTop";
            this.panelNewCampaignTop.Size = new System.Drawing.Size(652, 64);
            this.panelNewCampaignTop.TabIndex = 11;
            // 
            // panelNewCampaignContent
            // 
            this.panelNewCampaignContent.Controls.Add(this.labelNewCampaignContent);
            this.panelNewCampaignContent.Controls.Add(this.textBoxNewCampaignContent);
            this.panelNewCampaignContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewCampaignContent.Location = new System.Drawing.Point(0, 64);
            this.panelNewCampaignContent.Name = "panelNewCampaignContent";
            this.panelNewCampaignContent.Size = new System.Drawing.Size(652, 125);
            this.panelNewCampaignContent.TabIndex = 12;
            // 
            // panelNewCampaignBottom
            // 
            this.panelNewCampaignBottom.Controls.Add(this.buttonNewCampaign);
            this.panelNewCampaignBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCampaignBottom.Location = new System.Drawing.Point(0, 189);
            this.panelNewCampaignBottom.Name = "panelNewCampaignBottom";
            this.panelNewCampaignBottom.Size = new System.Drawing.Size(652, 119);
            this.panelNewCampaignBottom.TabIndex = 13;
            // 
            // CreateCampaignView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 308);
            this.Controls.Add(this.panelNewCampaignBottom);
            this.Controls.Add(this.panelNewCampaignContent);
            this.Controls.Add(this.panelNewCampaignTop);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateCampaignView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.panelNewCampaignTop.ResumeLayout(false);
            this.panelNewCampaignTop.PerformLayout();
            this.panelNewCampaignContent.ResumeLayout(false);
            this.panelNewCampaignContent.PerformLayout();
            this.panelNewCampaignBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNewCampaignContent;
        private Label labelNewCampaignContent;
        private Label labelNewCampaignTop;
        private Label label2;
        private Button buttonNewCampaign;
        private Panel panelNewCampaignTop;
        private Panel panelNewCampaignContent;
        private Panel panelNewCampaignBottom;
    }
}