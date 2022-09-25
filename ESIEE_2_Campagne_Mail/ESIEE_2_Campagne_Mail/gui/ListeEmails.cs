using ESIEE_2_Campagne_Mail.models;
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

            //Préparation de la liste de contacts.
            contacts = new List<Contact>();

            //Création d'un contact de test pour tester la liste de contact.
            Contact newContact = createContactTest();
            contacts.Add(newContact);

            //Création d'une liste des items pour la ListView.
            List<ListViewItem> itemListIew = new List<ListViewItem>();

            //Lecture de la liste de contacts pour ajouter les contact à les liste des items pour la ListeView.
            foreach (Contact contact in contacts)
            {
                ListViewItem item = new ListViewItem(contact.Id.ToString());
                item.SubItems.Add(contact.Nom);
                item.SubItems.Add(contact.Prenom);
                item.SubItems.Add(contact.Email);
                //-
                itemListIew.Add(item);
            }

            //Récupération de la liste des items pour les ajoutés dans la ListView.
            foreach (ListViewItem item in itemListIew) {
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
            return newContact2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
