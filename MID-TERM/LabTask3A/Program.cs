using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }
}


class Student : Person
{
    public int StudentID;

    
    public Student(string n, int a, int id) : base(n, a)
    {
        StudentID = id;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Student ID: " + StudentID);
    }
}

class ProgramA
{
    static void Main()
    {
        
        Student s1 = new Student("Rahim", 20, 101);

        Console.WriteLine("--- Student Details ---");
        s1.DisplayInfo();
    }
}