using Figgle;
namespace PHKlassenBibliothek
{
    public class PHMenue
    {
        public static void PH_Menue()
        {
            bool subexit = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----             -----      ---      --     -------      ---          ----      ----      ----      ------");
                Console.WriteLine("----     -------   ----    -----    -----     ----     ----    ------------    ------    ----     --------");
                Console.WriteLine("----     -------   ----    -----    ------     --     ----     ------------    ------    --     ----------");
                Console.WriteLine("----     ------   -----    -----    --------       --------      ----------    ------         ------------");
                Console.WriteLine("----            -------             ---------     ------------      ------     ------         ------------");
                Console.WriteLine("----     --------------    -----    ---------     ---------------     ----     ------    --     ----------");
                Console.WriteLine("----     --------------    -----    ---------     -------------      -----     ------    ----     --------");
                Console.WriteLine("----     -------------      ---      --------     -------          ------      ----      ----      -------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------\n");

                Console.WriteLine("Willkommen im Themenbereich Physik :)\n" +
                    "Hier sind Sie genau richtig, wenn Sie hilfe beim lösen von ihren Aufgaben, in den unten Aufgelisteten Themenbereichen, brauchen.\n" +
                    "Wenn Sie hier raus wollen, können Sie jeder Zeit mit dem Befehl 'subexit' ins Hauptmenü zurückkehren.\n\n");

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("--   Themenbereiche:                              --");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("--\t1: Gravitation                            --");                                                        //Untermenü Physik
                Console.WriteLine("--\t2: Lichtbrechung                          --");
                Console.WriteLine("--\t3: Lautstärke und Schall                  --");
                Console.WriteLine("--\t4: Geschwindigkeit                        --");
                Console.WriteLine("--                                                --");
                Console.WriteLine("--\tsubexit: Zurück ins Hauptmenü             --");
                Console.WriteLine("----------------------------------------------------\n");

                Console.Write("Eingabe: ");
                string eingabe = Console.ReadLine();
                if (eingabe == "1" | eingabe == "2" | eingabe == "3" | eingabe == "4")
                {
                    int feature = int.Parse(eingabe);
                    switch (feature)
                    {

                        case 1:
                            Console.Clear();
                            //Feature 1 Danny CallmeBabygirl
                            break;

                        case 2:
                            Console.Clear();
                            //Feature 2 Shehan nahehs
                            break;

                        case 3:
                            Console.Clear();
                            //Feature 3 Cihan Nextsuki
                            break;

                        case 4:
                            Console.Clear();
                            //Feature 4 Simon simqn
                            Feature9.Feature_9();
                            break;
                    }
                }
                if (eingabe == "subexit")
                {
                    //Zurück zum Hauptmenü
                    Console.Clear();
                    Console.WriteLine("Sie kehren jetzt zum Hauptmenü zurück.\nViel Erfolg weiterhin.");
                    subexit = true;
                    Console.WriteLine("Um fortzufahren eine beliebige Taste drücken.");
                    Console.ReadKey();
                }

                else
                {
                    //Falsche Eingabe
                    Console.WriteLine("Das hat nicht geklappt, "+ eingabe +" ist nicht gültig.\n" +
                        "Um fortfahren zu können, geben Sie bitte eine der vier vorgegebenen Zahlen an\n" +
                        " oder 'subexit' um ins Hauptmenü zurückzukehren.:)");
                    Console.WriteLine("Um fortzufahren eine beliebige Taste drücken.");
                    Console.ReadKey();
                }
            } while (!subexit);            
        }
    }
}