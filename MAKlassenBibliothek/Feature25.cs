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
            Console.WriteLine("Test Feature 25");
            //Diese Ausgabe hilft Ihnen zu erkennen ob der Aufruf funktioniert.
        }
    }
}
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

Console.Write("Bitte wählen Sie eine Form (1-13): ");
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
        double rechteckHöhe = Convert.ToDouble(Console.ReadLine());

        Console.Write("Tiefe des Rechtecks: ");
        double rechteckTiefe = Convert.ToDouble(Console.ReadLine());

        double rechteckFläche = rechteckBreite * rechteckHöhe;
        double rechteckUmfang = 2 * (rechteckBreite + rechteckHöhe);

        Console.WriteLine($"{"Fläche des Rechtecks:"} {rechteckFläche}cm²");
        Console.WriteLine($"{"Umfang des Rechtecks: "} {rechteckUmfang}cm");
        break;

    case 2:
        Console.WriteLine("Berechnung des Quadrats ");
        Console.WriteLine("------------------");
        Console.Write("Seitenlänge des Quadrats: ");
        double quadratSeite = Convert.ToDouble(Console.ReadLine());

        double quadratFläche = quadratSeite * quadratSeite;
        double quadratUmfang = 4 * quadratSeite;

        Console.WriteLine($"{"Fläche des Quadrats: "} {quadratFläche}cm²");
        Console.WriteLine($"{"Umfang des Quadrats: "}{quadratUmfang}cm");
        break;

    case 3:
        Console.WriteLine("Berechnung des Kreises ");
        Console.WriteLine("------------------");
        Console.Write("Radius des Kreises: ");
        double kreisRadius = Convert.ToDouble(Console.ReadLine());

        double kreisFläche = Math.PI * kreisRadius * kreisRadius;
        double kreisUmfang = 2 * Math.PI * kreisRadius;


        Console.WriteLine($"{"Fläche des Kreises: "}{kreisFläche}cm²");
        Console.WriteLine($"{"Umfang des Kreises: "}{kreisUmfang}cm");
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
        double höhekreis = Convert.ToDouble(Console.ReadLine());

        double umfang = a + b + c;
        double fläche = 0.5 * c * höhekreis;

        Console.WriteLine($"{"Flächeninhalt des Dreiecks: "}{fläche}cm²");
        Console.WriteLine($"{"Umfang des Dreiecks: "}{umfang}cm");
        break;

    case 5:

        Console.WriteLine("Berechnung des Trapezes");
        Console.WriteLine("-------------------");
        Console.Write("Länge der oberen Seite: ");
        double oberseite = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der unteren Seite: ");
        double unterseite = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe des Trapezes: ");
        double höhe = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der linken Seite: ");
        double linkeSeite = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der rechten Seite: ");
        double rechteSeite = Convert.ToDouble(Console.ReadLine());

        double flächetrapez = 0.5 * (oberseite + unterseite) * höhe;
        double umfangtrapez = oberseite + unterseite + linkeSeite + rechteSeite;

        Console.WriteLine($"{"Flächeninhalt des Trapezes: "}{flächetrapez}cm²");
        Console.WriteLine($"{"Umfang des Trapezes: "}{umfangtrapez}cm");
        break;


    case 6:


        Console.WriteLine("Berechnung des Zylinders");
        Console.WriteLine("--------------------");
        Console.Write("Radius des Zylinders: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe des Zylinders: ");
        double höhe_zylinder = Convert.ToDouble(Console.ReadLine());

        double volumen = Math.PI * radius * radius * höhe_zylinder;
        double mantelfläche = 2 * Math.PI * radius * höhe_zylinder;
        double oberfläche = 2 * Math.PI * radius * (radius + höhe_zylinder);

        Console.WriteLine($"{"Volumen des Zylinders: "}{volumen}cm³");
        Console.WriteLine($"{"Mantelfläche des Zylinders: "}{mantelfläche}cm²");
        Console.WriteLine($"{"Oberfläche des Zylinders: "}{oberfläche}cm²");
        break;

    case 7:

        Console.WriteLine("Berechnung des Parallelogramms");
        Console.WriteLine("---------------------");
        Console.Write("Grundseite des Parallelogramms: ");
        double grundseite = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe des Parallelogramms: ");
        double höhe_parallelogramm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der Seite: ");
        double seite = Convert.ToDouble(Console.ReadLine());

        double fläche_parallelogramm = grundseite * höhe_parallelogramm;
        double umfang_parallelogramm = 2 * (seite + grundseite);

        Console.WriteLine($"{"Flächeninhalt des Parallelogramms: "}{fläche_parallelogramm}cm²");
        Console.WriteLine($"{"Umfang des Parallelogramms: "}{umfang_parallelogramm}cm");
        break;

    case 8:

        Console.WriteLine("Berechnung des Würfels");
        Console.WriteLine("---------------------");
        Console.Write("Kantenlänge des Würfels: ");
        double kantenlänge = Convert.ToDouble(Console.ReadLine());

        double volumen_w = kantenlänge * kantenlänge * kantenlänge;
        double oberfläche_w = 6 * kantenlänge * kantenlänge;

        Console.WriteLine($"{"Volumen des Würfels: "}{volumen_w}cm³");
        Console.WriteLine($"{"Oberfläche des Würfels: "}{oberfläche_w}cm²");
        break;

    case 9:

        Console.WriteLine("Berechnung des Quaders");
        Console.WriteLine("----------------------");
        Console.Write("Länge des Quaders: ");
        double länge = Convert.ToDouble(Console.ReadLine());

        Console.Write("Breite des Quaders: ");
        double breite = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe des Quaders: ");
        double höhe_q = Convert.ToDouble(Console.ReadLine());

        double volumen_q = länge * breite * höhe_q;
        double oberfläche_q = 2 * (länge * breite + breite * höhe_q + höhe_q * länge);

        Console.WriteLine($"{"Volumen des Quaders: "}{volumen_q}cm³");
        Console.WriteLine($"{"Oberfläche des Quaders: "}{oberfläche_q}cm²");
        break;



    case 10:

        Console.WriteLine("Berechnung des dreieckigen Prismas");
        Console.WriteLine("----------------------");
        Console.Write("Länge der Grundseite des Dreiecks: ");
        double grundseite_p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der Höhe des Dreiecks: ");
        double höhe_p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Länge der Höhe des Prismas: ");
        double seite_p = Convert.ToDouble(Console.ReadLine());


        double dreiecksseiten = Math.Sqrt(grundseite_p / 2 * grundseite_p / 2 + höhe_p * höhe_p);
        double fläche_p = (grundseite_p * höhe_p) / 2;
        double volumen_p = fläche_p * seite_p;
        double mantelfläche_p = grundseite_p * seite_p + dreiecksseiten * seite_p + dreiecksseiten * seite_p;
        double oberfläche_p = 2 * fläche_p + mantelfläche_p;

        Console.WriteLine($"{"Volumen des Prismas: "}{volumen_p}cm³");
        Console.WriteLine($"{"Mantelfläche des Prismas: "}{mantelfläche_p} cm²");
        Console.WriteLine($"{"Oberfläche des Prismas: "}{oberfläche_p} cm²");
        break;

    case 11:


        Console.WriteLine("Berechnung der quadratischen Pyramide");
        Console.WriteLine("---------------------");
        Console.Write("Länge der Grundseite der Pyramide: ");
        double grundseite_qp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe der Pyramide: ");
        double höhe_qp = Convert.ToDouble(Console.ReadLine());

        double seitenkante = Math.Sqrt(höhe_qp * höhe_qp + (grundseite_qp / 2) * (grundseite_qp / 2));
        double volumen_qp = (grundseite_qp * grundseite_qp * höhe_qp) * 1 / 3;
        double mantelfläche_qp = 2 * grundseite_qp * seitenkante;
        double oberfläche_qp = grundseite_qp * grundseite_qp + 2 * grundseite_qp * seitenkante;

        Console.WriteLine($"{"Seitenkante der Pyramide: "}{seitenkante}cm");
        Console.WriteLine($"{"Volumen der Pyramide: "}{volumen_qp}cm³");
        Console.WriteLine($"{"Mantelfläche der Pyramide: "} {mantelfläche_qp}cm²");
        Console.WriteLine($"{"Oberfläche der Pyramide: "}{oberfläche_qp}cm²");
        break;

    case 12:

        Console.WriteLine("Berechnung des Kegels");

        Console.Write("Radius des Kegels: ");
        double radius_ke = Convert.ToDouble(Console.ReadLine());

        Console.Write("Höhe des Kegels: ");
        double höhe_ke = Convert.ToDouble(Console.ReadLine());

        double s = Math.Sqrt(radius_ke * radius_ke + höhe_ke * höhe_ke);
        double volumen_ke = (1.0 / 3.0) * Math.PI * radius_ke * radius_ke * höhe_ke;
        double mantelfläche_ke = Math.PI * radius_ke * s;
        double oberfläche_ke = Math.PI * radius_ke * (radius_ke + s);

        Console.WriteLine($"{"Volumen des Kegels: "}{volumen_ke} cm³");
        Console.WriteLine($"{"Mantelfläche des Kegels: "}{mantelfläche_ke} cm²");
        Console.WriteLine($"{"Oberfläche des Kegels: "}{oberfläche_ke} cm²");
        break;

    case 13:

        Console.WriteLine("Berechnung der Kugel");
        Console.WriteLine("---------------------");
        Console.Write("Radius der Kugel: ");
        double radius_k = Convert.ToDouble(Console.ReadLine());

        double volumen_k = (4.0 / 3.0) * Math.PI * radius_k * radius_k * radius_k;
        double oberfläche_k = 4 * Math.PI * radius_k * radius_k;

        Console.WriteLine($"{"Volumen der Kugel: "}{volumen_k} cm³");
        Console.WriteLine($"{"Oberfläche der Kugel: "}{oberfläche_k} cm²");
        break;
}
}