namespace immigrationLib
{
    public class ResidencyPermit : GenericDocument
    {
        private string type;

        public ResidencyPermit (string name, DateTime dateOfIssue, string issuingAuthority, string PINofPerson, DateTime dateOfExpiration, string type) : base(name, dateOfIssue, issuingAuthority, PINofPerson, dateOfExpiration)
        {
            Type = type;
        }

        public string Type
        {
            get
        {
                return type;
            }
            set
        {
                type = value;
            }
        }
        
    }
}
