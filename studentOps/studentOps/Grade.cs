namespace March22nd
{
    internal class Grade
    {
        private int note;
        private int subjectID;

        public Grade(int grade, int subjectID)
        {
            this.Note = grade;
            this.SubjectID = subjectID;
        }

        public int Note
        {
            get { return note; }
            set { note = value; }
        }

        public int SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
        }
    }
}
