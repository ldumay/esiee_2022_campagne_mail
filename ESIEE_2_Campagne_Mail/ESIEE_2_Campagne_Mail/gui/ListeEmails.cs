using ESIEE_2_Campagne_Mail.model;
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
            contacts = new List<Contact>()
            //-
            Contact newContact = new Contact(0, "Jean", "Pierre", "jean.pierre@mail.com");
            contacts.Add(newContact);
            //-
            foreach (Contact contact in contacts) {
                ListViewItem item = new ListViewItem(contact.Id.ToString());
                item.SubItems.Add(contact.Nom);
                item.SubItems.Add(contact.Prenom);
                item.SubItems.Add(contact.Email);
                //-
                this.listViewMails.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
