namespace ESIEE_2_Campagne_Mail.models
{
	/// <summary>
	/// Classe contenu de mail.
	/// </summary>
	public class ContenuDeMail
	{

		//Attribut de la liste des mails
		public string Expediteur { get; private set; }
		public string Titre { get; private set; }
		public string Rebound { get; private set; }
		public string Contenu { get; private set; }

		/// <summary>
		/// Constructeur vide de la classe ContenuDeMail.
		/// </summary>
		public ContenuDeMail()
		{
			Expediteur = string.Empty;
			Titre = string.Empty;
			Rebound = string.Empty;
			Contenu = string.Empty;
		}

		/// <summary>
		/// Constructeur de la classe ContenuDeMail.
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

		public void ChangerContenu(string? expediteur, string? titre, string? rebound, string? contenu)
		{
			Expediteur = string.IsNullOrWhiteSpace(expediteur) ? Expediteur : expediteur;
			Titre = string.IsNullOrWhiteSpace(titre) ? Titre : titre;
			Rebound = string.IsNullOrWhiteSpace(rebound) ? Rebound : rebound;
			Contenu = string.IsNullOrWhiteSpace(contenu) ? Contenu : contenu;
		}

		/// <summary>
		///     Clear all fields
		/// </summary>
		public void Clear()
		{
			Expediteur = string.Empty;
			Titre = string.Empty;
			Rebound = string.Empty;
			Contenu = string.Empty;
		}

		public bool IsValid()
		{
			bool MissingValue = string.IsNullOrWhiteSpace(Expediteur) || string.IsNullOrWhiteSpace(Titre) || string.IsNullOrWhiteSpace(Contenu);
			return !MissingValue;
		}
	}
}
