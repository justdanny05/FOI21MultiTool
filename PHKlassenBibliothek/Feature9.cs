using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHKlassenBibliothek
{
    internal class Feature9
    {
        internal static void Feature_9()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
_________                 ______           _____       _____________        ______      __________ 
__  ____/____________________  /____      ____(_)____________  /__(_)______ ___  /_________(_)_  /_
_  / __ _  _ \_  ___/  ___/_  __ \_ | /| / /_  /__  __ \  __  /__  /__  __ `/_  //_/  _ \_  /_  __/
/ /_/ / /  __/(__  )/ /__ _  / / /_ |/ |/ /_  / _  / / / /_/ / _  / _  /_/ /_  ,<  /  __/  / / /_  
\____/  \___//____/ \___/ /_/ /_/____/|__/ /_/  /_/ /_/\__,_/  /_/  _\__, / /_/|_| \___//_/  \__/  
                                                                    /____/                         ");



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║      Willkommen im Hauptmenü      ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║ Bitte wählen Sie eine             ║");
            Console.WriteLine("║ Option aus:                       ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║ 1. ⚙️ Berechnung                  ║");
            Console.WriteLine("║ 2. 📐 Messung                     ║");
            Console.WriteLine("║ 3. 📝 Merkhilfe Formel            ║");
            Console.WriteLine("║ 4. ℹ️ Informationen               ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║ Drücken Sie eine beliebige Taste, ║");
            Console.WriteLine("║ um fortzufahren...                ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("╚═══════════════════════════════════╝");

            Console.ReadKey();
            Console.Clear();

            int auswahl;
            while (true)
            {
                Console.WriteLine(@"
_________                 ______           _____       _____________        ______      __________ 
__  ____/____________________  /____      ____(_)____________  /__(_)______ ___  /_________(_)_  /_
_  / __ _  _ \_  ___/  ___/_  __ \_ | /| / /_  /__  __ \  __  /__  /__  __ `/_  //_/  _ \_  /_  __/
/ /_/ / /  __/(__  )/ /__ _  / / /_ |/ |/ /_  / _  / / / /_/ / _  / _  /_/ /_  ,<  /  __/  / / /_  
\____/  \___//____/ \___/ /_/ /_/____/|__/ /_/  /_/ /_/\__,_/  /_/  _\__, / /_/|_| \___//_/  \__/  
                                                                    /____/                         ");



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║      Willkommen im Hauptmenü      ║");
                Console.WriteLine("║                                   ║");
                Console.WriteLine("║                                   ║");
                Console.WriteLine("║ Bitte wählen Sie eine             ║");
                Console.WriteLine("║ Option aus:                       ║");
                Console.WriteLine("║                                   ║");
                Console.WriteLine("║ 1. ⚙️ Berechnung                  ║");
                Console.WriteLine("║ 2. 📐 Messung                     ║");
                Console.WriteLine("║ 3. 📝 Merkhilfe Formel            ║");
                Console.WriteLine("║ 4. ℹ️ Informationen               ║");
                Console.WriteLine("║                                   ║");
                Console.WriteLine("║ Geben Sie die Nummer der Option   ║");
                Console.WriteLine("║ ein und drücken Sie die Eingabe   ║");
                Console.WriteLine("║ Taste...                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                if (int.TryParse(Console.ReadLine(), out auswahl))
                {
                    switch (auswahl)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Sie haben Option ⚙️ 1 gewählt.");
                            while (true)
                            {
                                Console.Write("Gib die zurückgelegte Entfernung in Metern ein: ");
                                if (!double.TryParse(Console.ReadLine(), out distance))
                                {
                                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                                    continue;
                                }
                                break;
                            }

                            while (true)
                            {
                                Console.Write("Gib die Zeit in Sekunden ein: ");
                                if (!double.TryParse(Console.ReadLine(), out time))
                                {
                                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
                                    continue;
                                }
                                break;
                            }

                            Console.WriteLine("Möchtest du die Geschwindigkeit in:");
                            Console.WriteLine("1. Metern pro Sekunde");
                            Console.WriteLine("2. Kilometern pro Stunde");
                            Console.WriteLine("3. Meilen pro Stunde");

                            int option;
                            while (true)
                            {
                                if (!int.TryParse(Console.ReadLine(), out option))
                                {
                                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 3 ein.");
                                    continue;
                                }
                                if (option < 1 || option > 3)
                                {
                                    Console.WriteLine("Ungültige Option. Bitte wähle 1, 2 oder 3.");
                                    continue;
                                }
                                break;
                            }

                            double velocity;
                            switch (option)
                            {
                                case 1:
                                    velocity = distance / time;
                                    Console.WriteLine("Die Geschwindigkeit beträgt " + velocity + " m/s.");
                                    break;
                                case 2:
                                    velocity = distance / time * 3.6;
                                    Console.WriteLine("Die Geschwindigkeit beträgt " + velocity + " km/h.");
                                    break;
                                case 3:
                                    velocity = distance / time * 2.237;
                                    Console.WriteLine("Die Geschwindigkeit beträgt " + velocity + " mph.");
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Option.");
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Sie haben Option 📐 2 gewählt.");
                            Console.WriteLine("Bitte geben Sie die Strecke in Kilometern ein: ");
                            double distance = double.Parse(Console.ReadLine());

                            Console.WriteLine("Bitte geben Sie die Zeit in Stunden ein: ");
                            double time = double.Parse(Console.ReadLine());

                            double speed = distance / time;
                            Console.WriteLine("Die Geschwindigkeit beträgt: " + speed + " km/h");

                            if (speed < 30)
                            {
                                Console.WriteLine("🙂"); // lächelnder Smiley
                            }
                            else
                            {
                                Console.WriteLine("😕"); // trauriger Smiley
                            }

                            Console.WriteLine("Die Ausgabe lautet: ");

                            for (int i = 0; i < 10; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.WriteLine("🙂"); // lächelnder Smiley
                                }
                                else
                                {
                                    Console.WriteLine("😕"); // trauriger Smiley
                                }

                                Console.WriteLine(" " + speed + " km/h");
                            }

                            Console.WriteLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Sie haben Option 📝 3 gewählt.");

                            Console.WriteLine("              / \                 ");
                            Console.WriteLine("             /   \                ");
                            Console.WriteLine("            /     \               ");
                            Console.WriteLine("           /   s   \              ");
                            Console.WriteLine("          /         \             ");
                            Console.WriteLine("         /- - - - - -\            ");
                            Console.WriteLine("        /      |      \           ");
                            Console.WriteLine("       /       |       \          ");
                            Console.WriteLine("      /   v    |    t   \         ");
                            Console.WriteLine("     /         |         \        ");
                            Console.WriteLine("    /          |          \       ");
                            Console.WriteLine("    - - - - - - - - - - - -       ");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Das Geschwindigkeitsdreieck (s, v, t) ist ein Hilfsmittel zur Berechnung der Geschwindigkeit,");
                            Console.WriteLine("die ein Körper in einer bestimmten Zeit zurücklegt. Es ist besonders nützlich, wenn man die ");
                            Console.WriteLine("zurückgelegte Strecke s, die Zeit t und die Geschwindigkeit v des Körpers kennt ");
                            Console.WriteLine("oder bestimmen möchte.");
                            Console.WriteLine();
                            Console.WriteLine("Mit dem Geschwindigkeitsdreieck kann man verschiedene Größen berechnen, indem man");
                            Console.WriteLine("die entsprechenden Seiten des Dreiecks kennt und die passenden Formeln anwendet. Zum");
                            Console.WriteLine("Beispiel kann man die Geschwindigkeit v berechnen, wenn man die Strecke s und die ");
                            Console.WriteLine("Zeit t kennt, indem man die Formel v = s / t verwendet und die Strecke s als ");
                            Console.WriteLine("Kathete und die Zeit t als Hypotenuse des Dreiecks einzeichnet.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Hier einmal selbst ausprobieren:");

                            Console.WriteLine("Geschwindigkeitsdreieck-Rechner");
                            Console.WriteLine("Welche Größe möchtest du berechnen?");
                            Console.WriteLine("1 - Geschwindigkeit (v)");
                            Console.WriteLine("2 - Strecke (s)");
                            Console.WriteLine("3 - Zeit (t)");
                            int choice = int.Parse(Console.ReadLine());

                            double s, v, t, alpha;

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Strecke (s) in Metern: ");
                                    s = double.Parse(Console.ReadLine());
                                    Console.Write("Zeit (t) in Sekunden: ");
                                    t = double.Parse(Console.ReadLine());
                                    v = s / t;
                                    Console.WriteLine("Die Geschwindigkeit beträgt {0:F2} m/s", v);
                                    break;
                                case 2:
                                    Console.Write("Geschwindigkeit (v) in Metern pro Sekunde: ");
                                    v = double.Parse(Console.ReadLine());
                                    Console.Write("Zeit (t) in Sekunden: ");
                                    t = double.Parse(Console.ReadLine());
                                    s = v * t;
                                    Console.WriteLine("Die Strecke beträgt {0:F2} Meter", s);
                                    break;
                                case 3:
                                    Console.Write("Strecke (s) in Metern: ");
                                    s = double.Parse(Console.ReadLine());
                                    Console.Write("Geschwindigkeit (v) in Metern pro Sekunde: ");
                                    v = double.Parse(Console.ReadLine());
                                    alpha = Math.Acos(s / v);
                                    t = s / (v * Math.Cos(alpha));
                                    Console.WriteLine("Die Zeit beträgt {0:F2} Sekunden", t);
                                    break;
                                default:
                                    Console.WriteLine("Ungültige Auswahl");
                                    break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Sie haben Option ℹ️ 4 gewählt.");

                            Console.WriteLine();
                            Console.WriteLine("Geschwindigkeit ist ein physikalischer Begriff, der beschreibt, wie schnell sich ein Objekt");
                            Console.WriteLine("bewegt. Es wird in der Regel als die Veränderung der Entfernung pro Zeiteinheit definiert, ");
                            Console.WriteLine("gemessen in Kilometern pro Stunde (km/h) oder Metern pro Sekunde (m/s).");
                            Console.WriteLine();
                            Console.WriteLine("Es gibt verschiedene Arten von Geschwindigkeiten, wie zum Beispiel die lineare");
                            Console.WriteLine("Geschwindigkeit, die Winkelgeschwindigkeit und die Beschleunigung. Die lineare");
                            Console.WriteLine("Geschwindigkeit ist die Geschwindigkeit eines Objekts entlang einer geraden Linie, während");
                            Console.WriteLine("die Winkelgeschwindigkeit die Geschwindigkeit beschreibt, mit der sich ein Objekt um einen");
                            Console.WriteLine("bestimmten Punkt dreht. Die Beschleunigung beschreibt die Änderung der Geschwindigkeit");
                            Console.WriteLine("im Laufe der Zeit.");
                            Console.WriteLine();
                            Console.WriteLine("Die Geschwindigkeit kann durch verschiedene Faktoren beeinflusst werden, wie zum ");
                            Console.WriteLine("Beispiel die Masse des Objekts, die Kraft, die auf das Objekt ausgeübt wird, die Reibung und");
                            Console.WriteLine("die Luftwiderstand. Die Geschwindigkeit kann auch durch die Gravitation beeinflusst ");
                            Console.WriteLine("werden, wie zum Beispiel bei der Geschwindigkeit eines Objekts, das in der Nähe eines ");
                            Console.WriteLine("Schwarzen Lochs kreist.");
                            Console.WriteLine();
                            Console.WriteLine("In der Physik gibt es das Gesetz der Erhaltung der Energie, das besagt, dass die ");
                            Console.WriteLine("Gesamtenergie eines Systems immer erhalten bleibt. Das bedeutet, dass, wenn die ");
                            Console.WriteLine("Geschwindigkeit eines Objekts zunimmt, die Energie des Objekts auch zunimmt.");
                            Console.WriteLine();
                            Console.WriteLine("In der Technik und im Transportwesen spielt die Geschwindigkeit eine wichtige Rolle. So ");
                            Console.WriteLine("sind beispielsweise die Geschwindigkeiten von Fahrzeugen und Flugzeugen entscheidend ");
                            Console.WriteLine("für ihre Effizienz und ihre Leistung. In der Informationstechnologie wird die Geschwindigkeit ");
                            Console.WriteLine("von Prozessoren und Datenübertragungen oft als wichtige Kennzahl betrachtet.");
                            Console.WriteLine();
                            Console.WriteLine("In der Alltagssprache wird Geschwindigkeit oft als Synonym für Schnelligkeit verwendet. ");
                            Console.WriteLine("Hierbei geht es meist um die Geschwindigkeit von menschlichen Handlungen, wie zum ");
                            Console.WriteLine("Beispiel bei der Arbeit oder im Sport.");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Option zwischen 1 und 4.");
                            break;
                    }

                    Console.ReadKey();
        }
       
    }
}
