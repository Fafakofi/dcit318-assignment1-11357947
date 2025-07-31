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

        TicketCalculator isYoung = new TicketCalculator();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price = isYoung.CalculateTicketPrice(age);
        Console.WriteLine($"Your ticket price is: GHC{price}, enjoy your movie!");

       TriangleClassifier classifier = new TriangleClassifier();

        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        string result = classifier.ClassifyTriangle(side1, side2, side3);
        Console.WriteLine($"The triangle is {result}");
    }
}