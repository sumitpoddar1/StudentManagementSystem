using System;
using System.Collections.Generic;

class Student
{
    //Private fields for storing student data
    private string name;
    private int rollNumber;
    private double marks;

    //Public properties for controlled access to the private fields
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int RollNumber
    {
        get { return rollNumber; }
        set { rollNumber = value; }
    }

    public double Marks
    {
        get { return marks; }
        set { marks = value; }
    }

    // Constructor ( Constructor Overloading )
    public Student(string name, int rollNumber, double marks)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.marks = marks;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Marks: {marks}");
    }
}


class StudentManager
{
    //List to hold all students
    private List<Student> students;

    // Constructor
    public StudentManager()
    {
        students = new List<Student>();
    }

    //Method to add student
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    //Method to display all students
    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            student.DisplayInfo();
            Console.WriteLine("--------------");
        }
    }
}

class GradeCalculator
{
    //Method to calculate grade
    public string CalculateGrade(double marks)
    {
        if (marks >= 90)
            return "A";
        else if (marks >= 75)
            return "B";
        else if (marks >= 50)
            return "C";
        else
            return "F";
    }
}

class Program 
{
    static void Main(string[] args)
    {
        // Create an instance of StudentManager
        StudentManager studentManager = new StudentManager();

        // Create and add some students
        Student student1 = new Student("John Doe", 101, 85);
        Student student2 = new Student("Jane Smith", 102, 92);
        studentManager.AddStudent(student1);
        studentManager.AddStudent(student2);

        // Display students
        Console.WriteLine("Student List: ");
        studentManager.DisplayStudents();

        // Create an instance of GradeCalculator
        GradeCalculator gradeCalculator = new GradeCalculator();

        // Calculate and display grades
        Console.WriteLine("\nGrades: ");
        Console.WriteLine($"Grade for {student1.Name}: {gradeCalculator.CalculateGrade(student1.Marks)}");
        Console.WriteLine($"Grade for {student2.Name}: {gradeCalculator.CalculateGrade(student2.Marks)}");
    }
}

