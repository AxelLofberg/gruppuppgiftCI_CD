using System;

namespace PersonligVerifiering
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in ditt personnummer: ");
            string personnummer = Console.ReadLine();

            if (PersonligInfoValidator.Validera(personnummer))
            {
                Console.WriteLine("Personnumret är giltigt.");

                string kon = PersonligInfoValidator.HamtaKon(personnummer);
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
