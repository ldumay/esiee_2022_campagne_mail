using ESIEE_2_Campagne_Mail.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
	/// <summary>
	/// Classse SMTPConnectionHandler.
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
		/// Change les parametres du serveur SMTP
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

		public bool EnvoyerCampagneMail(List<string> listeMails, ContenuDeMail ContenuMail)
		{
			if (!IsSMTPParameterValid())
			{
				return false;
			}
			MailMessage message = new MailMessage();
			message.From = new MailAddress(ContenuMail.Expediteur);
			message.Subject = ContenuMail.Titre;
			message.Body = ContenuMail.Contenu;
			foreach (string mail in listeMails)
			{
				message.CC.Add(new MailAddress(mail));
			}
			Client.Host = SMTPHost;
			Client.Port = SMTPPort;
			Client.Credentials = new NetworkCredential(SMTPUserLogin, SMTPUserMDP);
			try
			{
				Client.Send(message);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
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
