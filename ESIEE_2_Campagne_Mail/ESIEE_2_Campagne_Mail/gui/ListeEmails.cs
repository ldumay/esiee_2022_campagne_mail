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

		/// <summary>
		/// Récupère la liste des Contacts dans la Campagne et les ajoute dans la ListView
		/// </summary>
		private void updateListView()
		{
			//Récupère de la liste des groupes de mails de la campagne
			List<Contact> listeContact = Home.Instance.Manager.RecupererListContact();

			// Réinitialisation de la ListView
			listViewMails.Items.Clear();
			// Index pour l'id de l'item (sera actuellement toujours 0)
			int nbItem = listViewMails.Items.Count;
			//Ajout des Contact dans la ListView
			foreach (Contact contact in listeContact)
			{
				System.Diagnostics.Debug.WriteLine(contact.Email);
				ListViewItem listViewItem = SetContactInListViewItem(contact);
				// Utilisation Id ou NbItem ?
				listViewItem.Text = nbItem.ToString();
				listViewMails.Items.Add(listViewItem);
				nbItem++;
			}
			Console.WriteLine("[Liste View Update] OK");
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
		/// Fonction appellé lors d'un click sur le bouton Import
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonImport_Click(object sender, EventArgs e)
		{
			Home.Instance.Manager.AddGroupContact(UtilsFiles.ImportWithOpenFileDialogEmailsTXT());
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
			List<GroupeContact> groupeMailList = Home.Instance.Manager.GetGroupContactList();

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

	}
}
