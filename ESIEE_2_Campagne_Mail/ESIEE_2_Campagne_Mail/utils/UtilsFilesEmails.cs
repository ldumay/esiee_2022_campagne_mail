using ESIEE_2_Campagne_Mail.models;
using System.Windows.Forms;

namespace ESIEE_2_Campagne_Mail.utils
{
    public class UtilsFilesEmails
    {

        /**
         * Importation d'une liste de mail depuis un fichier TXT.
         */
        public static GroupeMail ImportWithOpenFileDialogEmailsTXT(){
            GroupeMail groupeMail = null;
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
                openFileDialog.ShowDialog();

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

                Console.WriteLine("File infos OK.");
            }
            catch (Exception e) {
                string message = "Une erreur est survenue lors du choix du fichier.";
                System.Console.WriteLine(message);
                MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine(e.Message);
            }
            
            //Lecture du fichier
            try
            {
                //Lecture du fichier ligne par ligne
                string[] lines = System.IO.File.ReadAllLines(@""+ filePath + fileName + "." + fileExt);
                
                System.Console.WriteLine("Importation d'emails : ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }
                
                

                //-
                //  = = = = = > Update groupeMail
                //-

                string message = "Le fichier a bien été chargé.";
                MessageBox.Show(message, "Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.FileNotFoundException e)
            {
                string message = "Le fichier n'existe pas.";
                System.Console.WriteLine(message);
                MessageBox.Show(message, "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                string message = "Une erreur est survenue lors de l'importation du fichier.";
                System.Console.WriteLine(message);
                MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine(e.Message);
            }

            return groupeMail;
        }

        /**
         * Exportation d'une liste de mail vers un fichier TXT.
         */
        public static bool ExportEmailsTXT(string path, string fileName) {
            bool isGood = false;
            //-
            //-
            return isGood;
        }
    }
}
