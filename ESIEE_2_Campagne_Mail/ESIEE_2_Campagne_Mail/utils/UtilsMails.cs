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
		/// <param name="email"></param>
		/// <returns>true si l'adresse mail est valide, false sinon</returns>
		public static bool MailVerification(string? email)
		{
			if (string.IsNullOrWhiteSpace(email))
			{
				return false;
			}
			try
			{
				// le regex ne semble pas être utilisé ?
				Regex regex = new Regex(UtilsRegex.regexMail, RegexOptions.IgnoreCase);
				//-
				// renvoie vrai si le mail est égal à lui-même ? Cette fonction renvoie donc toujours vrai ?
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
