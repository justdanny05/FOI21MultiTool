namespace ETKlassenBibliothek
{
    internal class Feature1
    {
        internal static void Feature_1()
        {
            b a = true; w(a){ c.W("Widerstandsrechner\n-------------------\n1. Widerstand aus Spannung und Strom berechnen.\n2. Strom aus Spannung und Widerstand berechnen.\n3. Spannung aus Strom und Widerstand berechnen.\nGeben Sie 'exit' ein, um das Programm zu beenden."); int o; string i = c.RL().ToLower(); if (i == "exit") { a = false; break; } else if (!int.TP(i, out o) || o < 1 || o > 3) { c.C(); c.W("Widerstandsrechner\n-------------------\nUngültige Auswahl. Bitte versuchen Sie es erneut."); continue; } c.C(); string v1d; double v1; switch (o) { case 1: v1d = "Spannung (in Volt)"; break; case 2: v1d = "Spannung (in Volt)"; break; case 3: v1d = "Stromstärke (in Ampere)"; break; default: v1d = ""; break; } d{ c.W($"Geben Sie {v1d} ein: "); i = c.RL(); if (i == "exit") { a = false; break; } } w(!double.TP(i, out v1) || v1 < 0); if (!a) break; c.C(); string v2d; double v2; switch (o) { case 1: v2d = "Stromstärke (in Ampere)"; break; case 2: v2d = "Widerstand (in Ohm)"; break; case 3: v2d = "Widerstand (in Ohm)"; break; default: v2d = ""; break; } d{ c.W($"Geben Sie den {v2d} ein: "); i = c.RL(); if (i == "exit") { a = false; break; } } w(!double.TP(i, out v2) || v2 < 0); if (!a) break; c.C(); double r; switch (o) { case 1: r = v1 / v2; c.W($"Widerstand = {r} Ohm"); break; case 2: r = v1 / v2; c.W($"Stromstärke = {r} Ampere"); break; case 3: r = v1 * v2; c.W($"Spannung = {r} Volt"); break; default: c.W("Ungültige  Auswahl."); break} c.W("\nDrücken Sie eine beliebige Taste, um fortzufahren..."); c.RK(); c.C(); }c.W("Programm wird beendet..."); c.C();

        }
    }
}