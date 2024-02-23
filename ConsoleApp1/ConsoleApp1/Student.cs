using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        string name;
        float grade;
        int group;
        
        public void get()
        {
            System.Console.WriteLine($"Student {name} is in group {group} and has a grade of {grade}");
        }

        public void set()
        {
            System.Console.Write("Enter name: ");
            name = System.Console.ReadLine();
            System.Console.Write("Enter group: ");
            group = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter grade: ");
            grade = float.Parse(System.Console.ReadLine());
        }

        public bool passed()
        {
            return grade >= 5;
        }

        public void changeGroup(int newGroup)
        {
            group = newGroup;
        }

        public void changeGrade(float bonus)
        {
            grade += bonus;
            if (grade > 10)
                grade = 10;
        }
    }
}
