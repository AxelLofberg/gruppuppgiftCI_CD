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
