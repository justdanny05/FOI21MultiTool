using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHKlassenBibliothek
{
    internal class Feature8
    {
        internal static void Feature_8()
        {
                Console.Clear();
                // Schallgeschwindigkeit in Metern pro Sekunde bei Raumtemperatur
                const double soundSpeed = 343.2;

                // Begrüßungsnachricht
                Console.WriteLine("Willkommen zum Schallausbreitungsrechner!");

                // Abstand von der Schallquelle in Metern
                Console.Write("Bitte geben Sie die Entfernung von der Schallquelle in Metern ein: ");
                double distance = ReadDoubleInput();

                // Lautstärke der Schallquelle in Dezibel
                Console.Write("Bitte geben Sie die Lautstärke der Schallquelle in Dezibel ein: ");
                double soundLevel = ReadDoubleInput();

                // Berechnung der Schallintensität in Watt pro Quadratmeter
                double soundIntensity = Math.Pow(10, soundLevel / 10) * 1e-12;

                // Berechnung der Zeit, die der Schall benötigt, um die Entfernung zu überwinden
                double propagationTime = distance / soundSpeed;

                // Berechnung des Schalldrucks in Pascal
                double soundPressure = Math.Sqrt(soundIntensity / (4 * Math.PI));

                // Berechnung des Schalldruckpegels in Dezibel
                double soundPressureLevel = 20 * Math.Log10(soundPressure / 2e-5);

                // Ausgabe der berechneten Werte
                Console.WriteLine(" ");
                Console.WriteLine("Ergebnisse:");
                Console.WriteLine("Schall benötigt {0:0.##} Sekunden, um eine Entfernung von {1} Metern zu überwinden.", propagationTime, distance);
                Console.WriteLine("Schallintensität: {0} W/m^2", soundIntensity);
                Console.WriteLine("Schalldruckpegel: {0} dB", soundPressureLevel);

                // Warten auf Benutzerinput
                Console.WriteLine(" ");
                Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
                Console.ReadKey();
            }

            // Eine Methode, die eine Gleitkommazahl vom Benutzer einliest und sicherstellt, dass sie gültig ist
            static double ReadDoubleInput()
            {
                double value;
                while (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Gleitkommazahl ein:");
                }
                return value;
            }
        }
    }
