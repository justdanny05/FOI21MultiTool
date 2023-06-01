using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETKlassenBibliothek
{
    internal class Feature2
    {

            internal static void Feature_2()
            {
                namespace SpannungsfallBerechnen
    {
        class Program
        {
            static void Main(string[] args)
            {
                double spannung, strom, laenge, querschnitt, widerstand;
                string material;

                Console.WriteLine("Bitte geben Sie die Spannung in Volt ein:");
                spannung = double.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie den Strom in Ampere ein:");
                strom = double.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie das Material des Leiters ein:");
                material = Console.ReadLine();

                Console.WriteLine("Bitte geben Sie die Länge des Leiters in Metern ein:");
                laenge = double.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie den Querschnitt des Leiters in Quadratmillimetern ein:");
                querschnitt = double.Parse(Console.ReadLine());

                switch (material.ToLower())
                {
                    case "blei":
                        widerstand = 0.208;
                        break;
                    case "zinn":
                        widerstand = 0.11;
                        break;
                    case "platin":
                        widerstand = 0.106;
                        break;
                    case "eisen":
                        widerstand = 0.1;
                        break;
                    case "gold":
                        widerstand = 0.022;
                        break;
                    case "silber":
                        widerstand = 0.0167;
                        break;
                    case "kupfer":
                        widerstand = 0.0175;
                        break;
                    case "aluminium":
                        widerstand = 0.028;
                        break;
                    default:
                        Console.WriteLine("Ungültiges Material");
                        return;
                }

                double spannungsfall = widerstand * strom * laenge / (querschnitt / 1000);
                Console.WriteLine("Der Spannungsfall beträgt: " + spannungsfall.ToString("0.##") + " Volt");
            }
        }
    }
    //Diese Ausgabe hilft Ihnen zu erkennen ob der Aufruf funktioniert.
}

        
