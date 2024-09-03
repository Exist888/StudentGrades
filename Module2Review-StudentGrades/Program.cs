using System.Text.Json;
using System.Collections.Generic;

namespace Module2Review_StudentGrades;

class Program
{
    static void Main(string[] args)
    {
        //List of Type "Student"
        var students = new List<Student>();

        //4 Instances of Type "Student", and populating Student List with each instance
        var student1 = new Student()
        {
            ID = 7854935,
            Name = "Frodo Baggins",
        };
        students.Add(student1);

        var student2 = new Student()
        {
            ID = 7854936,
            Name = "Samwise Gamgee",
        };
        students.Add(student2);

        var student3 = new Student()
        {
            ID = 7854937,
            Name = "Peregrin Took",
        };
        students.Add(student3);

        var student4 = new Student()
        {
            ID = 7854938,
            Name = "Pippin Took",
        };
        students.Add(student4);
        
        //Calling AddGrade Method (overload) twice for each student, 1st as double, then as double[]
        student1.AddGrade(87.5);
        student1.AddGrade(94.5, 79.9, 89.8, 98.2);
        student2.AddGrade(93.4);
        student2.AddGrade(87.7, 81.1, 89.7, 97.5);
        student3.AddGrade(94.5);
        student3.AddGrade(87.6, 74.9, 73.3, 89.9);
        student4.AddGrade(80.9);
        student4.AddGrade(91.2, 78.8, 72.7, 93.7);

        foreach (var hobbitStudent in students)
        {
            Console.WriteLine($"Name: {hobbitStudent.Name}\n" +
                              $"ID: {hobbitStudent.ID}\n" +
                              $"List of Grades: {hobbitStudent.Grades}\n" +
                              $"Average of Grades: {hobbitStudent.CalculateAverageGrade():F1}");
        }

    }
}