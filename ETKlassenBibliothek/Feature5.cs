namespace ETKlassenBibliothek
{
    internal class Feature5
    {
        internal static void Feature_5()
        {

            int score = 0;

            Console.WriteLine("Willkommen beim Elektrotechnik-Quiz!\n");


            Console.WriteLine("Frage 1: Was ist eine Spannung?\n");
            Console.WriteLine("a) Die Differenz zwischen zwei Punkten eines elektrischen Feldes\n");
            Console.WriteLine("b) Die Stromstärke, die durch einen Leiter fließt\n");
            Console.WriteLine("c) Die Widerstandsfähigkeit eines Materials gegenüber Strom\n");
            Console.WriteLine("Antwort: ");
            string antwort1 = Console.ReadLine().ToLower();
            if (antwort1 == "a")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 2: Was ist ein Ohm?\n");
            Console.WriteLine("a) Eine Einheit für die Stromstärke\n");
            Console.WriteLine("b) Eine Einheit für die elektrische Leistung\n");
            Console.WriteLine("c) Eine Einheit für den elektrischen Widerstand\n");
            Console.WriteLine("Antwort: ");
            string antwort2 = Console.ReadLine().ToLower();
            if (antwort2 == "c")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 3: Was ist eine Diode?\n");
            Console.WriteLine("a) Ein elektronisches Bauteil, das den Strom in einer Richtung leitet\n");
            Console.WriteLine("b) Ein Bauteil, das den Strom in beide Richtungen leitet\n");
            Console.WriteLine("c) Ein Bauteil, das den Strom komplett blockiert\n");
            Console.WriteLine("Antwort: ");
            string antwort3 = Console.ReadLine().ToLower();
            if (antwort3 == "a")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }


            Console.WriteLine("Frage 4: Was ist ein Kondensator?\n");
            Console.WriteLine("a) Ein elektronisches Bauteil, das elektrische Energie speichert\n");
            Console.WriteLine("b) Ein Bauteil, das den Strom in einer Richtung leitet\n");
            Console.WriteLine("c) Ein Bauteil, das den Strom in beide Richtungen leitet\n");
            Console.WriteLine("Antwort: ");
            string antwort4 = Console.ReadLine().ToLower();
            if (antwort4 == "a")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }


            Console.WriteLine("Frage 5: Was ist eine Spule?\n");
            Console.WriteLine("a) Ein Bauteil, das den Strom in beide Richtungen leitet\n");
            Console.WriteLine("b) Ein Bauteil, das den Strom komplett blockiert\n");
            Console.WriteLine("c) Ein Bauteil, das magnetische Energie speichert\n");
            Console.WriteLine("Antwort: ");


            Console.WriteLine("Frage 6: Was ist eine Frequenz?\n");
            Console.WriteLine("a) Die Dauer, in der ein elektrisches Signal an- und ausgeschaltet wird\n");
            Console.WriteLine("b) Die Anzahl der Schwingungen pro Sekunde bei einem periodischen Signal\n");
            Console.WriteLine("c) Die Stromstärke, die durch einen Leiter fließt\n");
            Console.WriteLine("Antwort: ");
            string antwort6 = Console.ReadLine().ToLower();
            if (antwort6 == "b")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 7: Was ist eine Transistor?\n");
            Console.WriteLine("a) Ein elektronisches Bauteil, das den Strom in einer Richtung leitet\n");
            Console.WriteLine("b) Ein Bauteil, das den Strom in beide Richtungen leitet\n");
            Console.WriteLine("c) Ein elektronisches Bauteil, das als Schalter oder Verstärker eingesetzt wird\n");
            Console.WriteLine("Antwort: ");
            string antwort7 = Console.ReadLine().ToLower();
            if (antwort7 == "c")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 8: Was ist eine Induktivität?\n");
            Console.WriteLine("a) Der Widerstand eines Materials gegenüber Strom\n");
            Console.WriteLine("b) Die Fähigkeit eines Bauteils, magnetische Energie zu speichern\n");
            Console.WriteLine("c) Die Fähigkeit eines Bauteils, elektrische Energie zu speichern\n");
            Console.WriteLine("Antwort: ");
            string antwort8 = Console.ReadLine().ToLower();
            if (antwort8 == "b")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 9: Was ist ein Transformator?\n");
            Console.WriteLine("a) Ein elektronisches Bauteil, das den Strom in einer Richtung leitet\n");
            Console.WriteLine("b) Ein Bauteil, das den Strom in beide Richtungen leitet\n");
            Console.WriteLine("c) Ein elektrisches Gerät, das die Spannung eines Signals ändert\n");
            Console.WriteLine("Antwort: ");
            string antwort9 = Console.ReadLine().ToLower();
            if (antwort9 == "c")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Frage 10: Was ist eine Leistung?\n");
            Console.WriteLine("a) Die Spannung, die an einem elektrischen Bauteil anliegt\n");
            Console.WriteLine("b) Die elektrische Energie, die in einer bestimmten Zeit umgesetzt wird\n");
            Console.WriteLine("c) Die Widerstandsfähigkeit eines Materials gegenüber Strom\n");
            Console.WriteLine("Antwort: ");
            string antwort10 = Console.ReadLine().ToLower();
            if (antwort10 == "b")
            {
                Console.WriteLine("Richtig!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Falsch.\n");
            }

            Console.WriteLine("Quiz beendet. Dein Score: {0} von 10", score);
            Console.ReadLine();





        }
    }

}
