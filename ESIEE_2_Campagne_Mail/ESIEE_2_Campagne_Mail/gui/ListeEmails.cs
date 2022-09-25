using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESIEE_2_Campagne_Mail
{
    public partial class ListeEmails : Form
    {
        public ListeEmails()
        {
            InitializeComponent();
            //-
            updateListView();
        }

        private void updateListView()
        {
            //Création d'une liste des items pour la ListView.
            List<ListViewItem> itemListIew = new List<ListViewItem>();

            /**
            //Vérification de la liste des mails
            if (Home.Instance.campagne.GroupeMail != null)
            {
                foreach (List<string> mailsList in Home.Instance.campagne.GroupeMail.MailsList)
                {
                    //Ajout des mails dans la liste
                    foreach (string mail in groupeMail.MailsList)
                    {
                        ListViewItem item = new ListViewItem(mail);
                        item.SubItems.Add(groupeMail.MailsActifsList.Contains(mail) ? "Actif" : "Inactif");
                        listView1.Items.Add(item);
                    }
                }

                foreach (List<string> mailsActifsList in Home.Instance.campagne.GroupeMail.MailsActifsList)
                {
                    //Ajout des mails actifs dans la liste
                    foreach (string mail in groupeMail.MailsActifsList)
                    {
                        ListViewItem item = new ListViewItem(mail);
                        item.SubItems.Add(groupeMail.MailsActifsList.Contains(mail) ? "Actif" : "Inactif");
                        listView1.Items.Add(item);
                    }
                }
            }
            */

            

            //Lecture de la liste de contacts pour ajouter les contact à les liste des items pour la ListeView.
            foreach (Contact contact in contacts)
            {
                ListViewItem item = new ListViewItem(contact.Id.ToString());
                item.SubItems.Add(contact.Nom);
                item.SubItems.Add(contact.Prenom);
                item.SubItems.Add(contact.Email);
                item.SubItems.Add(contact.Etat.ToString());
                //-
                itemListIew.Add(item);
            }

            //Récupération de la liste des items pour les ajoutés dans la ListView.
            foreach (ListViewItem item in itemListIew)
            {
                this.listViewMails.Items.Add(item);
            }
        }

        private Contact createContactTest()
        {
            /*
            Contact newContact1 = new Contact(0, "Jean", "Pierre", "jean.pierre@mail.com");
            ==> Bug, le constructeur full ne charge pas des donnée -_-
            */
            Contact newContact2 = new Contact();
            newContact2.Id = 0;
            newContact2.Nom = "Jean";
            newContact2.Prenom = "Pierre";
            newContact2.Email = "jean.pierre@mail.com";
            newContact2.Etat = ContactEtat.ACTIF;
            return newContact2;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<GroupeMail> groupeMailList = new List<GroupeMail>();
            groupeMailList.Add(UtilsFilesEmails.ImportWithOpenFileDialogEmailsTXT());
            Home.Instance.campagne.GroupeMail = groupeMailList;
            updateListView();
        }

        private void listViewMails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
