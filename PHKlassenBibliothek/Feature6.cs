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
    internal class Feature6
    {
        //Untermenü Gravitation-Feature_6
        internal static void Feature_6()
        {
            bool exit_gravitation = false;
            do
            {
                bool exit_untermenü_ReUNDIn = false;
                Console.Clear();
                Console.Title = "Gravitation\n";

                Console.WriteLine("Das ist der Themenbereich Gravitation und ihre Kräfte.\n" +
                    "Hier können Sie lernen und oder Rechnungen aus diesem Themenbereich durchführen lassen.\n" +
                    "Wenn Sie das Programm verlassen wollen, können Sie dies hier jederzeit mit dem Befehl 'exit' tun!\n" +
                    "Mit dem Befehl 'back' springen Sie immer einen Schritt zurück.\n" +
                    "Viel Spaß :)\n\n");

                Console.WriteLine("Um zurück ins Untermenü Physik zu kommen geben Sie 'back' ein.\n");

                Console.WriteLine("\tWie wollen Sie fortfahren?\n");

                Console.WriteLine("\t1. Informationen");                                                          //Untermenü Gravitation
                Console.WriteLine("\t2. Rechner");
                Console.WriteLine("\tMit 'subexit' können Sie jederzeit hier ins Menü zurück.");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.Write("Geben Sie eine der angegebenen Wahlmöglichkeiten an:");
                string eingabe_1 = Console.ReadLine();

                if (eingabe_1 == "1" | eingabe_1 == "2")
                {
                    int ieingabe_1 = int.Parse(eingabe_1);
                    switch (ieingabe_1)
                    {
                        case 1:
                            do
                            {
                                //Informationen Gravitation
                                Console.Clear();
                                Console.WriteLine("Informationen\n");

                                Console.WriteLine("-------------------------------------------------------\n");
                                Console.WriteLine("--  Was möchten Sie herausfinden?                    --\n");
                                Console.WriteLine("-------------------------------------------------------\n");
                                Console.WriteLine("--  1. Was ist überhaupt Gravitation                 --\n");         //Untermenü Information (info)
                                Console.WriteLine("--  2. Anziehungskraft unterschiedlicher Planeten    --\n");
                                Console.WriteLine("--  3. Schwerelosigkeit = keine Gravitation?         --\n");
                                Console.WriteLine("--                                                   --\n");
                                Console.WriteLine("-------------------------------------------------------\n");

                                Console.WriteLine("Wenn Sie doch lieber den Rechner benutzen wollen dann geben Sie 'subexit' ein.\n");

                                Console.Write("Eingabe:");
                                string case1 = Console.ReadLine();
                                int info1;
                                if (case1 == "1" | case1 == "2" | case1 == "3")
                                {
                                    info1 = int.Parse(case1);
                                    switch (info1)
                                    {
                                        case 1:
                                            //Was ist Gravitation
                                            Console.Clear();
                                            Console.WriteLine("Was ist die Gravitation überhaupt?\n");
                                            Console.WriteLine("Die Gravitation, auch Massenanziehung oder Gravitationskraft, ist eine der vier Grundkräfte der Physik.\n" +
                                                              " Sie äußert sich in der gegenseitigen Anziehung von Massen. Sie nimmt mit zunehmender Entfernung der Massen ab, besitzt \n" +
                                                              "aber unbegrenzte Reichweite. Im Gegensatz zu elektrischen oder magnetischen Kräften lässt sie sich nicht abschirmen.\n");

                                            Console.WriteLine("Auf der Erde bewirkt die Gravitation (Erdanziehungskraft), dass alle Körper nach „unten“, d. h. in Richtung Erdmittelpunkt,\n" +
                                                              "fallen, sofern sie nicht durch andere Kräfte daran gehindert werden. Im Sonnensystem bestimmt die Gravitation die Bahnen der Planeten, Monde,\n" +
                                                              "Satelliten und Kometen und im Kosmos die Bildung von Sternen und Galaxien sowie dessen Entwicklung im Großen.\n");

                                            Console.WriteLine("Gravitation wird oft mit Schwerkraft gleichgesetzt. Allerdings umfasst die vom lokal herrschenden Schwerefeld bestimmte Kraft \n" +
                                                              "auf einen Körper nicht nur die Gravitationskraft, sondern auch die auf den Körper wirkenden Trägheitswirkungen.\n");
                                            Console.WriteLine("Das sind so die wichtigsten Dinge, die man über die Gravitation wissen sollte.\n" +
                                                              "Sie werden nun automatisch ins Untermenü Informationen weitergeleitet.");

                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            //Anziehungskraft unterschiedlicher Planeten im Sonnensystem
                                            Console.Clear();
                                            Console.WriteLine("Hier ist die Anziehungskraft der verschiedenen Planeten des Sonnensystems aufgelistet,\n" +
                                                              "mit dem Maßstab der Anziehungskraft von der Erde, welche 1 beträgt.\n");

                                            Console.WriteLine("--------------------------------------");
                                            Console.WriteLine("-- Anziehungskraft im Sonnensystem  --");
                                            Console.WriteLine("--------------------------------------");
                                            Console.WriteLine("--  Merkur        --    0,37        --");
                                            Console.WriteLine("--  Venus         --    0,90        --");
                                            Console.WriteLine("--  Mond          --    0,16        --");
                                            Console.WriteLine("--  Mars          --    0,38        --");
                                            Console.WriteLine("--  Jupiter       --    2,53        --");
                                            Console.WriteLine("--  Saturn        --    1,07        --");
                                            Console.WriteLine("--  Uranus        --    0,91        --");
                                            Console.WriteLine("--  Neptun        --    1,14        --");
                                            Console.WriteLine("--  Pluto         --    0,08        --");
                                            Console.WriteLine("--------------------------------------\n");
                                            bool rechnung2_abfrage = true;
                                            do
                                            {
                                                rechnung2_abfrage = true;
                                                Console.WriteLine("Wenn Sie jetzt noch wissen wollen, wieviel Sie Wiegen würden, wenn Sie auf einem dieser Planeten auf einer Waage stehen würden,\n" +
                                                              " dann tippen Sie die eins und wenn Sie zurück ins Untermenü Info wollen, dann geben Sie die zwei ein.\n");

                                                Console.WriteLine("1) Zum Rechner\n" +
                                                    "2) Zurück zum Untermenü Informationen\n");

                                                Console.WriteLine("--------------------------------------");
                                                string info2 = Console.ReadLine();

                                                if (info2 == "1" | info2 == "2")
                                                {
                                                    int irechner = int.Parse(info2);
                                                    switch (irechner)
                                                    {
                                                        case 1:
                                                            //Zum Rechner
                                                            Anziehungskraft_Rechner();
                                                            Console.WriteLine("Das wars Sie werden jetzt automatisch ins Untermenü Informationen weitergeleitet\n" +
                                                                "Viel Spaß :)");
                                                            Console.ReadKey();
                                                            break;

                                                        case 2:
                                                            //Zurück zum Untermenü Information
                                                            break;

                                                    }
                                                }
                                                else if (info2 == "subexit")
                                                {
                                                    //Ins Untermenü Gravitation zurück
                                                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                                    Feature_6();
                                                }
                                                else if (info2 == "exit")
                                                {
                                                    Programmbeendet();
                                                    rechnung2_abfrage = false;           //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.    
                                                }
                                                else
                                                {
                                                    //Erneute Eingabeaufforderung, wenn Eingabe nicht 1 oder 2 entspricht.
                                                    rechnung2_abfrage = false;
                                                    Console.WriteLine("Das gehts so leider nicht\n" +
                                                        "" + info2 + " ist keine gültige Eingabe.\n" +
                                                        "Um fortzufahren bitte eine der zwei Zahlen eingeben...");
                                                    Console.ReadKey();
                                                }
                                            } while (!rechnung2_abfrage);
                                            break;

                                        case 3:
                                            //Schwerelosigkeit = keine Gravitation?
                                            Console.Clear();
                                            Console.WriteLine("Schwerelosigkeit = keine Gravitation?\n");

                                            Console.WriteLine("Was ist Schwerkraft?");
                                            Console.WriteLine("Jeder Himmelskörper, ob Planet, Mond oder Asteroid, besitzt eine individuelle Anziehungskraft,\n" +
                                                " auch speziell Schwerkraft oder allgemein Gravitation genannt, die von der Masse des jeweiligen Körpers abhängig ist. \n" +
                                                "Je größer der Himmelskörper, desto größer ist seine Schwerkraft.\n");

                                            Console.WriteLine("Wenn man Schwerelos ist, ist die Gewichtskraft auf einen Körper nicht spürbar. \n" +
                                                "Er drückt dann nicht auf eine Unterlage und es besteht Gegenkraftlosigkeit. Der Zustand annähernder Schwerelosigkeit heißt Mikrogravitation. \n" +
                                                "Die sogennante Schwerelosigkeit befindet sich im Weltall und beginnt unmittelbar hinter der Grenze zwischen ihm und der Luft. \n" +
                                                "Schätzungsweise beginnt dieser Punkt circa 100 Kilometer über der Erdoberfläche.\n");

                                            Console.WriteLine("Zusammengefasst ist also ein Gegenstand, der ungebremst, also ohne Gegenkraft im freien Fall, zu Boden fällt, \n" +
                                                "schwerelos, da auf ihn außer der Schwerkraft keine weiteren unmittelbaren Kräfte einwirken. Deswegen kann man schon sagen, \n" +
                                                "dass wenn man Schwerelos ist, sich keine Gravitationskraft auf einen auswirkt.\n");

                                            Console.WriteLine("Das wars, sie werden nun automatisch ins Untermenü Informationen weiter geleitet");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                else if (case1 == "back")
                                {
                                    //Zurück zum Untermenü Gravitationen
                                    exit_untermenü_ReUNDIn = true;
                                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                    Console.ReadKey();
                                }
                                else if (case1 == "exit")
                                {
                                    Programmbeendet();                  //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                }
                                else
                                {
                                    //Erneute Eingabeaufforderung, wegen falscher eingabe
                                    Console.WriteLine($"Falsche Eingabe...\n" +
                                        $"{case1} ist keine korrekte Eingabe, versuchen Sie es mit den vorgegebenen Zahlen nocheinmal.");
                                    Console.ReadKey();
                                }
                            } while (!exit_untermenü_ReUNDIn);
                            break;

                        case 2:
                            //Rechner
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Wilkommen im Untermenü Rechner\n\n");

                                Console.WriteLine("[-----------------------------------------------------]");
                                Console.WriteLine("|  Hier können Sie folgende Rechnungen durchführen:   |");
                                Console.WriteLine("|-----------------------------------------------------|");
                                Console.WriteLine("|1. Gravitationskraft zwischen zwei Massen            |");
                                Console.WriteLine("|                                                     |");                       //Untermenü Rechner
                                Console.WriteLine("|2. Gewichtskraft auf der Erdoberfläche               |");
                                Console.WriteLine("|                                                     |");
                                Console.WriteLine("|3. Gewicht auf unterschiedlichen Planeten            |");
                                Console.WriteLine("|                                                     |");
                                Console.WriteLine("[-----------------------------------------------------]\n");

                                Console.WriteLine("Um das Untermenü Rechner zu verlassen und zurück zum Menü Gravitation zu kommen,\n" +
                                    "müssen Sie einfach 'subexit' eingeben.");                                                                         //'back' um das Menü zu verlassen
                                Console.WriteLine("---------------------------------------------------------------------------------------");
                                string rechner_eingabe = Console.ReadLine();

                                if (rechner_eingabe == "1" | rechner_eingabe == "2" | rechner_eingabe == "3")
                                {
                                    int rechner_zahl_eingabe = int.Parse(rechner_eingabe);                               //Eingabe gleich Zahl
                                    switch (rechner_zahl_eingabe)
                                    {
                                        case 1:
                                            Console.Clear();
                                            //Gravitationskraft zwischen zwei Massen 
                                            Grafitation_2Massen_Rechner();               //Verweis
                                            break;

                                        case 2:
                                            Console.Clear();
                                            //Gewichtskraft auf der Erdoberfläche
                                            Gewichtskraft_Rechner();                    //Verweis
                                            break;

                                        case 3:
                                            Console.Clear();
                                            //Gewicht auf unterschiedlichen Planeten
                                            Anziehungskraft_Rechner();                  //Verweis
                                            bool abfrage_schleife = false;
                                            do
                                            {
                                                abfrage_schleife = false;
                                                Console.WriteLine("-----------------------------------------------------------------");
                                                Console.WriteLine("Wie wollen Sie fortfahren?\n" +
                                                    "[1] Rechnung wiederholen\n" +
                                                    "[2] Zurück ins Untermenü Rechner");
                                                string abfrage_rechnung = Console.ReadLine();
                                                if (abfrage_rechnung == "1" | abfrage_rechnung == "2")
                                                {
                                                    int int_abfrage_rechnung;
                                                    int.TryParse(abfrage_rechnung, out int_abfrage_rechnung);
                                                    if (int_abfrage_rechnung == 1)
                                                    {
                                                        Anziehungskraft_Rechner();
                                                        abfrage_schleife|= true;
                                                    }
                                                    else if (int_abfrage_rechnung == 2)
                                                    {
                                                        //Schleife wird durchbrochen
                                                    }
                                                }
                                                else if (abfrage_rechnung == "subexit")
                                                {
                                                    //Ins Untermenü Gravitation zurück
                                                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                                    Feature_6();
                                                }
                                                else if (abfrage_rechnung == "exit")
                                                {
                                                    Programmbeendet();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Falsche Eingabe\n" +
                                                        "Bitte erneut Versuchen...");
                                                    Console.ReadKey();
                                                    abfrage_schleife = true;
                                                }
                                            } while (abfrage_schleife);
                                            break;
                                    }
                                }
                                else if (rechner_eingabe == "back" | rechner_eingabe == "subexit")
                                {
                                    //Zurück ins Untermenü Gravitation!
                                    Console.WriteLine("Sie werden ins Untermenü Gravitation weitergeleitet.\n" +
                                        "Tschüss");
                                    exit_untermenü_ReUNDIn = true;
                                    Console.ReadKey();
                                }
                                else if (rechner_eingabe == "exit")
                                {
                                    Programmbeendet();                  //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                }
                                else
                                {
                                    //Falsche Eingabe, weil nicht 1, 2, 3 oder back!!!
                                    Console.WriteLine($"Das geht so leider nicht, {rechner_eingabe} ist keine gültige Eingabe.\n" +
                                        $"Bitte versuchen Sie es erneut.");
                                    Console.ReadKey();
                                }
                            } while (!exit_untermenü_ReUNDIn);
                            break;
                    }
                }
                else if (eingabe_1 == "back")                                                //Back wird in dem Fall genommen, um das Programm zu verallgemeinern.
                {
                    //Zurück ins Untermenü PH
                    Console.WriteLine("Ich hoffe es hat ihnen gefallen.\n" +
                        "Tschüss");
                    exit_gravitation = true;
                    Console.ReadKey();
                }
                else if (eingabe_1 == "exit")
                {
                    Programmbeendet();                  //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                }
                else if (eingabe_1 == "subexit")
                {
                    //Das ist hier noch nicht möglich, erneute Eingabeaufforderung
                    Console.WriteLine("'subexit' bring ihnen hier nichts, da Sie sich schon im Untermenü Gravitation befinden :)\n" +
                        "Um fortfahren zu können, geben Sie eine der Angegebenen Zahlen an.");
                    Console.ReadKey();
                }
                else
                {
                    //Erneute Eingabeaufforderung, wegen falscher Eingabe
                    Console.WriteLine("Eingabe: '" + eingabe_1 + "'");
                    Console.WriteLine("Falsche Eingabe erkannt.\n" +
                        "Bitte eine der Angegebenen Zahlen eingeben um fortfahren zu können.");
                    Console.ReadKey();
                }
            } while (!exit_gravitation);
        }

        //Rechnung 1
        internal static void Grafitation_2Massen_Rechner()
        {
            //Gravitationskraft zwischen zwei Massen
            bool schleife = true;
            do
            {
                schleife = true;
                bool back = false;
                Console.Clear();
                Console.WriteLine("\t1. Gravitationskraft zwischen zwei Massen\n\n");

                Console.WriteLine("Um diese Rechnung hier durchführen zu können, brauchen Sie die Informationen, zu den Gewichten der Zwei Massen und den Abstand, \n" +
                    "den Sie zueinander haben. Wenn Sie diese Infos nicht besitzen, dann können Sie mit 'back' zurück ins Untermenü des Rechners.\n");

                Console.Write("Wenn Sie die Angaben haben und fortfahren können, dann geben Sie 'weiter' ein: ");
                string eingabe = Console.ReadLine();
                if (eingabe == "back")
                {
                    //Zurück zum Untermenü Rechner:
                }
                else if (eingabe == "weiter")
                {
                    //Weiter zur Rechnung:
                    bool b_m1 = true;
                    bool b_m2 = true;
                    bool b_r = true;
                    do
                    {
                        b_m1 = true;
                        Console.Clear();
                        Console.WriteLine("Nun können wir starten.\n");

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
                        Console.Write("Geben Sie zuerst das Gewicht der ersten Masse in Kilogramm an: ");
                        string m1 = Console.ReadLine();
                        double d_m1;
                        Console.WriteLine("");
                        if (double.TryParse(m1, out d_m1))
                        {
                            b_m2 = true;
                            do
                            {
                                Console.Write("Nun geben Sie das Gewicht der zweiten Masse in Kilogramm an: ");
                                string m2 = Console.ReadLine();
                                double d_m2;
                                Console.WriteLine("");
                                if (double.TryParse(m2, out d_m2))
                                {
                                    do
                                    {
                                        Console.Write("Jetzt nur noch den Abstand in Metern und dann kanns losgehen: ");
                                        string r = Console.ReadLine();
                                        double d_r;
                                        Console.WriteLine("");
                                        if (double.TryParse(r, out d_r))
                                        {
                                            //Die eigentliche Rechnung, wenn alle Angaben stimmen!!!
                                            b_r = true;
                                            double G = 6.674e-11;                                   // Gravitationskonstante in N*(m/kg)^2

                                            double F = G * d_m1 * d_m2 / (d_r * d_r);               // Berechnung der Gravitationskraft in N

                                            //Ausgabe des Ergebnis:
                                            Console.WriteLine($"Die Gravitationskraft zwischen den Massen {m1} kg und {m2} kg bei einem Abstand von {r} m beträgt {F} N (Newton).\n\n");

                                            bool b_abfrage = true;                                  //Für die Abfrage
                                            do
                                            {
                                                b_abfrage = true;
                                                Console.WriteLine("Wie wollen Sie jetzt fortfahren?\n" +
                                                "\t1) Zurück ins Untermenü Rechner\n" +
                                                "\t2) Weitere Rechnungen hier ausführen\n");

                                                Console.WriteLine("----------------------------------------");
                                                string abfrage = Console.ReadLine();
                                                if (abfrage == "1" | abfrage == "2")
                                                {
                                                    int i_abfrage;
                                                    int.TryParse(abfrage, out i_abfrage);
                                                    if (i_abfrage == 1)
                                                    {
                                                        //Zurück ins Untermenü Rechner
                                                    }
                                                    else if (i_abfrage == 2)
                                                    {
                                                        //Weitere Rechnungen ausführen!
                                                        Grafitation_2Massen_Rechner();
                                                    }
                                                    else
                                                    {
                                                        //Erneute Eingabeaufforderung:
                                                        b_abfrage = false;
                                                        Console.WriteLine("'" + i_abfrage + "' ist keine gültige Zahl.\n" +
                                                            "Versuchen Sie es erneut, mit den Zahlen 1 oder 2");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                else if (abfrage == "subexit")
                                                {
                                                    //Ins Untermenü Gravitation zurück
                                                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                                    Feature_6();
                                                }
                                                else if (abfrage == "exit")
                                                {
                                                    Programmbeendet();
                                                    b_abfrage = false;                      //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                                }
                                                else
                                                {
                                                    //Erneute Eingabeaufforderung:
                                                    b_abfrage = false;
                                                    Console.WriteLine("'" + abfrage + "' ist eine falsche Eingabe...\n" +
                                                            "Versuchen Sie es erneut, mit den Zahlen 1 und 2");
                                                    Console.ReadKey();
                                                }
                                            } while (!b_abfrage);
                                        }
                                        else if (r == "subexit")
                                        {
                                            //Ins Untermenü Gravitation zurück
                                            Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                            Feature_6();
                                        }
                                        else if (r == "exit")
                                        {
                                            Programmbeendet();
                                            b_r = false;                //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                        }
                                        else
                                        {
                                            b_r = false;
                                            Console.WriteLine("Eingabe: '" + r + "'");
                                            Console.WriteLine("Das geht so leider nicht, geben Sie bitte eine gültige Zahl ein...");
                                            Console.ReadKey();
                                        }

                                    } while (!b_r);
                                }
                                else if (m2 == "subexit")
                                {
                                    //Ins Untermenü Gravitation zurück
                                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                    Feature_6();
                                }
                                else if (m2 == "exit")
                                {
                                    Programmbeendet();
                                    b_m2 = false;                   //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                }
                                else
                                {
                                    b_m2 = false;
                                    Console.WriteLine("Eingabe: '" + m2 + "'");
                                    Console.WriteLine("Das geht so leider nicht, geben Sie bitte eine gültige Zahl ein...");
                                    Console.ReadKey();
                                }
                            } while (!b_m2);
                        }
                        else if (m1 == "subexit")
                        {
                            //Ins Untermenü Gravitation zurück
                            Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                            Feature_6();
                        }
                        else if (m1 == "exit")
                        {
                            Programmbeendet();
                            b_m1 = false;                   //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                        }
                        else
                        {
                            b_m1 = false;
                            Console.WriteLine("Eingabe: '" + m1 + "'");
                            Console.WriteLine("Das geht so leider nicht, geben Sie bitte eine gültige Zahl ein...");
                            Console.ReadKey();
                        }
                    } while (!b_m1);
                }
                else if (eingabe == "subexit")
                {
                    //Ins Untermenü Gravitation zurück
                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                    Feature_6();
                }
                else if (eingabe == "exit")
                {
                    Programmbeendet();
                    schleife = false;                       //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                }
                else
                {
                    //Falsche Eingabe, erneute Eingabeaufforderung:
                    schleife = false;
                    Console.WriteLine("Das war nicht korrekt '" + eingabe + "' ist nicht gültig.\nVersuchen Sie es nocheinmal...");
                    Console.ReadKey();
                }
            } while (!schleife);
        }

        //Rechnung 2
        internal static void Gewichtskraft_Rechner()
        {
            bool schleife = true;
            do
            {
                schleife = true;
                //Gewichtskraft auf der Erdoberfläche
                Console.Clear();
                Console.WriteLine("2. Gewichtskraft auf der Erdoberfläche\n");

                Console.WriteLine("Hier können Sie die Gewichtskraft in Newton ausrechnen. Um dies zu tun müssen Sie einfach nur hier unten das Gewicht eintragen.\n" +
                    "Wenn Sie wieder zurück ins Untermenü Rechner möchten, dann geben Sie 'back' ein.\n");

                Console.Write("Gewicht: ");
                string gewicht = Console.ReadLine();
                double d_gewicht;
                if (double.TryParse(gewicht, out d_gewicht))
                {
                    bool schleife_exit = true;
                    do
                    {
                        //Rechnung durchführen
                        schleife_exit = true;

                        double erdbeschleunigung = 9.81;                                    // Erdbeschleunigung in m/s^2

                        double gewichtskraft = d_gewicht * erdbeschleunigung;               //Rechnung

                        Console.WriteLine($"Die Gewichtskraft beträgt {gewichtskraft} N(Newton).");
                        Console.ReadKey();

                        Console.WriteLine("Wenn Sie wollen, können Sie jetzt noch die Gewichtskraft auf anderen Planeten in unserem Sonnensystem errechnen.");
                        Console.WriteLine("\t1) Gewichtskraft auf anderen Planeten im Sonnensystem\n" +
                            "\t2) Zurück ins Untermenü Rechner");
                        string eingabe = Console.ReadLine();
                        if (eingabe == "1" | eingabe == "2")
                        {
                            int i_eingabe;
                            int.TryParse(eingabe, out i_eingabe);
                            if (i_eingabe == 1)
                            {
                                //Rechnung mit Planeten aus dem Sonnensystem:
                                bool Sonnensystem_schleife = true;
                                do
                                {
                                    Sonnensystem_schleife = true;
                                    Console.Clear();
                                    Console.WriteLine("\t1) Gewichtskraft auf anderen Planeten im Sonnensystem\n");

                                Sonnensystem_PlanetenListe();
                                Console.WriteLine("");
                                Console.WriteLine("Wählen Sie einen Planeten aus, mit dem Sie rechnen wollen.");
                                string planet1 = Console.ReadLine();
                                if (planet1 == "1" | planet1 == "2" | planet1 == "3" | planet1 == "4" | planet1 == "5" | planet1 == "6" | planet1 == "7" | planet1 == "8" | planet1 == "9" | planet1 == "10")
                                {
                                    int i_planet1;
                                    double planetbeschleunigung;
                                    double s_gewichtskraft1;
                                    int.TryParse(planet1, out i_planet1);
                                    switch (i_planet1)
                                    {
                                        case 1:
                                            //Sonne 247
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 247;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf der Sonne, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            //Merkur 3.7
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 3.7;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Merkur, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 3:
                                            //Venus 8.87
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 8.87;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf der Venus, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 4:
                                            //Mond 1.62
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 1.62;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Mond, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 5:
                                            //Mars 3.721
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 3.721;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Mars, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 6:
                                            //Jupiter 24.79
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 24.79;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Jupiter, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 7:
                                            //Saturn 10.44
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 10.44;   
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Saturn, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 8:
                                            //Uranus 8.87
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 8.87;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Planeten Uranus beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 9:
                                            //Neptun 11.15
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 11.15;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Planeten Neptun beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;

                                        case 10:
                                            //Pluto 0.62
                                            Console.WriteLine($"Ihr Planet ist die Nr.{i_planet1}");
                                            planetbeschleunigung = 0.62;
                                            s_gewichtskraft1 = d_gewicht * planetbeschleunigung;               //Rechnung
                                            Console.WriteLine($"Die Gewichtskraft, auf dem Zwergplaneten Pluto, beträgt {s_gewichtskraft1} N(Newton).");
                                            Console.ReadKey();
                                            break;
                                    }
                                    bool unterabfrage_schleife;
                                    do
                                    {
                                        unterabfrage_schleife = true;
                                        Console.WriteLine("Wie wollen Sie jetzt fortfahren?");
                                        Console.WriteLine("\t1. Zurück zum Anfang der Rechnung\n" +
                                        "\t2. Mit einem anderen Planeten rechnen\n" +
                                        "\t3. Zurück zum Untermenü Rechner\n");

                                            Console.WriteLine("---------------------------------------------------------------");
                                            string unterabfrage_eingabe = Console.ReadLine();


                                            if (unterabfrage_eingabe == "1" | unterabfrage_eingabe == "2" | unterabfrage_eingabe == "3")
                                            {
                                                int i_unterabfrage_eingabe;
                                                int.TryParse(unterabfrage_eingabe, out i_unterabfrage_eingabe);
                                                if (i_unterabfrage_eingabe == 1)
                                                {
                                                    //Zurück zum Anfang der Rechnung:
                                                    Gewichtskraft_Rechner();
                                                }
                                                else if (i_unterabfrage_eingabe == 2)
                                                {
                                                    //Mit einem anderen Planeten rechnen
                                                    Sonnensystem_schleife = false;
                                                }
                                                else if (i_unterabfrage_eingabe == 3)
                                                {
                                                    //Zurück zum Untermenü Rechner:
                                                }
                                                else
                                                {
                                                    //Falsche Eingabe, weil nicht 1, 2 oder 3. Erneute Eingabeaufforderung:
                                                    unterabfrage_schleife = false;
                                                    Console.WriteLine($"Eingabe: '{i_unterabfrage_eingabe}'\n" +
                                                    $"Das hat nicht geklappt, bitte nocheinmal Versuchen...");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (unterabfrage_eingabe == "subexit")
                                            {
                                                //Ins Untermenü Gravitation zurück
                                                Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                                Feature_6();
                                            }
                                            else if (unterabfrage_eingabe == "exit")
                                            {
                                                Programmbeendet();
                                                unterabfrage_schleife = false;              //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                            }
                                            else
                                            {
                                                //Falsche Eingabe, erneute Eingabeaufforderung:
                                                unterabfrage_schleife = false;
                                                Console.WriteLine($"Eingabe: '{unterabfrage_eingabe}'\n" +
                                                    $"Das hat nicht geklappt, bitte nocheinmal Versuchen...");
                                                Console.ReadKey();
                                            }
                                        } while (!unterabfrage_schleife);
                                    }
                                    else if (planet1 == "subexit")
                                    {
                                        //Ins Untermenü Gravitation zurück
                                        Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                        Feature_6();
                                    }
                                    else if (planet1 == "exit")
                                    {
                                        Programmbeendet();
                                        Sonnensystem_schleife = false;      //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                                    }
                                    else
                                    {
                                        //Falsche Eingabe, erneute Eingabeaufforderung:
                                        Sonnensystem_schleife = false;
                                        Console.WriteLine($"Eingabe: '{planet1}'\n" +
                                            $"Das hat nicht geklappt, bitte nocheinmal Versuchen...");
                                        Console.ReadKey();
                                    }
                                } while (!Sonnensystem_schleife);
                            }
                            else if (i_eingabe == 2)
                            {
                                //Zurück ins Untermenü Rechner:
                            }
                            else
                            {
                                //Falsche EIngabe, erneute Eingabeaufforderung:
                                schleife = false;
                                Console.WriteLine("Falsche Eingabe, '" + i_eingabe + "' ist nicht gültig.\n" +
                                    "Versuchen Sie es bitte erneut.");
                                Console.ReadKey();
                            }
                        }
                        else if (eingabe == "subexit")
                        {
                            //Ins Untermenü Gravitation zurück
                            Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                            Feature_6();
                        }
                        else if (eingabe == "exit")
                        {
                            Programmbeendet();
                            schleife_exit = false;                      //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                        }
                        else
                        {
                            //Falsche Eingabe, weil nicht 1 oder 2. Erneute Eingabeaufforderung:
                            schleife = false;
                            Console.WriteLine("Falsche Eingabe, '" + eingabe + "' ist nicht gültig.\n" +
                                "Bitte erneut Versuchen.");
                            Console.ReadKey();
                        }
                    } while (!schleife_exit);
                }
                else if (gewicht == "back")
                {
                    //Zurück ins Untermenü Rechner
                }
                else if (gewicht == "subexit")
                {
                    //Ins Untermenü Gravitation zurück
                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                    Feature_6();
                }
                else if (gewicht == "exit")
                {
                    Programmbeendet();
                    schleife = false;                               //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                }
                else
                {
                    //Falsche Eingabe, erneute Eingabeaufforderung:
                    schleife = false;
                    Console.WriteLine("Eingabe: '" + gewicht + "'\n" +
                        "Diese Eingabe ist falsch, versuchen Sie es erneut...");
                    Console.ReadKey();
                }
            } while (!schleife);
        }

        //Rechnung 3
        internal static void Anziehungskraft_Rechner()
        {
            bool schleife = true;
            do
            {
                schleife = true;
                //Gewicht auf unterschiedlichen Planeten
                Console.Clear();
                Console.WriteLine("3. Gewicht auf unterschiedlichen Planeten\n");

                Console.WriteLine("Hier können Sie ausrechnen, wie schwer Sie auf unterschiedlichen Planeten in unserem Sonnensystem wären.\n" +
                    "Wählen Sie einfach nur einen der Planeten aus und geben Sie ihr Gewicht an und finden Sie es heraus :)\n");

                Sonnensystem_PlanetenListe();

                Console.Write("Wählen Sie nun einen Planeten aus: ");                                   //Planet wird gewählt
                string planet = Console.ReadLine();
                if (planet == "1" | planet == "2" | planet == "3" | planet == "4" | planet == "5" | planet == "6" | planet == "7" | planet == "8" | planet == "9" | planet == "10")     //Überprüfung ob planet gleich Zahl ist
                {
                    double Erdgewicht, Planetgrafitation, Planetgewicht;
                    int i_planet = int.Parse(planet);
                    switch (i_planet)
                    {
                        case 1:
                            //Sonne 274 m/s²
                            Planetgrafitation = 274;
                            Console.WriteLine("Gewichtausrechnung auf der Sonne\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 2:
                            //Merkur 3,7 m/s²
                            Planetgrafitation = 3.7;
                            Console.WriteLine("Gewichtausrechnung auf dem Merkur\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 3:
                            //Venus 8,87 m/s² 
                            Planetgrafitation = 8.87;
                            Console.WriteLine("Gewichtausrechnung auf der Venus\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 4:
                            //Mond  1,62 m/s²
                            Planetgrafitation = 1.62;
                            Console.WriteLine("Gewichtausrechnung auf dem Mond\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 5:
                            //Mars 3,721 m/s²
                            Planetgrafitation = 3.721;
                            Console.WriteLine("Gewichtausrechnung auf dem Mars\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 6:
                            //Jupiter 24,79 m/s²
                            Planetgrafitation = 24.79;
                            Console.WriteLine("Gewichtausrechnung auf dem Jupiter\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 7:
                            //Saturn 10,44 m/s²
                            Planetgrafitation = 10.44;
                            Console.WriteLine("Gewichtausrechnung auf dem Saturn\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 8:
                            //Uranus 8,87 m/s²
                            Planetgrafitation = 8.87;
                            Console.WriteLine("Gewichtausrechnung auf dem Uranus\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 9:
                            //Neptun 11,15 m/s² 
                            Planetgrafitation = 11.15;
                            Console.WriteLine("Gewichtausrechnung auf dem Neptun\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;

                        case 10:
                            //Pluto 0,62 m/s²
                            Planetgrafitation = 0.62;
                            Console.WriteLine("Gewichtausrechnung auf dem Pluto\n");

                            Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");                                // Gewicht der Person auf der Erde abfragen
                            Erdgewicht = double.Parse(Console.ReadLine());

                            Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;                                                // Berechnung des Gewichts auf dem Planeten

                            Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");             // Ergebnis ausgeben
                            Console.ReadKey();
                            break;
                    }
                }
                else if (planet == "subexit")
                {
                    //Ins Untermenü Gravitation zurück
                    Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                    Feature_6();
                }
                else if (planet == "exit")
                {
                    Programmbeendet();
                    schleife = false;                           //Um nach abbruch des Programmbeendens, wieder beim gleichen Eingabepunkt zu sein.
                }
                else
                {
                    //Falsche Eingabe, erneute Eingabeaufforderung
                    Console.WriteLine("Falsche Eingabe.\n" +
                        "" + planet + " ist keine gültige Eingabe.\n" +
                        "Versuchen Sie es bitte nocheinmal.");
                    schleife = false;
                    Console.ReadKey();
                }
            } while (!schleife);
        }

        //Tabelle mit Planeten im Sonnensystem:
        internal static void Sonnensystem_PlanetenListe()
        {
            Console.WriteLine("Referenz: Erde = 1\n");
            Console.Write("Tabelle: ");
            Console.WriteLine($"{"----------------------------------",35}");
            Console.WriteLine($"{"--   Planeten im Sonnensystem:  --",44}");
            Console.WriteLine($"{"----------------------------------",44}");
            Console.WriteLine($"{"-- 1. Sonne       |     247     --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 2. Merkur      |     0,37    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 3. Venus       |     0,90    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 4. Mond        |     0,16    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 5. Mars        |     0,38    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 6. Jupiter     |     2,53    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 7. Saturn      |     1,07    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 8. Uranus      |     0,91    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"-- 9. Neptun      |     1,14    --",44}");
            Console.WriteLine($"{"--                |             --",44}");
            Console.WriteLine($"{"--10. Pluto       |     0,68    --",44}");
            Console.WriteLine($"{"----------------------------------\n",45}");
        }

        //Eingabe des Benutzers == 'exit'
        internal static void Programmbeendet()
        {
            //Wird jedes mal ausgeführt, wenn die Eingabe des Nutzers 'exit' entspricht.
            bool schleife = true;
            do
            {
                schleife = true;
                Console.WriteLine("Wollen Sie das Programm wirklich beenden?\n" +
                                    "Ja             \tj\n" +
                                    "Nein           \tn");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("");
                string eingabe = Console.ReadLine();
                if (eingabe == "j")
                {
                    //Programm wird beendet
                    Console.WriteLine("Das Programm wurde erfolgreich beendet.");
                    Environment.Exit(0);
                }
                else if (eingabe == "n")
                {
                    //Beenden des Programms wurde abgebrochen.
                }
                else
                {
                    //Erneute Eingaberaufforderung wegen falscher Eingabe
                    schleife = false;
                    Console.WriteLine("'" + eingabe + "' ist eine falsche Eingabe.\n" +
                        "Erneute Eingabe erforderlich.");
                }
            } while (!schleife);
        }
    }
}
