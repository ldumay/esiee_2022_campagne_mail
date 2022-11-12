using System.Diagnostics;

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
		public List<GroupeContact> ListGroupeContact { get; }
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
			ListGroupeContact = new List<GroupeContact>();
			ContenuDeMail = new ContenuDeMail();
		}

		/// <summary>
		/// Constructeur complet de la classe Campagne.
		/// </summary>
		/// <param name="nom"></param>
		/// <param name="listGroupeContact"></param>
		/// <param name="message"></param>
		public Campagne(string nom, List<GroupeContact> listGroupeContact, ContenuDeMail message)
		{
			this.Nom = nom;
			this.ListGroupeContact = listGroupeContact;
			this.ContenuDeMail = message;
		}

	}
}
