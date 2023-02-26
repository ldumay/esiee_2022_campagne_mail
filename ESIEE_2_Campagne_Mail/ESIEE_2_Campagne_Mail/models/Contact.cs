namespace ESIEE_2_Campagne_Mail.models
{
	/// <summary>
	/// Classe Contact
	/// </summary>
	public class Contact
	{

		// Attribut du contact
		public int Id { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Email { get; set; }
		public ContactEtat Etat { get; set; }

		/// <summary>
		/// Constructeur vide du Contact
		/// </summary>
		public Contact()
		{
			Id = 0;
			Nom = "";
			Prenom = "";
			Email = "";
			Etat = ContactEtat.INACTIF;
		}

		/// <summary>
		/// Constructeur complet du Contact
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="prenom"></param>
		/// <param name="email"></param>
		/// <param name="etat"></param>
		public Contact(int id, string nom, string prenom, string email, ContactEtat etat)
		{
			Id = id;
			Nom = nom;
			Prenom = prenom;
			Email = email;
			Etat = etat;
		}
	}
}
