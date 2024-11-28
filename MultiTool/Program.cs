using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Die Größe des Konsolenfensters wird an den Bildschirm angepasst.
// Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight); need to remove the comment when working normally in visual studio and not in github codespaces

//Schriftfarbe wird auf Grün gesetzt.
Console.ForegroundColor = ConsoleColor.Green;

Init();

string GeneratePassword(int length, bool useSpecialChars, bool useNumbers, bool useLowerCaseChars) {
    Random random = new Random();

    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
    const string specialChars = "!$%&#@€./`'+*-";
    const string nums = "0123456789";

    string operableString = chars;

    if (useSpecialChars) {
        operableString = $"{chars}{specialChars}";
    }

    if (useNumbers) {
        operableString += $"{nums}";
    }

    if (useLowerCaseChars) {
        operableString += $"{lowerChars}";
    }

    return new string(Enumerable.Repeat(operableString, length).Select(s => s[random.Next(s.Length)]).ToArray());
}

void Init()
{
    bool exitGenerator = false;

    int passwordLength = 6;
    bool specialCharactersSelected = false;

    bool includeNumbersInPassword = false;
    bool lowerCaseCharactersSelected = false;
    string generatedPassword = "";

    do
    {
        (int, int) cPosBM = Console.GetCursorPosition();

        Console.WriteLine("1. Set length of password");
        Console.WriteLine("2. Use special characters");
        Console.WriteLine("3. Include numbers in password");
        Console.WriteLine("4. Use lowercase characters.");
        Console.WriteLine("5. Generate password");

        string selectedMenu = "";

        Console.Write("Input: ");

        selectedMenu = Console.ReadLine().ToLower();
        
        switch (selectedMenu)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Now set the desired length of your password.");
                Console.Write("Length: ");

                string lengthInput = Console.ReadLine();

                if (!int.TryParse(lengthInput, out passwordLength))
                {
                    Console.Clear();
                    Console.WriteLine("Wrong number.");
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Selected password length: " + passwordLength);
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                }


                break;
            case "2":
                Console.Clear();

                specialCharactersSelected = !specialCharactersSelected;

                if (specialCharactersSelected) {
                    Console.WriteLine("Now using special characters. ");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                } else {
                    Console.WriteLine("Special characters have been turned off.");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                }

                break;
            case "3":
                Console.Clear();

                includeNumbersInPassword = !includeNumbersInPassword;

                if (includeNumbersInPassword) {
                    Console.WriteLine("Now using numbers.");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                } else {
                    Console.WriteLine("Numbers have been turned off.");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                }

                break;
            case "4":
                Console.Clear();

                lowerCaseCharactersSelected = !lowerCaseCharactersSelected;

                if (lowerCaseCharactersSelected) {
                    Console.WriteLine("Now using lowercase characters.");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                } else {
                    Console.WriteLine("Lowercase characters have been turned off.");
                    Console.WriteLine("Press enter to go back.");
                    Console.ReadKey();
                    Console.Clear();
                }

                break;
            case "5":
                Console.Clear();
                
                string randomPassword = GeneratePassword(passwordLength, specialCharactersSelected, includeNumbersInPassword, lowerCaseCharactersSelected);
                generatedPassword = randomPassword;

                Console.WriteLine($"Generated password: {generatedPassword}");
                Console.WriteLine("Press enter to go back.");
                Console.ReadKey();
                Console.Clear();

                break;
            default:
                (int, int) cPosAM = Console.GetCursorPosition();

                KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                break;
        }
    } while (!exitGenerator);
}


//Der Schrifthintergrund kann geändert werden.
//Console.BackgroundColor = ConsoleColor.DarkRed;

//Aufruf des Hauptmenüs.
//MultiTool.Hauptmenue.HauptmenueAufruf();
