using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail_v2
{
	public partial class CampaignSendView : Form
	{
		/// <summary>
		/// Constructeur
		/// </summary>
		public CampaignSendView()
		{
			InitializeComponent();
			this.updateAllLabelStatuts();
		}

		private void testDuServeurSMTP(object sender, EventArgs e) {
			Debug.WriteLine("[Campagne] Test du serveur d'envoi");
			//-
			if (MailCampView.Instance.Manager.TesterEnvoiCampagne(textBoxMailTest.Text))
			{
				string message = " Le serveur d'envoi est bien configuré\n et le mail de test à bien été envoyé à : " + textBoxMailTest.Text;
				labelSendTryResultContent.Text = message;
				labelConfirmCampagneReadyForSend.Text = "✅ Test d'envoi valider";
				Debug.WriteLine("[Campagne]" + message);
				MessageBox.Show(message, "Configuration du serveur SMTP - OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string message = "[Campagne] Le serveur d'envoi n'est pas configuré.";
				Debug.WriteLine(message);
				MessageBox.Show("Oups !\n\n" + message, "Configuration du serveur SMTP - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void envoiDeLaCampagne(object sender, EventArgs e) {
			Debug.WriteLine("[Campagne] Envoi de la campagne");
			//-
			if (MailCampView.Instance.Manager.EnvoyerCampagneMail())
			{
				string message = "[Campagne] La campagne a bien été envoyée.";
				Debug.WriteLine(message);
				MessageBox.Show(message, "Configuration du serveur SMTP - OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				string message = "[Campagne] La campagne n'a pas été envoyée.";
				Debug.WriteLine(message);
				MessageBox.Show("Oups !\n\n" + message, "Configuration du serveur SMTP - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// Mise à jour des labels des satuts de la campagne visible sur la page d'accueil.
		/// </summary>
		private void updateAllLabelStatuts()
		{
			// Vérification du statut de la camapgne
			if (MailCampView.Instance.Manager.HasContenuValid() && MailCampView.Instance.Manager.HasListeEmail())
			{
				this.labelConfirmCampagneReady.Text = "✅ Campagne prête";
				Debug.WriteLine("[Campagne] La campagne est prête.");
			}
			// Vérification du statut de la camapgne
			if (MailCampView.Instance.Manager.SMTPConnectionHandler.IsSMTPParameterValid())
			{
				this.labelConfirmStatutSMTP.Text = "✅ Configuration du serveur SMTP prêt";
				Debug.WriteLine("[Campagne] La campagne est prête.");
			}
		}
	}
}
