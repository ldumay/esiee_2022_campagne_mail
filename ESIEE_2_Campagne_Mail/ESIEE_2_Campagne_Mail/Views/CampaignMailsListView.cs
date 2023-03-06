using ESIEE_2_Campagne_Mail.Models;
using ESIEE_2_Campagne_Mail.Utils;
using ESIEE_2_Campagne_Mail.Enums;
using Microsoft.Win32;
using System.Diagnostics;
using System.Text;

namespace ESIEE_2_Campagne_Mail
{
	public partial class CampaignMailsListView : Form
    {
        private readonly List<Contact> listeContactView = new List<Contact>();
        private List<ListViewItem> listeItemsDansLaListeView = new List<ListViewItem>();

        /// <summary>
        /// Constructeur
        /// </summary>
        public CampaignMailsListView()
        {
            InitializeComponent();
            updateListView();
        }

        /// <summary>
        /// Mise à jour de la liste des contacts.
        /// </summary>
        private void UpdateListContacts()
        {
            Debug.WriteLine("[Campagne] - Mise à jour de la liste des contacts - Début");
            int compteurIDs = listeContactView.Count + 1;
            List<Contact> listContactCampagne = MailCampView.Instance.Manager.RecupererListContact();
            foreach (Contact contact in listContactCampagne)
            {
				/*
                // Vérification de la présence du contact dans la liste des contacts actifs
                if (listContactCampagne.Contains(contact))
                {
                    if(contact.Etat.Equals(ContactEtat.INACTIF))
						contact.Etat = ContactEtat.ACTIF;
                }
                else if (contact.Etat == ContactEtat.ACTIF)
                {
                    contact.Etat = ContactEtat.INACTIF;
                }
				*/
                // Vérification de l'existance du contact dans la liste des contacts de la campagne
                if (!listeContactView.Contains(contact))
                {
                    contact.Id = compteurIDs;
                    listeContactView.Add(contact);
                    compteurIDs++;
                }
                //-
            }
            Debug.WriteLine("[Campagne] - Mise à jour de la liste des contacts - Début");
        }

        /// <summary>
        /// Récupère la liste des Contacts dans la Campagne et les ajoute dans la ListView
        /// </summary>
        private void oldupdateListView()
        {
            //Récupère de la liste des groupes de mails de la campagne
            List<Contact> listeContact = MailCampView.Instance.Manager.RecupererListContact();

            // Réinitialisation de la ListView
            listViewContacts.Items.Clear();
            // Index pour l'id de l'item (sera actuellement toujours 0)
            int nbItem = listViewContacts.Items.Count;
            //Ajout des Contact dans la ListView
            foreach (Contact contact in listeContact)
            {
                ListViewItem listViewItem = SetContactInListViewItem(contact);
                // Utilisation Id ou NbItem ?
                listViewItem.Text = nbItem.ToString();
                listViewContacts.Items.Add(listViewItem);
                nbItem++;
            }
            Console.WriteLine("[Liste View Update] OK");
        }

        /// <summary>
        /// Mise à jour de la vue de la liste des contacts.
        /// </summary>
        private void updateListView()
        {
            Debug.WriteLine("[Campagne] - Liste View Update - Début");

            // Vidage de la vue de la liste des contacts existants
            listViewContacts.Items.Clear();
            // Vidage de la liste des items de la vue de la liste des contacts
            listeItemsDansLaListeView.Clear();

            // Mise à jour de la liste des contacts
            UpdateListContacts();

            // Ajout de la nouvelle liste de contacts dans la liste des items de la vue de la liste des contacts
            foreach (Contact contact in listeContactView)
            {
                List<Contact> listContactAdded = new List<Contact>();
                if (!listContactAdded.Contains(contact))
                {
                    listContactAdded.Add(contact);
                    listeItemsDansLaListeView.Add(addInListViewItem(contact));
                }
            }

            //Ajouter la liste des items dans la vue de la liste des contacts
            listViewContacts.Items.AddRange(listeItemsDansLaListeView.ToArray());

            /*
            // TODO : refaire cette fonction pour appliquer les changements dans CampagneManager au lieu d'ici
            if (listViewContacts.Items.Count > 0)
            {
                MailCampView.Instance.Manager.statutCampagneListeEmails = true;
            }
            */

            Debug.WriteLine("[Campagne] - Liste View Update - Fin");
        }

        private ListViewItem SetContactInListViewItem(Contact contact)
        {
            ListViewItem item = new ListViewItem();
            // Id utilisé ?
            item.Text = contact.Id.ToString();
            item.SubItems.Add(contact.Nom);
            item.SubItems.Add(contact.Prenom);
            item.SubItems.Add(contact.Email);
            item.SubItems.Add(contact.Etat.ToString());
            return item;
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
        /// Fonction appellé lors d'un click sur le bouton Import
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            //MailCampView.Instance.Manager.AddGroupContact(UtilsFiles.ImportWithOpenFileDialogEmailsTXT());
            updateListView();
        }

        /// <summary>
        /// Bouton d'action d'importation.
        /// </summary>
        private void buttonActionImporter(object sender, EventArgs e)
        {
            List<GroupeContact> groupeMailList = new List<GroupeContact>();
            groupeMailList.Add(UtilsFiles.ImportWithOpenFileDialogEmailsTXT());
            MailCampView.Instance.Manager.ClearGroupContact();
            foreach (GroupeContact contacts in groupeMailList)
            {
                MailCampView.Instance.Manager.AddGroupContact(contacts);
            }
            //-
            updateListView();
        }

        /// <summary>
        /// Bouton d'action d'exportation.
        /// </summary>
        private void buttonActionExporter(object sender, EventArgs e)
        {
			// TODO: move this function into FileUtils with a function export ?
            // txt header
            String txtHeader = "Id,Nom,Prenom,Email,Etat";
            //get download path
            string filePath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", string.Empty).ToString() ?? string.Empty;

            //get today date
            DateTime now = DateTime.Now;

            // get the download path with the file name;
            string downloadFilePath = Path.Combine(filePath, "email_list_" + now.ToString("yyyy_MM_dd_HH'_'mm'_'ss") + ".txt");

            // This text is added only once to the file.
            if (!File.Exists(downloadFilePath))
            {
                // Create a file to write to.
                File.WriteAllText(downloadFilePath, txtHeader + Environment.NewLine, Encoding.UTF8);
            }

            // get object instance / email list
            List<Contact> contactList = MailCampView.Instance.Manager.RecupererListContact();
            foreach (Contact contact in contactList)
            {
                File.AppendAllText(
					downloadFilePath, //
					contact.Id //Id
					+ "," + contact.Nom //Nom
					+ "," + contact.Prenom //Prenom
					+ "," + contact.Email //Email
					+ "," + formatageEtat(contact.Etat)
					+ Environment.NewLine,
					Encoding.UTF8
				);
            }
            MessageBox.Show("L'exportation a bien été effectué.\nLe fichier a été déposé dans le dossier : "+downloadFilePath);
        }

		/// <summary>
		/// Méthode de formatage d'un état reçu en majuscule.
		/// </summary>
		private string formatageEtat(ContactEtat contactEtat) {
			if (contactEtat.Equals(ContactEtat.ACTIF) || contactEtat.Equals("ACTIF"))
				return "Actif";
			else if (contactEtat.Equals(ContactEtat.INACTIF) || contactEtat.Equals("INACTIF"))
				return "Inactif";
			else if (contactEtat.Equals(ContactEtat.DOUBLON) || contactEtat.Equals("DOUBLON"))
				return "Doublon";
			else if (contactEtat.Equals(ContactEtat.ERREUR_MAIL_NON_CONFORME) || contactEtat.Equals("ERREUR_MAIL_NON_CONFORME"))
				return "Erreur_mail_non_conforme";
			else if (contactEtat.Equals(ContactEtat.ERREUR) || contactEtat.Equals("ERREUR"))
				return "Erreur";
			else
				return "Inconnu";
		}

        /// <summary>
        /// Bouton d'action de vérification des doublons.
        /// </summary>
        private void buttonDedoublonnage_Click(object sender, EventArgs e)
        {
            MailCampView.Instance.Manager.DedoublonnageListeContacts();
            this.updateListView();
        }

        /// <summary>
        /// Bouton d'action de vérification des doublons.
        /// </summary>
        private void buttonMinifyMail_Click(object sender, EventArgs e)
        {
            MailCampView.Instance.Manager.CleanMajusculeListeContacts();
            this.updateListView();
        }

        /// <summary>
        /// Bouton d'action de nettoyage de la liste des emails.
        /// </summary>
        private void buttonClearListeView_Click(object sender, EventArgs e)
        {
            MailCampView.Instance.Manager.ClearGroupContact();
            this.listViewContacts.Clear();
            //-
            string message = "Le nettoyage de la vue de la liste des contacts a bien été effectué.";
            MessageBox.Show(message, "Liste des emails - Nettoyage de la vue de la liste des contacts terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Debug.WriteLine("[Campagne] - Nettoyage de la vue de la liste des contacts");
        }
    }
}
