namespace ETKlassenBibliothek
{
    internal class Feature1
    {
        internal static void Feature_1()
        {
            Console.WriteLine("Resistance Calculator");
            Console.WriteLine("---------------------");

            while (true)
            {
                Console.WriteLine("Please choose an operation:");
                Console.WriteLine("1. Calculate resistance from voltage and current.");
                Console.WriteLine("2. Calculate current from voltage and resistance.");
                Console.WriteLine("3. Calculate voltage from current and resistance.");
                Console.WriteLine("Type 'exit' to quit.");

                int operationChoice;
                string input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }
                else if (!int.TryParse(input, out operationChoice) || operationChoice < 1 || operationChoice > 3)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("Resistance Calculator");
                Console.WriteLine("---------------------");

                string value1Description;
                double value1;
                switch (operationChoice)
                {
                    case 1:
                        value1Description = "Voltage (in volts)";
                        break;
                    case 2:
                        value1Description = "Voltage (in volts)";
                        break;
                    case 3:
                        value1Description = "Current (in amps)";
                        break;
                    default:
                        value1Description = "";
                        break;
                }
                do
                {
                    Console.Write($"Enter {value1Description}: ");
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        return;
                    }
                } while (!double.TryParse(input, out value1) || value1 < 0);

                Console.Clear();
                Console.WriteLine("Resistance Calculator");
                Console.WriteLine("---------------------");

                string value2Description;
                double value2;
                switch (operationChoice)
                {
                    case 1:
                        value2Description = "Current (in amps)";
                        break;
                    case 2:
                        value2Description = "Resistance (in ohms)";
                        break;
                    case 3:
                        value2Description = "Resistance (in ohms)";
                        break;
                    default:
                        value2Description = "";
                        break;
                }
                do
                {
                    Console.Write($"Enter {value2Description}: ");
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        return;
                    }
                } while (!double.TryParse(input, out value2) || value2 < 0);

                Console.Clear();
                Console.WriteLine("Resistance Calculator");
                Console.WriteLine("---------------------");

                double result;
                switch (operationChoice)
                {
                    case 1:
                        result = value1 / value2;
                        Console.WriteLine($"Resistance = {result} ohms");
                        break;
                    case 2:
                        result = value1 / value2;
                        Console.WriteLine($"Current = {result} amps");
                        break;
                    case 3:
                        result = value1 * value2;
                        Console.WriteLine($"Voltage = {result} volts");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            //Diese Ausgabe hilft Ihnen zu erkennen ob der Aufruf funktioniert.
        }
    }
}