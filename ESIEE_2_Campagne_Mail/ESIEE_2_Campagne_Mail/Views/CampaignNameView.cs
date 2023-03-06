using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail
{
	public partial class CampaignNameView : Form
	{
		private string? message;
		private string? campaignName;

		/// <summary>
		/// Constructeur
		/// </summary>
		public CampaignNameView()
		{
			// Initialisation des composants de la vue
			InitializeComponent();
			// Nettoyage du label d'erreur
			clearWarning();
			// Vérification du nom de campagne
			checkNameCampagne();
		}

		/// <summary>
		/// Vérification de l'existance d'un nom de campagne
		/// </summary>
		private void checkNameCampagne()
		{
			if (!string.IsNullOrEmpty(MailCampView.Instance.Manager.GetCampagneName()))
			{
				textBoxNewCampaignContent.Text = MailCampView.Instance.Manager.GetCampagneName();
			}
		}

		/// <summary>
		/// Bouton de vérification à la bonne création d'une nouvelle campagne.
		/// </summary>
		private void buttonCreateCampagneClick(object sender, EventArgs e)
		{
			// Nettoyage du label d'erreur
			clearWarning();

			// Récuparation du nom saisi dans le champ de texte
			campaignName = textBoxNewCampaignContent.Text;

			// Vérification de la saisie
			if (!string.IsNullOrEmpty(campaignName)
				&& !campaignName.Equals(MailCampView.Instance.Manager.GetCampagneName())
			)
			{
				// On enregistre le nom de la campagne
				MailCampView.Instance.Manager.ChangeCampagneName(campaignName);
				// Préparation du message d'erreur
				message = "La campagne \"" + campaignName + "\" a bien été créé.";
				// warning message
				labelWarning.Text = "[Campagne] " + message;
                labelWarning.ForeColor = System.Drawing.Color.FromArgb(127, 255, 0);
				//-
				Debug.WriteLine("[Campagne] " + message + " - Nom : " + campaignName);
			}
			else
			{
				// Préparation du message d'erreur
				message = "La campagne n'a pas pu être créé car le nom n'est pas correcte ou celui-ci existe déjà.";
				// warning message
				labelWarning.Text = "[Campagne] " + message;
				labelWarning.ForeColor = System.Drawing.Color.Red;
				//-
				Debug.WriteLine("[Campagne] " + message + " - Nom : " + campaignName);
			}
		}

		/// <summary>
		/// Nettoyage de l'affichage du label d'erreur.
		/// </summary>
		private void clearWarning()
		{
			labelWarning.Text = "";
		}
	}
}