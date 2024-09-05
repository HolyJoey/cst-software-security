using System;

namespace DivisionMultiplicationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Voer het eerste getal in:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Voer het tweede getal in:");
                int num2 = int.Parse(Console.ReadLine());

                // Delen
                Console.WriteLine($"Resultaat van deling: {CheckedDivision(num1, num2)}");

                // Vermenigvuldigen
                Console.WriteLine($"Resultaat van vermenigvuldiging: {CheckedMultiplication(num1, num2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ongeldige invoer. Voer alstublieft een geldig geheel getal in.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Kan niet delen door nul.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overloop gedetecteerd. Het resultaat is buiten het bereik van het datatype.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Er is een fout opgetreden: {ex.Message}");
            }
        }

        static int CheckedDivision(int dividend, int divisor)
        {
            checked
            {
                return dividend / divisor;
            }
        }

        static int CheckedMultiplication(int num1, int num2)
        {
            checked
            {
                return num1 * num2;
            }
        }
    }
}
