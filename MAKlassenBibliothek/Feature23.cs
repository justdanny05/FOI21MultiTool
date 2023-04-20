using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAKlassenBibliothek
{
    public class Feature23
    {
        internal static void Feature_23()
        {
            Console.Clear();

            double distance, speed, timeInHours, timeInMinutes, timeInSeconds;

            Console.WriteLine("Geben sie ihre Distanze in Kilometer an:");
            distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben sie ihre Geschwindigkeit in km/h an:");
            speed = double.Parse(Console.ReadLine());

            timeInHours = distance / speed;
            timeInMinutes = timeInHours * 60;
            timeInSeconds = timeInMinutes * 60;

            Console.WriteLine("{0} Stunden", timeInHours);
            Console.WriteLine("{0} minuten", timeInMinutes);
            Console.WriteLine("{0} sekunden", timeInSeconds);

            Console.ReadLine();

        }
    }
}

