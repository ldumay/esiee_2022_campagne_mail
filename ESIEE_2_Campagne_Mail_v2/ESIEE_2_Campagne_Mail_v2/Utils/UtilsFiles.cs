using ESIEE_2_Campagne_Mail_v2.Models;
using ESIEE_2_Campagne_Mail_v2.Enums;
using System.Diagnostics;

namespace ESIEE_2_Campagne_Mail_v2.Utils
{
	/// <summary>
	/// Classe d'utils pour les fichier.
	/// </summary>
	public class UtilsFiles
	{

		/// <summary>
		/// Importation d'une liste de mail depuis un fichier TXT.
		/// </summary>
		/// <returns>GroupeMail</returns>
		public static GroupeContact ImportWithOpenFileDialogEmailsTXT()
		{

			GroupeContact groupeMail = new GroupeContact();
			string fileExt = string.Empty;
			string filePath = string.Empty;
			string fileName = string.Empty;

			// Sélection du fichier
			try
			{
				// Création d'une nouvelle fenêtre d'édition de message.
				// Source : https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					InitialDirectory = @"C:\",
					Title = "Choisir un fichier texte",

					CheckFileExists = true,
					CheckPathExists = true,

					DefaultExt = "txt",
					Filter = "txt files (*.txt)|*.txt",
					RestoreDirectory = true,

					ReadOnlyChecked = true,
					ShowReadOnly = true
				};
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult != DialogResult.OK)
				{
					return groupeMail;
				}
				string openFileDialogFileNameWithPath = openFileDialog.FileName;
				string[] fileSplit = openFileDialogFileNameWithPath.Split('.');
				fileExt = fileSplit[1];
				filePath = fileSplit[0];
				Debug.WriteLine("Choosen file path : " + filePath + "\nFile extension : " + fileExt);
				string[] filePathExplode = filePath.Split('\\');
				fileName = filePathExplode.Length > 0 ? filePathExplode[filePathExplode.Length - 1] : string.Empty;
				filePath = "";
				for (int i = 0; i < filePathExplode.Length - 1; i++)
				{
					if (i < filePathExplode.Length - 1)
					{
						filePath += filePathExplode[i] + "\\";
					}
					else
					{
						filePath += filePathExplode[i];
					}
				}
				Debug.WriteLine("Reduce file path : " + filePath);

				Debug.WriteLine("File infos OK.");
			}
			catch (Exception ex)
			{
				string message = "Une erreur est survenue lors du choix du fichier.";
				Debug.WriteLine(message);
				MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine(ex.Message);
			}

			//Lecture du fichier
			try
			{
				//Lecture du fichier ligne par ligne
				string[] lines = System.IO.File.ReadAllLines(@"" + filePath + fileName + "." + fileExt);
				Debug.WriteLine("Lecture OK");

				//Conversion des lignes en liste de contact
				foreach (string line in lines)
				{
					//Ligne
					Debug.WriteLine("\t" + line);

					//Non lecture de la première ligne
					if (line != "Id,Nom,Prenom,Email,Etat")
					{

						//Découpage de la ligne
						string[] lineCut = line.Split(",");

						//Création du contact
						Contact contact = new Contact();
						contact.Id = int.Parse(lineCut[0]);
						contact.Nom = lineCut[1];
						contact.Prenom = lineCut[2];
						contact.Email = lineCut[3];
						if (lineCut[4] == "Actif")
						{
							contact.Etat = ContactEtat.ACTIF;
						}
						else if (lineCut[4] == "Inactif")
						{
							contact.Etat = ContactEtat.INACTIF;
						}
						else
						{
							contact.Etat = ContactEtat.ERREUR;
						}

						//Ajout du contact à la liste du GroupeContact
						groupeMail.AjouterContact(contact);
						if (contact.Etat == ContactEtat.ACTIF)
						{
							groupeMail.ActiverMail(contact);
						}
					}
				}

				string message = "Le fichier a bien été chargé.";
				MessageBox.Show(message, "Importation - Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return groupeMail;
			}
			catch (FileNotFoundException ex)
			{
				string message = "Le fichier n'existe pas.";
				Debug.WriteLine(message + "\n" + ex.Message);
				MessageBox.Show("Oups !\n\n" + message, "Importation - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return groupeMail;
			}
			catch (Exception ex)
			{
				string message = "Une erreur est survenue lors de l'importation du fichier.";
				Debug.WriteLine(message + "\n" + ex.Message);
				MessageBox.Show("Erreur !\n\n" + message, "Importation - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return groupeMail;
			}
		}

		/// <summary>
		/// Exportation d'une liste de mail vers un fichier TXT.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="fileName"></param>
		/// <returns>bool</returns>
		public static bool ExportEmailsTXT(string path, string fileName)
		{
			bool isGood = false;
			//-
			//-
			return isGood;
		}
	}
}
