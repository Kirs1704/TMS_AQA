namespace Interfaces.Example;

public class Tablet : IDysplayable
{
    public int SerialNumber;
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet dysplay: {information}"); // реализация отображения на экране планшета
    }
}