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
        internal static void Feature_20()
        {
            Kassensystem kassensystem = new Kassensystem();
            kassensystem.ProdukteAusDateiEinlesen();

            bool exit = false;
            while (!exit)

            {
                Kassensystem.SetConsoleColor(ConsoleColor.Green);

                Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                               "                              >>> Kassensystem <<<\n" +
                                               "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("\nWas möchten Sie tun?");
                Console.WriteLine("1 - Produkt hinzufügen");
                Console.WriteLine("2 - Produkt Preis ändern");
                Console.WriteLine("3 - Produkt löschen");
                Console.WriteLine("4 - Produkte Liste");
                Console.WriteLine("5 - Programm beenden");

                string antwort = Console.ReadLine();
                switch (antwort)
                {
                    case "1":
                        kassensystem.ProduktHinzufuegen();
                        Produkt letztesProdukt = kassensystem.produkte.Last();
                        kassensystem.QuittungErstellen(letztesProdukt);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                       "                              >>> Preis Ändern <<<\n" +
                                                       "------------------------------------------------------------------------------------\n\n");
                        kassensystem.ProdukteAuflisten();
                        Console.Write("Welches Produkt möchten Sie bearbeiten? (Name eingeben): ");
                        string produktName = Console.ReadLine();
                        kassensystem.ProduktPreisAendern(produktName);
                        break;
                    case "3":
                        kassensystem.ProdukteAuflisten();
                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Wirtschaft"));
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                       "                              >>> Produkt Löschen <<<\n" +
                                                       "------------------------------------------------------------------------------------\n\n");
                        Console.Write("Welches Produkt möchten Sie löschen? (Name eingeben): ");
                        string name = Console.ReadLine();
                        kassensystem.ProduktLoeschen(name);
                        break;
                    case "4":
                        kassensystem.ProdukteAuflisten();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 5 ein.");
                        break;
                }
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
            public DateTime Datum { get; set; }
            public Produkt Produkt { get; set; }
            public int ID { get; set; }


            public Quittung(int id, DateTime datum, Produkt produkt)
            {
                this.ID = id;
                this.Datum = datum;
                this.Produkt = produkt;

            }

            public override string ToString()
            {
                return $"ID: {ID}\nDatum: {Datum}\nProdukt: {Produkt.Name} ({Produkt.Preis} Euro)\n ";
            }
        }

        class Kassensystem
        {
            string header = FiggleFonts.Slant.Render("Wirtschaft");
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
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                Directory.CreateDirectory(kassensystemOrdnerPfad);

                string produktOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Produkte");
                Directory.CreateDirectory(produktOrdnerPfad);

                string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
                Directory.CreateDirectory(quittungOrdnerPfad);


                Console.Clear();
                Console.WriteLine(header);
                Console.Title = "Kassensystem";
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                                   "                              >>> Produkt Hinzufügen <<<\n" +
                                                   "------------------------------------------------------------------------------------\n");
                Console.Write("Name des Produkts: ");
                string name = Console.ReadLine();

                double preis;
                bool preisValid = false;
                do
                {
                    Console.Write("Preis des Produkts: ");
                    string preisEingabe = Console.ReadLine();
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

                Console.Write("Kategorie des Produkts: ");
                string kategorie = Console.ReadLine();

                Console.Write("Hersteller des Produkts: ");
                string hersteller = Console.ReadLine();

                Produkt produkt = new Produkt(name, Convert.ToDecimal(preis), kategorie, hersteller);
                produkte.Add(produkt);
                Console.WriteLine("Produkt wurde hinzugefügt.");

                ProdukteSpeichern();

            }

            public void QuittungErstellen(Produkt produkt)
            {
                string desktopPfad = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string kassensystemOrdnerPfad = Path.Combine(desktopPfad, "Kassensystem");
                string quittungOrdnerPfad = Path.Combine(kassensystemOrdnerPfad, "Quittungen");
                string kategorieOrdnerPfad = Path.Combine(quittungOrdnerPfad, produkt.Kategorie);
                string datum = DateTime.Now.ToString("yyyy-MM");
                string dateiName = $"{datum}_{produkt.Name}";
                int quittungsId = quittungsIdCounter++;

                Directory.CreateDirectory(kategorieOrdnerPfad); // Verzeichnis erstellen, falls es noch nicht existiert

                Bitmap bmp = new Bitmap(@"C:\Users\Janluca\source\repos\FOI21MultiTool\WIKlassenBibliothek\template\temp.PNG");
                Graphics g = Graphics.FromImage(bmp);
                System.Drawing.Font font = new System.Drawing.Font("Bahnschrift SemiBold", 16);
                //lINKS Breite RECHTS Höhe
                SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);
                g.DrawString($"{quittungsId}\n", font, brush, new System.Drawing.PointF(443, 387));
                g.DrawString($" {produkt.Name}", font, brush, new System.Drawing.PointF(160, 464));
                g.DrawString($" {produkt.Preis}€\n", font, brush, new System.Drawing.PointF(140, 538));
                g.DrawString($" {datum}\n", font, brush, new System.Drawing.PointF(613, 574));

                //Rechts je höher zahl dest mehr runter
   
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
                Directory.CreateDirectory(kategorieOrdnerPfad);
                string kategorieDateiPfad = Path.Combine(kategorieOrdnerPfad, $"{dateiName}.txt");
                if (!File.Exists(kategorieDateiPfad))
                {
                    File.WriteAllText(kategorieDateiPfad, $"Quittungen für Artikel {produkt.Name} :\n\n");
                }

                string dateiPfad = Path.Combine(kategorieOrdnerPfad, dateiName);
                Quittung quittung = new Quittung(quittungsId, DateTime.Now, produkt);

                File.AppendAllText(kategorieDateiPfad, quittung.ToString() + "\n");
                Console.WriteLine($"Quittung wird erstellt...");
                Console.WriteLine($"Quittung erstellt: {dateiPfad}");
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
                Console.WriteLine("Produkt wurde gelöscht.");

                ProdukteSpeichern();
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
                if (eingabe.ToLower() == "b")
                {
                    Console.Clear();
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
                    Console.WriteLine("Produkt nicht gefunden.");
                    return;
                }


                Console.Write($"Aktueller Preis von {name}: {produkt.Preis} Euro\n" +
                              $"Neuer Preis eingeben: ");
                decimal preis = Convert.ToDecimal(Console.ReadLine());

                produkt.Preis = preis;
                Console.WriteLine($"Preis von {name} wurde auf {preis} Euro geändert.");

                ProdukteSpeichern();
            }



            static void Main(string[] args)
            {


            }
        }
    }
}



