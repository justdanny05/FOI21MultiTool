using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIKlassenBibliothek
{
    internal class Feature18
    {
        internal static void Feature_18()
        {


            bool Exit = false;


            do
            {

                Console.WriteLine("\n\n          >>Zinnsrechner<<");//10 rechts

                Console.WriteLine("\n\n     Was möchtest du berechnen?\n");

                Console.WriteLine("1 = Startkapital");
                Console.WriteLine("2 = Zinssatz");
                Console.WriteLine("3 = Laufzeit");
                Console.WriteLine("4 = Endkapital");
                Console.WriteLine("subexit");
                Console.WriteLine("exit");






                string Auswahl;

                Auswahl = Console.ReadLine().ToLower();

                switch (Auswahl)

                {
                    case "1":
                        //Startkapital Berechnen
                        Console.Clear();
                        double zinsatz1 = 0;
                        double endkapital1 = 0;
                        double laufzeit1 = 0;

                        Console.WriteLine(">>STARTKAPITAL BERECHNEN<<\n\n");

                        //Zinssatz1
                        bool flag1z = true;
                        do
                        {
                            ; Console.WriteLine("Gib den Zinssatz in Prozent ein: ");
                            string ein1z = Console.ReadLine();

                            try
                            {
                                zinsatz1 = double.Parse(ein1z);
                                flag1z = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein1z == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag1z = true;
                                }
                            }
                        } while (flag1z);
                        //Endkapital1
                        bool flag1e = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Endkapital ein: ");
                            string ein1e = Console.ReadLine();

                            try
                            {
                                endkapital1 = double.Parse(ein1e);
                                flag1e = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein1e == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag1e = true;
                                }
                            }
                        } while (flag1e);
                        //Laufzeit1
                        bool flag1l = true;
                        do
                        {
                            ; Console.WriteLine("Gib die Laufzeit in Jahren ein: ");
                            string ein1l = Console.ReadLine();

                            try
                            {
                                laufzeit1 = double.Parse(ein1l);
                                flag1l = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein1l == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag1l = true;
                                }
                            }
                        } while (flag1l);

                        //Berechnung Startkapital
                        double startkapital1 = endkapital1 / Math.Pow(1 + (zinsatz1 / 100), laufzeit1);

                        double value1 = startkapital1;
                        Console.WriteLine("Das Startkapital beträgt: {0,5:#.###}", value1);

                        
                        break;


                    case "2":
                        //Zinssatz berechnen 
                        Console.Clear();
                        double startkapital2 = 0;
                        double endkapital2 = 0;
                        double laufzeit2 = 0;

                        Console.WriteLine(">>ZINSSATZ BERECHNEN<<\n\n");
                        //Startkapital2
                        bool flag2s = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Startkapital ein: ");
                            string ein2s = Console.ReadLine();

                            try
                            {
                                startkapital2 = double.Parse(ein2s);
                                flag2s = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein2s == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag2s = true;
                                }
                            }
                        } while (flag2s);


                        //Endkapital2
                        bool flag2e = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Endkapital ein: ");
                            string ein2e = Console.ReadLine();

                            try
                            {
                                endkapital2 = double.Parse(ein2e);
                                flag2e = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein2e == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag2e = true;
                                }
                            }
                        } while (flag2e);


                        //Laufzeit2
                        bool flag2l = true;
                        do
                        {
                            ; Console.WriteLine("Gib die Laufzeit in Jahren ein: ");
                            string ein2l = Console.ReadLine();

                            try
                            {
                                laufzeit2 = double.Parse(ein2l);
                                flag2l = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein2l == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag2l = true;
                                }
                            }
                        } while (flag2l);

                        //Berechnung Zinssatz
                        double zinssatz2 = 100 * Math.Pow(endkapital2 / startkapital2, (1 / laufzeit2)) - 100;
                        double value2 = zinssatz2;
                        Console.WriteLine("Das Startkapital beträgt: {0,5:#.###}%", value2);
                        

                        break;


                    case "3":
                        //Laufzeit Berechnen

                        Console.Clear();
                        double startkapital3 = 0;
                        double zinssatz3 = 0;
                        double endkapital3 = 0;
                        Console.WriteLine(">>LAUFZEIT BERECHNEN<<\n\n");

                        //Startkapital 3

                        bool flag3s = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Startkapital ein: ");
                            string ein3s = Console.ReadLine();

                            try
                            {
                                startkapital3 = double.Parse(ein3s);
                                flag3s = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein3s == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag3s = true;
                                }
                            }
                        } while (flag3s);

                        //Zinssatz 3
                        bool flag3z = true;
                        do
                        {
                            ; Console.WriteLine("Gib den Zinssatz in Prozent ein: ");
                            string ein3z = Console.ReadLine();

                            try
                            {
                                zinssatz3 = double.Parse(ein3z);
                                flag3z = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein3z == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag3z = true;
                                }
                            }
                        } while (flag3z);

                        //Endkapital 3

                        bool flag3e = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Endkapital ein: ");
                            string ein3e = Console.ReadLine();

                            try
                            {
                                endkapital3 = double.Parse(ein3e);
                                flag3e = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein3e == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag3e = true;
                                }
                            }
                        } while (flag3e);

                        //Berechnung Laufzeit
                        double laufzeit3 = Math.Log(endkapital3 / startkapital3, (1 + (zinssatz3 / 100)));
                        double value3 = laufzeit3;

                        Console.WriteLine("Die Laufzeit beträgt: {0,5:#.###} Jahre", value3);



                        break;


                    case "4":
                        //Endkapital Berechnen
                        Console.Clear();
                        double startkapital4 = 0;
                        double zinssatz4 = 0;
                        double laufzeit4 = 0;
                        Console.WriteLine(">>ENDKAPITAL BERECHNEN<<\n\n");

                        //startkapital 4
                        bool flag4s = true;
                        do
                        {
                            ; Console.WriteLine("Gib das Startkapital ein: ");
                            string ein4s = Console.ReadLine();

                            try
                            {
                                startkapital4 = double.Parse(ein4s);
                                flag4s = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein4s == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag4s = true;
                                }
                            }
                        } while (flag4s);

                        //Zinssatz 4
                        bool flag4z = true;
                        do
                        {
                            ; Console.WriteLine("Gib den Zinssatz in Prozent ein: ");
                            string ein4z = Console.ReadLine();

                            try
                            {
                                zinssatz4 = double.Parse(ein4z);
                                flag4z = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein4z == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag4z = true;
                                }
                            }
                        } while (flag4z);

                        //Laufzeit 4

                        bool flag4l = true;
                        do
                        {
                            ; Console.WriteLine("Gib die Laufzeit in Jahren ein: ");
                            string ein4l = Console.ReadLine();

                            try
                            {
                                laufzeit4 = double.Parse(ein4l);
                                flag4l = false;
                            }
                            catch (FormatException ex)
                            {

                                if (ein4l == "exit")
                                {

                                    Console.WriteLine("Auf Wiedersehn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe");
                                    Console.ReadKey();
                                    flag4l = true;
                                }
                            }
                        } while (flag4l);

                        //Berechnung Endkapital
                        double endkapital4 = startkapital4 * Math.Pow(1 + (zinssatz4 / 100), laufzeit4);
                        double value4 = endkapital4;
                        Console.WriteLine("Das Endkapital beträgt: {0,5:#.###}", value4);
                        
                        

                        break;


                    case "subexit":
                        Exit = true;
                        Console.Clear();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Falsche eingabe");
                        
                        break;
                }

            } while (!Exit);
        }
    }
}
