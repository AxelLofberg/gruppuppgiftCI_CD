using System;

namespace PersonligVerifiering
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in ditt personnummer (YYMMDD-XXXX): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (PersonligInfoValidator.Validera(input))
            {
                Console.WriteLine("Personnumret är giltigt.");

                string kon = PersonligInfoValidator.HamtaKon(input);
                Console.WriteLine($"Kön: {kon}");
            }
            else
            {
                Console.WriteLine("Ogiltigt personnummer.");
            }

            Console.ReadLine();
        }
    }
}
