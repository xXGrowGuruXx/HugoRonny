using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.utils
{
    public static class CustomSoundPlayer
    {
        private static readonly string SoundFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils",  "sounds");

        /// <summary>
        /// Spielt eine WAV-Datei ab.
        /// </summary>
        /// <param name="fileName">Der Name der WAV-Datei.</param>
        public static void PlaySound(string fileName)
        {
            try
            {
                string filePath = Path.Combine(SoundFolderPath, fileName);
                if (File.Exists(filePath))
                {
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.Play();
                    }
                }
                else
                {
                    throw new FileNotFoundException($"Die Datei '{fileName}' wurde nicht im Ordner 'sounds' gefunden.");
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
