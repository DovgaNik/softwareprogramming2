using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March22nd
{
    internal class Professor
    {
        private String department, title;
        public Professor(String firstName, String lastName, String phoneNumber, String personalEmail, String department, String title) : base(firstName, lastName, phoneNumber, personalEmail)
        {
            this.Department = department;
            this.Title = title;
        }

        public String Department
        {
            get { return department; }
            set { department = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
