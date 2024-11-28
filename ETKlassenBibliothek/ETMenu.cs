﻿using Figgle;


namespace ETKlassenBibliothek
{
    public class ETMenu
    {
        public static void ET_Menu()
        {
            bool Exit = false;

            do
            {

                

                Console.WriteLine();
                Console.Clear();
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.SetCursorPosition(0, 0);
                //ASCII art Logo wird erzeugt.
                Console.WriteLine(FiggleFonts.Slant.Render("FOIMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "FOIMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> ETMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");


                string SubAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eines der folgenden Features:\n");
                Console.WriteLine("\t1 - Voltage, Current, Resistance Calculator");
                Console.WriteLine("\t2 - Spannungsfallberechner");
                Console.WriteLine("\t3 - Quiz");
                Console.WriteLine("\t4 - Physik");
                Console.WriteLine("\t5 - Wirtschaft\n");
                int LOL = Console.CursorTop;
                Console.Write("Eingabe:");
                SubAusw = Console.ReadLine().ToLower();

                switch (SubAusw)
                {
                    case "1":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen
                        break;

                    case "2":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
                        break;

                    case "3":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        Feature5.Feature_5();
                        break;

                    case "p":
                        Console.Clear();
                        //Hier das Physikmenü aufrufen
                        break;

                    case "w":
                        Console.Clear();
                        //Hier das Wirtschaftsmenü aufrufen
                        break;

                    case "exit":
                        Exit = true;
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