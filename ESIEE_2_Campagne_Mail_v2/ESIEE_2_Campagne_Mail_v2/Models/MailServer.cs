using ESIEE_2_Campagne_Mail_v2.Enums;

namespace ESIEE_2_Campagne_Mail_v2.Models
{
    /// <summary>
	/// Classe d'un serveur de mail SMTP.
	/// </summary>
    public class MailServer
    {
        //Attribut du serveur de mail SMTP
        public MailServerType Type { get; private set; }
        public string Host { get; private set; }
        public int Port { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }
        public bool SSL { get; private set; }

        /// <summary>
        /// Constructeur vide de serveur de mail SMTP.
        /// </summary>
        public MailServer()
        {
            Type = MailServerType.DEFAULT;
            Host = string.Empty;
            Port = 0;
            User = string.Empty;
            Password = string.Empty;
            SSL = false;
        }

        /// <summary>
		/// Constructeur complet de serveur de mail SMTP.
		/// </summary>
		/// <param name="mailServerType"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="ssl"></param>
        public MailServer(MailServerType mailServerType, string host, int port, string user, string password, bool ssl)
        {
            Type = mailServerType;
            Host = host;
            Port = port;
            User = user;
            Password = password;
            SSL = ssl;
        }

        /// <summary>
        /// Cette méthode permet de vérifier si le serveur de mail 
        /// est prêt à être utilisé.
        /// </summary>
        public bool isReady()
        {
            if (Type == null || Type == MailServerType.DEFAULT)
                return false;
            if (string.IsNullOrEmpty(Host))
                return false;
            if (Port == 0)
                return false;
            if (string.IsNullOrEmpty(User))
                return false;
            if (string.IsNullOrEmpty(Password))
                return false;
            return true;
        }
    }
}
