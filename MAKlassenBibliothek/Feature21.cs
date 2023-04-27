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
                Console.WriteLine("Wilkommen im Funktionsrechner!\n" +
                              "Wählen Sie eine der folgenden Optionen:\n" +
                              "\t1 - Berechnet das Ergebnis einer Funktion\n" +
                              "\t2 - Berechnet den Wert von x einer Funktion\n" +
                              "\tExit - Verlässt das Feature");

                Console.Write("Eingabe:");
                string Eingabe = Console.ReadLine();

                Console.Clear();

                if (Eingabe == "1")
                {

                    Console.WriteLine("Geben Sie eine Funktion ein, das x beinhaltet:");
                    string function = Console.ReadLine();

                    Console.WriteLine("\nGeben Sie den Wert von X ein:");
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

                    Console.WriteLine("Geben Sie eine Funktion ein, das x beinhaltet:");
                    string function = Console.ReadLine();

                    Console.WriteLine("Geben sie das Ergebnis der Funktion ein:");
                    double solution = Convert.ToDouble(Console.ReadLine());

                    double x = SolveFunction(function, solution);

                    Console.WriteLine("x = " + x);

                    static double SolveFunction(string function, double solution)
                    {
                        double x = 0;

                        // Replace "x" in the function string with a placeholder value
                        function = function.Replace("x", "{0}");

                        // Evaluate the function for different values of x until the solution is found
                        for (double i = -1000; i <= 1000; i += 0.1)
                        {
                            double result = CalculateFunction(function, i);

                            if (Math.Abs(result - solution) < 0.1)
                            {
                                x = i;
                                break;
                            }
                        }

                        return x;
                    }

                    static double CalculateFunction(string function, double x)
                    {
                        double result = 0;

                        // Replace the placeholder value with the input value of x
                        function = string.Format(function, x);

                        // Evaluate the function using the built-in math functions
                        try
                        {
                            result = Convert.ToDouble(new System.Data.DataTable().Compute(function, ""));
                        }
                        catch
                        {

                        }

                        return result;
                    }
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
