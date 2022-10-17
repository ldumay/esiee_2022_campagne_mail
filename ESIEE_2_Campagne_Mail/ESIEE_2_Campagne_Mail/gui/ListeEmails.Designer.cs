using ESIEE_2_Campagne_Mail.models;

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
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnNom = new System.Windows.Forms.ColumnHeader();
            this.columnPrenom = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnEtat = new System.Windows.Forms.ColumnHeader();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonDedoublonnage = new System.Windows.Forms.Button();
            this.buttonVerificationMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMails
            // 
            this.listViewMails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNom,
            this.columnPrenom,
            this.columnEmail,
            this.columnEtat});
            this.listViewMails.FullRowSelect = true;
            this.listViewMails.Location = new System.Drawing.Point(14, 77);
            this.listViewMails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMails.Name = "listViewMails";
            this.listViewMails.Size = new System.Drawing.Size(906, 433);
            this.listViewMails.TabIndex = 0;
            this.listViewMails.UseCompatibleStateImageBehavior = false;
            this.listViewMails.View = System.Windows.Forms.View.Details;
            this.listViewMails.SelectedIndexChanged += new System.EventHandler(this.listViewMails_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 50;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 160;
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            this.columnPrenom.Width = 160;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 300;
            // 
            // columnEtat
            // 
            this.columnEtat.Text = "Etat";
            this.columnEtat.Width = 80;
            // 
            // buttonImporter
            // 
            this.buttonImporter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImporter.Location = new System.Drawing.Point(14, 16);
            this.buttonImporter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(157, 53);
            this.buttonImporter.TabIndex = 1;
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonActionImporter);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExporter.Location = new System.Drawing.Point(177, 16);
            this.buttonExporter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(157, 53);
            this.buttonExporter.TabIndex = 2;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonActionExporter);
            // 
            // buttonDedoublonnage
            // 
            this.buttonDedoublonnage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDedoublonnage.Location = new System.Drawing.Point(341, 16);
            this.buttonDedoublonnage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDedoublonnage.Name = "buttonDedoublonnage";
            this.buttonDedoublonnage.Size = new System.Drawing.Size(157, 53);
            this.buttonDedoublonnage.TabIndex = 3;
            this.buttonDedoublonnage.Text = "Dédoublonnage";
            this.buttonDedoublonnage.UseVisualStyleBackColor = true;
            // 
            // buttonVerificationMail
            // 
            this.buttonVerificationMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerificationMail.Location = new System.Drawing.Point(504, 16);
            this.buttonVerificationMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVerificationMail.Name = "buttonVerificationMail";
            this.buttonVerificationMail.Size = new System.Drawing.Size(157, 53);
            this.buttonVerificationMail.TabIndex = 4;
            this.buttonVerificationMail.Text = "Vérification Mail";
            this.buttonVerificationMail.UseVisualStyleBackColor = true;
            // 
            // ListeEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.buttonVerificationMail);
            this.Controls.Add(this.buttonDedoublonnage);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonImporter);
            this.Controls.Add(this.listViewMails);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListeEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListeEmails";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewMails;
        private Button buttonImporter;
        private Button buttonExporter;
        private Button buttonDedoublonnage;
        private Button buttonVerificationMail;
        private ColumnHeader columnID;
        private ColumnHeader columnNom;
        private ColumnHeader columnPrenom;
        private ColumnHeader columnEmail;
        private ColumnHeader columnEtat;
    }
}