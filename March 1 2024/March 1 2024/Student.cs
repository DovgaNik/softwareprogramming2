using System.Runtime.InteropServices;

namespace March_1_2024;
internal class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int group;
    private int grade;
    public int Group
    {
        get { return group; }
        set
        {
            if (value >= 610 && value <= 620)
                group = value;
            else
                throw new Exception("Group can't be below 610 or over 620!");
        }
    }

    public int Grade
    {
        get { return grade; }
        set
        {
            if (value >= 0 && value <= 10)
                grade = value;
            else
                throw new Exception("Grade can't be below 0 or over 10!");
        }
    }

    public Student(string name, int group, int grade)
    {
        this.name = name;
        this.group = group;
        this.grade = grade;
    }

    public Student(string studentData)
    {
        string[] parts = studentData.Split(';');
        if (parts.Length != 3)
            throw new ArgumentException("Invalid input format. Expected format: 'name;group;grade'");

        this.name = parts[0];
        this.group = int.Parse(parts[1]);
        this.grade = int.Parse(parts[2]);
    }

    public override string ToString()
    {
        return $"The student's name is {name} and they are in the group {group} and they got a grade: {grade}";
    }

    public static int CompareByName(Student a, Student b)
    {
        return string.Compare(a.name, b.name);
    }

    public static int CompareByGradeDesc(Student a, Student b)
    {
        return -a.grade.CompareTo(b.grade);
    }

    public bool HasFailed()
    {
        return Grade < 5;
    }

    public static Student operator +(Student student, int bonus)
    {
        int newGrade = Math.Min(student.Grade + bonus, 10); 
        return new Student(student.Name, student.Group, newGrade);
    }
}