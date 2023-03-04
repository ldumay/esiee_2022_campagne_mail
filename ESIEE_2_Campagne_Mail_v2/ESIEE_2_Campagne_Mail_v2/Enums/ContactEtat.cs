using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail_v2.enums
{
	/// <summary>
	/// Enumération des états d'un contact.
	/// </summary>
	public enum ContactEtat
	{
		ACTIF,
		INACTIF,
		DOUBLON,
		ERREUR_MAIL_NON_CONFORME,
		ERREUR
	}
}
