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

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nWilkommen im Mathematik-Submenü!\n" +
                                  "Hier können sie verschiedene Features aufrufen und diese benutzen\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Feature 1");
                Console.WriteLine("\t2 - Feature 2");
                Console.WriteLine("\t3 - Feature 3");
                Console.WriteLine("\t4 - Feature 4");
                Console.WriteLine("\t5 - Feature 5\n");
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
                        //Hier Feature schreiben
                        Feature22.Feature_22();
                        break;

                    case "3":
                        Console.Clear();
                        //Hier Feature3 aufrufen
                        Feature23.Feature_23();
                        break;

                    case "4":
                    
                        //Hier Feature1 aufrufen
                        Feature24.Feature_24();
                        break;

                    case "5": 
                        Console.Clear();
                        Feature25.Feature_25();
                        //Hier Feature schreiben
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