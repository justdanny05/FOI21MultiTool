using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WIKlassenBibliothek
{
   internal class Feature20
   {
        private static string benutzerdateiPath1;

        internal static void Feature_20()
        {


        string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
        Directory.CreateDirectory(kassensystemOrdnerPfad);

        string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
        Directory.CreateDirectory(produktOrdnerPfad);

        string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
        Directory.CreateDirectory(quittungOrdnerPfad);

        string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
        Directory.CreateDirectory(usersOrdnerPfad);

        bool loggedIn = false;
        string benutzerName = "";
        string passwort = "";
        string auswahl;
        string benutzernameAdmin = "admin";
        string passwortAdmin = "777";
        string rechteadmin = "999";
        string benutzerdateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");


            string Verschluesseln(string klartext)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(klartext);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] ^= 0x42;
                }
                return Convert.ToBase64String(bytes);
            }

            if (!File.Exists(benutzerdateiPfad))
            {
                File.Create(benutzerdateiPfad).Close();
            }

            bool adminVorhanden = false;

            foreach (string zeile in File.ReadLines(benutzerdateiPfad))
            {
                string[] benutzer = zeile.Split(':');
                if (benutzer.Length == 3 && benutzer[0] == benutzernameAdmin && Verschluesseln(passwortAdmin) == benutzer[1])
                {
                    adminVorhanden = true;
                    break;
                }
            }

            if (!adminVorhanden)
            {
                using (StreamWriter sw = File.AppendText(benutzerdateiPfad))
                {
                    sw.WriteLine($"{benutzernameAdmin}:{Verschluesseln(passwortAdmin)}:{rechteadmin}");
                }

            }

            while (!loggedIn)
            {
                Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                "                              >>> Benutzer Interface <<<\n" +
                                "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Möchten Sie sich einloggen (1), ein neues Konto erstellen (2) oder ein Konto löschen (3)?");
                auswahl = Console.ReadLine();


                bool autologinEnabled = IsAutoLoginEnabled();
                if (auswahl == "1" && autologinEnabled)
                {
                    string loggedinPath = Path.Combine(usersOrdnerPfad, "loggedin.txt");

                    string benutzerName1 = "";
                    if (File.Exists(loggedinPath))
                    {
                        benutzerName1 = File.ReadAllText(loggedinPath);
                    }

                    Console.Clear();
                    Console.WriteLine($"Willkommen zurück, {benutzerName1}!");
                    Console.WriteLine("Sie wurden automatisch angemeldet, da Sie Autologin aktiviert haben!");
                    adminoberflaeche();
                    File.WriteAllText(Path.Combine(usersOrdnerPfad, "loggedin.txt"), benutzerName);
                }
                else if (auswahl == "1" && !autologinEnabled)
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Benutzer Login <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");
                    Console.Write("Benutzername: ");
                    benutzerName = Console.ReadLine();
                    Console.Write("Passwort: ");
                    passwort = Console.ReadLine();

                    bool benutzernameUndPasswortKorrekt = false;

                    if (File.Exists(Path.Combine(usersOrdnerPfad, "users.txt")))
                    {
                        foreach (string zeile in File.ReadLines(Path.Combine(usersOrdnerPfad, "users.txt")))
                        {
                            string[] benutzer = zeile.Split(':');
                            if (benutzer.Length == 3 && benutzer[0] == benutzerName && Verschluesseln(passwort) == benutzer[1])
                            {
                                benutzernameUndPasswortKorrekt = true;
                                break;
                            }
                        }
                    }

                    if (benutzernameUndPasswortKorrekt)
                    {
                        Console.Clear();
                        Console.WriteLine($"Willkommen zurück, {benutzerName}!");

                        string[] benutzerDaten = File.ReadAllLines(Path.Combine(usersOrdnerPfad, "users.txt"));
                        foreach (string zeile in benutzerDaten)
                        {
                            string[] benutzer = zeile.Split(':');
                            if (benutzer.Length == 3 && benutzer[0] == benutzerName && Verschluesseln(passwort) == benutzer[1])
                            {
                                if (benutzer[2] == "999")
                                {
                                    File.WriteAllText(Path.Combine(usersOrdnerPfad, "loggedin.txt"), benutzerName);
                                    adminoberflaeche();
                                }
                                else
                                {
                                    File.WriteAllText(Path.Combine(usersOrdnerPfad, "loggedin.txt"), benutzerName);
                                    KassensystemBenutzeroberflaeche();
                                }

                            }
                        }
                    }



                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Benutzername oder Passwort ungültig. Bitte versuchen Sie es erneut.");
                        Feature20.Feature_20();
                    }
                }


                else if (auswahl == "2")
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Neues Konto erstellen <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");

                    Console.Write("Benutzername: ");
                    string newBenutzerName = Console.ReadLine();


                    // check if the user already exists
                    bool userExists = false;
                    foreach (string zeile in File.ReadLines(benutzerdateiPfad))
                    {
                        string[] benutzer = zeile.Split(':');
                        if (benutzer.Length == 3 && benutzer[0] == newBenutzerName)
                        {
                            Console.Clear();
                            Console.WriteLine($"Der Benutzername \"{newBenutzerName}\" ist bereits vergeben. Bitte wählen Sie einen anderen Benutzernamen.");
                            userExists = true;
                            break;
                        }
                    }

                    // if the user does not exist, prompt for a password and create a new user
                    if (!userExists)
                    {
                        Console.Write("Passwort: ");
                        string newPasswort = Console.ReadLine();
                        string loggedinPath = Path.Combine(usersOrdnerPfad, "loggedin.txt");

                        Console.Write("Passwort erneut eingeben: ");
                        string newPasswortBestaetigen = Console.ReadLine();

                        if (newPasswort != newPasswortBestaetigen)
                        {
                            Console.WriteLine("Die Passwörter stimmen nicht überein. Bitte versuchen Sie es erneut.");
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(benutzerdateiPfad))
                            {
                                sw.WriteLine($"{newBenutzerName}:{Verschluesseln(newPasswort)}:000");
                            }


                            Console.Clear() ;
                            Console.WriteLine($"Benutzer {newBenutzerName} wurde erfolgreich erstellt.");
                            File.WriteAllText(loggedinPath, newBenutzerName);
                            KassensystemBenutzeroberflaeche();
                        }
                    }
                }





                if (auswahl == "3")
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                    " >>> Benutzer löschen <<<\n" +
                    "------------------------------------------------------------------------------------\n\n");
                    Console.Write("Geben Sie den Benutzernamen des zu löschenden Kontos ein: ");
                    string benutzerZumLoeschen = Console.ReadLine();
                    if (benutzerZumLoeschen.ToLower() == "admin")
                    {
                        Console.Clear();
                        Console.WriteLine("Der Benutzer 'admin' kann nicht gelöscht werden.");
                    }
                    else
                    {
                        Console.Write("Geben Sie das Passwort des Kontos ein, um das Konto zu löschen: ");
                        string passwortBestaetigen = Console.ReadLine();

                        bool benutzernameUndPasswortKorrekt = false;
                        if (File.Exists(Path.Combine(usersOrdnerPfad, "users.txt")))
                        {
                            foreach (string zeile in File.ReadLines(Path.Combine(usersOrdnerPfad, "users.txt")))
                            {
                                string[] benutzer = zeile.Split(':');
                                if (benutzer.Length == 2 && benutzer[0] == benutzerZumLoeschen && Verschluesseln(passwortBestaetigen) == benutzer[1])
                                {
                                    benutzernameUndPasswortKorrekt = true;
                                    break;
                                }
                            }
                        }

                        if (benutzernameUndPasswortKorrekt)
                        {
                            string benutzerdateiTempPfad = Path.Combine(usersOrdnerPfad, "users_temp.txt");
                            using (StreamWriter sw = new StreamWriter(benutzerdateiTempPfad))
                            {
                                foreach (string zeile in File.ReadLines(Path.Combine(usersOrdnerPfad, "users.txt")))
                                {
                                    string[] benutzer = zeile.Split(':');
                                    if (benutzer.Length == 2 && benutzer[0] != benutzerZumLoeschen)
                                    {
                                        sw.WriteLine(zeile);
                                    }
                                }
                            }
                            File.Delete(Path.Combine(usersOrdnerPfad, "users.txt"));
                            File.Move(benutzerdateiTempPfad, Path.Combine(usersOrdnerPfad, "users.txt"));

                            Console.Clear();
                            Console.WriteLine($"Der Benutzer \"{benutzerZumLoeschen}\" wurde erfolgreich gelöscht.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Benutzername oder Passwort ungültig. Bitte versuchen Sie es erneut.");
                        }
                    }
                }
            }
        }

        internal static string GetCurrentUserName1()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            string loggedinDateiPfad = Path.Combine(usersOrdnerPfad, "loggedin.txt");

            if (File.Exists(loggedinDateiPfad))
            {
                string benutzerName = File.ReadAllText(loggedinDateiPfad);
                return benutzerName;
            }

            return "";
        }



        public static bool IsAutoLoginEnabled()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            string settingsFolder = Path.Combine(usersOrdnerPfad, "settings");
            string autoLoginPath = Path.Combine(settingsFolder, "settings.txt");

            if (!Directory.Exists(kassensystemOrdnerPfad))
            {
                Directory.CreateDirectory(kassensystemOrdnerPfad);
            }

            if (!Directory.Exists(usersOrdnerPfad))
            {
                Directory.CreateDirectory(usersOrdnerPfad);
            }

            if (!Directory.Exists(settingsFolder))
            {
                Directory.CreateDirectory(settingsFolder);
            }

            if (!File.Exists(autoLoginPath))
            {
                File.WriteAllText(autoLoginPath, "autologin=false");
            }

            string content = File.ReadAllText(autoLoginPath);
            bool autoLoginEnabled = content.Trim().ToLower().EndsWith("true");
            return autoLoginEnabled;
        }


        public static void ToggleAutoLogin()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            string settingsFolder = Path.Combine(usersOrdnerPfad, "settings");
            string autoLoginPath = Path.Combine(settingsFolder, "settings.txt");

            if (!Directory.Exists(kassensystemOrdnerPfad))
            {
                Directory.CreateDirectory(kassensystemOrdnerPfad);
            }

            if (!Directory.Exists(usersOrdnerPfad))
            {
                Directory.CreateDirectory(usersOrdnerPfad);
            }

            if (!Directory.Exists(settingsFolder))
            {
                Directory.CreateDirectory(settingsFolder);
            }

            bool autoLoginEnabled = IsAutoLoginEnabled();
            bool newValue = !autoLoginEnabled;
            File.WriteAllText(autoLoginPath, $"autologin={newValue.ToString().ToLower()}");

            if (newValue)
            {
                Console.Clear();
                Console.WriteLine("Auto-Login ist jetzt aktiviert.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Auto-Login ist jetzt deaktiviert.");
            }
        }



        public static List<string> BenutzerAuflisten()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            Directory.CreateDirectory(kassensystemOrdnerPfad);

            string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
            Directory.CreateDirectory(produktOrdnerPfad);

            string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
            Directory.CreateDirectory(quittungOrdnerPfad);

            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            Directory.CreateDirectory(usersOrdnerPfad);

            string usersDateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");

            List<string> benutzerListe = new List<string>();
            string header = FiggleFonts.Slant.Render("Wirtschaft");

            if (!File.Exists(usersDateiPfad))
            {
                Console.WriteLine("Keine Benutzer vorhanden.");
                return benutzerListe;
            }

            Console.Clear();
            Console.WriteLine(header);
            Console.Title = "Kassensystem";
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                               "                              >>> Benutzer Liste <<<\n" +
                               "------------------------------------------------------------------------------------\n");
            foreach (string zeile in File.ReadLines(usersDateiPfad))
            {
                string[] benutzer = zeile.Split(':');
                benutzerListe.Add(benutzer[0]);
                Console.WriteLine($"Benutzername: {benutzer[0]}");
            }

            Console.WriteLine("\nDrücken Sie 'B' und dann Enter, um zum Hauptmenü zurückzukehren.");
            string eingabe = Console.ReadLine();
            Console.Clear();
            if (eingabe.ToLower() == "b")
            {
                Console.Clear();
                KassensystemBenutzeroberflaeche();
            }

            return benutzerListe;
        }

         public bool UserHasRole999()
            {
                string benutzerName = GetCurrentUserName1();
                string usersOrdnerPfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Kassensystem", "Users");
                string benutzerDateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");

                if (!File.Exists(benutzerDateiPfad))
                {
                    return false;
                }

                string[] benutzerListe = File.ReadAllLines(benutzerDateiPfad);
                foreach (string benutzer in benutzerListe)
                {
                    string[] benutzerDaten = benutzer.Split(':');
                    if (benutzerDaten[0] == benutzerName && benutzerDaten[2] == "999")
                    {
                        return true;
                    }
                }
                return false;
            }

        public static void BenutzerZuAdminMachen()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            Directory.CreateDirectory(kassensystemOrdnerPfad);

            string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
            Directory.CreateDirectory(produktOrdnerPfad);

            string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
            Directory.CreateDirectory(quittungOrdnerPfad);

            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            Directory.CreateDirectory(usersOrdnerPfad);
            string header = FiggleFonts.Slant.Render("Wirtschaft");

            BenutzerAuflisten();


            Console.WriteLine(header);
            Console.Title = "Kassensystem";
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                               "                              >>> Admin vergabe <<<\n" +
                               "------------------------------------------------------------------------------------\n");
            Console.WriteLine("Für welchen Benutzer möchten Sie Admin-Rechte vergeben?");
            string benutzername = Console.ReadLine();

            string usersDateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");
            if (File.Exists(usersDateiPfad))
            {
                bool benutzerGefunden = false;
                List<string> neueBenutzerdaten = new List<string>();
                foreach (string zeile in File.ReadLines(usersDateiPfad))
                {
                    string[] benutzer = zeile.Split(':');
                    if (benutzer.Length == 3 && benutzer[0] == benutzername)
                    {
                        benutzerGefunden = true;
                        if (benutzer[2] == "999")
                        {
                            Console.Clear();
                            Console.WriteLine($"Der Benutzer {benutzername} ist bereits ein Admin.");
                            return;
                        }
                        benutzer[2] = "999";
                    }
                    neueBenutzerdaten.Add(string.Join(':', benutzer));
                }

                if (benutzerGefunden)
                {
                    File.WriteAllLines(usersDateiPfad, neueBenutzerdaten);
                    Console.Clear();
                    Console.WriteLine($"Der Benutzer {benutzername} wurde der Rang Admin hinzugefügt.");
                    Kassensystem kassensystem = new Kassensystem();
                    if (kassensystem.UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Der angegebene Benutzername konnte nicht gefunden werden.");
                }
            }
            else
            {
                Console.WriteLine("Die users.txt-Datei existiert nicht.");
            }
        }

        public static void adminoberflaeche()
        {
 
            Kassensystem kassensystem = new Kassensystem();
            kassensystem.ProdukteAusDateiEinlesen();

            Kassensystem.SetConsoleColor(ConsoleColor.Green);

            Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Admin-Kassensystem <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("\nWas möchten Sie tun?");
            Console.WriteLine("1 - Produkt hinzufügen");
            Console.WriteLine("2 - Produkt Preis ändern");
            Console.WriteLine("3 - Produkt löschen");
            Console.WriteLine("4 - Produkte Liste");
            Console.WriteLine("5 - Automatisch Angemeldet bleiben");
            Console.WriteLine("6 - Rechte vergeben");
            Console.WriteLine("7 - Benutzer Abmelden");
            Console.WriteLine("8 - Programm beenden");

            Console.WriteLine("");

            string antwort = kassensystem.GetUserInputWithExitOption("Bitte geben Sie eine Zahl zwischen 1 und 7 ein:");
            switch (antwort)
            {
                case "1":
                    kassensystem.ProduktHinzufuegen();
                    Produkt letztesProdukt = kassensystem.produkte.Last();
                    kassensystem.QuittungErstellen(letztesProdukt);
                    break;
                case "2":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Preis Ändern <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
                    string produktName = kassensystem.GetUserInputWithExitOption("Welches Produkt möchten Sie bearbeiten? (Name eingeben):");
                    kassensystem.ProduktPreisAendern(produktName);
                    break;
                case "3":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Produkt Löschen <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
                    string name = kassensystem.GetUserInputWithExitOption("Welches Produkt möchten Sie löschen? (Name eingeben):");
                    kassensystem.ProduktLoeschen(name);
                    break;
                case "4":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    adminoberflaeche();
                    break;
                case "5":
                    ToggleAutoLogin();
                    adminoberflaeche();
                    break;
                case "6":
                    BenutzerZuAdminMachen();
                    if (kassensystem.UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Sie wurden abgemeldet!");
                    Feature20.Feature_20();
                    break;
                case "8":
                    Console.Clear();
                    WIMenue.WI_Menue();
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 8 ein.");
                    break;
            }
        }

        public static void KassensystemBenutzeroberflaeche()
        {

            Kassensystem kassensystem = new Kassensystem();
            kassensystem.ProdukteAusDateiEinlesen();

            Kassensystem.SetConsoleColor(ConsoleColor.Green);

            Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Kassensystem <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("\nWas möchten Sie tun?");
            Console.WriteLine("1 - Produkt hinzufügen");
            Console.WriteLine("2 - Produkte Liste");
            Console.WriteLine("3 - Benutzer Abmelden");
            Console.WriteLine("4 - Programm beenden");
            Console.WriteLine("");

            string antwort = kassensystem.GetUserInputWithExitOption("Bitte geben Sie eine Zahl zwischen 1 und 8 ein:");
            switch (antwort)
            {
                case "1":
                    kassensystem.ProduktHinzufuegen();
                    Produkt letztesProdukt = kassensystem.produkte.Last();
                    kassensystem.QuittungErstellen(letztesProdukt);
                    break;
                case "2":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    KassensystemBenutzeroberflaeche();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Sie wurden abgemeldet!");
                    Feature20.Feature_20();
                    break;
                case "4":
                    Console.Clear();
                    WIMenue.WI_Menue();
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 4 ein.");
                    break;
            }
        }

        public class Produkt
        {
            public string Name { get; set; }
            public decimal Preis { get; set; }
            public string Kategorie { get; set; }
            public string Hersteller { get; set; }

            public Produkt(string name, decimal preis, string kategorie, string hersteller)
            {
                Name = name;
                Preis = preis;
                Kategorie = kategorie;
                Hersteller = hersteller;
            }
        }

        public class Quittung
        {
            private int ID;
            private DateTime Datum;
            private Produkt Produkt;
            private string benutzerName;

            public Quittung(int id, DateTime Datum, Produkt Produkt, string benutzerName)
            {
                this.ID = ID;
                this.Datum = Datum;
                this.Produkt = Produkt;
                this.benutzerName = benutzerName;
            }
        

            public override string ToString()
            {
                string benutzerName = GetCurrentUserName1();
                return $"ID: {ID}\nDatum: {Datum}\nProdukt: {Produkt.Name} ({Produkt.Preis} Euro)\nBenutzer: {benutzerName}";
            }

            private static string GetCurrentUserName(ref bool loggedIn)
            {
                string benutzerName = "";
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string 
                    OrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");

                
                        return benutzerName;
                    }
                }

        class Kassensystem
        {
            public string GetUserInputWithExitOption(string prompt)
            {
                Console.Write(prompt + " (oder 'exit' zum Beenden, 'menu' für Hauptmenü): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.Clear();
                    WIMenue.WI_Menue();
                }
                else if (input.ToLower() == "menu")
                {
                    Console.Clear();
                    Feature_20();
                }

                while (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit" || input.ToLower() == "menu")
                {
                    if (input.ToLower() == "exit")
                    {
                        Console.Clear();
                        WIMenue.WI_Menue();
                    }
                    else if (input.ToLower() == "menu")
                    {
                        Console.Clear();
                        Feature_20();
                    }
                    else
                    {
                        Console.Write("Ungültige Eingabe. Bitte geben Sie eine Zeichenkette ein: ");
                        input = Console.ReadLine();
                    }
                }

                return input.Trim();
            }


            public static object Verschluesseln(string v)
            {
                throw new NotImplementedException();
            }

            string header = FiggleFonts.Slant.Render("Kassensystem");
            public List<Produkt> produkte = new List<Produkt>();
            private List<Quittung> quittungen = new List<Quittung>();
            private int quittungsIdCounter = 1;
            private Stream quittungPfad;

            public static void SetConsoleColor(ConsoleColor color)
            {
                Console.ForegroundColor = color;
            }

            public void ProduktHinzufuegen()
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.Title = "Kassensystem";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                                "                              >>> Produkt Hinzufügen <<<\n" +
                                                                "------------------------------------------------------------------------------------\n");

                string name = GetUserInputWithExitOption("Name des Produkts: ");

                double preis;
                bool preisValid = false;
                do
                {
                    string preisEingabe = GetUserInputWithExitOption("Preis des Produkts: ");
                    preisValid = double.TryParse(preisEingabe, out preis);
                    if (!preisValid)
                    {
                        Console.WriteLine("Ungültiger Wert. Bitte geben Sie eine positive Zahl ein.");
                    }
                    else if (preis < 0)
                    {
                        Console.WriteLine("Ungültiger Wert. Bitte geben Sie eine positive Zahl ein.");
                        preisValid = false;
                    }
                } while (!preisValid);

                string kategorie = GetUserInputWithExitOption("Kategorie des Produkts: ");
                string hersteller = GetUserInputWithExitOption("Hersteller des Produkts: ");

                Produkt produkt = new Produkt(name, Convert.ToDecimal(preis), kategorie, hersteller);
                produkte.Add(produkt);
                Console.Clear();
                Console.WriteLine("Produkt wurde hinzugefügt.");

                ProdukteSpeichern();
            }

            private int GetNextQuittungsID()
            {
                int nextQuittungsID = 0;

                return nextQuittungsID;
            }

            public bool UserHasRole999()
            {
                string benutzerName = GetCurrentUserName1();
                string usersOrdnerPfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Kassensystem", "Users");
                string benutzerDateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");

                if (!File.Exists(benutzerDateiPfad))
                {
                    return false;
                }

                string[] benutzerListe = File.ReadAllLines(benutzerDateiPfad);
                foreach (string benutzer in benutzerListe)
                {
                    string[] benutzerDaten = benutzer.Split(':');
                    if (benutzerDaten[0] == benutzerName && benutzerDaten[2] == "999")
                    {
                        return true;
                    }
                }
                return false;
            }

            public void QuittungErstellen(Produkt produkt)
            {
                int quittungsId = GetNextQuittungsID();

                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
                string kategorieOrdnerPfad = Path.Combine(quittungOrdnerPfad, produkt.Kategorie);
                string datum = DateTime.Now.ToString("yyyy-MM");
                string dateiName = $"{datum}_{produkt.Name}";
                string benutzerName = GetCurrentUserName1();

                Directory.CreateDirectory(kategorieOrdnerPfad);

                Bitmap bmp = new Bitmap(@".\..\..\..\..\WIKlassenBibliothek\template\temp.PNG");
                Graphics g = Graphics.FromImage(bmp);
                System.Drawing.Font font = new System.Drawing.Font("Bahnschrift SemiBold", 16, FontStyle.Bold);
                SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);

                g.DrawString($"{quittungsId}\n", font, brush, new System.Drawing.PointF(443, 387));
                g.DrawString($" {produkt.Name}", font, brush, new System.Drawing.PointF(160, 464));
                g.DrawString($" {produkt.Preis}€\n", font, brush, new System.Drawing.PointF(140, 538));
                g.DrawString($" {datum}\n", font, brush, new System.Drawing.PointF(613, 574));
                g.DrawString($" {benutzerName}\n", font, brush, new System.Drawing.PointF(200, 574));

                string quittungPdfPfad = Path.Combine(kategorieOrdnerPfad, $"{dateiName}.pdf");
                using (FileStream fs = new FileStream(quittungPdfPfad, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(bmp.Width, bmp.Height);
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(pageSize);
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(pageSize.Width, pageSize.Height);
                    pdfDoc.Add(img);
                    pdfDoc.Close();
                }

                string kategorieDateiPfad = Path.Combine(kategorieOrdnerPfad, $"{dateiName}.txt");

                if (!File.Exists(kategorieDateiPfad))
                {
                    File.WriteAllText(kategorieDateiPfad, $"Quittungen für Artikel {produkt.Name} :\n\n");
                }

                string dateiPfad = Path.Combine(kategorieOrdnerPfad, dateiName);
                Quittung quittung = new Quittung(GetNextQuittungsID(), DateTime.Now, produkt, benutzerName);
                File.AppendAllText(kategorieDateiPfad, quittung.ToString() + "\n");
                Console.WriteLine($"Quittung wird erstellt...");
                Console.WriteLine($"Quittung erstellt: {dateiPfad}");

                if (UserHasRole999())
                {
                    adminoberflaeche();
                }
                else
                {
                    KassensystemBenutzeroberflaeche();
                }
            }

            private void ProdukteSpeichern()
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
                string produktPfad = Path.Combine(produktOrdnerPfad, "produkte.txt");



                using (StreamWriter writer = new StreamWriter(produktPfad))
                {
                    HashSet<string> bereitsGespeicherteProdukte = new HashSet<string>();

                    foreach (Produkt produkt in produkte)
                    {
                        string produktEintrag = $"{produkt.Name},{produkt.Preis},{produkt.Kategorie},{produkt.Hersteller}";

                        if (!bereitsGespeicherteProdukte.Contains(produktEintrag))
                        {
                            writer.WriteLine(produktEintrag);
                            bereitsGespeicherteProdukte.Add(produktEintrag);
                        }
                    }
                }
            }

            public void ProduktLoeschen(string name)
            {
                produkte.RemoveAll(produkt => produkt.Name == name);
                Console.Clear();
                Console.WriteLine("Produkt wurde gelöscht.");

                ProdukteSpeichern();
                adminoberflaeche();
            }

            public void ProdukteAuflisten()
            {

                if (produkte.Count == 0)
                {
                    Console.WriteLine("Keine Produkte vorhanden.");
                    return;
                }

                Console.Clear();
                Console.WriteLine(header);
                Console.Title = "Kassensystem";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                   "                              >>> Produkt Liste <<<\n" +
                                                   "------------------------------------------------------------------------------------\n");
                foreach (Produkt produkt in produkte)
                {
                    Console.WriteLine($"\nName: {produkt.Name}\n" +
                            $"Preis: {produkt.Preis} Euro\n" +
                            $"Kategorie: {produkt.Kategorie}\n" +
                            $"Hersteller: {produkt.Hersteller}\n" +
                            "-----------------------------------");
                }

                Console.WriteLine("\nDrücken Sie 'B' und dann Enter, um zum Hauptmenü zurückzukehren.");
                string eingabe = Console.ReadLine();
                Console.Clear();
                if (eingabe.ToLower() == "b")
                {
                    Console.Clear();
                    if (UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
                    return;
                }
            }

            public void ProdukteAusDateiEinlesen()
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string dateiPfad = Path.Combine(desktopPfad, "Kassensystem", "Produkte", "produkte.txt");

                if (File.Exists(dateiPfad))
                {
                    using (StreamReader reader = new StreamReader(dateiPfad))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            try
                            {
                                string[] produktDaten = line.Split(',');
                                string name = produktDaten[0];
                                decimal preis = Convert.ToDecimal(produktDaten[1]);
                                string kategorie = produktDaten[2];
                                string hersteller = produktDaten[3];

                                Produkt produkt = new Produkt(name, preis, kategorie, hersteller);
                                produkte.Add(produkt);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ungültige Zeile: " + line);
                            }
                        }
                    }
                }
            }

            public void ProduktPreisAendern(string name)
            {
                Produkt produkt = produkte.Find(p => p.Name == name);

                if (produkt == null)
                {
                    Console.Clear();
                    Console.WriteLine("Produkt nicht gefunden.");
                    KassensystemBenutzeroberflaeche();
                    return;
                }

                decimal preis;

                while (true)
                {
                    Console.Write($"Aktueller Preis von {name}: {produkt.Preis} Euro\n" +
                                  $"Neuer Preis eingeben: ");
                    string input = Console.ReadLine();

                    if (!decimal.TryParse(input, out preis) || preis < 0)
                    {
                        Console.Clear() ;
                        Console.WriteLine(header);
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                   "                              >>> Preis Ändern <<<\n" +
                                                   "------------------------------------------------------------------------------------\n");
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                        continue;
                    }

                    break;
                }
                produkt.Preis = preis;
                Console.Clear();
                Console.WriteLine($"Preis von {name} wurde auf {preis} Euro geändert.");

                ProdukteSpeichern();
                KassensystemBenutzeroberflaeche();
            }
        }
    }
}



