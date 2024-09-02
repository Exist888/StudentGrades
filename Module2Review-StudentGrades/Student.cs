namespace Module2Review_StudentGrades;

public class Student
{
    //Properties of Class "Student"
    public string Name { get; set; }
    public int ID { get; set; }
    
    //Grades List (property)
    public static List<double> Grades { get; set; } = new List<double>();

    
    //Method to add student grade to Grades List
    public static void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    
    //Method to add student grades to Grades List
    public static void AddGrade(double[] grades)
    {
        Grades.AddRange(grades);
    }
}