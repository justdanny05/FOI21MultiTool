using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHKlassenBibliothek
{
    internal class Feature6
    {
        internal static void Feature_6()
        {
            bool exit = false;
            do
            {
                bool back = false;
                    Console.Clear();
                    Console.Title = "Gravitation\n";

                    Console.WriteLine("Das ist der Themenbereich Gravitation und ihre Kräfte.\n" +
                        "Hier können Sie lernen und oder Rechnungen aus diesem Themenbereich durchführen lassen.\n" +
                        "Viel Spaß:)\n\n");

                    Console.WriteLine("Um zurück ins Untermenü Physik zu kommen geben Sie 'exit' ein.\n");

                    Console.WriteLine("Wie wollen Sie fortfahren?");
                    Console.WriteLine("1. Informationen");                                                          //Untermenü Gravitation
                    Console.WriteLine("2. Rechner");
                    Console.WriteLine("exit. Zurück zum Untermenü Physik\n");

                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("Geben Sie eine der angegebenen Zahlen an");

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

                                    Console.WriteLine("Wenn Sie doch lieber den Rechner benutzen wollen dann geben Sie 'back' ein.\n");

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
                                                Console.WriteLine("Hier ist die Anziehungskraft der verschiedenen Planeten des Sonnensystems aufgelistet, " +
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

                                                Console.WriteLine("Wenn Sie jetzt noch wissen wollen, wieviel Sie Wiegen würden, wenn Sie auf einem dieser Planeten auf einer Waage stehen würden," +
                                                                  " dann tippen Sie die eins und wenn Sie zurück ins Untermenü Info wollen, dann geben Sie die zwei ein.");
                                                Console.WriteLine("1) Zum Rechner\n2) Zurück zum Untermenü Informationen\n");

                                                Console.WriteLine("--------------------------------------");
                                                string info2 = Console.ReadLine();

                                                if (info2 == "1" | info2 == "2")
                                                {
                                                    int irechner = int.Parse(info2);
                                                    switch (irechner)
                                                    {
                                                        case 1:
                                                            //Zum Rechner
                                                            Console.Clear();
                                                            Anziehungskraft_Rechner();
                                                            break;

                                                        case 2:
                                                            //Zurück zum Untermenü Information
                                                            break;

                                                    }
                                                }
                                                else
                                                {
                                                    //Erneute Eingabeaufforderung, wenn Eingabe nicht 1 oder 2 entspricht.
                                                    Console.Clear();
                                                    Console.WriteLine("Um fortzufahren bitte eine der zwei Zahlen eingeben...");
                                                    Console.WriteLine($"Ihre Eingabe: {info2}");
                                                    Console.ReadKey();
                                                }

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
                                        Console.WriteLine("Sie kehren ins Untermenü Gravitation zurück.");
                                        back = true;
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        //Erneute Eingabeaufforderung, wegen falscher eingabe
                                        Console.WriteLine($"Falsche Eingabe...\n" +
                                            $"{case1} ist keine korrekte Eingabe, versuchen Sie es mit den vorgegebenen Zahlen nocheinmal.");
                                        Console.ReadKey();
                                    }
                                } while (!back);
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
                                        "müssen Sie einfach 'back' eingeben.");                                                                         //'back' um das Menü zu verlassen
                                    Console.WriteLine("---------------------------------------------------------------------------------------");
                                    string r_eingabe = Console.ReadLine();

                                    if (r_eingabe == "1" | r_eingabe == "2" | r_eingabe == "3")
                                    {
                                        int rzahl_eingabe = int.Parse(r_eingabe);               //Eingabe gleich Zahl
                                        bool r_leave = true;
                                        switch (rzahl_eingabe)
                                        {
                                            case 1:
                                                //Gravitationskraft zwischen zwei Massen 
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("1. Gravitationskraft zwischen zwei Massen\n");


                                                } while (!r_leave);
                                                break;

                                            case 2:
                                                //Gewichtskraft auf der Erdoberfläche 
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("2. Gewichtskraft auf der Erdoberfläche\n");

                                                } while (!r_leave);
                                                break;

                                            case 3:
                                                //Gewicht auf unterschiedlichen Planeten
                                                break;
                                        }
                                    }
                                    else if (r_eingabe == "back")
                                    {
                                        //Zurück ins Untermenü Gravitation!
                                        Console.WriteLine("Sie werden ins Untermenü Gravitation weitergeleitet...\n" +
                                            "Tschüss");
                                        back = true;
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        //Falsche Eingabe, weil nicht 1, 2, 3 oder back!!!
                                        Console.WriteLine($"Das geht so leider nicht, {r_eingabe} ist keine gültige Eingabe.\n" +
                                            $"Bitte versuchen Sie es erneut...");
                                        Console.ReadKey();
                                    }
                                } while (!back);
                                break;
                        }

                    }
                    else if (eingabe_1 == "exit")
                    {
                        //Zurück ins Untermenü PH
                        Console.WriteLine("Ich hoffe es hat ihnen gefallen\n" +
                            "Tschüss");
                        exit = true;
                        Console.ReadKey();
                    }

                    else
                    {
                        //Erneute Eingabeaufforderung, wegen falscher Eingabe
                        Console.WriteLine("Falsche Eingabe erkannt.\nBitte eine der Angegebenen Zahlen eingeben um fortfahren zu können\n");
                        Console.ReadKey();
                    }

            } while (!exit);
        }
        internal static void Anziehungskraft_Rechner()
        {
        //Gewicht auf unterschiedlichen Planeten
                Console.Clear();
                Console.WriteLine("3. Gewicht auf unterschiedlichen Planeten\n");

                Console.WriteLine("Hier können Sie ausrechnen, wie schwer Sie auf unterschiedlichen Planeten in unserem Sonnensystem wären.\n" +
                    "Wählen Sie einfach nur einen der Planeten aus und geben Sie ihr Gewicht an und finden Sie es heraus :)\n");

                Console.Write("Tabelle: ");
                Console.WriteLine($"{"----------------------------------",35}");
                Console.WriteLine($"{"--   Planeten im Sonnensystem:  --",44}");
                Console.WriteLine($"{"----------------------------------",44}");
                Console.WriteLine($"{"-- 1. Sonne                     --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 2. Merkur                    --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 3. Venus                     --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 4. Mond                      --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 5. Mars                      --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 6. Jupiter                   --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 7. Saturn                    --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 8. Uranus                    --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"-- 9. Neptun                    --",44}");
                Console.WriteLine($"{"--                              --",44}");
                Console.WriteLine($"{"--10. Pluto                     --",44}");
                Console.WriteLine($"{"----------------------------------\n",44}");

                Console.Write("Wählen Sie einen Planeten aus: ");                                   //Planet wird gewählt
                string planet = Console.ReadLine();
                double gewicht = Convert.ToDouble(Console.ReadLine());
                if (planet == "1" | planet == "2" | planet == "3" | planet == "4" | planet == "5" | planet == "6" | planet == "7" | planet == "8" | planet == "9" | planet == "10")
                {
                double Erdgewicht, Planetgrafitation, Planetgewicht;
                    int i_planet = int.Parse(planet);
                    switch (i_planet)
                    {
                        case 1:
                        //Sonne 274 m/s²
                        Planetgrafitation = 274;
                        Console.WriteLine("Gewichtausrechnung auf der Sonne\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 2:
                        //Merkur 3,7 m/s²
                        Planetgrafitation = 3.7;
                        Console.WriteLine("Gewichtausrechnung auf dem Merkur\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 3:
                        //Venus 8,87 m/s² 
                        Planetgrafitation = 8.87;
                        Console.WriteLine("Gewichtausrechnung auf der Venus\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 4:
                        //Mond  1,62 m/s²
                        Planetgrafitation = 1.62;
                        Console.WriteLine("Gewichtausrechnung auf dem Mond\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 5:
                        //Mars 3,721 m/s²
                        Planetgrafitation = 3.721;
                        Console.WriteLine("Gewichtausrechnung auf dem Mars\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 6:
                        //Jupiter 24,79 m/s²
                        Planetgrafitation = 24.79;
                        Console.WriteLine("Gewichtausrechnung auf dem Jupiter\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 7:
                        //Saturn 10,44 m/s²
                        Planetgrafitation = 10.44;
                        Console.WriteLine("Gewichtausrechnung auf dem Saturn\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 8:
                        //Uranus 8,87 m/s²
                        Planetgrafitation = 8.87;
                        Console.WriteLine("Gewichtausrechnung auf dem Uranus\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 9:
                        //Neptun 11,15 m/s² 
                        Planetgrafitation = 11.15;
                        Console.WriteLine("Gewichtausrechnung auf dem Neptun\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;

                        case 10:
                        //Pluto 0,62 m/s²
                        Planetgrafitation = 0.62;
                        Console.WriteLine("Gewichtausrechnung auf dem Pluto\n");
                        // Gewicht der Person auf der Erde abfragen
                        Console.Write("Geben Sie Ihr Gewicht auf der Erde in Kilogramm ein: ");
                        Erdgewicht = double.Parse(Console.ReadLine());
                        // Berechnung des Gewichts auf dem Planeten
                        Planetgewicht = Erdgewicht * Planetgrafitation / 9.81;
                        // Ergebnis ausgeben
                        Console.WriteLine($"Ihr Gewicht auf diesem Planeten ist {Planetgewicht:F2} Kilogramm.");
                        Console.ReadKey();
                        break;
                    }
                }
        }
    }
}
