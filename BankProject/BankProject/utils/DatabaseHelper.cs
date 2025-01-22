using System.Reflection;

namespace BankProject.utils
{
    internal class DatabaseHelper
    {
        public static string ExtractDatabase()
        {
            // Der vollständige Name der eingebetteten Ressource
            string resourceName = "BankProject.utils.database.database.db";

            // Zielpfad für die extrahierte Datenbank (im temporären Verzeichnis)
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            try
            {
                // Ressource als Stream laden
                using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (resourceStream != null)
                    {
                        using (FileStream fileStream = new FileStream(databasePath, FileMode.Create, FileAccess.Write))
                        {
                            resourceStream.CopyTo(fileStream);
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException($"Die eingebettete Ressource '{resourceName}' wurde nicht gefunden.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fehler beim Extrahieren der Datenbank: {ex.Message}");
            }

            return databasePath; // Pfad zur extrahierten Datenbank
        }
    }
}
