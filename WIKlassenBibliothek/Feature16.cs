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

            bool Exit = false;

            string username;
            Console.WriteLine("Geben Sie Ihren Namen ein:");
            username = Console.ReadLine();


            Console.WriteLine("Geben Sie 'start' ein, um den Währungsrechner zu starten. Geben Sie 'exit' ein, um das tool zu schliessen.");
            do
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "start")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(FiggleFonts.Slant.Render("Währungsrechner"));
                        Console.Title = "Währungsrechner";
                        Console.WriteLine("------------------------------------------------------------------------------------\n");
                        Console.WriteLine("Taste: e\t->\tbeendet das Programm");
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
                                double result = Math.Round((double)data["result"], 2);
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
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Danke " + username + " Das du mein tool genutzt hast!");
                        Console.WriteLine();
                        Console.WriteLine("\nWenn du das Programm beenden möchtest, drücke 'e'. Wenn du Fortsetzen möchtest drücke eine beliebige andere taste.");
                        string userInput = Console.ReadLine().ToLower();
                        if (userInput == "e")
                        {
                            Exit = true;
                            Console.Clear();
                        }


                    } while (!Exit);
                }
                else if (input.ToLower() == "exit")
                {
                    Exit = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Geben Sie 'start' ein, um den Währungsrechner zu starten. Geben Sie 'exit' ein, um das tool zu schliessen");
                }
            } while (!Exit);



        }
    }
}