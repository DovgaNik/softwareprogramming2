namespace March22nd
{
    internal class Student : Person
    {
        private double studentId;
        private String major, minor;
        private List<Grade> grades = new List<Grade>();

        public Student(String firstName, String lastName, String phoneNumber, String personalEmail, double studentId, String major, String minor) : base(firstName, lastName, phoneNumber, personalEmail)
        {
            this.StudentId = studentId;
            this.Major = major;
            this.Minor = minor;
        }

        public double StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public String Major
        {
            get { return major; }
            set { major = value; }
        }

        public String Minor
        {
            get { return minor; }
            set { minor = value; }
        }
        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }

    }
}
