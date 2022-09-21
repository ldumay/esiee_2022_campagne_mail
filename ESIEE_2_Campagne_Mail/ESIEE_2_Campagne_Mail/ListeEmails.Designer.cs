namespace ESIEE_2_Campagne_Mail
{
    partial class ListeEmails
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
            this.listViewMails = new System.Windows.Forms.ListView();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonDedoublennage = new System.Windows.Forms.Button();
            this.buttonVerificationMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMails
            // 
            this.listViewMails.Location = new System.Drawing.Point(12, 58);
            this.listViewMails.Name = "listViewMails";
            this.listViewMails.Size = new System.Drawing.Size(776, 380);
            this.listViewMails.TabIndex = 0;
            this.listViewMails.UseCompatibleStateImageBehavior = false;
            // 
            // buttonImporter
            // 
            this.buttonImporter.Location = new System.Drawing.Point(12, 12);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(137, 40);
            this.buttonImporter.TabIndex = 1;
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Location = new System.Drawing.Point(155, 12);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(137, 40);
            this.buttonExporter.TabIndex = 2;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.UseVisualStyleBackColor = true;
            // 
            // buttonDedoublennage
            // 
            this.buttonDedoublennage.Location = new System.Drawing.Point(298, 12);
            this.buttonDedoublennage.Name = "buttonDedoublennage";
            this.buttonDedoublennage.Size = new System.Drawing.Size(137, 40);
            this.buttonDedoublennage.TabIndex = 3;
            this.buttonDedoublennage.Text = "Dédoublennage";
            this.buttonDedoublennage.UseVisualStyleBackColor = true;
            // 
            // buttonVerificationMail
            // 
            this.buttonVerificationMail.Location = new System.Drawing.Point(441, 12);
            this.buttonVerificationMail.Name = "buttonVerificationMail";
            this.buttonVerificationMail.Size = new System.Drawing.Size(137, 40);
            this.buttonVerificationMail.TabIndex = 4;
            this.buttonVerificationMail.Text = "Vérification Mail";
            this.buttonVerificationMail.UseVisualStyleBackColor = true;
            // 
            // ListeEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerificationMail);
            this.Controls.Add(this.buttonDedoublennage);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonImporter);
            this.Controls.Add(this.listViewMails);
            this.Name = "ListeEmails";
            this.Text = "ListeEmails";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewMails;
        private Button buttonImporter;
        private Button buttonExporter;
        private Button buttonDedoublennage;
        private Button buttonVerificationMail;
    }
}