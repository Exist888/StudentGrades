using System.Text.Json;

namespace Module2Review_StudentGrades;

class Program
{
    static void Main(string[] args)
    {
        //List of Type "Student"
        var students = new List<Student>();

        //4 Instances of Type "Student"
        var student1 = new Student()
        {
            ID = 7854935,
            Name = "Frodo Baggins",
        };

        var student2 = new Student()
        {
            ID = 7854936,
            Name = "Samwise Gamgee",
        };

        var student3 = new Student()
        {
            ID = 7854937,
            Name = "Peregrin Took",
        };

        var student4 = new Student()
        {
            ID = 7854938,
            Name = "Pippin Took",
        };
        
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