namespace Module2Review_StudentGrades;

public class Student
{
    //Properties of Class "Student" (Name and ID)
    public string Name { get; set; }
    public int ID { get; set; }
    
    //Property/List (List of Grades)
    public static List<double> Grades { get; set; } = new List<double>();
    
    
    //Method to add individual student grade to Grades List
    public static void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    
    //Method to add multiple grades (array) to Grades List
    public static void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
    
    //Method to calculate Grade Average from Grades List
    public static double CalculateAverageGrade()
    {
        if (Grades == null)
        {
            return 0;
        }
        else
        {
            return Grades.Sum() / Grades.Count;
        }
        
        // double gradesSum = Grades.Sum();
        // double gradesAvg = gradesSum / Grades.Count;
        // return gradesAvg;
    }
    
}