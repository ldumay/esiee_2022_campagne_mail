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
        private List<Contact> listeContactsDeLaCampagne = new List<Contact>();
        private List<ListViewItem> listeItemsDansLaListeView = new List<ListViewItem>();

        /// <summary>
        /// Constructeur
        /// </summary>
        public ListeEmails()
        {
            InitializeComponent();
            this.updateListView();
        }

        /// <summary>
        /// Mise à jour de la liste des contacts.
        /// </summary>
        private void updateListContacts() {
            Debug.WriteLine("[Campagne] - Mise à jour de la liste des contacts - Début");
            
            if (Home.Instance.Manager.GetCampagne().recupererListeContacts().Count > 0)
            {
                int compteurIDs = (listeContactsDeLaCampagne.Count > 0) ? listeContactsDeLaCampagne.Count + 1 : 0;
                foreach (Contact contact in Home.Instance.Manager.GetCampagne().recupererListeContacts())
                {
                    //Vérification de la présence du contact dans la liste des contacts actifs
                    if (Home.Instance.Manager.GetCampagne().recupererListeContactsActifs().Contains(contact))
                    {
                        contact.Etat = ContactEtat.ACTIF;
                    }
                    else if (!Home.Instance.Manager.GetCampagne().recupererListeContactsActifs().Contains(contact)
                        && contact.Etat == ContactEtat.ACTIF)
                    {
                        contact.Etat = ContactEtat.INACTIF;
                    }
                    //Vérification de l'existance du contact dans la liste des contacts de la campagne
                    if (!listeContactsDeLaCampagne.Contains(contact))
                    {
                        contact.Id = compteurIDs;
                        listeContactsDeLaCampagne.Add(contact);
                    }
                    //-
                    compteurIDs++;
                }
            }

            Debug.WriteLine("[Campagne] - Mise à jour de la liste des contacts - Début");
        }

        /// <summary>
        /// Mise à jour de la vue de la liste des contacts.
        /// </summary>
        private void updateListView()
        {
            Debug.WriteLine("[Campagne] - Liste View Update - Début");
            
            //Vidage de la vue de la liste des contacts existants
            this.listViewContacts.Items.Clear();
            //Vidage de la liste des items de la vue de la liste des contacts
            this.listeItemsDansLaListeView.Clear();

            //Mise à jour de la liste des contacts
            this.updateListContacts();

            //Ajout de la nouvelle liste de contacts dans la liste des items de la vue de la liste des contacts
            foreach (Contact contact in listeContactsDeLaCampagne)
            {
                List<Contact> listContactAdded = new List<Contact>();
                if (!listContactAdded.Contains(contact))
                {
                    listContactAdded.Add(contact);
                    this.listeItemsDansLaListeView.Add(addInListViewItem(contact));
                }
            }

            //Ajouter la liste des items dans la vue de la liste des contacts
            this.listViewContacts.Items.AddRange(listeItemsDansLaListeView.ToArray());

            Debug.WriteLine("[Campagne] - Liste View Update - Fin");
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

        /// <summary>
        /// Bouton d'action de nettoyage de la liste des emails.
        /// </summary>
        private void buttonClearListeView_Click(object sender, EventArgs e)
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
