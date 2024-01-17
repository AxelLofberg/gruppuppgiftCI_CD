using System;

namespace PersonligVerifiering
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vänligen ange ett svenskt personnummer:");
            string input = Console.ReadLine() ?? string.Empty;

            bool isValid = PersonligInfoValidator.Validera(input);

            if (isValid)
            {
                Console.WriteLine("Personnumret är giltigt.");
            }
            else
            {
                Console.WriteLine("Personnumret är ogiltigt.");
            }
        }
    }
}
