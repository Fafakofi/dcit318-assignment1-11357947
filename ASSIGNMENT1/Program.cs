using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score:");
        int score;
        while (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
        {
            Console.WriteLine("Invalid input. Please enter a score between 0 and 100:");
        }

        GradeCalculator calculator = new GradeCalculator();
        string grade = calculator.CalculateGrade(score);
        Console.WriteLine($"Your grade is: {grade}");
    }
}