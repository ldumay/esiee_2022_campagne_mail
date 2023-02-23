using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.models
{
	/// <summary>
	/// Classe contenu de mail.
	/// </summary>
	public class ContenuDeMail
	{

		//Attribut de la liste des mails
		public string Expediteur { get; set; }
		public string Titre { get; set; }
		public string Rebound { get; set; }
		public string Contenu { get; set; }

		/// <summary>
		/// Constructeur vide de la classe Message.
		/// </summary>
		public ContenuDeMail()
		{
			Expediteur = "";
			Titre = "";
			Rebound = "";
			Contenu = "";
		}

		/// <summary>
		/// Constructeur complet de la classe Message.
		/// </summary>
		/// <param name="expediteur"></param>
		/// <param name="titre"></param>
		/// <param name="rebound"></param>
		/// <param name="contenu"></param>
		public ContenuDeMail(string? expediteur, string? titre, string? rebound, string? contenu)
		{
			Expediteur = expediteur ?? string.Empty;
			Titre = titre ?? string.Empty;
			Rebound = rebound ?? string.Empty;
			Contenu = contenu ?? string.Empty;
		}

		/// <summary>
		///     Clear all fields
		/// </summary>
		public void Clear()
		{
			Expediteur = "";
			Titre = "";
			Rebound = "";
			Contenu = "";
		}
	}
}
