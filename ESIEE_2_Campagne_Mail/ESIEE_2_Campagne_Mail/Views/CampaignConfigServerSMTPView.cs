using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail.Views
{
	public partial class CampaignConfigServerSMTPView : Form
	{
		/// <summary>
		/// Constructeur
		/// </summary>
		public CampaignConfigServerSMTPView()
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
			bool SMTPSSL = (textBoxSMTPPort.Text != null) ? true : false;
			//MailCampView.Instance.Manager.GetSMTPConnectionHandler().SMTPPort = (textBoxSMTPPort.Text != null) ? port : 0;
			string SMTPUserLogin = textBoxSMTPUserLogin.Text ?? string.Empty;
			string SMTPUserMDP = textBoxSMTPUserMDP.Text ?? string.Empty;

			MailCampView.Instance.Manager.ChangeSMTPConnectionParametres(SMTPAddressIP, SMTPport, SMTPSSL, SMTPUserLogin, SMTPUserMDP);

			if (MailCampView.Instance.Manager.SMTPConnectionHandler.IsSMTPParameterValid())
			{
				string message = "La configuration du serveur SMTP a bien été enregistrée.";
				Debug.WriteLine("[Campagne] Configuration SMTP : " + message);
				MessageBox.Show(message, "Configuration du serveur SMTP - Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string message = "La configuration du serveur SMTP n'a pas pu être enregistrée.";
				Debug.WriteLine("[Campagne] Configuration SMTP : " + message);
				MessageBox.Show(message, "Configuration du serveur SMTP - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Vérification du contenu exsitant
		/// </summary>
		private void updateConfigServerSMTPContent()
		{
			// Adresse IP
			textBoxSMTPAddressIP.Text = MailCampView.Instance.Manager.SMTPConnectionHandler.SMTPHost;
			// Port
			textBoxSMTPPort.Text = MailCampView.Instance.Manager.SMTPConnectionHandler.SMTPPort.ToString();
			// SSL
			checkBoxSMTPSSL.Checked = MailCampView.Instance.Manager.SMTPConnectionHandler.SMTPSSL;
			// Login
			textBoxSMTPUserLogin.Text = MailCampView.Instance.Manager.SMTPConnectionHandler.SMTPUserLogin;
			// Rebound
			textBoxSMTPUserMDP.Text = MailCampView.Instance.Manager.SMTPConnectionHandler.GetSMTPUserMDP();
		}
	}
}
