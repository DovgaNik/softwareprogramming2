namespace immigrationLib
{
    internal class Passport : GenericDocument
    {
        private string passportNumber;

        public Passport(string name, DateTime dateOfIssue, string issuingAuthority, string PINofPerson, string passportNumber) : base(name, dateOfIssue, issuingAuthority, PINofPerson)
        {
            PassportNumber = passportNumber;
        }

        public string PassportNumber
        {
            get
            {
                return passportNumber;
            }
            set
            {
                passportNumber = value;
            }
        } 
    }
}