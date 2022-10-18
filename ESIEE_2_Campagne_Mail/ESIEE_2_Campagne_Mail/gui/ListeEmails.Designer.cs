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
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnNom = new System.Windows.Forms.ColumnHeader();
            this.columnPrenom = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.columnEtat = new System.Windows.Forms.ColumnHeader();
            this.buttonImporter = new System.Windows.Forms.Button();
            this.buttonExporter = new System.Windows.Forms.Button();
            this.buttonDedoublonnage = new System.Windows.Forms.Button();
            this.buttonVerificationMail = new System.Windows.Forms.Button();
            this.buttonMinifyMail = new System.Windows.Forms.Button();
            this.buttonListeView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewContacts
            // 
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNom,
            this.columnPrenom,
            this.columnEmail,
            this.columnEtat});
            this.listViewContacts.FullRowSelect = true;
            this.listViewContacts.Location = new System.Drawing.Point(14, 77);
            this.listViewContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(906, 433);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            this.listViewContacts.SelectedIndexChanged += new System.EventHandler(this.listViewMails_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnNom
            // 
            this.columnNom.Text = "Nom";
            this.columnNom.Width = 200;
            // 
            // columnPrenom
            // 
            this.columnPrenom.Text = "Prénom";
            this.columnPrenom.Width = 200;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 320;
            // 
            // columnEtat
            // 
            this.columnEtat.Text = "Etat";
            this.columnEtat.Width = 100;
            // 
            // buttonImporter
            // 
            this.buttonImporter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImporter.Location = new System.Drawing.Point(14, 16);
            this.buttonImporter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonImporter.Name = "buttonImporter";
            this.buttonImporter.Size = new System.Drawing.Size(142, 53);
            this.buttonImporter.TabIndex = 1;
            this.buttonImporter.Text = "Importer";
            this.buttonImporter.UseVisualStyleBackColor = true;
            this.buttonImporter.Click += new System.EventHandler(this.buttonActionImporter);
            // 
            // buttonExporter
            // 
            this.buttonExporter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExporter.Location = new System.Drawing.Point(162, 16);
            this.buttonExporter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExporter.Name = "buttonExporter";
            this.buttonExporter.Size = new System.Drawing.Size(142, 53);
            this.buttonExporter.TabIndex = 2;
            this.buttonExporter.Text = "Exporter";
            this.buttonExporter.UseVisualStyleBackColor = true;
            this.buttonExporter.Click += new System.EventHandler(this.buttonActionExporter);
            // 
            // buttonDedoublonnage
            // 
            this.buttonDedoublonnage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDedoublonnage.Location = new System.Drawing.Point(310, 16);
            this.buttonDedoublonnage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDedoublonnage.Name = "buttonDedoublonnage";
            this.buttonDedoublonnage.Size = new System.Drawing.Size(142, 53);
            this.buttonDedoublonnage.TabIndex = 3;
            this.buttonDedoublonnage.Text = "Dédoublonnage";
            this.buttonDedoublonnage.UseVisualStyleBackColor = true;
            this.buttonDedoublonnage.Click += new System.EventHandler(this.buttonDedoublonnage_Click);
            // 
            // buttonVerificationMail
            // 
            this.buttonVerificationMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerificationMail.Location = new System.Drawing.Point(458, 16);
            this.buttonVerificationMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVerificationMail.Name = "buttonVerificationMail";
            this.buttonVerificationMail.Size = new System.Drawing.Size(142, 53);
            this.buttonVerificationMail.TabIndex = 4;
            this.buttonVerificationMail.Text = "Vérification Mail";
            this.buttonVerificationMail.UseVisualStyleBackColor = true;
            // 
            // buttonMinifyMail
            // 
            this.buttonMinifyMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinifyMail.Location = new System.Drawing.Point(606, 16);
            this.buttonMinifyMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinifyMail.Name = "buttonMinifyMail";
            this.buttonMinifyMail.Size = new System.Drawing.Size(157, 53);
            this.buttonMinifyMail.TabIndex = 5;
            this.buttonMinifyMail.Text = "Minify Mail";
            this.buttonMinifyMail.UseVisualStyleBackColor = true;
            this.buttonMinifyMail.Click += new System.EventHandler(this.buttonMinifyMail_Click);
            // 
            // buttonListeView
            // 
            this.buttonListeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListeView.Location = new System.Drawing.Point(769, 16);
            this.buttonListeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonListeView.Name = "buttonListeView";
            this.buttonListeView.Size = new System.Drawing.Size(151, 53);
            this.buttonListeView.TabIndex = 6;
            this.buttonListeView.Text = "Vider la liste";
            this.buttonListeView.UseVisualStyleBackColor = true;
            this.buttonListeView.Click += new System.EventHandler(this.buttonClearListeView_Click);
            // 
            // ListeEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.buttonListeView);
            this.Controls.Add(this.buttonMinifyMail);
            this.Controls.Add(this.buttonVerificationMail);
            this.Controls.Add(this.buttonDedoublonnage);
            this.Controls.Add(this.buttonExporter);
            this.Controls.Add(this.buttonImporter);
            this.Controls.Add(this.listViewContacts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListeEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListeEmails";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewContacts;
        private Button buttonImporter;
        private Button buttonExporter;
        private Button buttonDedoublonnage;
        private Button buttonVerificationMail;
        private ColumnHeader columnID;
        private ColumnHeader columnNom;
        private ColumnHeader columnPrenom;
        private ColumnHeader columnEmail;
        private ColumnHeader columnEtat;
        private Button buttonMinifyMail;
        private Button buttonListeView;
    }
}