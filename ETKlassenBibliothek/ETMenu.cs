using Figgle;


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
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Elektrotechnik");
                Console.WriteLine("\t2 - Informatik");
                Console.WriteLine("\t3 - Mathematik");
                Console.WriteLine("\t4 - Physik");
                Console.WriteLine("\t5 - Wirtschaft\n");
                int LOL = Console.CursorTop;
                Console.Write("Eingabe:");
                SubAusw = Console.ReadLine().ToLower();

                switch (SubAusw)
                {
                    case "1":
                        Console.Clear();
                        Feature1.Feature_1();
                        break;

                    case "i":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
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