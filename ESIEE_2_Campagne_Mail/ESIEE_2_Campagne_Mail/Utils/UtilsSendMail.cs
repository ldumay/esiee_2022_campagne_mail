using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using ESIEE_2_Campagne_Mail.Models;

namespace ESIEE_2_Campagne_Mail.Utils
{
	/// <summary>
	/// Classe d'utils sur l'envoi de mail(s).
	/// </summary>
	public class UtilsSendMail
	{
        /// <summary>
        /// Cette méthode permet d'envoyer un mail 
        /// à un ou plusieurs destinataire(s) direct,
        /// à un ou plusieurs destinataire(s) CC,
        /// à un ou plusieurs destinataire(s) CCI
        /// et avec un ou plusieur(s) fichiers joints.
        /// </summary>
        /// <param name="mailServer"></param>
        /// <param name="mail"></param>
        public static void sendMailsWithAttachements(MailServer mailServer, Mail mail)
        {
            //Variables nécessaires
            MailMessage message;
            ContentDisposition disposition;
            Attachment data = null;
            SmtpClient serverSMTP;
            NetworkCredential networkCredential;
            ContentDisposition contentDisposition;

            // Il est néssaire de vérifier la non-nullité des données.
            // du seveur de mail et du mail.
            if (mailServer.isReady() && mail.isReady()) {
                //-
                Console.WriteLine("---");
                Console.WriteLine("[Mail] Préparation du message et du serveur SMTP...\n");

                // Préparation du message.
                message = new MailMessage();
                // Configuration du message.
                message.Priority = 0;
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                //From - Adresse de l’expéditeur de l’e-mail.
                message.From = new MailAddress(mailServer.User);
                //Reply-to
                message.ReplyTo = new MailAddress(mailServer.User);
                //To - adresse du destinataire de l’e-mail.
                if (mail.To.Count > 0)
                    foreach (string to in mail.To) { message.To.Add(to); }
                //CC - Récupération de la liste des copie carbone.
                if (mail.CC.Count > 0)
                    foreach (string cc in mail.CC) { message.CC.Add(cc); }
                //CCI - Récupération de la liste des copie carbone invisible.
                if (mail.CCI.Count > 0)
                    foreach (string cci in mail.CCI) { message.Bcc.Add(cci); }
                //Subjet - Sujet du mail.
                message.Subject = mail.Subject;
                //Body - Corps du message.
                message.Body = mail.Body + "\n";
                //-
                Console.WriteLine("---");
                Console.WriteLine("[Mail] Message et du serveur SMTP - OK");
                Console.WriteLine("---");

                // Préparation du ou des fichier(s) à joindre
                try
                {
                    if (mail.AttachmentsPathFile.Count > 0)
                    {
                        int nbFile = 1;
                        //-
                        foreach (string file in mail.AttachmentsPathFile)
                        {
                            // Création du fichier joint pour ce message électronique.
                            data = new Attachment(file, MediaTypeNames.Application.Octet);
                            // Ajout du fichier joint à ce message électronique.
                            message.Attachments.Add(data);
                            // Ajout des informations d'horodatage pour le ou les fichier(s).
                            disposition = data.ContentDisposition;
                            disposition.CreationDate = File.GetCreationTime(file);
                            disposition.ModificationDate = File.GetLastWriteTime(file);
                            disposition.ReadDate = File.GetLastAccessTime(file);
                            //-
                            Console.WriteLine("[Mail] Ajout des informations d'horodatage pour le fichier n°" + nbFile + "\n- path : " + file);
                        }
                        //-
                        Console.WriteLine("[Mail] Ajout des informations d'horodatage pour le ou les fichier(s) - OK");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("[Mail] Ajout des informations d'horodatage pour le ou les fichier(s) - ERREUR");
                    Console.WriteLine("[Erreur]" + exception.ToString);
                }

                // Prépartion du seveur SMTP.
                serverSMTP = new SmtpClient();
                serverSMTP.Host = mailServer.Host;
                serverSMTP.EnableSsl = mailServer.SSL;
                serverSMTP.Port = mailServer.Port;
                //-
                Console.WriteLine("---");
                Console.WriteLine("[Mail] Serveur SMTP - OK");

                // Créer d'une référence réseau pour le serveur SMTP
                networkCredential = new NetworkCredential();
                networkCredential.UserName = mailServer.User;
                networkCredential.Password = mailServer.Password;
                // Ajout des informations d'identification si le serveur SMTP
                // requiert l'identification de l'utilisateur.
                serverSMTP.Credentials = networkCredential;
                //-
                Console.WriteLine("[Mail] Référence réseau pour le serveur SMTP - OK");


                // Essai d'envoi du message
                try
                {
                    serverSMTP.Send(message);
                    Console.WriteLine("---");
                    Console.WriteLine("[Mail] Mail envoyé");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("---");
                    Console.WriteLine("Exception caught in CreateMessageWithAttachment():\n{0}",
                        ex.ToString());
                }

                // Affiche les valeurs dans le ContentDisposition pour la pièce jointe.
                if (data != null)
                {
                    contentDisposition = data.ContentDisposition;
                    Console.WriteLine("---");
                    Console.WriteLine("Content disposition");
                    Console.WriteLine(contentDisposition.ToString());
                    Console.WriteLine("File {0}", contentDisposition.FileName);
                    Console.WriteLine("Size {0}", contentDisposition.Size);
                    Console.WriteLine("Creation {0}", contentDisposition.CreationDate);
                    Console.WriteLine("Modification {0}", contentDisposition.ModificationDate);
                    Console.WriteLine("Read {0}", contentDisposition.ReadDate);
                    Console.WriteLine("Inline {0}", contentDisposition.Inline);
                    Console.WriteLine("Parameters: {0}", contentDisposition.Parameters.Count);
                    foreach (DictionaryEntry d in contentDisposition.Parameters)
                    {
                        Console.WriteLine("{0} = {1}", d.Key, d.Value);
                    }
                    data.Dispose();
                }
            }
        }
    }
}
