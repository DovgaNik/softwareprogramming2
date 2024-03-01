using March_1_2024;

List<Student> students = new List<Student>();

int i = 0;
while (true)
{
    Console.WriteLine($"Please enter student {i + 1}: ");
    Console.Write("Please enter name: ");
    string name = Console.ReadLine();
    Console.Write("Please enter group: ");
    int group = int.Parse(Console.ReadLine());
    Console.Write("Please enter grade: ");
    int grade = int.Parse(Console.ReadLine());

    students.Add(new Student(name, group, grade));

    Console.Write("Do you wish to continue? : ");
    i++;
    if (Console.ReadLine().ToLower() == "no")
    {
        break;
    }
}


foreach (Student student in students)
    Console.WriteLine(student.ToString());

string[] lines = File.ReadAllLines("students.list");
foreach (string line in lines)
{
    students.Add(new Student(line));
}


foreach (Student student in students)
    Console.WriteLine(student.ToString());

students.Sort(Student.CompareByName);

Console.WriteLine("\nThe list of students ordered alphabetically by name:");

foreach (Student student in students)
    Console.WriteLine(student.ToString());

string text = "The list of students ordered alphabetically by name: \n";
foreach (Student student in students)
    text += student.ToString() + "\n";
File.WriteAllText("student_report_1.text", text);

Console.WriteLine("\n");

students.Sort(Student.CompareByGradeDesc);

Console.WriteLine("\nThe list of students in ordered by  descending grade:");

foreach (Student student in students)

    Console.WriteLine(student.ToString());

Console.WriteLine("\n");

text = "The list of students ordered by grade: \n";
foreach (Student student in students)
    text += student.ToString() + "\n";
File.WriteAllText("student_report_2.text", text);

int cnt = 0;

foreach (Student student in students)

{

    if (student.HasFailed())

    {

        Console.WriteLine($"{student.Name} has failed the exam with a grade of {student.Grade}.");

        cnt++;

    }

}

Console.WriteLine($"Total number of students who failed: {cnt}");

foreach (Student student in students)
{
    if (student.HasFailed())
    {
        student.Grade += 2;
    }
}

foreach (Student student in students)
    Console.WriteLine(student.ToString());

int sum = 0;

foreach (Student student in students)
{
    sum += student.Grade;
}


Console.WriteLine($"The average is {(double)sum / students.Count}");

int amountPassed = 0;
int amountFailed = 0;

foreach (Student student in students)
{
    if (student.HasFailed())
    {
        amountFailed++;
    }
    else
    {
        amountPassed++;
    }
}

Console.WriteLine($"The amount of students who passed is {amountPassed} which is {(double)amountPassed / students.Count * 100}% and the amount of students who failed is {amountFailed} which is {(double)amountFailed / students.Count * 100}%");