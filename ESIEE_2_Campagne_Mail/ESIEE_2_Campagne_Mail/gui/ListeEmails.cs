using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ESIEE_2_Campagne_Mail
{
    public partial class ListeEmails : Form
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public ListeEmails()
        {
            InitializeComponent();
            this.updateListView();
        }

        /// <summary>
        /// Mise à jour de la vue de la liste de contacts.
        /// </summary>
        private void updateListView()
        {
            //Création d'une liste des items pour la ListView.
            List<ListViewItem> itemListViewItem = new List<ListViewItem>();

            //Vérification de la liste des mails
            if (Home.Instance.Manager.GetCampagne() != null)
            {
                //Récupère de la liste des groupes de mails de la campagne
                List<Contact> listeContacts = Home.Instance.Manager.GetCampagne().recupererListeContacts();
                
                //Récupère de la liste des groupes de mails de la campagne
                List<Contact> listeContactsActifs = Home.Instance.Manager.GetCampagne().recupererListeContactsActifs();

                if (listeContacts.Count > 0)
                {
                    //Ajout des mails dans la liste
                    foreach (Contact contact in listeContacts)
                    {
                        contact.Etat = listeContactsActifs.Count > 0 ? listeContactsActifs.Contains(contact) ? ContactEtat.ACTIF : ContactEtat.INACTIF : ContactEtat.INACTIF;
                        itemListViewItem.Add(
                            addInListViewItem(contact)
                            /*
                            addInListViewItem(new Contact()
                            {
                                Id = 0,
                                Nom = "",
                                Prenom = "",
                                Email = mail,
                                Etat = listeMailActif.Count > 0 ? listeMailActif.Contains(mail) ? ContactEtat.ACTIF : ContactEtat.INACTIF : ContactEtat.INACTIF
                            })
                            */
                        );
                    }
                }
            }

            if (itemListViewItem.Count > 0)
            {
                int idItem = (this.listViewContacts.Items.Count > 0) ? this.listViewContacts.Items.Count : 0;

                //Récupération de la liste des items pour les ajoutés dans la ListView.
                foreach (ListViewItem item in itemListViewItem)
                {
                    //-
                    item.Text = idItem.ToString();
                    
                    //Ajout de l'item dans la ListView si il n'existe pas.
                    if (!this.listViewContacts.Items.ContainsKey(item.Text))
                    {
                        this.listViewContacts.Items.Add(item);
                        idItem++;
                    }
                }
            }

            Debug.WriteLine("[Campagne] - Liste View Update");
        }

        /// <summary>
        /// Ajout d'un élément à vue de la liste de contacts.
        /// </summary>
        private ListViewItem addInListViewItem(Contact contact)
        {
            ListViewItem item = new ListViewItem(contact.Id.ToString());
            item.SubItems.Add(contact.Nom.ToString());
            item.SubItems.Add(contact.Prenom.ToString());
            item.SubItems.Add(contact.Email.ToString());
            item.SubItems.Add(contact.Etat.ToString());
            return item;
        }

        private void listViewMails_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Bouton d'action d'importation.
        /// </summary>
        private void buttonActionImporter(object sender, EventArgs e)
        {
            List<GroupeContact> groupeMailList = new List<GroupeContact>();
            groupeMailList.Add(UtilsFiles.ImportWithOpenFileDialogEmailsTXT());
            Home.Instance.Manager.GetCampagne().ListGroupeContact.Clear();
            Home.Instance.Manager.GetCampagne().ListGroupeContact.AddRange(groupeMailList);
            //-
            updateListView();
            //-
            if (groupeMailList.Count > 0)
            {
                Home.Instance.Manager.statutCampagneListeEmails = true;
            }
        }

        /// <summary>
        /// Bouton d'action d'exportation.
        /// </summary>
        private void buttonActionExporter(object sender, EventArgs e)
        {

            // txt header
            String txtHeader = "Id,Nom,Prenom,Email,Etat";
            //get download path
            String filePath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();

            //get today date
            DateTime now = DateTime.Now;

            // get the download path with the file name;
            string downloadFilePath = Path.Combine(filePath, "email_list_" + now.ToString("yyyy_MM_dd_HH'_'mm'_'ss") + ".txt");

            // get object instance / email list
            List<GroupeContact> groupeMailList = Home.Instance.Manager.GetCampagne().ListGroupeContact;

            // This text is added only once to the file.
            if (!File.Exists(downloadFilePath))
            {
                // Create a file to write to.
                File.WriteAllText(downloadFilePath, txtHeader + Environment.NewLine, Encoding.UTF8);
            }

            foreach (GroupeContact mailList in groupeMailList)
            {
                foreach (Contact contact in mailList.ContactList)
                {
                    File.AppendAllText(downloadFilePath, "nop,nop,nop," + contact.Email + ",nop" + Environment.NewLine, Encoding.UTF8);
                }
            }

            MessageBox.Show("Export done");

        }

        /// <summary>
        /// Bouton d'action de vérification des doublons.
        /// </summary>
        private void buttonDedoublonnage_Click(object sender, EventArgs e)
        {
            Home.Instance.Manager.DedoublonnageListeContacts();
            this.updateListView();
        }

        /// <summary>
        /// Bouton d'action de vérification des doublons.
        /// </summary>
        private void buttonMinifyMail_Click(object sender, EventArgs e)
        {
            Home.Instance.Manager.CleanMajusculeListeContacts();
            this.updateListView();
        }

        private void buttonListeView_Click(object sender, EventArgs e)
        {
            Home.Instance.Manager.ClearListeContacts();
            this.listViewContacts.Clear();
            //-
            string message = "Le nettoyage de la vue de la liste des contacts a bien été effectué.";
            MessageBox.Show(message, "Liste des emails - Nettoyage de la vue de la liste des contacts terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Debug.WriteLine("[Campagne] - Nettoyage de la vue de la liste des contacts");
        }
    }
}
