namespace PersonligVerifiering
{
    public static class PersonligInfoValidator
    {
        public static bool Validera(string personnummer)
        {
            // Kontrollera om personnumret har rätt längd.
            if (personnummer.Length != 10 && personnummer.Length != 11 && personnummer.Length != 12)
            {
                return false;
            }

            // Kontrollera om alla tecken är siffror (förutom eventuell bindestreck eller plus-tecken).
            foreach (char c in personnummer)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    return false;
                }
            }
  // Om personnumret är i formatet "ÅÅMMDDXXXX" eller "ÅÅMMDD-XXXX"
            if (personnummer.Length == 10  personnummer.Length == 12)
            {
                int år = int.Parse(personnummer.Substring(0, 2));
                int månad = int.Parse(personnummer.Substring(2, 2));
                int dag = int.Parse(personnummer.Substring(4, 2));

                // Enkel kontroll för år, månad och dag.
                if (år < 0  månad < 1  månad > 12  dag < 1 || dag > 31)
                {
                    return false;
                }
            }

            // Ytterligare kontroller för personnummer kan läggas till här.

            return true;
        }
    }
}