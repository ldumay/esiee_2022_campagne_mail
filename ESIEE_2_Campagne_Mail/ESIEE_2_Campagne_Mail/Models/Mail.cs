using ESIEE_2_Campagne_Mail.Enums;

namespace ESIEE_2_Campagne_Mail.Models
{
    /// <summary>
	/// Classe d'un mail.
	/// </summary>
    public class Mail
    {
        //Attribut d'un mail
        public List<string> To { get; private set; }
        public List<string> CC { get; private set; }
        public List<string> CCI { get; private set; }
        public string Subject { get; private set; }
        public string Body { get; private set; }
        public List<string> AttachmentsPathFile { get; private set; }

        /// <summary>
        /// Constructeur vide de la classe Mail.
        /// </summary>
        public Mail()
        {
            To = new List<string>();
            CC = new List<string>();
            CCI = new List<string>();
            Subject = string.Empty;
            Body = string.Empty;
            AttachmentsPathFile = new List<string>();
        }

        /// <summary>
        /// Constructeur à moitié complet de la classe Mail.
        /// </summary>
        /// <param name="To"></param>
        /// <param name="CC"></param>
        /// <param name="CCI"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AttachmentsPathFile"></param>
        public Mail(string subject, string body)
        {
            To = new List<string>();
            CC = new List<string>();
            CCI = new List<string>();
            Subject = subject;
            Body = body;
            AttachmentsPathFile = new List<string>();
        }

        /// <summary>
        /// Constructeur complet de la classe Mail.
        /// </summary>
        /// <param name="To"></param>
        /// <param name="CC"></param>
        /// <param name="CCI"></param>
        /// <param name="Subject"></param>
        /// <param name="Body"></param>
        /// <param name="AttachmentsPathFile"></param>
        public Mail(List<string> to, List<string> cc, List<string> cci, string subject, string body, List<string> attachmentsPathFile)
        {
            To = to;
            CC = cc;
            CCI = cci;
            Subject = subject;
            Body = body;
            AttachmentsPathFile = attachmentsPathFile;
        }

        /// <summary>
        /// Cette méthode permet de vérifier si le  mail 
        /// est prêt à être utilisé.
        /// </summary>
        public bool IsReady()
        {
            if (To.Count > 0 && Subject != string.Empty && Body != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
