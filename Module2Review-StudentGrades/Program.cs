using System.Text.Json;

namespace Module2Review_StudentGrades;

class Program
{
    static void Main(string[] args)
    {
        //List of Type "Student"
        var students = new List<Student>();

        //4 Instances of Type "Student", populating Student List with each instance
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

    }



//Temp Entry for now
    // public static Student Joe = new Student()
    // {
    //     Grades = {33.3, 47.98},
    //     ID = 306785,
    //     Name = "Joseph",
    //         
    // };
}