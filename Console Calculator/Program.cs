using Console_Calculator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
                Console.WriteLine("Welkom bij de Console Calculator");
                Console.WriteLine("Kies een operatie:");
                Console.WriteLine("1. Optellen");
                Console.WriteLine("2. Aftrekken");
                Console.WriteLine("3. Vermenigvuldigen");
                Console.WriteLine("4. Delen");
                Console.WriteLine("5. Afsluiten");
                Console.Write("Type Keuze: ");

                string keuze = Console.ReadLine();

                if (keuze == "5")
                {
                    Console.WriteLine("Bedankt voor het gebruik van de calculator. Tot ziens!");
                    break;
                }

                if (keuze != "1" && keuze != "2" && keuze != "3" && keuze != "4")
                {
                    Console.WriteLine("Ongeldige keuze. Kies een geldige operatie.");
                    continue; // Ga terug naar het begin van de lus
                }

                Console.Write("Voer het eerste getal in: ");
                if (!double.TryParse(Console.ReadLine(), out double getal1) || !DecimalValidator.IsValidDecimal(getal1))
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }

                Console.Write("Voer het tweede getal in: ");
                if (!double.TryParse(Console.ReadLine(), out double getal2) || !DecimalValidator.IsValidDecimal(getal2))
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }

                ICalculatorOperation calculatorOperation = null;
                switch (keuze)
                {
                    case "1":
                        calculatorOperation = new AddOperation();
                        break;
                    case "2":
                        calculatorOperation = new SubtractOperation();
                        break;
                    case "3":
                        calculatorOperation = new MultiplyOperation();
                        break;
                    case "4":
                        calculatorOperation = new DivideOperation();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Kies een geldige operatie. ");
                        return;
                }

                var resultaat = calculatorOperation.PerformOperation(getal1, getal2);

                if (!resultaat.isSuccess)
                {
                    Console.WriteLine($"Er is een fout opgetreden: {resultaat.ErrorMessage}");
                }
                Console.WriteLine($"Resultaat: {resultaat.Result}");
            }
        }
    }
}