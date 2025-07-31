// TriangleClassifier.cs
public class TriangleClassifier
{
    public string ClassifyTriangle(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            return "Sides must be positive numbers";
        }
        
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            return "Not a valid triangle";
        }

        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
