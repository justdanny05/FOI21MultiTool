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
            Console.WriteLine("Gebe dein Namen ein:");
            username = Console.ReadLine();


            Console.WriteLine("Gebe 'start' ein, um den Währungsrechner zu starten. Gebe 'exit' ein, um das tool zu schliessen.");
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
                        Console.WriteLine("\n\nHi " + username + ", ich wurde von Selim programmiert und ich rechne für dich Währungen um.\n\n");

                        string Währung1 = "";
                        string Währung2 = "";
                        double betrag = 0;

                        do
                        {
                            Console.Write("Gebe die erste Währung ein(z.B. USD): ");
                            Währung1 = Console.ReadLine().ToUpper();

                            if (Währung1 == "E")
                            {
                                Exit = true;
                                break;
                            }

                            Console.Write("Gebe die zweite Währung ein (z.B. EUR): ");
                            Währung2 = Console.ReadLine().ToUpper();

                            if (Währung2 == "E")
                            {
                                Exit = true;
                                break;
                            }

                            Console.Write("Gebe den Betrag ein, der umgerechnet werden soll: ");
                            string inputBetrag = Console.ReadLine();

                            if (inputBetrag == "E")
                            {
                                Exit = true;
                                break;
                            }

                            if (!double.TryParse(inputBetrag, out betrag))
                            {
                                Console.WriteLine("Ungültiger Betrag. Bitte gib einen gültigen Betrag ein.");
                            }

                        } while (betrag <= 0);



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

                        Console.WriteLine("Wenn du das Programm beenden möchtest, drücke 'e'. Wenn du Fortsetzen möchtest drücke eine beliebige andere taste.");
                        Console.WriteLine("Wenn du dir paar beispiel währungen anschauen möchtest drücke 't'.");
                        string userInput = Console.ReadLine().ToLower();
                        if (userInput == "e")
                        {
                            Exit = true;
                            Console.Clear();
                        }
                        else if (userInput == "t")
                        {
                            Console.Clear();
                            Console.WriteLine("| Währung | ISO-Code |\r\n|------------------|----------|\r\n| US-Dollar | USD |\r\n| Euro | EUR |\r\n| Japanischer Yen | JPY |\r\n| Britisches Pfund | GBP |\r\n| Schweizer Franken| CHF |\r\n| Kanadischer Dollar| CAD |\r\n| Australischer Dollar| AUD |\r\n| Neuseeland-Dollar| NZD |\r\n| Chinesischer Yuan | CNY |\r\n| Russischer Rubel | RUB |\r\n| Südkoreanischer Won | KRW |\r\n| Singapur-Dollar | SGD |\r\n| Indische Rupie | INR |\r\n| Südafrikanischer Rand | ZAR|\r\n| Mexikanischer Peso | MXN |\r\n| Brasilianischer Real | BRL |\r\n| Türkische Lira | TRY |\r\n| Norwegische Krone | NOK |\r\n| Schwedische Krone | SEK |\r\n| Dänische Krone | DKK |\r\n| Hongkong-Dollar | HKD |\r\n| Indonesische Rupiah | IDR |\r\n| Malaysischer Ringgit | MYR |\r\n| Philippinischer Peso | PHP |\r\n| Thailändischer Baht | THB |\r\n| Taiwan-Dollar | TWD | \n");
                            Console.WriteLine("Drücke eine Beliebige taste um zurückzukehren");

                            Console.ReadKey();
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
                    Console.WriteLine("Ungültige Eingabe. Gebe 'start' ein, um den Währungsrechner zu starten. Gebe 'exit' ein, um das tool zu schliessen.");
                }
            } while (!Exit);

            Console.WriteLine("Das Programm wurde beendet. Drücke eine beliebige Taste zum schliessen.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}