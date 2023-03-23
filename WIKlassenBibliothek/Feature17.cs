using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature17
    {
        internal static void Feature_17()
        {
            bool Exit = false;

            do
            {
                Console.Clear();

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Lohnabrechnung"));

                //Konsolentitel wird geändert.
                Console.Title = "Wirtschaft";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Wirtschafts Submenu<<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t        ->\tbeendet das Programm");
                Console.WriteLine("Eingabe: subexit\t->\tbeendet das Submenu");

                //Beschreibung der Software
                Console.WriteLine("\n\nWillkommen im Untermenü 'Wirtschaft' hier findest du coole und spannende Tools.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Tools:\n");
                Console.WriteLine("\t1 - Währungsrechner");
                Console.WriteLine("\t2 - Lohnabrechnung");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik");
                Console.WriteLine("\tw - Wirtschaft\n");
                Console.WriteLine("Eingabe:");
                
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Feature17.Feature_17();
                        break;

                    case "m":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;

                    case "p":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        break;

                    case "w":
                        Console.Clear();
                        //Hier das Wirtschaftsmenü aufrufen
                        break;
                    case "subexit":
                        Exit = true;
                        Console.Clear();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);
        }
    }
    }

