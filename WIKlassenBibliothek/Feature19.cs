using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature19
    {
        internal static void Feature_19()
        {
            bool repeatProgrm = true;
            while (repeatProgrm)
            {

                Console.WriteLine($"{"---Amortisationsrechner---"}");
                Console.WriteLine("");

                string fixkosten;
                int fixkosten_int;

                string variablekosten;
                int variablekosten_int;

                string preis;
                int preis_int;

                bool isNumeric = false;
                bool repeatProgram = true;

                do
                {
                    Console.WriteLine("Bitte geben Sie Ihre Fixkosten ein: ");
                    fixkosten = Console.ReadLine();
                    isNumeric = int.TryParse(fixkosten, out fixkosten_int);
                    if (!isNumeric)
                    {
                        Console.WriteLine("Die Eingabe war ungültig. Bitte geben Sie Ihre Fixkosten nochmal ein:");
                        Console.ReadKey();
                       
                    }
                } while (!isNumeric);

                do
                {
                    Console.WriteLine("Bitte geben Sie Ihre Variable Kosten ein: ");
                    variablekosten = Console.ReadLine();
                    isNumeric = int.TryParse(variablekosten, out variablekosten_int);

                    if (!isNumeric)
                    {
                        Console.WriteLine("Die Eingabe war ungültig. \nBitte geben Sie Ihre Variable kosten noch mal ein:");
                    }

                } while (!isNumeric);

                do
                {
                    
                    Console.WriteLine("Bitte geben Sie Ihre Preis ein: ");
                    preis = Console.ReadLine();
                    isNumeric = int.TryParse(preis, out preis_int);

                    if (!isNumeric)
                    {
                        Console.WriteLine("Die Eingabe war ungültig. \nBitte geben Sie Ihre Preis nochmal ein:");
                    }
                } while (!isNumeric);

                

                double menge = fixkosten_int + (variablekosten_int / preis_int);

                Console.WriteLine();
                Console.WriteLine($"Die Menge beträgt: {menge}");




            }
        }
    }

}
