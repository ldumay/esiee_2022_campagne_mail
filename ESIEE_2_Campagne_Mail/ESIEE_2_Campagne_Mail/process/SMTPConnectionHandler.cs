using ESIEE_2_Campagne_Mail.models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public string SMTPAddressIP { get; private set; }
		public int SMTPPort { get; private set; }
		public string SMTPUserLogin { get; private set; }
		public string SMTPUserMDP { get; private set; }
		public SmtpClient Client { get; private set; }

		/// <summary>
		/// Constructeur
		/// </summary>
		public SMTPConnectionHandler()
		{
			SMTPAddressIP = string.Empty;
			SMTPPort = 0;
			SMTPUserLogin = string.Empty;
			SMTPUserMDP = string.Empty;
			Client = new SmtpClient();
		}

		public void ChangeSMTPParameters(string? ipAdresse, int? port, string? login, string? password)
		{
            SMTPAddressIP = ipAdresse ?? string.Empty;
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
			// TODO: implement mail send
			return true;
		}

		private bool IsSMTPParameterValid()
		{
			return !(
				string.IsNullOrWhiteSpace(SMTPAddressIP) || SMTPPort <= 0 || string.IsNullOrWhiteSpace(SMTPUserLogin) || string.IsNullOrWhiteSpace(SMTPUserMDP)
			);
		}
	}
}
