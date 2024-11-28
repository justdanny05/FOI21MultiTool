using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace PHKlassenBibliothek
{
    internal class Feature8
    {
        internal static void Feature_8()
        {
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║              Hauptmenü               ║");
                    Console.WriteLine("╠══════════════════════════════════════╣");
                    Console.WriteLine("║                                      ║");
                    Console.WriteLine("║ 1 - Schallausbreitungsrechner        ║");
                    Console.WriteLine("║ 2 - Informationen                    ║");
                    Console.WriteLine("║ 3 - Taschenrechner                   ║");
                    Console.WriteLine("║ 4 - Beenden                          ║");
                    Console.WriteLine("║                                      ║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    Console.Write("Bitte wählen Sie eine Option aus: ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            RunSchallausbreitungsrechner();
                            break;
                        case "2":
                            Information();
                            break;
                        case "3":
                            RunTaschenrechner();
                            break;
                        case "4":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine gültige Option.");
                            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            static double ReadDoubleInput(string prompt)
            {
                Console.WriteLine(prompt);
                double input;
                while (!double.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl ein:");
                }
                return input;
            }
            static int ReadIntInput(string prompt, int lower_bound, int upper_bound)
            {
                Console.WriteLine(prompt);
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || input > upper_bound || input < lower_bound)
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl ein:");
                }
                return input;
            }
            static void RunSchallausbreitungsrechner()
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|        Schallausbreitungsrechner       |");
                Console.WriteLine("-----------------------------------------");

                double distance = ReadDoubleInput("Bitte geben Sie die Entfernung von der Schallquelle in Metern ein:");
                double soundLevel = ReadDoubleInput("Bitte geben Sie die Lautstärke der Schallquelle in Dezibel ein:");
                Console.WriteLine("Bitte wählen Sie das Material, das sich zwischen der Schallquelle und dem Ziel befindet:");
                Console.WriteLine("1) Holzwand");
                Console.WriteLine("2) Betonwand");
                Console.WriteLine("3) Metallwand");
                Console.WriteLine("4) Kein Material");
                int materialChoice = ReadIntInput("Geben Sie Ihre Wahl ein (1-4):", 1, 4);
                double materialFactor;
                switch (materialChoice)
                {
                    case 1:
                        materialFactor = 0.5; // Holzwand
                        break;
                    case 2:
                        materialFactor = 0.2; // Betonwand
                        break;
                    case 3:
                        materialFactor = 0.1; // Metallwand
                        break;
                    case 4:
                        materialFactor = 1.0; // No wall material
                        break;
                    default:
                        materialFactor = 1.0;
                        break;
                }

                Console.WriteLine("Befindet sich die Schallquelle im Wasser oder an Land?");
                Console.WriteLine("1) Wasser");
                Console.WriteLine("2) Land");
                int environmentChoice = ReadIntInput("Geben Sie Ihre Wahl ein (1-2):", 1, 2);
                double speedOfSound;
                if (environmentChoice == 1)
                {
                    speedOfSound = 1500; // speed of sound in water (m/s)
                }
                else
                {
                    speedOfSound = 343.2; // speed of sound in air (m/s)
                }

                double soundIntensity = Math.Pow(10, soundLevel / 10) * 1e-12 * materialFactor;
                double propagationTime = distance / speedOfSound;
                double soundPressure = Math.Sqrt(soundIntensity / (4 * Math.PI));
                double soundPressureLevel = 20 * Math.Log10(soundPressure / 2e-5);
                Console.WriteLine("|                                                                                                                    |");
                Console.WriteLine("|             Ergebnisse:                                                                                            |");
                Console.WriteLine("|                                                                                                                    |");
                Console.WriteLine("| Schall benötigt {0:0.##} Sekunden, um eine Entfernung von {1} Metern zu überwinden.                                |", propagationTime, distance);
                Console.WriteLine("|                                                                                                                    |");
                Console.WriteLine("| Schallintensität: {0} W/m^2                                                                                        |", soundIntensity);
                Console.WriteLine("| Schalldruckpegel: {0} dB                                                                                           |", soundPressureLevel);
                Console.WriteLine("|                                                                                                                    |");

                bool returnToMenu = false;
                while (!returnToMenu)
                {
                    Console.Write("Drücken Sie 'm', um zum Hauptmenü zurückzukehren, oder 'b', um das Programm zu beenden: ");
                    string choice = Console.ReadLine().ToLower();
                    switch (choice)
                    {
                        case "m":
                            return;
                        case "b":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                            break;
                    }
                }
            }



            static void Information()
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|               Informationen            |");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("|                                        |");
                Console.WriteLine("| 1 - Schall und Lautstärke              |");
                Console.WriteLine("| 2 - Schallgeschwindigkeit              |");
                Console.WriteLine("| 3 - Zurück zum Hauptmenü               |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Bitte wählen Sie eine Option aus: ");
                string infoOption = Console.ReadLine();

                switch (infoOption)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("|          Schall und Lautstärke         |");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("| Schall ist eine Schwingung von Luft-    |");
                        Console.WriteLine("| oder anderen Teilchen, die durch ein   |");
                        Console.WriteLine("| Medium wie Luft oder Wasser übertragen |");
                        Console.WriteLine("| wird. Schallwellen bewegen sich durch   |");
                        Console.WriteLine("| die Luft und können von unserem Ohr    |");
                        Console.WriteLine("| aufgefangen werden. Die Lautstärke       |");
                        Console.WriteLine("| des Schalls wird in Dezibel (dB) gemessen|");
                        Console.WriteLine("| und gibt an, wie stark der Schall ist.  |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("| Der Schallpegel verdoppelt sich, wenn   |");
                        Console.WriteLine("| der Schall um 6 dB ansteigt. Zum        |");
                        Console.WriteLine("| Beispiel ist ein Schalldruckpegel von   |");
                        Console.WriteLine("| 100 dB doppelt so laut wie ein          |");
                        Console.WriteLine("| Schalldruckpegel von 94 dB.             |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("| Zurück zum Hauptmenü (beliebige Taste)   |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("-----------------------------------------");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("|          Schallgeschwindigkeit         |");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("| Schallwellen bewegen sich mit einer     |");
                        Console.WriteLine("| Geschwindigkeit durch ein Medium wie    |");
                        Console.WriteLine("| Luft oder Wasser. Die Schallgeschwindig-|");
                        Console.WriteLine("| keit hängt von der Dichte des Mediums   |");
                        Console.WriteLine("| und der Temperatur ab. In trockener     |");
                        Console.WriteLine("| Luft bei 20 Grad Celsius beträgt die    |");
                        Console.WriteLine("| Schallgeschwindigkeit etwa 343 m/s.     |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("| Zurück zum Hauptmenü (beliebige Taste)   |");
                        Console.WriteLine("|                                        |");
                        Console.WriteLine("-----------------------------------------");
                        Console.ReadKey();
                        break;
                    case "3":
                        // Zurück zum hauptmenü
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine gültige Option.");
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
                        Console.ReadKey();
                        break;
                }
            }

            static void RunTaschenrechner()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=====================================");
                Console.WriteLine("|          Taschenrechner           |");
                Console.WriteLine("=====================================\n");
                Console.ResetColor();

                double zahl1 = ReadDoubleInput("Bitte geben Sie die erste Zahl ein:");
                double zahl2 = ReadDoubleInput("Bitte geben Sie die Zweite Zahl ein:");

                Console.WriteLine("\nBitte wählen Sie eine Rechenoperation aus:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraktion");
                Console.WriteLine("3 - Multiplikation");
                Console.WriteLine("4 - Division");

                bool validOperator = false;
                double result = 0;
                string input = Console.ReadLine();
                while (!validOperator)
                {


                    switch (input)
                    {
                        case "1":
                            result = zahl1 + zahl2;
                            validOperator = true;
                            break;
                        case "2":
                            result = zahl1 - zahl2;
                            validOperator = true;
                            break;
                        case "3":
                            result = zahl1 * zahl2;
                            validOperator = true;
                            break;
                        case "4":
                            if (zahl2 != 0)
                            {
                                result = zahl1 / zahl2;
                                validOperator = true;
                            }
                            else
                            {
                                zahl2 = ReadDoubleInput("Division durch Null ist nicht erlaubt. Bitte geben Sie eine andere Zahl ein:");
                            }
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine gültige Rechenoperation aus:");
                            break;
                    }
                }

                Console.WriteLine($"\nDas Ergebnis von {zahl1} {(input == "1" ? "+" : input == "2" ? "-" : input == "3" ? "*" : "/")} {zahl2} ist: {result}\n");

                Console.WriteLine("Möchten Sie zurück zum Hauptmenü? (J/n)");

                if (Console.ReadKey().Key == ConsoleKey.J)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n\nVielen Dank für die Verwendung unseres Taschenrechners. Auf Wiedersehen!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
    }
}