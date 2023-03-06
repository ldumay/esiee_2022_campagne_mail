using ESIEE_2_Campagne_Mail.Enums;
using ESIEE_2_Campagne_Mail.Models;
using ESIEE_2_Campagne_Mail.Utils;
using System.Net.Mail;

namespace ESIEE_2_Campagne_Mail.Process
{
	/// <summary>
	/// Classe SMTPConnectionHandler.
	/// </summary>
	internal class SMTPConnectionHandler
	{
		public string SMTPHost { get; private set; }
		public int SMTPPort { get; private set; }
		public bool SMTPSSL { get; private set; }
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
			SMTPSSL = false;
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
		public void ChangeSMTPParameters(string? host, int? port, bool? ssl, string? login, string? password)
		{
			SMTPHost = host ?? string.Empty;
			SMTPPort = port ?? 0;
			SMTPSSL = ssl ?? false;
			SMTPUserLogin = login ?? string.Empty;
			SMTPUserMDP = password ?? string.Empty;
		}

		/// <summary>
		/// Teste si les parametres du serveur SMTP sont valides.
		/// </summary>
		/// <returns>bool</returns>
		public bool IsSMTPParameterValid()
		{
			if(string.IsNullOrEmpty(SMTPHost))
				return false;
			if (SMTPPort <= 0)
				return false;
			if (string.IsNullOrEmpty(SMTPUserLogin))
				return false;
			if (string.IsNullOrEmpty(SMTPUserMDP))
				return false;
			return true;
		}

		/// <summary>
		/// Teste si les lparametres du serveur SMTP sont valides.
		/// </summary>
		/// <returns>bool</returns>
		public bool TestEnvoiDeMail(string adresseMail, ContenuDeMail contenuMail)
		{
			// Vérification de la validité des paramètres
			if (IsSMTPParameterValid())
			{
				// Essai d'envoi de mail
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
					//--Destinataires
					to.Add(adresseMail);
					//--Copies-Carbones
					//listCC.Add("hello@ldumay.fr");
					//--Copies-Carbones-Invisibles
					listCCI.Add(contenuMail.Expediteur);
					//listCCI.Add("dumay.famille@gmail.com");
					//--Pièces jointes
					//listAttachmentsPathFile.Add("test.txt");

					//Préparation du serveur de mail
					MailServer mailServer = new MailServer(
						MailServerType.IMAP, //type
						SMTPHost, //host
						SMTPPort, // port
						SMTPUserLogin, //user
						SMTPUserMDP, //password
						SMTPSSL // ssl
					);

					//Préparation du mail
					Mail mails = new Mail(
						to, //to
						listCC, //cc
						listCCI, //cci
						subject, //subject
						body, //body
						listAttachmentsPathFile //attachmentsPathFile
					);

					//Envoi du ou des mail(s)
					UtilsSendMail.sendMailsWithAttachements(mailServer, mails);

					Console.WriteLine("\n---");
					Console.WriteLine("Fin du Test");
					//-
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erreur lors de l'envoi du mail de test : " + ex.Message);
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		public bool EnvoyerCampagneMail(List<string> listeMails, ContenuDeMail contenuMail)
		{
			// Vérification de la validité des paramètres
			if (IsSMTPParameterValid())
			{
				// Essai d'envoi de mail
				try
				{
					Console.WriteLine("Envoi de la campagne de mail");

					//Variables
					List<string> to = new List<string>();
					List<string> listCC = new List<string>();
					List<string> listCCI = new List<string>();
					string subject = contenuMail.Titre;
					string body = contenuMail.Contenu;
					List<string> listAttachmentsPathFile = new List<string>();

					//Alimentation des listes
					//--Destinataires
					foreach (string mail in listeMails)
					{
						to.Add(mail);
					}
					//--Copies-Carbones
					//listCC.Add("hello@ldumay.fr");
					//--Copies-Carbones-Invisibles
					//listCCI.Add(contenuMail.Expediteur);
					//listCCI.Add("dumay.famille@gmail.com");
					//--Pièces jointes
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
					Mail mails = new Mail(
						to, //to
						listCC, //cc
						listCCI, //cci
						subject, //subject
						body, //body
						listAttachmentsPathFile //attachmentsPathFile
					);

					//Envoi du ou des mail(s)
					UtilsSendMail.sendMailsWithAttachements(mailServer, mails);
					
					Console.WriteLine("\n---");
					Console.WriteLine("Fin du Test");
					//-
					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erreur lors de l'envoi de la campagne de mail : " + ex.Message);
					return false;
				}
			}
			else
			{
				return false;
			}
		}
	}
}
