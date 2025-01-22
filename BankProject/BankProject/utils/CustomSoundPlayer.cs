using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace BankProject.utils
{
    public static class CustomSoundPlayer
    {
        /// <summary>
        /// Spielt eine WAV-Datei aus den eingebetteten Ressourcen ab.
        /// </summary>
        /// <param name="resourceName">Der Name der eingebetteten Ressource (ohne Ordnerpfad).</param>
        private static void PlaySound(string resourceName)
        {
            try
            {
                // Der vollständige Name der Ressource (Namespace + Datei)
                string fullResourceName = $"BankProject.utils.sounds.{resourceName}";

                // Ressource als Stream laden
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fullResourceName))
                {
                    if (stream != null)
                    {
                        using (SoundPlayer player = new SoundPlayer(stream))
                        {
                            player.Play();
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
                MessageBox.Show($"Fehler beim Abspielen der Datei: {ex.Message}");
            }
        }

        public static void PlayWarningSound() => PlaySound("warning.wav");
        public static void PlayErrorSound() => PlaySound("error.wav");
        public static void PlaySuccessSound() => PlaySound("success.wav");
        public static void PlayInformationSound() => PlaySound("info.wav");
        public static void PlayQuestionSound() => PlaySound("question.wav");
    }
}