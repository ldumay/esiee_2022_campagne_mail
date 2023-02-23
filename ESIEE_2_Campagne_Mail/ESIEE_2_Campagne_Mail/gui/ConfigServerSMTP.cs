using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ESIEE_2_Campagne_Mail.gui
{
	public partial class ConfigServerSMTP : Form
	{
		/// <summary>
		/// Constructeur
		/// </summary>
		public ConfigServerSMTP()
		{
			InitializeComponent();
			this.updateConfigServerSMTPContent();
		}

		/// <summary>
		/// Bouton de sauvegarde de la configuration du serveur SMTP.
		/// </summary>
		private void buttonSaveSMTPConfiguration_Click(object sender, EventArgs e)
		{
			int SMTPport = 0;
			string SMTPAddressIP = textBoxSMTPAddressIP.Text ?? string.Empty;
			try
			{
				SMTPport = int.Parse(textBoxSMTPPort.Text);
			}
			catch (Exception)
			{
				string message = "Le port saisi n'est pas un nombre.";
				Debug.WriteLine(message);
				MessageBox.Show(message, "Configuration du serveur SMTP - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// Home.Instance.Manager.GetSMTPConnectionHandler().SMTPPort = (textBoxSMTPPort.Text != null) ? port : 0;
			string SMTPUserLogin = textBoxSMTPUserLogin.Text ?? string.Empty;
			string SMTPUserMDP = textBoxSMTPUserMDP.Text ?? string.Empty;

			Home.Instance.Manager.ChangerSMTPConnectionParametres(SMTPAddressIP, SMTPport, SMTPUserLogin, SMTPUserMDP);

			if (
				Home.Instance.Manager.GetSMTPConnectionHandler().SMTPAddressIP != null
				&& Home.Instance.Manager.GetSMTPConnectionHandler().SMTPPort != 0
				&& Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserLogin != null
				&& Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserMDP != null
			)
			{
				Home.Instance.Manager.statutSMTPServer = true;
				//-
				string message = "La configuration du serveur SMTP a bien été enregistrée.";
				MessageBox.Show(message, "Configuration du serveur SMTP - Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Debug.WriteLine("[Campagne] Configuration SMTP : " + Home.Instance.Manager.statutSMTPServer);
			}
			else
			{
				string message = "La configuration du serveur SMTP n'a pas pu être enregistrée.";
				MessageBox.Show(message, "Configuration du serveur SMTP - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine("[Campagne] Erreur lors de la sauvegarde de la configuration du serveur SMTP.");
			}
		}

		/// <summary>
		/// Vérification du contenu exsitant
		/// </summary>
		private void updateConfigServerSMTPContent()
		{
			if (Home.Instance.Manager.GetSMTPConnectionHandler() != null)
			{
				//Expéditeur
				if (Home.Instance.Manager.GetSMTPConnectionHandler().SMTPAddressIP != null)
				{
					textBoxSMTPAddressIP.Text = Home.Instance.Manager.GetSMTPConnectionHandler().SMTPAddressIP;
				}
				//Rebound
				if (Home.Instance.Manager.GetSMTPConnectionHandler().SMTPPort != null)
				{
					textBoxSMTPPort.Text = Home.Instance.Manager.GetSMTPConnectionHandler().SMTPPort.ToString();
				}
				//Rebound
				if (Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserLogin != null)
				{
					textBoxSMTPUserLogin.Text = Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserLogin;
				}
				//Rebound
				if (Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserMDP != null)
				{
					textBoxSMTPUserMDP.Text = Home.Instance.Manager.GetSMTPConnectionHandler().SMTPUserMDP;
				}
			}
		}
	}
}
