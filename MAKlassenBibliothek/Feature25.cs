using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    internal class Feature25
    {
        internal static void Feature_25()
        {

            bool exit = true;
            while (exit)
            {

                Console.WriteLine("Geometrische Formenberechnung");
                Console.WriteLine("----------------");
                Console.WriteLine(" 1. Rechteck");
                Console.WriteLine(" 2. Quadrat");
                Console.WriteLine(" 3. Kreis");
                Console.WriteLine(" 4. Dreieck");
                Console.WriteLine(" 5. Trapez");
                Console.WriteLine(" 6. Zylinder");
                Console.WriteLine(" 7. Parallelogramm");
                Console.WriteLine(" 8. Würfel");
                Console.WriteLine(" 9. Quader");
                Console.WriteLine("10. Dreiecks Prisma");
                Console.WriteLine("11. Quadratische Pyramide");
                Console.WriteLine("12. Kegel");
                Console.WriteLine("13. Kugel");
                Console.WriteLine("14. Programm beenden");

                Console.Write("Bitte wählen Sie eine Option (1-14): ");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Berechnung des Rechtecks");
                        Console.WriteLine("-----------------");
                        Console.Write("Breite des Rechtecks: ");
                        double rechteckBreite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Rechtecks: ");
                        double rechteckHoehe = Convert.ToDouble(Console.ReadLine());

                        double rechteckFlaeche = rechteckBreite * rechteckHoehe;
                        double rechteckUmfang = 2 * (rechteckBreite + rechteckHoehe);

                        Console.WriteLine($"{"Fläche des Rechtecks:"} {rechteckFlaeche}cm²");
                        Console.WriteLine($"{"Umfang des Rechtecks: "} {rechteckUmfang}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Berechnung des Quadrats ");
                        Console.WriteLine("------------------");
                        Console.Write("Seitenlänge des Quadrats: ");
                        double quadratSeite = Convert.ToDouble(Console.ReadLine());

                        double quadratFlaeche = quadratSeite * quadratSeite;
                        double quadratUmfang = 4 * quadratSeite;

                        Console.WriteLine($"{"Fläche des Quadrats: "} {quadratFlaeche}cm²");
                        Console.WriteLine($"{"Umfang des Quadrats: "}{quadratUmfang}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Berechnung des Kreises ");
                        Console.WriteLine("------------------");
                        Console.Write("Radius des Kreises: ");
                        double kreisRadius = Convert.ToDouble(Console.ReadLine());

                        double kreisFlaeche = Math.PI * kreisRadius * kreisRadius;
                        double kreisUmfang = 2 * Math.PI * kreisRadius;


                        Console.WriteLine($"{"Fläche des Kreises: "}{kreisFlaeche}cm²");
                        Console.WriteLine($"{"Umfang des Kreises: "}{kreisUmfang}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Berechnung des Dreiecks ");
                        Console.WriteLine("------------------");
                        Console.Write("Seite a des Dreiecks: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Seite b des Dreiecks: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Seite c (grundseite) des Dreiecks: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Dreiecks: ");
                        double hoehekreis = Convert.ToDouble(Console.ReadLine());

                        double dreieckUmfang = a + b + c;
                        double dreieckFlaeche = 0.5 * c * hoehekreis;

                        Console.WriteLine($"{"Flächeninhalt des Dreiecks: "}{dreieckFlaeche}cm²");
                        Console.WriteLine($"{"Umfang des Dreiecks: "}{dreieckUmfang}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:

                        Console.WriteLine("Berechnung des Trapezes");
                        Console.WriteLine("-------------------");
                        Console.Write("Länge der oberen Seite: ");
                        double oberseite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der unteren Seite: ");
                        double unterseite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Trapezes: ");
                        double hoehe = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der linken Seite: ");
                        double linkeSeite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der rechten Seite: ");
                        double rechteSeite = Convert.ToDouble(Console.ReadLine());

                        double flaechetrapez = 0.5 * (oberseite + unterseite) * hoehe;
                        double umfangtrapez = oberseite + unterseite + linkeSeite + rechteSeite;

                        Console.WriteLine($"{"Flächeninhalt des Trapezes: "}{flaechetrapez}cm²");
                        Console.WriteLine($"{"Umfang des Trapezes: "}{umfangtrapez}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 6:


                        Console.WriteLine("Berechnung des Zylinders");
                        Console.WriteLine("--------------------");
                        Console.Write("Radius des Zylinders: ");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Zylinders: ");
                        double hoehe_zylinder = Convert.ToDouble(Console.ReadLine());

                        double zylinderVolumen = Math.PI * radius * radius * hoehe_zylinder;
                        double zylinderMantelflaeche = 2 * Math.PI * radius * hoehe_zylinder;
                        double zylinderOberflaeche = 2 * Math.PI * radius * radius + zylinderMantelflaeche;

                        Console.WriteLine($"{"Volumen des Zylinders: "}{zylinderVolumen}cm³");
                        Console.WriteLine($"{"Mantelfläche des Zylinders: "}{zylinderMantelflaeche}cm²");
                        Console.WriteLine($"{"Oberfläche des Zylinders: "}{zylinderOberflaeche}cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:

                        Console.WriteLine("Berechnung des Parallelogramms");
                        Console.WriteLine("---------------------");
                        Console.Write("Grundseite des Parallelogramms: ");
                        double grundseite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Parallelogramms: ");
                        double hoehe_parallelogramm = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der Seite: ");
                        double seite = Convert.ToDouble(Console.ReadLine());

                        double flaeche_parallelogramm = grundseite * hoehe_parallelogramm;
                        double umfang_parallelogramm = 2 * (seite + grundseite);

                        Console.WriteLine($"{"Flächeninhalt des Parallelogramms: "}{flaeche_parallelogramm}cm²");
                        Console.WriteLine($"{"Umfang des Parallelogramms: "}{umfang_parallelogramm}cm");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 8:

                        Console.WriteLine("Berechnung des Würfels");
                        Console.WriteLine("---------------------");
                        Console.Write("Kantenlänge des Würfels: ");
                        double kantenlaenge = Convert.ToDouble(Console.ReadLine());

                        double volumen_w = kantenlaenge * kantenlaenge * kantenlaenge;
                        double oberflaeche_w = 6 * kantenlaenge * kantenlaenge;

                        Console.WriteLine($"{"Volumen des Würfels: "}{volumen_w}cm³");
                        Console.WriteLine($"{"Oberfläche des Würfels: "}{oberflaeche_w}cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 9:

                        Console.WriteLine("Berechnung des Quaders");
                        Console.WriteLine("----------------------");
                        Console.Write("Länge des Quaders: ");
                        double laenge = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Breite des Quaders: ");
                        double breite = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Quaders: ");
                        double hoehe_q = Convert.ToDouble(Console.ReadLine());

                        double volumen_q = laenge * breite * hoehe_q;
                        double oberflaeche_q = 2 * (laenge * breite + breite * hoehe_q + hoehe_q * laenge);

                        Console.WriteLine($"{"Volumen des Quaders: "}{volumen_q}cm³");
                        Console.WriteLine($"{"Oberfläche des Quaders: "}{oberflaeche_q}cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case 10:

                        Console.WriteLine("Berechnung des dreieckigen Prismas");
                        Console.WriteLine("----------------------");
                        Console.Write("Länge der Grundseite des Dreiecks: ");
                        double grundseite_p = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der Höhe des Dreiecks: ");
                        double hoehe_p = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Länge der Höhe des Prismas: ");
                        double seite_p = Convert.ToDouble(Console.ReadLine());


                        double dreiecksseiten = Math.Sqrt(grundseite_p / 2 * grundseite_p / 2 + hoehe_p * hoehe_p);
                        double flaeche_p = (grundseite_p * hoehe_p) / 2;
                        double volumen_p = flaeche_p * seite_p;
                        double mantelflaeche_p = grundseite_p * seite_p + dreiecksseiten * seite_p + dreiecksseiten * seite_p;
                        double oberflaeche_p = 2 * flaeche_p + mantelflaeche_p;

                        Console.WriteLine($"{"Volumen des Prismas: "}{volumen_p}cm³");
                        Console.WriteLine($"{"Mantelfläche des Prismas: "}{mantelflaeche_p} cm²");
                        Console.WriteLine($"{"Oberfläche des Prismas: "}{oberflaeche_p} cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 11:


                        Console.WriteLine("Berechnung der quadratischen Pyramide");
                        Console.WriteLine("---------------------");
                        Console.Write("Länge der Grundseite der Pyramide: ");
                        double grundseite_qp = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe der Pyramide: ");
                        double hoehe_qp = Convert.ToDouble(Console.ReadLine());

                        double seitenkante = Math.Sqrt(hoehe_qp * hoehe_qp + (grundseite_qp / 2) * (grundseite_qp / 2));
                        double volumen_qp = (grundseite_qp * grundseite_qp * hoehe_qp) * 1 / 3;
                        double mantelflaeche_qp = 2 * grundseite_qp * seitenkante;
                        double oberflaeche_qp = grundseite_qp * grundseite_qp + mantelflaeche_qp;

                        Console.WriteLine($"{"Seitenkante der Pyramide: "}{seitenkante}cm");
                        Console.WriteLine($"{"Volumen der Pyramide: "}{volumen_qp}cm³");
                        Console.WriteLine($"{"Mantelfläche der Pyramide: "} {mantelflaeche_qp}cm²");
                        Console.WriteLine($"{"Oberfläche der Pyramide: "}{oberflaeche_qp}cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 12:

                        Console.WriteLine("Berechnung des Kegels");
                        Console.WriteLine("-----------------");
                        Console.Write("Radius des Kegels: ");
                        double radius_ke = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Höhe des Kegels: ");
                        double hoehe_ke = Convert.ToDouble(Console.ReadLine());

                        double s = Math.Sqrt(radius_ke * radius_ke + hoehe_ke * hoehe_ke);
                        double volumen_ke = (1.0 / 3.0) * Math.PI * radius_ke * radius_ke * hoehe_ke;
                        double mantelflaeche_ke = Math.PI * radius_ke * s;
                        double oberflaeche_ke = Math.PI * radius_ke * (radius_ke + s);

                        Console.WriteLine($"{"Volumen des Kegels: "}{volumen_ke} cm³");
                        Console.WriteLine($"{"Mantelfläche des Kegels: "}{mantelflaeche_ke} cm²");
                        Console.WriteLine($"{"Oberfläche des Kegels: "}{oberflaeche_ke} cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 13:

                        Console.WriteLine("Berechnung der Kugel");
                        Console.WriteLine("---------------------");
                        Console.Write("Radius der Kugel: ");
                        double radius_k = Convert.ToDouble(Console.ReadLine());

                        double volumen_k = (4.0 / 3.0) * Math.PI * radius_k * radius_k * radius_k;
                        double oberflaeche_k = 4 * Math.PI * radius_k * radius_k;

                        Console.WriteLine($"{"Volumen der Kugel: "}{volumen_k} cm³");
                        Console.WriteLine($"{"Oberfläche der Kugel: "}{oberflaeche_k} cm²");
                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 14:

                        Console.WriteLine("\nDrücken sie eine Beliebige Taste zum wiederholen:");
                        Console.ReadKey();
                        Console.Clear();
                        exit = false;
                        break;


                }
            }
        }
    }
}