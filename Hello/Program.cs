using System;
using System.Speech.Synthesis;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
            //synth.Speak("How are you today?");

            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;

            book.Name = "Harry Potter";
            book.Name = "Chemistry";

            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBookStatistics statistics = book.ComputeGradeBookStatistics();

            WriteMessage("Highest", statistics.HighestGrade);
            WriteMessage("Lowest", statistics.LowestGrade);
            WriteMessage("Average", statistics.AverageGrade);
            WriteMessage("Letter Grade", statistics.LetterGrade);
        }

        private static void WriteMessage(string message, char grade)
        {
            Console.WriteLine($"{message}: {grade}");
        }

        private static void WriteMessage(string message, float grade)
        {
            Console.WriteLine($"{message}: {grade:F2}");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grand book name changed from {args.ExistingName} to {args.NewName}");
        }
    }
}