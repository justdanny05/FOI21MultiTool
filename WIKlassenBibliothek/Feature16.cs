using System;
using RestSharp;
using Newtonsoft.Json.Linq;
using Figgle;

namespace WIKlassenBibliothek
{
    internal class Feature16
    {
        internal static void Feature_16()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.CursorSize = 100;
            Console.ForegroundColor = ConsoleColor.White;
            bool Exit = false;

            string username;
            Console.WriteLine("Geben Sie Ihren Namen ein:");
            username = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(FiggleFonts.Slant.Render("Währungsrechner"));
                Console.Title = "Währungsrechner";
                Console.WriteLine("------------------------------------------------------------------------------------\n");
                Console.WriteLine("Eingabe: exit\t        ->\tbeendet das Programm");
                Console.WriteLine("Eingabe: toolexit\t->\tbeendet das Tool");
                Console.WriteLine("Eingabe: help\t->\tSie brauchen Hilfe?");
                Console.WriteLine("\n\nHi " + username + ", ich wurde von Selim programmiert und ich rechne für Sie Währungen um.\n\n");

                string Währung1;
                string Währung2;
                double betrag;

                Console.WriteLine("Die erste Währung, die Sie eingeben, wird in die zweite umgerechnet.\n");
                Console.Write("Geben Sie die erste Währung (z.B. USD): ");
                Währung1 = Console.ReadLine().ToUpper();
                Console.Write("Geben Sie die zweite Währung (z.B. EUR): ");
                Währung2 = Console.ReadLine().ToUpper();
                Console.Write("Geben Sie den Betrag ein, der umgerechnet werden soll: ");
                betrag = Convert.ToDouble(Console.ReadLine());

                // API request to Fixer.io

                // API request to Fixer.io
                var client = new RestClient($"https://api.apilayer.com/fixer/convert?from={Währung1}&to={Währung2}&amount={betrag}");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("apikey", "11jkM650waV1JUSKCDDDzUXqGHHoHHRI");
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var data = JObject.Parse(response.Content);

                    if (data["success"].ToObject<bool>())
                    {
                        double result = (double)data["result"];
                        Console.WriteLine($"\n{betrag} {Währung1} entspricht {result} {Währung2}");
                    }
                    else
                    {
                        Console.WriteLine("\nFehler beim Abrufen der Wechselkurse.");
                    }
                }
                else
                {
                    Console.WriteLine($"\nFehler beim Abrufen der Wechselkurse. Status code: {response.StatusCode}");
                }


                Console.WriteLine("\nDrücken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
            } while (!Exit);
        }
    }
}