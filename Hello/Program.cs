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
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grand book name changed from {args.ExistingName} to {args.NewName}");
        }
    }
}