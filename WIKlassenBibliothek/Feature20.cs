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
using System.Globalization;
using static iTextSharp.text.pdf.AcroFields;
using static WIKlassenBibliothek.Feature20;
using System.Diagnostics;

namespace WIKlassenBibliothek
{
   internal class Feature20
   {
        private static string benutzerdateiPath1;
        private static produkt produkte;
        private static List<string> warenkorbProdukte;

        internal static void Feature_20()
        {


        string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
        Directory.CreateDirectory(kassensystemOrdnerPfad);

        string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
        Directory.CreateDirectory(produktOrdnerPfad);

        string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
        Directory.CreateDirectory(usersOrdnerPfad);

            string settingsFolder = Path.Combine(usersOrdnerPfad, "settings");
            string autoLoginPath1 = Path.Combine(settingsFolder, "settings.txt");


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

            if (!File.Exists(autoLoginPath1))
            {
                File.WriteAllText(autoLoginPath1, "autologin=false");

            }

        bool loggedIn = false;
        string benutzerName = "";
        string passwort = "";
        string auswahl;
        string benutzernameAdmin = "admin";
        string passwortAdmin = "777";
        string rechteadmin = "999";
        string benutzerdateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");

             bool UserHasRole999()
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


            if (File.Exists(autoLoginPath1))
            {
                string settings = File.ReadAllText(autoLoginPath1);

                if (!settings.Contains("readme=true"))
                {
                    Feature20.OpenReadmeFile();
                }
            }



            while (!loggedIn)
            {
                Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));

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
                    if (UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
                    File.WriteAllText(Path.Combine(usersOrdnerPfad, "loggedin.txt"), benutzerName);
                }
                else if (auswahl == "1" && !autologinEnabled)
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
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
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Neues Konto erstellen <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");

                    Console.Write("Benutzername: ");
                    string newBenutzerName = Console.ReadLine();

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


                    if (!userExists)
                    {
                        Console.Write("Passwort: ");
                        string newPasswort = Console.ReadLine();
                        string loggedinPath = Path.Combine(usersOrdnerPfad, "loggedin.txt");

                        Console.Write("Passwort erneut eingeben: ");
                        string newPasswortBestaetigen = Console.ReadLine();

                        if (newPasswort != newPasswortBestaetigen)
                        {
                            Console.Clear();
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
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Benutzer löschen <<<\n" +
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
                                if (benutzer.Length == 3 && benutzer[0] == benutzerZumLoeschen && Verschluesseln(passwortBestaetigen) == benutzer[1])
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
                                    if (benutzer.Length == 3 && benutzer[0] != benutzerZumLoeschen)
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

        public static void OpenReadmeFile()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string readmeDateiPfad = Path.Combine(@".\..\..\..\..\WIKlassenBibliothek\readme\readme.txt");
            if (File.Exists(readmeDateiPfad))
            {
                Process.Start("notepad.exe", readmeDateiPfad);

                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
                string settingsOrdnerPfad = Path.Combine(usersOrdnerPfad, "settings");
                string settingsDateiPfad = Path.Combine(settingsOrdnerPfad, "settings.txt");

                if (!Directory.Exists(settingsOrdnerPfad))
                {
                    Directory.CreateDirectory(settingsOrdnerPfad);
                }

                if (File.Exists(settingsDateiPfad))
                {
                    string settingsInhalt = File.ReadAllText(settingsDateiPfad);
                    if (!settingsInhalt.Contains("readme=true"))
                    {
                        settingsInhalt += "\nreadme=true";
                        File.WriteAllText(settingsDateiPfad, settingsInhalt);
                    }
                }
                else
                {
                    string settingsInhalt = "readme=true";
                    File.WriteAllText(settingsDateiPfad, settingsInhalt);
                }
            }
            else
            {
                Console.WriteLine("Die readme.txt-Datei existiert nicht.");
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
            string[] settings = content.Trim().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            bool autoLoginEnabled = false;

            foreach (string setting in settings)
            {
                string[] parts = setting.Trim().Split('=');
                if (parts.Length == 2 && parts[0].Trim().ToLower() == "autologin")
                {
                    bool value;
                    if (bool.TryParse(parts[1].Trim().ToLower(), out value))
                    {
                        autoLoginEnabled = value;
                    }
                }
            }

            return autoLoginEnabled;
        }

        public static void ToggleAutoLogin()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            string settingsFolder = Path.Combine(usersOrdnerPfad, "settings");
            string autoLoginPath = Path.Combine(settingsFolder, "settings.txt");

            bool autoLoginEnabled = IsAutoLoginEnabled();

            if (autoLoginEnabled)
            {
                string content = File.ReadAllText(autoLoginPath);
                content = content.Replace("autologin=true", "autologin=false");
                File.WriteAllText(autoLoginPath, content);
                Console.Clear();
                Console.WriteLine("Auto-Login ist jetzt deaktiviert.");
            }
            else
            {
                string content = File.ReadAllText(autoLoginPath);
                content = content.Replace("autologin=false", "autologin=true");
                File.WriteAllText(autoLoginPath, content);
                Console.Clear();
                Console.WriteLine("Auto-Login ist jetzt aktiviert.");
            }
        }

        public static List<string> BenutzerAuflisten()
        {
            string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
            Directory.CreateDirectory(kassensystemOrdnerPfad);

            string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
            Directory.CreateDirectory(produktOrdnerPfad);

            string usersOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "users");
            Directory.CreateDirectory(usersOrdnerPfad);

            string usersDateiPfad = Path.Combine(usersOrdnerPfad, "users.txt");

            List<string> benutzerListe = new List<string>();
            string header = FiggleFonts.Slant.Render("Kassensystem");

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
            string header = FiggleFonts.Slant.Render("Kassensystem");

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
                    Console.WriteLine($"Der Benutzer {benutzername} wurde dem Rang Admin hinzugefügt.");
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

            Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Admin-Kassensystem <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("\nWas möchten Sie tun?");
            Console.WriteLine("1 - Warenkorb anzeigen");
            Console.WriteLine("2 - Produkt hinzufügen");
            Console.WriteLine("3 - Produkt Preis ändern");
            Console.WriteLine("4 - Produkt löschen");
            Console.WriteLine("5 - Produkte Liste");
            Console.WriteLine("6 - Automatisch Angemeldet bleiben");
            Console.WriteLine("7 - Rechte vergeben");
            Console.WriteLine("8 - Benutzer Abmelden");
            Console.WriteLine("9 - Programm beenden");

            Console.WriteLine("");

            string antwort = kassensystem.GetUserInputWithExitOption("Bitte geben Sie eine Zahl zwischen 1 und 9 ein:");
            switch (antwort)
            {
                case "1":
                    produkt produkt = new produkt();
                    kassensystem.ErstelleWarenkorb(produkt);
                    break;
                case "2":
                    kassensystem.ProduktHinzufuegen();
                    produkt letztesProdukt = kassensystem.produkte.Last();
                    adminoberflaeche();
                    break;
                case "3":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Preis Ändern <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
                    string produktName = kassensystem.GetUserInputWithExitOption("Welches Produkt möchten Sie bearbeiten? (Name eingeben):");
                    kassensystem.ProduktPreisAendern(produktName);
                    break;
                case "4":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Produkt Löschen <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
                    string name = kassensystem.GetUserInputWithExitOption("Welches Produkt möchten Sie löschen? (Name eingeben):");
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        kassensystem.ProduktLoeschen(name);
                    }
                    else
                    {
                        Console.WriteLine("Kein gültiger Produktnamen eingegeben.");
                    }

                    break;
                case "5":
                    kassensystem.ProdukteAuflisten();
                    Console.Clear();
                    adminoberflaeche();
                    break;
                case "6":
                    ToggleAutoLogin();
                    adminoberflaeche();
                    break;
                case "7":
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
                case "8":
                    Console.Clear();
                    Console.WriteLine("Sie wurden abgemeldet!");
                    Feature20.Feature_20();
                    break;
                case "9":
                    Console.Clear();
                    WIMenue.WI_Menue();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 9 ein.");
                    if (kassensystem.UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
                    break;
            }
        }

        public static void KassensystemBenutzeroberflaeche()
        {

            Kassensystem kassensystem = new Kassensystem();
            kassensystem.ProdukteAusDateiEinlesen();

            Kassensystem.SetConsoleColor(ConsoleColor.Green);

            Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                            "                              >>> Kassensystem <<<\n" +
                            "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("\nWas möchten Sie tun?");
            Console.WriteLine("1 - Warenkorb anzeigen");
            Console.WriteLine("2 - Produkte Liste");
            Console.WriteLine("3 - Benutzer Abmelden");
            Console.WriteLine("4 - Programm beenden");
            Console.WriteLine("");

            string antwort = kassensystem.GetUserInputWithExitOption("Bitte geben Sie eine Zahl zwischen 1 und 4 ein:");
            switch (antwort)
            {
                case "1":
                    produkt produkt = new produkt();
                    kassensystem.ErstelleWarenkorb(produkt);
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

        public class produkt
        {
            public string Name { get; set; }
            public decimal Preis { get; set; }
            public string Kategorie { get; set; }
            public string Hersteller { get; set; }

            public produkt(string name, decimal preis, string kategorie, string hersteller)
            {
                Name = name;
                Preis = preis;
                Kategorie = kategorie;
                Hersteller = hersteller;
            }

            public produkt()
            {

            }
        }

        public class Quittung
        {
            private int ID;
            private DateTime Datum;
            private produkt Produkt;
            private string benutzerName;

            public Quittung(int id, DateTime Datum, produkt Produkt, string benutzerName)
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
            public void ErstelleWarenkorb(produkt produkte)
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string warenkorbOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Warenkorb");
                

                string benutzername = File.ReadAllText(Path.Combine(kassensystemOrdnerPfad, "users", "loggedin.txt"));
                string benutzerWarenkorbPfad = Path.Combine(warenkorbOrdnerPfad, benutzername);
                string warengekauft = Path.Combine(benutzerWarenkorbPfad, "gekauft");
                string quittungOrdnerPfad = Path.Combine(warengekauft, "Quittung");

                if (!Directory.Exists(quittungOrdnerPfad))
                {
                    Directory.CreateDirectory(quittungOrdnerPfad);
                }
                if (!Directory.Exists(benutzerWarenkorbPfad))
                {
                    Directory.CreateDirectory(benutzerWarenkorbPfad);
                }
                string warenkorbDateiPfad = Path.Combine(benutzerWarenkorbPfad, "warenkorb.txt");
                if (!File.Exists(warenkorbDateiPfad))
                {
                    File.Create(warenkorbDateiPfad).Dispose();
                }
                if (!Directory.Exists(warengekauft))
                {
                    Directory.CreateDirectory(warengekauft);
                }


                List<string> warenkorbProdukte = File.ReadAllLines(warenkorbDateiPfad).ToList();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                      "                              >>> Warenkorb <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");
                    if (warenkorbProdukte.Count > 0)
                    {
                        Console.WriteLine("In ihrem Warenkorb befinden sich zurzeit:\n");
                        decimal gesamtsumme = 0;
                        foreach (var produktString in warenkorbProdukte)
                        {
                            var produktTeile = produktString.Split(',');
                            if (produktTeile.Length >= 2)
                            {
                                var name = produktTeile[0];
                                var preis = decimal.Parse(produktTeile[1]);
                                var produkts = new produkt(name, preis, "", "");

                                Console.WriteLine($"- {produkts.Name}: {produkts.Preis.ToString("N2")} Euro");
                                gesamtsumme += produkts.Preis;
                            }
                            else
                            {
                                Console.WriteLine($"Ungültiger Produkt-String: {produktString}");
                            }
                        }

                        Console.WriteLine($"\nGesamtsumme: {gesamtsumme.ToString("N2")} Euro");
                    }


                    if (warenkorbProdukte.Count == 0)
                    {
                        Console.WriteLine("Ihr Warenkorb ist leer.\n");
                    }


                    Console.WriteLine("\nMöchten Sie ein Produkt zum Warenkorb hinzufügen (Ja/Nein)?");
                    string antwort = Console.ReadLine();
                    if (antwort.ToLower() == "ja")
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                          "                              >>> Warenkorb <<<\n" +
                                          "------------------------------------------------------------------------------------\n\n");
                        Console.WriteLine("Bitte geben Sie den Namen des Produkts ein, das Sie zum Warenkorb hinzufügen möchten:");
                        string produktNames = Console.ReadLine();
                        ProduktZumWarenkorbHinzufügen(produktNames);
                    }
                    else if (antwort.ToLower() == "nein")
                    {
                        Console.WriteLine("\nMöchten Sie zur Kasse gehen? (Ja/Nein)");
                        string ant = Console.ReadLine();
                        if (ant.ToLower() == "ja")
                        {
                            Console.Clear();
                            Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                              "                              >>> Kasse <<<\n" +
                                              "------------------------------------------------------------------------------------\n\n");

                            Console.WriteLine("Folgende Waren werden zur Kasse gebracht:\n");

                            decimal gesamtsumme = 0;
                            List<produkt> produkt = new List<produkt>();
                            foreach (var produktString in warenkorbProdukte)
                            {
                                var produktTeile = produktString.Split(',');
                                if (produktTeile.Length >= 2)
                                {
                                    var name = produktTeile[0];
                                    var preis = decimal.Parse(produktTeile[1]);
                                    var produktss = new produkt(name, preis, "", "");

                                    Console.WriteLine($"- {produktss.Name}: {produktss.Preis.ToString("N2")} Euro");
                                    gesamtsumme += produktss.Preis;
                                    produkt.Add(produktss);
                                }
                                else
                                {
                                    Console.WriteLine($"Ungültiger Produkt-String: {produktString}");
                                }
                            }

                            Console.WriteLine($"\nGesamtsumme: {gesamtsumme.ToString("N2")} Euro");

                            Console.WriteLine("\nMöchten Sie eine Quittung erhalten? (ja/nein)");
                            ant = Console.ReadLine();

                            if (ant.ToLower() == "ja")
                            {
                                foreach (produkt produkttt in produkt)
                                {
                                    Console.Clear();
                                    int anzahlWarenkorbDateien = Directory.GetFiles(warengekauft, "warenkorb*").Length;
                                    string neueDateiName = "warenkorb" + (anzahlWarenkorbDateien + 1).ToString() + ".txt";
                                    string neueDateiPfad = Path.Combine(warengekauft, neueDateiName);
                                    File.Copy(warenkorbDateiPfad, neueDateiPfad);
                                    File.WriteAllText(warenkorbDateiPfad, string.Empty);
                                    QuittungErstellen(warenkorbProdukte);

                                }
                            }

                            else if (ant.ToLower() == "nein")
                            {
                                Console.Clear();
                                int anzahlWarenkorbDateien = Directory.GetFiles(warengekauft, "warenkorb*").Length;
                                string neueDateiName = "warenkorb" + (anzahlWarenkorbDateien + 1).ToString() + ".txt";
                                string neueDateiPfad = Path.Combine(warengekauft, neueDateiName);
                                File.Copy(warenkorbDateiPfad, neueDateiPfad);
                                File.WriteAllText(warenkorbDateiPfad, string.Empty);
                                Console.WriteLine("Vielen Dank für Ihren Einkauf!");
                            }

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
                        else if (ant.ToLower() == "nein")
                        {
                            Console.Clear();
                            Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                              "                              >>> Kasse <<<\n" +
                                              "------------------------------------------------------------------------------------\n\n");

                            Console.WriteLine("Folgende Waren sind zur Zeit im Warenkorb:\n");

                            decimal gesamtsumme = 0;
                            foreach (var produktString in warenkorbProdukte)
                            {
                                var produktTeile = produktString.Split(',');
                                if (produktTeile.Length >= 2)
                                {
                                    var name = produktTeile[0];
                                    var preis = decimal.Parse(produktTeile[1]);
                                    var produkt = new produkt(name, preis, "", "");

                                    Console.WriteLine($"- {produkt.Name}: {produkt.Preis.ToString("N2")} Euro");
                                    gesamtsumme += produkt.Preis;
                                }
                                else
                                {
                                    Console.WriteLine($"Ungültiger Produkt-String: {produktString}");
                                }
                            }

                            Console.WriteLine($"\nGesamtsumme: {gesamtsumme.ToString("N2")} Euro");

                            Console.WriteLine($"\nWollen Sie den Warenkorb verlassen? (Ja/Nein)");
                            string ant1 = Console.ReadLine();

                            if (ant1.ToLower() == "ja")
                            {
                                if (UserHasRole999())
                                {
                                    Console.Clear ();
                                    Console.WriteLine("Sie haben den Warenkorb verlassen");
                                    adminoberflaeche();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sie haben den Warenkorb verlassen");
                                    KassensystemBenutzeroberflaeche();
                                }

                            }
                            else if (ant1.ToLower() == "nein")
                            {
                                Console.Clear();
                                break;
                            }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                          "                              >>> Warenkorb <<<\n" +
                                          "------------------------------------------------------------------------------------\n\n");
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'ja' oder 'nein' ein.");
                        Console.ReadKey();
                        continue;
                    }
                }
            }
        }         

      public void ProduktZumWarenkorbHinzufügen(string produktName)
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                List<produkt> produkte = ProdukteAusDateiEinlesen();
                produkt produkt = produkte.FirstOrDefault(p => p.Name.Equals(produktName, StringComparison.OrdinalIgnoreCase));
                if (produkt == null)
                {
                    Console.WriteLine("Das Produkt wurde nicht gefunden.");
                    ErstelleWarenkorb(produkt);
                    return;
                }
                string benutzername = File.ReadAllText(Path.Combine(kassensystemOrdnerPfad, "users", "loggedin.txt"));
                string warenkorbDateiPfad = Path.Combine(kassensystemOrdnerPfad, "Warenkorb", benutzername, "warenkorb.txt");
                using (StreamWriter writer = File.AppendText(warenkorbDateiPfad))
                {
                    writer.WriteLine($"{produkt.Name},{produkt.Preis}");
                }
                List<string> warenkorb = new List<string>(File.ReadAllLines(warenkorbDateiPfad));
                if (warenkorb.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                    "                              >>> Warenkorb <<<\n" +
                                    "------------------------------------------------------------------------------------\n\n");
                    Console.WriteLine($"Das Produkt '{produktName}' wurde zum Warenkorb hinzugefügt, der Warenkorb ist jedoch leer.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                    Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                    "                              >>> Warenkorb <<<\n" +
                                    "------------------------------------------------------------------------------------\n\n");


                    Console.WriteLine($"Das Produkt '{produktName}' wurde zum Warenkorb hinzugefügt.");
                    Console.WriteLine("Möchten Sie noch weitere Produkte hinzufügen? (Ja/Nein)");
                    string antwort = Console.ReadLine();
                    if (antwort.Equals("ja", StringComparison.OrdinalIgnoreCase))
                    {

                        Console.WriteLine("Welches Produkt möchten Sie hinzufügen?");
                        string weiteresProduktName = Console.ReadLine();
                        ProduktZumWarenkorbHinzufügen(weiteresProduktName);
                    }
                    else if (antwort.Equals("nein", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        ErstelleWarenkorb(new produkt());
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Kassensystem"));
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                          "                              >>> Warenkorb <<<\n" +
                                          "------------------------------------------------------------------------------------\n\n");
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'ja' oder 'nein' ein.");
                        Console.ReadKey();
                    }

                }
            }
            
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

                    if (UserHasRole999())
                    {
                        adminoberflaeche();
                    }
                    else
                    {
                        KassensystemBenutzeroberflaeche();
                    }
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

                        if (UserHasRole999())
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
                        Console.Write("Ungültige Eingabe. Bitte geben Sie eine Zeichenkette ein: ");
                        input = Console.ReadLine();
                    }
                }

                return input.Trim();
            }

            string header = FiggleFonts.Slant.Render("Kassensystem");
            public List<produkt> produkte = new List<produkt>();
            private List<Quittung> quittungen = new List<Quittung>();
            private int quittungsIdCounter = 1;
            private Stream quittungPfad;
            private static int anzahlWarenkorbDateien;

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

                produkt produkt = new produkt(name, Convert.ToDecimal(preis), kategorie, hersteller);
                produkte.Add(produkt);
                Console.Clear();
                Console.WriteLine("Produkt wurde hinzugefügt.");

                ProdukteSpeichern();
            }

            private const string QuittungsIDDateiName = "letzteQuittungsID.txt";
            private int letzteQuittungsID = 0;

            private void LadeLetzteQuittungsID()
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem", "users", "settings");
                string quittungsIDDateiPfad = Path.Combine(kassensystemOrdnerPfad, QuittungsIDDateiName);

                if (File.Exists(quittungsIDDateiPfad))
                {
                    string quittungsIDText = File.ReadAllText(quittungsIDDateiPfad);
                    int quittungsID;
                    if (int.TryParse(quittungsIDText, out quittungsID))
                    {
                        letzteQuittungsID = quittungsID;
                    }
                }
            }

            private void SpeichereLetzteQuittungsID()
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem", "users", "settings");
                string quittungsIDDateiPfad = Path.Combine(kassensystemOrdnerPfad, QuittungsIDDateiName);

                File.WriteAllText(quittungsIDDateiPfad, letzteQuittungsID.ToString());
            }


            private int GetNextQuittungsID()
            {
                letzteQuittungsID++;
                SpeichereLetzteQuittungsID();
                return letzteQuittungsID;
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


            public void QuittungErstellen(List<string> warenkorbProdukte)
            {
                int quittungsId = GetNextQuittungsID();
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string gekauftOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Warenkorb", GetCurrentUserName1(), "gekauft", "Quittung");
                string datum = DateTime.Now.ToString("yyyy-MM");
                string neueDateiName = $"warenkorb{Kassensystem.anzahlWarenkorbDateien + 1}";
                string dateiName = $"{datum}_{neueDateiName}";
                Directory.CreateDirectory(gekauftOrdnerPfad);

                string quittungPdfPfad = Path.Combine(gekauftOrdnerPfad, $"{dateiName}.pdf");
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document();
                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, new FileStream(quittungPdfPfad, FileMode.Create));
                pdfDoc.Open();

                foreach (string produkt in warenkorbProdukte)
                {
                    string[] produktDetails = produkt.Split(',');
                    string produktName = produktDetails[0];
                    double produktPreis = Convert.ToDouble(produktDetails[1]);

                    Bitmap bmp = new Bitmap(@".\..\..\..\..\WIKlassenBibliothek\template\temp.PNG");
                    Graphics g = Graphics.FromImage(bmp);
                    System.Drawing.Font font = new System.Drawing.Font("Bahnschrift SemiBold", 16, FontStyle.Bold);
                    SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);

                    g.DrawString($"{quittungsId}\n", font, brush, new System.Drawing.PointF(443, 387));
                    g.DrawString($" {produktName}", font, brush, new System.Drawing.PointF(160, 464));
                    g.DrawString($" {produktPreis}€\n", font, brush, new System.Drawing.PointF(140, 538));
                    g.DrawString($" {datum}\n", font, brush, new System.Drawing.PointF(613, 574));
                    g.DrawString($" {GetCurrentUserName1()}\n", font, brush, new System.Drawing.PointF(200, 574));
                    pdfDoc.NewPage();
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(pdfDoc.PageSize.Width, pdfDoc.PageSize.Height);
                    pdfDoc.Add(img);
                }

                pdfDoc.Close();


                Kassensystem.anzahlWarenkorbDateien++;



                string kategorieDateiPfad = Path.Combine(gekauftOrdnerPfad, $"{dateiName}.txt");

                if (!File.Exists(kategorieDateiPfad))
                {
                    File.WriteAllText(kategorieDateiPfad, $"Quittungen für alle Artikel im Warenkorb:\n\n");
                }

                string quittungText = $"Datum: {datum}\nKäufer: {GetCurrentUserName1()}\n\n";
                string produktListe = "Produktliste: ";
                foreach (string produkt in warenkorbProdukte)
                {
                    string[] produktDetails = produkt.Split(',');
                    string produktName = produktDetails[0];
                    produktListe += produktName + ", ";
                }
                produktListe = produktListe.Remove(produktListe.Length - 2);
                quittungText += produktListe + "\n";
                foreach (string produkt in warenkorbProdukte)
                {
                    string[] produktDetails = produkt.Split(',');
                    string produktName = produktDetails[0];
                    double produktPreis = Convert.ToDouble(produktDetails[1]);

                    quittungText += $"Produkt: {produktName}: {produktPreis}€\n";
                }

                quittungText += "\n";

                File.AppendAllText(kategorieDateiPfad, quittungText);


                SpeichereLetzteQuittungsID();
                Console.WriteLine("TEST");
                string dateiPfad = Path.Combine(gekauftOrdnerPfad, dateiName);
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

                List<string> bereitsGespeicherteProdukte = new List<string>();

                if (File.Exists(produktPfad))
                {
                    bereitsGespeicherteProdukte = File.ReadAllLines(produktPfad).ToList();
                }

                using (StreamWriter writer = new StreamWriter(produktPfad))
                {
                    foreach (produkt produkt in produkte)
                    {
                        string produktEintrag = $"{produkt.Name},{produkt.Preis},{produkt.Kategorie},{produkt.Hersteller}";

                        if (bereitsGespeicherteProdukte.Contains(produktEintrag))
                        {
                            bereitsGespeicherteProdukte.Remove(produktEintrag);
                        }

                        writer.WriteLine(produktEintrag);
                    }

                    foreach (string produktEintrag in bereitsGespeicherteProdukte)
                    {
                        writer.WriteLine(produktEintrag);
                    }
                }
            }

            public void ProduktLoeschen(string produktName)
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
                string produktPfad = Path.Combine(produktOrdnerPfad, "produkte.txt");

                if (File.Exists(produktPfad))
                {
                    string[] zeilen = File.ReadAllLines(produktPfad);
                    bool produktGefunden = false;

                    for (int i = 0; i < zeilen.Length; i++)
                    {
                        if (zeilen[i].StartsWith(produktName + ","))
                        {
                            produktGefunden = true;
                            List<string> zeilenListe = new List<string>(zeilen);
                            zeilenListe.RemoveAt(i);
                            File.WriteAllLines(produktPfad, zeilenListe.ToArray());
                            Console.Clear();
                            Console.WriteLine($"Produkt {produktName} wurde gelöscht.");
                            adminoberflaeche();
                            break;
                        }
                    }

                    if (!produktGefunden)
                    {
                        Console.Clear();
                        Console.WriteLine($"Produkt {produktName} nicht gefunden.");
                        adminoberflaeche();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Datei {produktPfad} nicht gefunden.");
                    adminoberflaeche();
                }
            }


            public List<Feature20.produkt> ProdukteAusDateiLesen(string dateiPfad)
            {
                List<Feature20.produkt> produkte = new List<Feature20.produkt>();

                try
                {
                    using (StreamReader sr = new StreamReader(dateiPfad))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] tokens = line.Split(',');
                            string name = tokens[0];
                            decimal preis = decimal.Parse(tokens[1]);
                            string kategorie = tokens[2];
                            string hersteller = tokens[3];
                            Feature20.produkt produkt = new Feature20.produkt(name, preis, kategorie, hersteller);
                            produkte.Add(produkt);
                        }
                    }
                }
                catch (Exception ex)
                {
                }

                return produkte;
            }

            public void ProdukteAuflisten()
            {
                Console.Clear();
                Console.WriteLine(header);
                Console.Title = "Kassensystem";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                           "                              >>> Produktliste <<<\n" +
                                                           "------------------------------------------------------------------------------------\n");

                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
                string produktPfad = Path.Combine(produktOrdnerPfad, "produkte.txt");

                List<Feature20.produkt> produkte = ProdukteAusDateiLesen(produktPfad);

                foreach (Feature20.produkt produkt in produkte)
                {
                    Console.WriteLine($"Name: {produkt.Name}\n" +
                                               $"Preis: {produkt.Preis} Euro\n" +
                                               $"Kategorie: {produkt.Kategorie}\n" +
                                               $"Hersteller: {produkt.Hersteller}\n");
                    Console.WriteLine("------------------------------------------------------------------------------------\n");
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
                }
            }

            public List<produkt> ProdukteAusDateiEinlesen()
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string dateiPfad = Path.Combine(desktopPfad, "Kassensystem", "Produkte", "produkte.txt");

                List<produkt> produkte = new List<produkt>();
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

                                produkt produkt = new produkt(name, preis, kategorie, hersteller);
                                produkte.Add(produkt);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                }
                return produkte;
            }

            public void ProduktPreisAendern(string produktName)
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
                string produktPfad = Path.Combine(produktOrdnerPfad, "produkte.txt");

                List<Feature20.produkt> produkte = new List<Feature20.produkt>();

                // Lese alle Produkte aus der Datei und speichere sie in der Liste
                string[] lines = File.ReadAllLines(produktPfad);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string name = parts[0];
                        decimal preis = decimal.Parse(parts[1], CultureInfo.InvariantCulture);
                        string kategorie = parts[2];
                        string hersteller = parts[3];
                        produkte.Add(new Feature20.produkt(name, preis, kategorie, hersteller));
                    }
                    else
                    {
                       
                    }

                }

                // Suche das Produkt in der Liste und ändere den Preis
                Feature20.produkt produkt = produkte.FirstOrDefault(p => p.Name == produktName);
                if (produkt == null)
                {
                    Console.Clear();
                    Console.WriteLine("Produkt nicht gefunden.");
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

                decimal neuerPreis;
                while (true)
                {
                    Console.Write($"Aktueller Preis von {produkt.Name}: {produkt.Preis} Euro\n" +
                                    $"Neuer Preis eingeben: ");
                    string input = Console.ReadLine();

                    if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out neuerPreis) || neuerPreis < 0)
                    {
                        Console.Clear();
                        Console.WriteLine(header);
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                            "                              >>> Preis Ändern <<<\n" +
                                            "------------------------------------------------------------------------------------\n");
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                        continue;
                    }

                    break;
                }

                produkt.Preis = neuerPreis;

                // Schreibe die aktualisierten Produkte in die Datei
                using (StreamWriter writer = new StreamWriter(produktPfad))
                {
                    foreach (Feature20.produkt p in produkte)
                    {
                        writer.WriteLine($"{p.Name},{p.Preis.ToString(CultureInfo.InvariantCulture)},{p.Kategorie},{p.Hersteller}");
                    }
                }

                Console.Clear();
                Console.WriteLine($"Preis von {produkt.Name} wurde auf {neuerPreis} Euro geändert.");
                ProdukteSpeichern();
                if (UserHasRole999())
                {
                    adminoberflaeche();
                }
                else
                {
                    KassensystemBenutzeroberflaeche();
                }
            }




        }
    }
}

