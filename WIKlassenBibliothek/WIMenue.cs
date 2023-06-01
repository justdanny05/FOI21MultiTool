using Figgle;

namespace WIKlassenBibliothek
{
    public class WIMenue
    {
        public static void WI_Menue()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("Wirtschaft"));

                //Konsolentitel wird geändert.
                Console.Title = "Wirtschaft";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Wirtschafts Submenu<<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t        ->\tbeendet das Programm");
                Console.WriteLine("Eingabe: subexit\t->\tbeendet das Submenu");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'FOIMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung
                Console.WriteLine("Wählen Sie eine der folgenden Tools:\n");
                Console.WriteLine("\t1 - Währungsrechner");
                Console.WriteLine("\t2 - Lohnabrechnung");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik");
                Console.WriteLine("\tw - Wirtschaft\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Feature16.Feature_16();
                        break;

                    case "2":
                        Console.Clear();

                        Feature17 rechner = new Feature17();
                        rechner.Run();                       
           
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
