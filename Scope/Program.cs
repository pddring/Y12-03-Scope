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
            ShowOff();
            ShowOff();
            ShowOff();
            ShowOff();
            ShowOff();
            ShowOff();
            ShowOff();
            ShowOff();

        }

        private static void ShowOff()
        {
            List<string> languages = new List<string> {
                "English", "German", "French", "Yorkshire"
            };
            Console.WriteLine(title);

            foreach (string language in languages)
            {
                SayHello(language);
                // make it say "You can greet people in English by saying 'Hello'"
            }
        }

        private static void SayHello(string language)
        {
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
                default:
                    Console.WriteLine("How do?!");
                    break;
            }
        }
    }
}
