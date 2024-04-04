namespace immigrationLib
{
    public class GenericDocument
    {
        private string name;
        private DateTime dateOfIssue;
        private int issuingAuthority;
        private string pINofPerson;
        private DateTime dateOfExpiration;

        public GenericDocument(string name, DateTime dateOfIssue, int issuingAuthority, string PINofPerson, DateTime dateOfExpiration)
        {
            Name = name;
            DateOfIssue = dateOfIssue;
            IssuingAuthority = issuingAuthority;
            this.PINofPerson = PINofPerson;
            this.dateOfExpiration = dateOfExpiration;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime DateOfIssue
        {
            get
            {
                return dateOfIssue;
            }
            set
            {
                if (value.Date <= DateTime.Now.Date)
                    dateOfIssue = value;
                else
                    throw new Exception("Date of issue cannot be in the future");
            }
        }

        public DateTime DateOfExpiration
        {
            get
            {
                return dateOfExpiration;
            }
            set
            {
                if (value.Date >= DateTime.Now.Date)
                    dateOfExpiration = value;
                else
                    throw new Exception("Date of expiration cannot be in the past");
            }
        }

        public int IssuingAuthority
        {
            get
            {
                return issuingAuthority;
            }
            set
            {
                issuingAuthority = value;
            }
        }

        public string PINofPerson
        {
            get
            {
                return pINofPerson;
            }
            set
            {
                pINofPerson = value;
            }
        }

        public override string ToString()
        {
            return $"{name} issued on {dateOfIssue.ToString("dd/MM/yyyy")} by {issuingAuthority} with PIN of {PINofPerson} expires on {dateOfExpiration.ToString("dd/MM/yyyy")}";
        }
    }
}
