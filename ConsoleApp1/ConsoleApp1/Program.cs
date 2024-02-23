using ConsoleApp1;

Student student1 = new Student();
Student student2 = new Student();

student1.set();
student2.set();

student1.get();
student2.get();

System.Console.WriteLine(student1.passed());
System.Console.WriteLine(student2.passed());

student1.changeGroup(int.Parse(System.Console.ReadLine()));
student2.changeGroup(int.Parse(System.Console.ReadLine()));
