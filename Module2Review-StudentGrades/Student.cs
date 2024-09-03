using System.Collections.Generic;

namespace Module2Review_StudentGrades;

public class Student
{
    //Properties of Class "Student" (Name and ID)
    public string Name { get; set; }
    public int ID { get; set; }
    
    //Property/List (List of Grades)
    public List<double> Grades { get; set; } = new List<double>();
    
    
    //Method to add individual student grade to Grades List
    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    
    //Method to add multiple grades (array) to Grades List
    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
    
    //Method to calculate Grade Average from Grades List
    public double CalculateAverageGrade()
    {
        if (Grades == null)
        {
            return 0;
        }
        else
        {
            return Grades.Sum() / Grades.Count;
        }
    }
}