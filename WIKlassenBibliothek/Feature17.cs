using Figgle;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature17
    {
        internal static void Feature_17()
        {




            //-----------------------------------------------------------------------------
            //---------------------------Array Tabelle für Namen---------------------------
            //-----------------------------------------------------------------------------

            string[] namenswert = new string[12];

            namenswert[0] = "Anschaffungswert (Euro): ";
            namenswert[1] = "nutzungsdauer (Jahr): ";
            namenswert[2] = "Restwert (Euro): ";
            namenswert[3] = "Zinssatz Alternativanlage (Prozent): ";
            namenswert[4] = "Platzbedarf (mq): ";
            namenswert[5] = "OrtsüblicheMonatsmiete (Euro/qm): ";
            namenswert[6] = "max. Produktionskapatität (Stück/Jahr): ";
            namenswert[7] = "geplante Auslastung (Stück/Jahr): ";
            namenswert[8] = "Versicherungskosten (Euro/Jahr): ";
            namenswert[9] = "Wartungskosten (Euro/Jahr): ";
            namenswert[10] = "Lohnkosten (Euro/Stück): ";
            namenswert[11] = "Werkzeugkosten: ";

            //------------------------------------------------------------------------------
            //--------------------------Array Tabelle für Zahlen----------------------------
            //------------------------------------------------------------------------------
            double[] zahlenwert = new double[12];
            zahlenwert[0] = 0;
            zahlenwert[1] = 0;
            zahlenwert[2] = 0;
            zahlenwert[3] = 0;
            zahlenwert[4] = 0;
            zahlenwert[5] = 0;
            zahlenwert[6] = 0;
            zahlenwert[7] = 0;
            zahlenwert[8] = 0;
            zahlenwert[9] = 0;
            zahlenwert[10] = 0;
            zahlenwert[11] = 0;

            //-----------------------------------------------------------------------------

            bool wiederholen = true;
            bool flag = false;

            //Fixe Kosten------------------------------------------------------------------

            double kalkulatorischeAbschreibung = 0;
            double kalkulatorischeZinsen = 0;
            double kalkulatoricheMiete = 0;
            double versicherungskosten = 0;
            double wartungskosten = 0;

            double gesamteFixkostenProJahr = 0;

            //Variable Kosten-------------------------------------- -----------------------

            double lohnkosten = 0;
            double werkzeugkosten = 0;

            double gesamteVariableKostenProJahr = 0;

            double gesamtkostenProJahr = 0;

            //----------------------------------------------------------------------------


            while (wiederholen)
            {
                Console.WriteLine("Füllen Sie bitte aus\n");


                for (int i = 0; i < namenswert.Length; i++)
                {
                    Console.Write(namenswert[i]);

                    do
                    {
                        try
                        {
                            zahlenwert[i] = double.Parse(Console.ReadLine());
                            flag = true;

                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("KEINE GANZE ZAHL");
                            flag = false;
                        }

                        if (flag == true && zahlenwert[i] <= 0)
                        {
                            Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                            flag = false;
                        }
                    } while (flag == false);

                }

                //------------------------------------------------------------------------
                //                           RECHNUNGSWEGEN
                //------------------------------------------------------------------------

                //----------------------------Fixe Kosten--------------------------------- 

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Fixe Kosten\n");

                kalkulatorischeAbschreibung = (zahlenwert[0] - zahlenwert[2]) / zahlenwert[1];
                Console.WriteLine($"kalkuratorische Abschreibung: {kalkulatorischeAbschreibung}");

                kalkulatorischeZinsen = (zahlenwert[0] + zahlenwert[2]) / 2 * zahlenwert[3] / 100;
                Console.WriteLine($"kalkulatorische Zinsen: {kalkulatorischeZinsen}");

                kalkulatoricheMiete = zahlenwert[4] * zahlenwert[5] * 12;
                Console.WriteLine($"kalkulatorische Miete: {kalkulatoricheMiete}");

                versicherungskosten = zahlenwert[8];
                Console.WriteLine($"Versicherungskosten:{versicherungskosten}");

                wartungskosten = zahlenwert[9];
                Console.WriteLine($"Wartungskosten: {wartungskosten}\n");

                gesamteFixkostenProJahr = kalkulatorischeAbschreibung + kalkulatorischeZinsen + kalkulatoricheMiete + versicherungskosten + wartungskosten;
                Console.WriteLine($"gesamte Fixkosten pro Jahr: {gesamteFixkostenProJahr}\n");

                //---------------------------Vriable Kosten-------------------------------
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Variable Kosten\n");

                lohnkosten = zahlenwert[10] * zahlenwert[7];
                Console.WriteLine($"Lohnkosten: {lohnkosten}");

                werkzeugkosten = zahlenwert[11] * zahlenwert[7];
                Console.WriteLine($"Werkzeugkosten: {werkzeugkosten}");

                gesamteVariableKostenProJahr = lohnkosten + werkzeugkosten;
                Console.WriteLine($"gesamte Variable Kosten: {gesamteVariableKostenProJahr}\n");

                // Gesamtkosten
                gesamtkostenProJahr = gesamteFixkostenProJahr + gesamteVariableKostenProJahr;

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Gesamtkosten pro Jahr: {gesamtkostenProJahr}\n");

                Console.WriteLine("----------------------------------------------------------------");

                //-----------------------------------------------------------------------
                Console.Write("Möchten Sie das Programm beenden? (true/false)");
                bool beenden = Convert.ToBoolean(Console.ReadLine());

                if (beenden == true)
                {
                    wiederholen = false;
                }

                else
                {
                    wiederholen = true;
                }

            }









        }
    }
}

