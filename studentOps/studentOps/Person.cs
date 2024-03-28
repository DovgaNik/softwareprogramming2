namespace March22nd
{
    internal class Person
    {
        private String firstName, lastName, phoneNumber, personalEmail;

        public Person(String firstName, String lastName, String phoneNumber, String personalEmail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.PersonalEmail = personalEmail;
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public String PersonalEmail
        {
            get { return personalEmail; }
            set { personalEmail = value; }
        }
    }
}
