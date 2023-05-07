using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    internal class Feature22
    {
        internal static void Feature_22()
        {
            bool weiterSpielen = true;
            int punkte = 0;
            int gesamtFragen = 0;
            int schwierigkeitsgrad = 1;


            while (weiterSpielen)
            {
                Console.Clear();
                Console.WriteLine("=== Hauptmenü ===");
                Console.WriteLine("1. Spiel starten");
                Console.WriteLine("2. Beenden");
                Console.WriteLine($"{"Deine Punkte: "}{punkte}");
                Console.WriteLine("***************Info******************");
                Console.WriteLine("Wenn Sie Während des Spiels ;exit; eingeben, können Sie das Programm verlassen ");
                Console.Write("Bitte wählen Sie eine Option: ");
                string eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":

                        Console.Write($"Geben Sie den Schwierigkeitsgrad ein (1-5, {schwierigkeitsgrad} ist aktuell ausgewählt): ");
                        int eingabeSchwierigkeitsgrad = 0;
                        string Input = Console.ReadLine();
                        try
                        {
                            eingabeSchwierigkeitsgrad = int.Parse(Input);

                        }
                        catch (FormatException ex)
                        {
                            if (Input == "exit")
                            {

                                Console.WriteLine("Auf Wiedersehen!");
                                Console.ReadKey();
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Bitte exit oder Nummer schreiben ");
                                Console.ReadKey();
                                continue;
                            }

                        }

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
                        string eingabeAntwort = Console.ReadLine();

                        if (eingabeAntwort == "exit")
                        {

                            Console.WriteLine("Auf Wiedersehen!");
                            Console.ReadKey();
                            Console.Clear();
                            return;
                        }

                        int antword = 0;

                        try
                        {
                            antword = int.Parse(eingabeAntwort);
                        }
                        catch (FormatException ex)
                        {
                            if (eingabeAntwort == "exit")
                            {
                                Console.WriteLine("Auf Wiedersehen!");
                                Console.ReadKey();
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Bitte exit oder Nummer schreiben ");
                                Console.ReadKey();
                                continue;
                            }

                        }
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

                        if (antword == ergebnis)
                        {
                            Console.WriteLine("Richtig!");
                            punkte += 1;
                            gesamtFragen++;
                            punkte = +2;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"Falsch. Die richtige Antwort ist: {ergebnis}");
                            Console.ReadKey();



                        }

                        break;
                    case "2":
                        Console.WriteLine("Programm wird beendet...");
                        weiterSpielen = false;
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }
            }
        }
    }
}
