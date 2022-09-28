using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ESIEE_2_Campagne_Mail.utils
{
    /// <summary>
    /// Classe d'utils sur les mails.
    /// </summary>
    public class UtilsMails
    {

        /// <summary>
        /// Vérifier le bon format d'un email grâce à un Regex de norme RFC2822.
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>bool</returns>
        public static bool MailVerification(string email)
        {
            try
            {
                Regex regex = new Regex(UtilsRegex.regexMail, RegexOptions.IgnoreCase);
                //-
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
