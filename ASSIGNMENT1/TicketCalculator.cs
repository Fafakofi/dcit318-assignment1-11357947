public class TicketCalculator
{
    public double CalculateTicketPrice(int age)
    {
        if (age <= 12 || age >= 65)
        {
            return 7.0; 
        }
        else
        {
            return 10.0; 
        }
    }
}
