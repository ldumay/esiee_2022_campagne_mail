using ESIEE_2_Campagne_Mail.models;
using ESIEE_2_Campagne_Mail.utils;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIEE_2_Campagne_Mail.process
{
	/// <summary>
	/// Classse CampagneManager.
	/// </summary>
	internal class CampagneManager
	{
		private Campagne Campagne { get; }
		/// <summary>
		/// Attribut de la Campagne.
		/// </summary>
		private SMTPConnectionHandler SMTPConnectionHandler { get; }
		/// <summary>
		/// Attribut du SMTPConnectionHandler.
		/// </summary>
		public Boolean statutCampagneListeEmails { get; private set; }
		/// <summary>
		/// Attribut du statut de la liste des mails de la campagne.
		/// </summary>
		public Boolean statutCampagneMessage { get; private set; }
		/// <summary>
		/// Attribut du statut du message de la campagne.
		/// </summary>
		public Boolean statutCampagne { get; private set; }
		/// <summary>
		/// Attribut du statut de la campagne.
		/// </summary>
		public Boolean statutSendReady { get; private set; }
		/// <summary>
		/// Attribut du statut de l'envoi de la campagne.
		/// </summary>
		public Boolean statutSMTPServer { get; private set; }

		public CampagneManager(string nomCampagne)
		{
			Campagne = new Campagne(nomCampagne);
			SMTPConnectionHandler = new SMTPConnectionHandler();
		}

		[Obsolete("Sert juste d'entre-deux commits")]
		internal Campagne GetCampagne()
		{
			return Campagne;
		}

		/// <summary>
		/// Retourne le contenu du mail de la campagne.
		/// </summary>
		/// <returns></returns>
		internal ContenuDeMail GetContenuDuMail()
		{
			return Campagne.ContenuDeMail;
		}

		/// <summary>
		/// Change le contenu du message envoyé.
		/// </summary>
		/// <param name="expediteur"></param>
		/// <param name="titre"></param>
		/// <param name="rebound"></param>
		/// <param name="contenu"></param>
		internal void ChangerContenuDuMail(string? expediteur, string? titre, string? rebound, string? contenu)
		{
			//Vérification de l'adresse mail de l'expéditeur
			if (!UtilsMails.MailVerification(expediteur))
			{
				throw new InvalidDataException(
					"L'adresse mail de l'expéditeur est invalide."
					+ "\nVeuillez vérifier l'adresse mail de l'expéditeur.");
			}
			//Vérification de l'adresse mail du rebond
			if (!UtilsMails.MailVerification(rebound))
			{
				throw new InvalidDataException(
					"L'adresse mail du rebound est invalide."
					+ "\nVeuillez vérifier l'adresse mail du rebound.");
			}
			ContenuDeMail contenuDeMail = GetContenuDuMail();
			contenuDeMail.ChangerContenu(expediteur, titre, rebound, contenu);
		}


		internal SMTPConnectionHandler GetSMTPConnectionHandler()
		{
			return SMTPConnectionHandler;
		}

		/// <summary>
		/// Change la configuration de SMTPConnectionHandler selon les paramètres donnés
		/// </summary>
		/// <param name="SMTPAddressIP"></param>
		/// <param name="SMTPport"></param>
		/// <param name="SMTPUserLogin"></param>
		/// <param name="SMTPUserMDP"></param>
		/// <exception cref="NotImplementedException"></exception>
		internal void ChangeSMTPConnectionParametres(string SMTPAddressIP, int SMTPport, string SMTPUserLogin, string SMTPUserMDP)
		{
			if (string.IsNullOrWhiteSpace(SMTPAddressIP))
			{
				throw new ArgumentException($"« {nameof(SMTPAddressIP)} » ne peut pas être vide ou avoir la valeur Null.", nameof(SMTPAddressIP));
			}
			if (SMTPport == 0)
			{
				throw new ArgumentException($"« {nameof(SMTPport)} » ne peut pas être vide ou avoir la valeur Null.", nameof(SMTPport));
			}

			if (string.IsNullOrWhiteSpace(SMTPUserLogin))
			{
				throw new ArgumentException($"« {nameof(SMTPUserLogin)} » ne peut pas être vide ou avoir la valeur Null.", nameof(SMTPUserLogin));
			}
			// TOFIX : MDP peut être vide ?
			if (string.IsNullOrWhiteSpace(SMTPUserMDP))
			{
				throw new ArgumentException($"« {nameof(SMTPUserMDP)} » ne peut pas être vide ou avoir la valeur Null.", nameof(SMTPUserMDP));
			}
			SMTPConnectionHandler.ChangeSMTPParameters(SMTPAddressIP, SMTPport, SMTPUserLogin, SMTPUserMDP);
		}

		/// <summary>
		/// Test l'envoie de la campagne à l'aide d'un adresse
		/// </summary>
		/// <returns></returns>
		internal bool TesterEnvoieCampagne(string adresseMail)
		{
			return false;
		}

		/// <summary>
		/// Envoie le ContenuDeMail à tous les GroupeContact dans SMTPConnectionHandler 
		/// </summary>
		internal void EnvoyerCampagneMail()
		{
			if (HasListeEmail())
			{
				// Envoyer la campagne
				List<Contact> contacts = RecupererListContact(true);
				List<string> emails = new List<string>();
				foreach (Contact contact in contacts)
				{
					emails.Add(contact.Email);
				}
				SMTPConnectionHandler.EnvoyerCampagneMail(emails, Campagne.ContenuDeMail);
			}
		}

		/// <summary>
		/// Vérification des majuscules dans la liste des emails de la campagne.
		/// </summary>
		internal void CleanMajusculeListeContacts()
		{
			Debug.WriteLine("[Campagne] - Début du nettoyage des majuscules de la liste des contacts");
			//-
			List<GroupeContact> groupeContactList = Campagne.ListGroupeContact;
			foreach (GroupeContact groupeContact in groupeContactList)
			{
				List<Contact> contactList = groupeContact.ContactList;
				foreach (Contact contact in contactList)
				{
					contact.Email = contact.Email.ToLower();
				}
			}
			//-
			string message = "Le nettoyage des majuscules des emails de la liste des contacts a bien été effectué.";
			Debug.WriteLine("[Campagne] - " + message);
			MessageBox.Show(message, "Liste des emails - Nettoyage des majuscules terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Vérification des doublons existants dans la liste des emails de la campagne.
		/// </summary>
		internal void DedoublonnageListeContacts()
		{
			Debug.WriteLine("[Campagne] - Début du dédoublonnage de la liste des contacts");
			//-
			int compteur = 0;
			List<string> emailsNonDoublons = new List<string>();
			//-
			List<GroupeContact> groupeContactList = Campagne.ListGroupeContact;
			foreach (GroupeContact groupeContact in groupeContactList)
			{
				List<Contact> contactList = groupeContact.ContactList;
				foreach (Contact contact in contactList)
				{
					if (!emailsNonDoublons.Contains(contact.Email.ToLower()))
					{
						emailsNonDoublons.Add(contact.Email.ToLower());
					}
					else
					{
						compteur++;
						contact.Etat = ContactEtat.DOUBLON;
						Debug.WriteLine("Doublon trouvé : " + contact.Email);
					}
				}
			}
			//-
			string messagePart1 = "Le dédoublonnage a bien été effectué.";
			string messagePart2 = "Doublon total trouvé : " + compteur;
			string message = messagePart1 + "\n" + messagePart2;
			MessageBox.Show(message, "Liste des emails - Dédoublonnage terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Debug.WriteLine("[Campagne] - " + messagePart2);
			Debug.WriteLine("[Campagne] - Fin du dédoublonnage de la liste des contacts");
		}

		/// <summary>
		/// Ajoute le groupe de contact dans la campagne.
		/// </summary>
		/// <param name="contacts"></param>
		internal void AddGroupContact(GroupeContact contacts)
		{
			Campagne.ListGroupeContact.Add(contacts);
		}

		/// <summary>
		/// Nettoyage de la liste des contacts de la campagne.
		/// </summary>
		public void ClearGroupContact()
		{
			Campagne.ListGroupeContact.Clear();
			statutCampagneListeEmails = false;
		}

		/// <summary>
		/// Nettoyage de la liste des contacts de la campagne.
		/// </summary>
		public void ReplaceGroupContact(GroupeContact contacts)
		{
			ClearGroupContact();
			AddGroupContact(contacts);
		}

		internal List<Contact> RecupererListContact(bool activeOnly = false)
		{
			List<Contact> listeContact = new();
			foreach (GroupeContact groupeContact in Campagne.ListGroupeContact)
			{
				listeContact.AddRange(groupeContact.ContactList);
			}
			if (activeOnly)
			{
				List<Contact> listeContactActif = new();
				foreach (Contact contact in listeContact)
				{
					if (contact.Etat == ContactEtat.ACTIF)
					{
						listeContactActif.Add(contact);
					}
				}
				return listeContactActif;
			}
			return listeContact;
		}

		public bool HasListeEmail()
		{
			foreach (GroupeContact groupeContact in Campagne.ListGroupeContact)
			{
				if (groupeContact.ContactList.Count > 0)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasContenuValid()
		{
			return Campagne.ContenuDeMail.IsValid();
		}
	}
}
