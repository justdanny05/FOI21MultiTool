using System;
using System.Collections.Generic;
using System.Globalization;
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

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Amortisationsrechner <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine($"{"Mit diesem Programm können sie berechnen, wie viel sie im Monat verkaufen müssen damit sie keine verlust machen.\n"}");

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
                        Console.WriteLine("Die Eingabe war ungültig.Bitte geben Sie Ihre Fixkosten nochmal ein:\n");
                        Console.ReadKey();
                       
                    }
                } while (!isNumeric);

                do
                {
                    Console.WriteLine("Bitte geben Sie Ihre Variable Kosten ein:\n");
                    variablekosten = Console.ReadLine();
                    isNumeric = int.TryParse(variablekosten, out variablekosten_int);

                    if (!isNumeric)
                    {
                        Console.WriteLine("Die Eingabe war ungültig.Bitte geben Sie Ihre Variable kosten noch mal ein:\n");
                        Console.ReadKey();
                    }

                } while (!isNumeric);

                do
                {
                    
                    Console.WriteLine("Bitte geben Sie Ihre Preis ein:\n");
                    preis = Console.ReadLine();
                    isNumeric = int.TryParse(preis, out preis_int);

                    if (!isNumeric)
                    {
                        Console.WriteLine("Die Eingabe war ungültig.Bitte geben Sie Ihre Preis nochmal ein:\n");
                        Console.ReadKey();
                    }
                } while (!isNumeric);

                

                double menge = fixkosten_int + (variablekosten_int / preis_int);

                Console.WriteLine($"Die Menge die verkauft werden muss beträgt: {menge}\n");

                Console.WriteLine("Wollen Sie das Programm wiederholen? (Ja = 1 / Nein = 2)\n");
                int antwort_int = Convert.ToInt16(Console.ReadLine());

                if (antwort_int == 1) 
                    {
                    Console.WriteLine("Das Programm wird Wiederholt.\n");
                    repeatProgrm = true;
                    
                    }  
                else if (antwort_int == 2)
                    {

                    repeatProgrm = false;
                    
                    }




            }
        }
    }

}
