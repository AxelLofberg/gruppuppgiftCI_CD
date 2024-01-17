namespace PersonligVerifiering
{
    public static class PersonligInfoValidator
    {
        public static bool Validera(string personnummer)
        {
            // Kontrollerar så att personnummersinmatningen inte är null
            if (personnummer == null)
            {
                return false;
            }

            // Kontrollera om personnumret har rätt längd.
            if (personnummer.Length != 10 && personnummer.Length != 12)
            {
                return false;
            }

            // Kontrollera om alla tecken är siffror, bindestreck eller plus-tecken.
            foreach (char c in personnummer)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    return false;
                }
            }

            // Om personnumret är i formatet "ÅÅMMDDXXXX" eller "ÅÅMMDD-XXXX"
            if (personnummer.Length == 10 || personnummer.Length == 12)
            {
                int år = int.Parse(personnummer.Substring(0, 2));
                int månad = int.Parse(personnummer.Substring(2, 2));
                int dag = int.Parse(personnummer.Substring(4, 2));

                // Kontroll för år, månad och dag.
                if (år < 0 || månad < 1 || månad > 12 || dag < 1 || dag > DateTime.DaysInMonth(2000 + år, månad))
                {
                    return false;
                }
            }


            // Ytterligare kontroller för personnummer kan läggas till här.

            return true;
        }
          public static string HamtaKon(string personnummer)
        {
            int sistaSiffror = int.Parse(personnummer.Substring(personnummer.Length - 2));
            return (sistaSiffror % 2 == 0) ? "Kvinna" : "Man";
        }
    }
}
