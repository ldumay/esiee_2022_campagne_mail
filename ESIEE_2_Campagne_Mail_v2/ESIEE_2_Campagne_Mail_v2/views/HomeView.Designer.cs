namespace ESIEE_2_Campagne_Mail_v2
{
    partial class MailCamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailCamp));
            this.panelHome = new System.Windows.Forms.Panel();
            this.TitleMailCamp = new System.Windows.Forms.Label();
            this.labelNomDeLaCampagne = new System.Windows.Forms.Label();
            this.textBoxNomDeLaCampagne = new System.Windows.Forms.TextBox();
            this.buttonValiderDeLaCampagne = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.buttonValiderDeLaCampagne);
            this.panelHome.Controls.Add(this.textBoxNomDeLaCampagne);
            this.panelHome.Controls.Add(this.labelNomDeLaCampagne);
            this.panelHome.Controls.Add(this.TitleMailCamp);
            this.panelHome.Location = new System.Drawing.Point(12, 12);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(548, 276);
            this.panelHome.TabIndex = 0;
            // 
            // TitleMailCamp
            // 
            this.TitleMailCamp.AutoSize = true;
            this.TitleMailCamp.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleMailCamp.Location = new System.Drawing.Point(146, 19);
            this.TitleMailCamp.Name = "TitleMailCamp";
            this.TitleMailCamp.Size = new System.Drawing.Size(246, 55);
            this.TitleMailCamp.TabIndex = 0;
            this.TitleMailCamp.Text = "MailCamp";
            // 
            // labelNomDeLaCampagne
            // 
            this.labelNomDeLaCampagne.AutoSize = true;
            this.labelNomDeLaCampagne.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomDeLaCampagne.Location = new System.Drawing.Point(31, 127);
            this.labelNomDeLaCampagne.Name = "labelNomDeLaCampagne";
            this.labelNomDeLaCampagne.Size = new System.Drawing.Size(225, 26);
            this.labelNomDeLaCampagne.TabIndex = 1;
            this.labelNomDeLaCampagne.Text = "Nom de la campagne";
            this.labelNomDeLaCampagne.Click += new System.EventHandler(this.buttonNomDeLaCampagneClick);
            // 
            // textBoxNomDeLaCampagne
            // 
            this.textBoxNomDeLaCampagne.Location = new System.Drawing.Point(262, 126);
            this.textBoxNomDeLaCampagne.Name = "textBoxNomDeLaCampagne";
            this.textBoxNomDeLaCampagne.Size = new System.Drawing.Size(225, 27);
            this.textBoxNomDeLaCampagne.TabIndex = 2;
            // 
            // buttonValiderDeLaCampagne
            // 
            this.buttonValiderDeLaCampagne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonValiderDeLaCampagne.Location = new System.Drawing.Point(136, 186);
            this.buttonValiderDeLaCampagne.Name = "buttonValiderDeLaCampagne";
            this.buttonValiderDeLaCampagne.Size = new System.Drawing.Size(256, 60);
            this.buttonValiderDeLaCampagne.TabIndex = 3;
            this.buttonValiderDeLaCampagne.Text = "Valider le nom de la campagne";
            this.buttonValiderDeLaCampagne.UseVisualStyleBackColor = true;
            // 
            // MailCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelHome);
            this.Name = "MailCamp";
            this.Text = "MailCamp";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHome;
        private Label TitleMailCamp;
        private Label labelNomDeLaCampagne;
        private Button buttonValiderDeLaCampagne;
        private TextBox textBoxNomDeLaCampagne;
    }
}