using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March22nd
{
    internal class Subject
    {
        private String subjectName;
        int subjectCode;
        public Subject(String subjectName)
        {

            this.SubjectName = subjectName;
            this.subjectCode = (int)new Random().NextInt64(100, 1000);
        }

        public String SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public int SubjectCode
        {
            get { return subjectCode; }
        }
    }
}
