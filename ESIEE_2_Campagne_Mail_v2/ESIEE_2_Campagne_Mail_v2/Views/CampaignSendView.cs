using ESIEE_2_Campagne_Mail.gui;
using ESIEE_2_Campagne_Mail_v2;
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

namespace ESIEE_2_Campagne_Mail
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
		}

		private void envoiDeLaCampagne(object sender, EventArgs e) {
			Debug.WriteLine("[Campagne] Envoi de la campagne");
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
