using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ListeEmails()
        {
            InitializeComponent();
        }

        private void updateListView()
        {
            //Création d'une liste des items pour la ListView.
            List<ListViewItem> itemListViewItem = new List<ListViewItem>();

            //Vérification de la liste des mails
            if (Home.Instance.Manager.Campagne.GroupeMailList != null)
            {
                //Récupère de la liste des groupes de mails de la campagne
                List<string> listeMail = Home.Instance.Manager.Campagne.recupererListeMail();

                //Récupère de la liste des groupes de mails de la campagne
                List<string> listeMailActif = Home.Instance.Manager.Campagne.recupererListeMailActifs();

                if (listeMail.Count > 0)
                {
                    //Ajout des mails dans la liste
                    foreach (string mail in listeMail)
                    {
                        itemListViewItem.Add(
                            addInListViewItem(new Contact()
                            {
                                Id = 0,
                                Nom = "",
                                Prenom = "",
                                Email = mail,
                                Etat = listeMailActif.Count > 0 ? listeMailActif.Contains(mail) ? ContactEtat.ACTIF : ContactEtat.INACTIF : ContactEtat.INACTIF
                            })
                        );
                    }
                }
            }

            if (itemListViewItem.Count > 0)
            {
                int idItem = (this.listViewMails.Items.Count > 0) ? this.listViewMails.Items.Count : 0;

                //Récupération de la liste des items pour les ajoutés dans la ListView.
                foreach (ListViewItem item in itemListViewItem)
                {
                    item.Text = idItem.ToString();
                    this.listViewMails.Items.Add(item);
                    idItem++;
                }
            }

            Console.WriteLine("[Liste View Update] OK");
        }

        private ListViewItem addInListViewItem(Contact contact)
        {
            ListViewItem item = new ListViewItem(contact.Id.ToString());
            item.SubItems.Add(contact.Nom);
            item.SubItems.Add(contact.Prenom);
            item.SubItems.Add(contact.Email);
            item.SubItems.Add(contact.Etat.ToString());
            return item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<GroupeMail> groupeMailList = new List<GroupeMail>();
            groupeMailList.Add(UtilsFilesEmails.ImportWithOpenFileDialogEmailsTXT());
            Home.Instance.Manager.Campagne.GroupeMailList.Clear();
            Home.Instance.Manager.Campagne.GroupeMailList.AddRange(groupeMailList);
            //-
            updateListView();
        }

        private void listViewMails_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonExporter_Click(object sender, EventArgs e)
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
            List<GroupeMail> groupeMailList = Home.Instance.Manager.Campagne.GroupeMailList;

            // This text is added only once to the file.
            if (!File.Exists(downloadFilePath))
            {
                // Create a file to write to.
                File.WriteAllText(downloadFilePath, txtHeader + Environment.NewLine, Encoding.UTF8);
            }

            foreach (GroupeMail mailList in groupeMailList)
            {
                foreach (string email in mailList.MailsList)
                {
                    File.AppendAllText(downloadFilePath,"nop,nop,nop,"+ email + ",nop" + Environment.NewLine, Encoding.UTF8);
                }
            }
           
            MessageBox.Show("Export done");

        }

    }
}
