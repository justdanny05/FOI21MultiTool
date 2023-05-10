using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature18
    {
        internal static void Feature_18()
        {


            bool Exit = false;


            do
            {

                Console.WriteLine("\n\n          >>Zinnsrechner<<");//10 rechts

                Console.WriteLine("\n\n     Was möchtest du berechnen?\n");

                Console.WriteLine("1 = Startkapital");
                Console.WriteLine("2 = Zinssatz");
                Console.WriteLine("3 = Laufzeit");
                Console.WriteLine("4 = Endkapital");
                Console.WriteLine("subexit");
                Console.WriteLine("exit");






                string Auswahl;

                Auswahl = Console.ReadLine().ToLower();

                switch (Auswahl)

                {
                    case "1":
                        Console.Clear();
                        double zinsatz1, endkapital1, laufzeit1;

                        Console.WriteLine("Gib den Zinssatz in Prozent ein: ");
                        zinsatz1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib das Endkapital ein: ");
                        endkapital1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib die Laufzeit in Jahren ein: ");
                        laufzeit1 = double.Parse(Console.ReadLine());

                        double startkapital1 = endkapital1 / Math.Pow(1 + (zinsatz1 / 100), laufzeit1);

                        Console.WriteLine("Das Startkapital beträgt: " + startkapital1);
                        break;


                    case "2":
                        Console.Clear();
                        double startkapital2, endkapital2, laufzeit2;
                        
                        Console.WriteLine("Gib das Startkapital ein: ");
                        startkapital2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib das Endkapital ein: ");
                        endkapital2= double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib die Laufzeit in Jahren ein: ");
                        laufzeit2= double.Parse(Console.ReadLine());

                        double zinssatz2 = Math.Pow(endkapital2 / startkapital2, 1.0 / laufzeit2) - 1;

                        Console.WriteLine("Der Zinssatz beträgt " + (zinssatz2) + " %");

                        break;


                    case "3":
                        Console.Clear();
                        double startkapital3, zinssatz3, endkapital3;

                        Console.WriteLine("Gib das Startkapital ein: ");
                        startkapital3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib den Zinssatz in prozent ein: ");
                        zinssatz3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Gib das Endkapital ein: ");
                        endkapital3 = double.Parse(Console.ReadLine());



                        break;


                    case "4":
                        Console.Clear();
                        Console.WriteLine();
                        break;


                    case "subexit":
                        Exit = true;
                        Console.Clear();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Falsche eingabe");
                        break;
                }

            } while (!Exit);
        }
    }
}
