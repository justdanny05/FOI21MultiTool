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

        private string[] namenswert;
        private double[] zahlenwert;
        private bool wiederholen;

        private double kalkulatorischeAbschreibung;
        private double kalkulatorischeZinsen;
        private double kalkulatoricheMiete;
        private double versicherungskosten;
        private double wartungskosten;
        private double lohnkosten;
        private double werkzeugkosten;

        public void Run()
        {
            Console.WriteLine();
           
            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("Wirtschaft"));
            //Konsolentitel wird geändert.
            Console.Title = "Kostenvergleichsrechnung";
         
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>>Kostenvergleichsrechnung<<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eingabe: exit\t        ->\tbeendet das Programm");
            Console.WriteLine("Eingabe: subexit\t->\tbeendet das Submenu");

            //Beschreibung der Software
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nHerzlich willkommen zu Ihrem neuen Feature!\n\n" +
                "Wir freuen uns, Ihnen mitteilen zu können, dass unser C#-Programm nun ein neues Tool für\n" +
                "die Kostenvergleichsrechnung bietet. Mit diesem Feature können Sie als Unternehmen nun\n" +
                "einfach und effektiv die Gesamtkosten pro Jahr berechnen, indem sowohl fixe als auch\n" +
                "variable Kosten berücksichtigt werden.\n\n" +
                "Dieses Feature löst das Problem der Kostenvergleichsrechnung und ermöglicht es Ihnen,\n" +
                "Ihre Rentabilität zu bewerten und fundierte Entscheidungen zu treffen. Die Berechnungen\n" +
                "werden anhand Ihrer Eingaben durchgeführt, was die Benutzung noch einfacher und\n" +
                "zeitsparender macht.\n\n" +
                "Wir sind davon überzeugt, dass Sie mit diesem neuen Feature Ihre Finanzen noch besser im\n" +
                "Blick behalten können und somit noch erfolgreicher in Ihrem Unternehmen agieren werden.\n\n" +
                "Viel Erfolg!\n");

            namenswert = new string[12] {
                    "Anschaffungswert (Euro): ",
                    "nutzungsdauer (Jahr): ",
                    "Restwert (Euro): ",
                    "Zinssatz Alternativanlage (Prozent): ",
                    "Platzbedarf (mq): ",
                    "OrtsüblicheMonatsmiete (Euro/qm): ",
                    "max. Produktionskapatität (Stück/Jahr): ",
                    "geplante Auslastung (Stück/Jahr): ",
                    "Versicherungskosten (Euro/Jahr): ",
                    "Wartungskosten (Euro/Jahr): ",
                    "Lohnkosten (Euro/Stück): ",
                    "Werkzeugkosten: "};

            zahlenwert = new double[12];
            wiederholen = true;
            string eingabe = "";

            while (wiederholen)
            {
                Console.WriteLine("Füllen Sie bitte aus");
                Console.WriteLine("__________________________________________", Console.ForegroundColor = ConsoleColor.Gray, Console.BackgroundColor = ConsoleColor.Gray);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;

                for (int i = 0; i < namenswert.Length; i++)
                {
                    Console.Write(namenswert[i].PadRight(42)+"|");
                    
                    do
                    {
                        
                        try
                        {
                            eingabe = Console.ReadLine();
                            zahlenwert[i] = double.Parse(eingabe);

                        }
                        catch (System.FormatException e)
                        {
                            if (eingabe == "exit")
                            {
                                Environment.Exit(0);
                            }
                            else if(eingabe == "subexit")
                            {
                                Console.Clear();
                                return;

                            }

                            (int, int) cPosBM = Console.GetCursorPosition();
                            Console.Write("KEINE GANZE ZAHL");
                            Console.ReadKey();

                            (int, int) cPosAM = Console.GetCursorPosition();

                            KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                            continue;

                        }
                        
                        if (zahlenwert[i] < 0)
                        {
                            (int, int) cPosBM = Console.GetCursorPosition();
                            Console.WriteLine("DIE ZAHL MUSS GRÖßER ODER GLEICH 0 SEIN");
                            Console.ReadKey();

                            (int, int) cPosAM = Console.GetCursorPosition();

                            KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                            continue;
                        }
                        Console.WriteLine("------------------------------------------");
                        break;
                        

                    } while (true);
                }

                Formeln();
                Console.WriteLine("__________________________________________", Console.ForegroundColor = ConsoleColor.Gray, Console.BackgroundColor = ConsoleColor.Gray);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("kalkulatorische Abschreibung: ".PadRight(42) + "|" + kalkulatorischeAbschreibung);
                Console.WriteLine("kalkulatorische Zinsen: ".PadRight(42) + "|" + kalkulatorischeZinsen);
                Console.WriteLine("kalkulatorische Miete: ".PadRight(42) + "|" + kalkulatoricheMiete);
                Console.WriteLine("Lohnksten: ".PadRight(42) + "|" + lohnkosten);
                Console.WriteLine("Wekzeugkosten: ".PadRight(42) + "|" + werkzeugkosten);
                Console.WriteLine("__________________________________________", Console.ForegroundColor = ConsoleColor.Gray, Console.BackgroundColor = ConsoleColor.Gray);
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Gesamtkosten pro Jahr: ".PadRight(42) + "|" + GesamtkostenProJahr());
                
                Console.WriteLine("__________________________________________", Console.ForegroundColor = ConsoleColor.Gray, Console.BackgroundColor = ConsoleColor.Gray);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                bool repeat = true;

                while (repeat)
                {
                    Console.Write("Wollen Sie den Vorgang wiederholen? (J/N) ".PadRight(42) + "|");

                    string input = Console.ReadLine().ToUpper();

                    switch (input)
                    {
                        case "J":
                            Console.Clear();
                            Run();
                            break;

                        case "N":
                        case "EXIT":
                            Environment.Exit(0);
                            break;

                        case "SUBEXIT":
                            Console.Clear();
                            repeat = false;
                            break;

                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'J' oder 'N' ein.");
                            break;
                    }
                }


            }
            //Bei Subexit ohne anderen Code auszuführen hier hin.
        }

        private void Formeln()
        {
            // Fixe Kosten
            kalkulatorischeAbschreibung = (zahlenwert[0] - zahlenwert[2]) / zahlenwert[1];
            kalkulatorischeZinsen = (zahlenwert[0] + zahlenwert[2]) / 2 * zahlenwert[3] / 100;
            kalkulatoricheMiete = zahlenwert[4] * zahlenwert[5] * 12;
            versicherungskosten = zahlenwert[8];
            wartungskosten = zahlenwert[9];

            // Variable Kosten
            lohnkosten = zahlenwert[10] * zahlenwert[7];
            werkzeugkosten = zahlenwert[11] * zahlenwert[7];
        }

        private double GesamtkostenProJahr()
        {
            double gesamteFixkostenProJahr = kalkulatorischeAbschreibung + kalkulatorischeZinsen + kalkulatoricheMiete + versicherungskosten + wartungskosten;
            double gesamteVariableKostenProJahr = lohnkosten + werkzeugkosten;
            return gesamteFixkostenProJahr + gesamteVariableKostenProJahr;
        }

    }
}
