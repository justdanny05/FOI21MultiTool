using Figgle;
using System;
using System.Collections.Generic;
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
            //---------------------------Array Tabelle für Zahlen--------------------------
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

            bool wiederholen = true;
            bool flag = false;
            double gesamtzahl = 0;

            while (wiederholen)
            {
                Console.WriteLine("Füllen Sie bitte aus\n");

                //------------------------------------------------------------------------
                //---------------------------Anschafungswert------------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[0]);
                do
                {
                    try
                    {
                        zahlenwert[0] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[0] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //---------------------------------------------------------------------------
                //---------------------------Nutzungsdauer-----------------------------------
                //---------------------------------------------------------------------------

                Console.Write(namenswert[1]);

                do
                {
                    try
                    {
                        zahlenwert[1] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[1] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //--------------------------------------------------------------------------
                //-----------------------------Restwert-------------------------------------
                //--------------------------------------------------------------------------

                Console.Write(namenswert[2]);

                do
                {
                    try
                    {
                        zahlenwert[2] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[2] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //---------------------Zinssatz Alternativanlage--------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[3]);

                do
                {
                    try
                    {
                        zahlenwert[3] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[3] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //------------------------------Platzbedarf-------------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[4]);

                do
                {
                    try
                    {
                        zahlenwert[4] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[4] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);
                //------------------------------------------------------------------------
                //-----------------------Ortsübliche Monatsmiete--------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[5]);

                do
                {
                    try
                    {
                        zahlenwert[5] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[5] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //----------------------max. Produktionskapatität-------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[6]);

                do
                {
                    try
                    {
                        zahlenwert[6] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[6] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //------------------------geplante Auslastung-----------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[7]);

                do
                {
                    try
                    {
                        zahlenwert[7] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[7] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //-------------------------Versicherungskosten----------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[8]);

                do
                {
                    try
                    {
                        zahlenwert[8] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[8] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //---------------------------Wartungskosten-------------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[9]);

                do
                {
                    try
                    {
                        zahlenwert[9] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[9] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //------------------------------Lohkosten---------------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[10]);

                do
                {
                    try
                    {
                        zahlenwert[10] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[10] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);



                //------------------------------------------------------------------------
                //---------------------------Werkzeugkosten-------------------------------
                //------------------------------------------------------------------------

                Console.Write(namenswert[11]);

                do
                {
                    try
                    {
                        zahlenwert[11] = double.Parse(Console.ReadLine());
                        flag = true;

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("KEINE GANZE ZAHL");
                        flag = false;
                    }

                    if (flag == true && zahlenwert[11] <= 0)
                    {
                        Console.WriteLine("DIE ZAHL MUSS GRÖßER ALS 0 SEIN");
                        flag = false;
                    }
                } while (flag == false);


                //------------------------------------------------------------------------

                gesamtzahl = zahlenwert[0] + zahlenwert[1];

                Console.WriteLine($"Gesamtzahl: {gesamtzahl}\n");

                //------------------------------------------------------------------------

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

