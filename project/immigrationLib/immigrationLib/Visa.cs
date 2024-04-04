namespace immigrationLib
{
    internal class Visa : GenericDocument
    {
        private int daysAllowed;
        private int daysUsed;

        public Visa(string name, DateTime dateOfIssue, string issuingAuthority, string PINofPerson, int daysAllowed, int daysUsed, DateTime dateOfExpiration) : base(name, dateOfIssue, issuingAuthority, PINofPerson, dateOfExpiration)
        {
            DaysUsed = daysUsed;
            DaysAllowed = daysAllowed;
        }

        public int DaysAllowed
        {
            get
            {
                return daysAllowed;
            }
            set
            {
                daysAllowed = value;
            }
        }

        public int DaysUsed
        {
            get
            {
                return daysUsed;
            }
            set
            {
                daysUsed = value;
            }
        }

        public int daysRemaining() { 
        
            return daysAllowed - daysUsed;
        
        }
    }
}
