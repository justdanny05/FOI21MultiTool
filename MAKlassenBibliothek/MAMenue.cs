using Figgle;
namespace MAKlassenBibliothek
{
    public class MAMenue
    {
        public static void MA_Menue()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("FOIMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "FOIMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: subexit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nWilkommen im Mathematik-Submenü!\n" +
                                  "Hier können sie verschiedene Features aufrufen und diese benutzen\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Funktionsrechner");
                Console.WriteLine("\t2 - Mathequiz");
                Console.WriteLine("\t3 - Distanzrechner");
                Console.WriteLine("\t4 - Koordinatenbasierter Rechner");
                Console.WriteLine("\t5 - Geometrischer Formenrechner\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Feature21.Feature_21();
                        break;

                    case "2":
                        Console.Clear();
                        Feature22.Feature_22();
                        break;

                    case "3":
                        Console.Clear();
                        Feature23.Feature_23();
                        break;

                    case "4":
                        Console.Clear();
                        Feature24.Feature_24();
                        break;

                    case "5": 
                        Console.Clear();
                        Feature25.Feature_25();
                        break;

                    case "subexit":
                        Console.Clear();
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