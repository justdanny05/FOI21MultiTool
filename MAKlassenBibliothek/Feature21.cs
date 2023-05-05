using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    internal class Feature21
    {
        internal static void Feature_21()
        {
            bool exit = false;

            do
            {
                Console.WriteLine("Willkommen im Funktionsrechner!\n" +
                              "Wählen Sie eine der folgenden Optionen:\n" +
                              "\t1 - Berechnet das Ergebnis einer Funktion\n" +
                              "\t2 - Berechnet den Wert von x einer linearen Funktion\n" +
                              "\tExit - Verlässt das Feature");

                Console.Write("Eingabe: ");
                string Eingabe = Console.ReadLine();

                Console.Clear();

                if (Eingabe == "1")
                {

                    Console.WriteLine("Geben Sie eine Funktion ein, das x beinhaltet:");
                    string function = Console.ReadLine();

                    Console.WriteLine("\nGeben Sie den Wert von x ein: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    double result = CalculateFunction(function, x);

                    Console.WriteLine("\nErgebnis: " + result);
                    Console.WriteLine("\n\nDrücken Sie eine beliebige Taste zum fortfahren");
                    Console.ReadKey();


                    static double CalculateFunction(string function, double x)
                    {
                        double result = 0;

                        // Replace "x" in the function string with the input value of x
                        function = function.Replace("x", x.ToString());

                        // Evaluate the function using the built-in math functions
                        try
                        {
                            result = Convert.ToDouble(new System.Data.DataTable().Compute(function, ""));
                        }
                        catch
                        {
                            Console.WriteLine("Ungültige Funktion!");
                        }

                        return result;
                    }

                }
                else if (Eingabe == "2")
                {

                    Console.WriteLine("Die Funktion, mit denen sie den Wert von x berechnen können, lautet f(x) = ax + b\n");
                    Console.Write("Geben sie die Steigung a an: ");
                    double a;
                    while (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Ungültige Eingabe, bitte geben sie eine gültige Zahl ein.");
                    }

                    Console.Write("Geben sie den y-Achsenabschnitt b an: ");
                    double b;
                    while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Ungültige Eingabe, bitte geben sie eine gültige Zahl ein.");
                    }

                    Console.Write("Geben sie die Lösung der Funktion an: ");
                    double fx;
                    while (!double.TryParse(Console.ReadLine(), out fx))
                    {
                        Console.WriteLine("Ungültige Eingabe, bitte geben sie eine gültige Zahl ein.");
                    }

                    // Calculate the value of x using the given linear function and fx
                    double x = (fx - b) / a;
                    Console.WriteLine($"Der Wert von x der Funktion {a}x + {b} = {fx} ist {x}");
                    Console.WriteLine("\n\nDrücken Sie eine beliebige Taste zum fortfahren");
                    Console.ReadKey();

                }
                else
                {
                    Console.Clear();
                    exit = true;
                }
                Console.Clear();

            } while(!exit);
            
        }
    }
}
