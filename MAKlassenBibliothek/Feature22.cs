using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    internal class Feature22
    {
        internal static void Feature_22 ()
        {
            Console.WriteLine("Test Feature 22");

            bool weiterSpielen = true;
            int punkte = 0;
            int gesamtFragen = 0;
            int punkteWert = 1;
            int schwierigkeitsgrad = 1;

            while (weiterSpielen)
            {

                Console.WriteLine("Math QueZZee ");
                Console.Write($"Geben Sie den Schwierigkeitsgrad ein (1-5, {schwierigkeitsgrad} ist aktuell ausgewählt): ");
                int eingabeSchwierigkeitsgrad = int.Parse(Console.ReadLine());

                if (eingabeSchwierigkeitsgrad < 1 || eingabeSchwierigkeitsgrad > 5)
                {
                    Console.WriteLine("Ungültiger Schwierigkeitsgrad. Bitte geben Sie eine Zahl zwischen 1 und 5 ein.");
                    continue;
                }

                schwierigkeitsgrad = eingabeSchwierigkeitsgrad;

                Random zufall = new Random();

                int anzahlOperanden = zufall.Next(schwierigkeitsgrad + 1, schwierigkeitsgrad + 4);
                int[] operanden = new int[anzahlOperanden];

                for (int i = 0; i < anzahlOperanden; i++)
                {
                    operanden[i] = zufall.Next(1, schwierigkeitsgrad * 5 + 1);
                }

                int anzahlOperatoren = anzahlOperanden - 1;
                char[] operatoren = new char[anzahlOperatoren];

                for (int i = 0; i < anzahlOperatoren; i++)
                {
                    int operatorIndex = zufall.Next(0, 4);

                    switch (operatorIndex)
                    {
                        case 0:
                            operatoren[i] = '+';
                            break;
                        case 1:
                            operatoren[i] = '-';
                            break;
                        case 2:
                            operatoren[i] = '*';
                            break;
                        case 3:
                            operatoren[i] = '/';
                            break;
                    }
                }

                string ausdruck = "";

                for (int i = 0; i < anzahlOperanden; i++)
                {
                    ausdruck += operanden[i].ToString();

                    if (i < anzahlOperatoren)
                    {
                        ausdruck += operatoren[i].ToString();
                    }
                }

                Console.Write($"Was ist {ausdruck}? ");
                int antwort = int.Parse(Console.ReadLine());

                int ergebnis = operanden[0];

                for (int i = 0; i < anzahlOperatoren; i++)
                {
                    switch (operatoren[i])
                    {
                        case '+':
                            ergebnis += operanden[i + 1];
                            break;
                        case '-':
                            ergebnis -= operanden[i + 1];
                            break;
                        case '*':
                            ergebnis *= operanden[i + 1];
                            break;
                        case '/':
                            ergebnis /= operanden[i + 1];
                            break;
                    }
                }

                if (antwort == ergebnis)
                {
                    Console.WriteLine("Richtig!");
                    punkte += punkteWert;
                }
                else
                {
                    Console.WriteLine($"Falsch!. Die richtige Antwort ist {ergebnis}.");
                }

                gesamtFragen++;
                punkteWert += 2;

                Console.WriteLine($"Aktueller Punktestand: {punkte}");
                Console.WriteLine($"Gesamte Fragen: {gesamtFragen}");


            }
        }
    }
}
