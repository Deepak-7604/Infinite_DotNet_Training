using System;

class Student
{
    int rollNo;
    string name;
    string studentClass;
    int semester;
    string branch;
    int[] marks = new int[5];

    // Constructor
    public Student(int rollNo, string name, string studentClass, int semester, string branch)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.studentClass = studentClass;
        this.semester = semester;
        this.branch = branch;
    }

    
    public void GetMarks()
    {
        Console.WriteLine("Enter marks for 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

   
    public void DisplayResult()
    {
        int total = 0;
        bool fail = false;

        for (int i = 0; i < 5; i++)
        {
            if (marks[i] < 35)
            {
                fail = true;
            }
            total += marks[i];
        }

        double average = total / 5.0;

        Console.WriteLine("\nAverage Marks: " + average);

        if (fail)
        {
            Console.WriteLine("Result: Failed (One or more subjects below 35)");
        }
        else if (average < 50)
        {
            Console.WriteLine("Result: Failed (Average less than 50)");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
    }

   
    public void DisplayData()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Class: " + studentClass);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("Branch: " + branch);

        Console.WriteLine("Marks:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(101, "Deepak", "Btech", 3, "Data Science");

        s1.GetMarks();
        s1.DisplayData();
        s1.DisplayResult();

        Console.ReadLine();
    }
}