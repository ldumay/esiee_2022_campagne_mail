using ESIEE_2_Campagne_Mail_v2.Enums;
using ESIEE_2_Campagne_Mail_v2.Models;
using ESIEE_2_Campagne_Mail_v2.Utils;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace ESIEE_2_Campagne_Mail_v2.Process
{
	/// <summary>
	/// Classe SMTPConnectionHandler.
	/// </summary>
	internal class SMTPConnectionHandler
	{
		public string SMTPHost { get; private set; }
		public int SMTPPort { get; private set; }
		public string SMTPUserLogin { get; private set; }
		private string SMTPUserMDP { get; set; }
		[Obsolete("On ne devrait pas sortir le mot de passe n'importe où")]
		public string GetSMTPUserMDP() { return SMTPUserMDP; }
		public SmtpClient Client { get; private set; }

		/// <summary>
		/// Constructeur
		/// </summary>
		public SMTPConnectionHandler()
		{
			SMTPHost = string.Empty;
			SMTPPort = 0;
			SMTPUserLogin = string.Empty;
			SMTPUserMDP = string.Empty;
			Client = new SmtpClient();
		}

		/// <summary>
		/// Change les parametres du serveur SMTP.
		/// </summary>
		/// <param name="host"></param>
		/// <param name="port"></param>
		/// <param name="login"></param>
		/// <param name="password"></param>
		public void ChangeSMTPParameters(string? host, int? port, string? login, string? password)
		{
			SMTPHost = host ?? string.Empty;
			SMTPPort = port ?? 0;
			SMTPUserLogin = login ?? string.Empty;
			SMTPUserMDP = password ?? string.Empty;
		}


		/// <summary>
		/// Teste si les parametres du serveur SMTP sont valides.
		/// </summary>
		/// <returns></returns>
		public bool TestEnvoiDeMail(string adresseMail, ContenuDeMail contenuMail)
		{
			try
			{
				Console.WriteLine("Test d'envoi de mail");

				//Variables
				List<string> to = new List<string>();
				List<string> listCC = new List<string>();
				List<string> listCCI = new List<string>();
				string subject = contenuMail.Titre;
				string body = contenuMail.Contenu;
				List<string> listAttachmentsPathFile = new List<string>();

				//Alimentation des listes
				to.Add(contenuMail.Expediteur);
				//listCC.Add("hello@ldumay.fr");
				listCCI.Add(contenuMail.Expediteur);
				//listCCI.Add("dumay.famille@gmail.com");
				//listAttachmentsPathFile.Add("test.txt");

				//Préparation du serveur de mail
				MailServer mailServer = new MailServer(
					MailServerType.IMAP, //type
					SMTPHost, //host
					SMTPPort, // port
					SMTPUserLogin, //user
					SMTPUserMDP, //password
					true // ssl
				);

				//Préparation du mail
				Mail mail = new Mail(
					to, //to
					listCC, //cc
					listCCI, //cci
					subject, //subject
					body, //body
					listAttachmentsPathFile //attachmentsPathFile
				);

				//Envoi du mail
				UtilsSendMail.sendMailsWithAttachements(mailServer, mail);

				Console.WriteLine("\n---");
				Console.WriteLine("Fin du Test");

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Erreur lors de l'envoi du mail de test : " + ex.Message);
				return false;
			}
		}

		public bool EnvoyerCampagneMail(List<string> listeMails, ContenuDeMail contenuMail)
		{
			if (!IsSMTPParameterValid())
			{
				return false;
			}
			MailMessage message = new MailMessage();
			message.From = new MailAddress(contenuMail.Expediteur);
			message.Subject = contenuMail.Titre;
			message.Body = contenuMail.Contenu;
			foreach (string mail in listeMails)
			{
				message.To.Add(new MailAddress(mail));
			}
			Client.Host = SMTPHost;
			Client.Port = SMTPPort;
			Client.Credentials = new NetworkCredential(SMTPUserLogin, SMTPUserMDP);
			//-
			string messageError = "";
			//-
			try
			{
				Client.Send(message);
			}
			catch (Exception ex)
			{
				messageError = ex.Message;
				Debug.WriteLine("[Campagne] - Message d'erreur :\n" + messageError);
				MessageBox.Show("Oups !\n\n" + messageError, "Envoi de la campagne - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		public bool IsSMTPParameterValid()
		{
			return !(
				string.IsNullOrWhiteSpace(SMTPHost) || SMTPPort <= 0 || string.IsNullOrWhiteSpace(SMTPUserLogin) || string.IsNullOrWhiteSpace(SMTPUserMDP)
			);
		}
	}
}
