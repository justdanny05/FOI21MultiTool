namespace MAKlassenBibliothek
{
    internal class Feature24
    {
        internal static void Feature_24()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Koordinatenbasierter Rechner\n");
                Console.WriteLine("Bitte wählen Sie eine Option aus:");
                Console.WriteLine("1) Abstand zwichen zwei Punkten berechnen");
                Console.WriteLine("2) Mittelpunkt einer Strecke berechnen");
                Console.WriteLine("3) Steigung zwischen zwei Punkten berechnen");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("4) Beenden\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                string Eingabe = Console.ReadLine();

                if (Eingabe == "1")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("~~~~~--Abstand zwischen zwei Punkten auf einer Ebene berechnen--~~~~~\n");

                    Console.WriteLine("Gib die Koordinaten von Punkt 1 ein (x1, y1):");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Gib die Koordinaten von Punkt 2 ein (x2, y2):");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());

                    double distance = CalculateDistance(x1, y1, x2, y2);
                    Console.WriteLine("Der Abstand zwischen den beiden Punkten beträgt {0}", distance);
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                    Console.Clear();


                }
                else if (Eingabe == "2")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("~~~~~--Berechnung des Mittelpunkts einer Strecke--~~~~~\n");
                    Console.WriteLine("Gib die Koordinaten von Punkt 1 ein (x1, y1):");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Gib die Koordinaten von Punkt 2 ein (x2, y2):");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    double midX = (x1 + x2) / 2;
                    double midY = (y1 + y2) / 2;

                    Console.WriteLine("Der Mittelpunkt der Strecke liegt bei ({0}, {1})", midX, midY);
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Eingabe == "3")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("~~~~~--Berechnung der Steigung zwischen zwei Punkten auf einer Ebene--~~~~~\n");
                    Console.WriteLine("Gib die Koordinaten von Punkt 1 ein (x1, y1):");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Gib die Koordinaten von Punkt 2 ein (x2, y2):");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());

                    if (x2 - x1 == 0)
                    {
                        Console.WriteLine("Die Steigung ist unendlich");
                    }
                    else
                    {
                        double steigung = (y2 - y1) / (x2 - x1);
                        Console.WriteLine("Die Steigung zwischen den beiden Punkten beträgt {0}", steigung);
                    }

                    Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Eingabe == "4")
                {
                    Console.WriteLine("Programm beendet");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;

                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine Option aus dem Menü aus.");
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            static double CalculateDistance(double x1, double y1, double x2, double y2)
            {
                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return distance;


            }
        }
    }
}
