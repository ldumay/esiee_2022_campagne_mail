namespace ESIEE_2_Campagne_Mail.models
{
	/// <summary>
	/// Classe Campagne.
	/// </summary>
	public class Campagne
	{
		/// <summary>
		/// Attribut du nom dela campagne
		/// </summary>
		public string Nom { get; set; }
		/// <summary>
		/// Attribut de la liste des mails
		/// </summary>
		public List<GroupeContact> GroupeMailList { get; }
		/// <summary>
		/// Attribut du message
		/// </summary>
		public ContenuDeMail ContenuDeMail { get; set; }

		/// <summary>
		/// Constructeur vide de la classe Campagne.
		/// </summary>
		/// <param name="nom"></param>
		public Campagne(string nom)
		{
			Nom = nom;
			GroupeMailList = new List<GroupeContact>();
			ContenuDeMail = new ContenuDeMail();
		}

		/**
		 * Constructeur complet de la classe Campagne.
		 */
		public Campagne(string nom, List<GroupeContact> groupeMailList, ContenuDeMail message)
		{
			this.Nom = nom;
			this.GroupeMailList = groupeMailList;
			this.ContenuDeMail = message;
		}

	}
}
