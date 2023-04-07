using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    internal class Feature24
    {
        internal static void Feature_24()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bitte wählen Sie eine Option aus:");
                Console.WriteLine("1) Abstand zwischen zwei Punkten berechnen");
                Console.WriteLine("2) Mittelpunkt einer Strecke berechnen");
                Console.WriteLine("3) Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("~~~~~--Abstand zwischen zwei Punkten auf einer Ebene berechnen.--~~~~~\n");

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
                }
                else if (input == "2")
                {
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
                }
                else if (input == "3")
                {
                    Console.WriteLine("Das Programm wird beendet...");
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte wählen Sie eine gültige Option aus.");
                    Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                    Console.ReadKey();
                }
            }

            Console.ResetColor();
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
