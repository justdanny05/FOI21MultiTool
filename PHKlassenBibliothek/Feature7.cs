using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHKlassenBibliothek
{
    internal class Feature7
    {
        internal static void Feature_7()
        {
            {
                int choice = 0;

                while (choice != 3)
                {
                    Console.WriteLine("Menü");
                    Console.WriteLine("====");
                    Console.WriteLine("1.informationen");
                    Console.WriteLine("2.rechnung");
                    Console.WriteLine("3. Beenden");

                    Console.Write("Wählen Sie eine Option: ");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Lichtbrechung findet statt, wenn Licht auf eine Grenzfläche, also den Übergang von einem Medium wie Luft in ein anderes, wie Wasser, auftrifft. Hierbei wird ein Teil des Lichtes reflektiert, während ein weiterer Teil beim Durchgang der Grenzfläche seine Richtung verändert. Die Ausnahme stellen senkrecht auf die Grenzfläche auftreffende Lichtstrahlen dar. Diese werden nicht gebrochen.\r\nBei bestimmten Einfallswinkeln des Lichts kommt es auch zu einer sogenannten Totalreflexion. Das heißt, jegliches Licht wird reflektiert ohne dass eine Brechung stattfindet.");
                        Console.WriteLine("Die Sinuswerte von Einfalls - und Brechungswinkel, sin\alpha und sin\beta, stehen im gleichen Verhältnis zueinander wie c1 und c2.Die Formelzeichen c1 und c2 sind die Geschwindigkeiten des in den jeweiligen Materialien 1 und 2.Breitet sich das Licht vor der Brechung im Vakuum oder der Luft aus, so ergibt sich aus dem Winkelverhältnis eine materialabhängige Konstante, die absolute Brechzahl n.n =\frac{ sin\alpha){ sin\beta}");
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Bitte wählen Sie ein optisches Medium:");
                        Console.WriteLine("1 - Luft");
                        Console.WriteLine("2 - Wasser");
                        Console.WriteLine("3 - Glas");

                        int mediumAuswahl = int.Parse(Console.ReadLine());

                        double n1, n2;

                        switch (mediumAuswahl)
                        {
                            case 1:
                                n1 = 1.0003;
                                Console.WriteLine("Sie haben Luft ausgewählt.");
                                break;
                            case 2:
                                n1 = 1.333;
                                Console.WriteLine("Sie haben Wasser ausgewählt.");
                                break;
                            case 3:
                                n1 = 1.52;
                                Console.WriteLine("Sie haben Glas ausgewählt.");
                                break;
                            default:
                                Console.WriteLine("Ungültige Auswahl.");
                                return;
                        }

                        Console.Write("Einfallswinkel in Grad: ");
                        double theta1 = double.Parse(Console.ReadLine());

                        // Überprüfung auf gültige Eingaben des Brechungsindex des zweiten Mediums
                        while (true)
                        {
                            Console.Write("Brechungsindex des zweiten Mediums: ");
                            if (double.TryParse(Console.ReadLine(), out n2))
                            {
                                break;
                            }
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }

                        double radTheta1 = theta1 * Math.PI / 180.0;

                        double theta2 = Math.Asin(n1 * Math.Sin(radTheta1) / n2);

                        double degTheta2 = theta2 * 180.0 / Math.PI;

                        // Runden der Ausgabe auf eine Ganzzahl
                        int ausfallswinkel = (int)Math.Round(degTheta2);
                        Console.Write("Ausfallswinkel: " + ausfallswinkel + " Grad");

                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Das Programm wird beendet.");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Option von 1 bis 3.");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
