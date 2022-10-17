using ESIEE_2_Campagne_Mail.models;
using System.Diagnostics;
using System.Windows.Forms;

namespace ESIEE_2_Campagne_Mail.utils
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
            string fileExt = "";
            string filePath = "";
            string fileName = "";

            //Sélection du fichier
            try
            {
                //Création d'une nouvelle fenêtre d'édition de message.
                //Source : https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Choisir Text Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt",
                    FilterIndex = 2,
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

                fileExt = openFileDialogFileNameWithPath.Split('.')[1];
                filePath = openFileDialogFileNameWithPath.Split('.')[0];
                string[] filePathExplode = filePath.Split('\\');
                fileName = filePathExplode.Length > 0 ? filePathExplode[filePathExplode.Length - 1] : null;
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

                Debug.WriteLine("File infos OK.");
            }
            catch (Exception e)
            {
                string message = "Une erreur est survenue lors du choix du fichier.";
                Debug.WriteLine(message);
                MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e.Message);
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
            catch (System.IO.FileNotFoundException e)
            {
                string message = "Le fichier n'existe pas.";
                Debug.WriteLine(message);
                MessageBox.Show("Oups !\n\n" + message, "Importation - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return groupeMail;
            }
            catch (Exception e)
            {
                string message = "Une erreur est survenue lors de l'importation du fichier.";
                Debug.WriteLine(message);
                MessageBox.Show("Erreur !\n\n" + message, "Importation - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e.Message);
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
