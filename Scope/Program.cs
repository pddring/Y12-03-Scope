using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string title = "Translator";
        static string name;

        static void Main(string[] args)
        {
            string language = "Japanese";
            SayHello(ref language);
            Console.WriteLine($"I just said hello in {language}");
        }

        private static void ShowOff()
        {
            List<string> languages = new List<string> {
                "English", "German", "French", "Yorkshire"
            };

            foreach (string language in languages)
            {
                string lang = language;
                SayHello(ref lang);
                // make it say "You can greet people in English by saying 'Hello'"
            }
        }

        private static void SayHello(ref string language)
        {
            language = "English";
            Console.Write($"You can say a greeting in {language} by saying ");
            switch (language)
            {
                case "English":
                    Console.WriteLine("Hello");
                    break;
                case "German":
                    Console.WriteLine("Guten tag");
                    break;
                case "French":
                    Console.WriteLine("Bonjour");
                    break;
                case "Japanese":
                    Console.WriteLine("Kon'nichiwa");
                    break;
                default:
                    Console.WriteLine("How do?!");
                    break;
            }
        }
    }
}
