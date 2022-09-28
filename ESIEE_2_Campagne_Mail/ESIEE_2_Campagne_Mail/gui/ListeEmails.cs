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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            List<GroupeMail> groupeMailList = Home.Instance.campagne.GroupeMailList;

                Console.WriteLine(groupeMailList);


        }

    }
}
