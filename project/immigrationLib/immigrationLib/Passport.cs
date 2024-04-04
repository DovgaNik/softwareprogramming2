namespace immigrationLib
{
    public class Passport : GenericDocument
    {
        private string passportNumber;

        public Passport(string name, DateTime dateOfIssue, int issuingAuthority, string PINofPerson, string passportNumber, DateTime dateOfExpiry) : base(name, dateOfIssue, issuingAuthority, PINofPerson, dateOfExpiry)
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