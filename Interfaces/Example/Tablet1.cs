namespace Interfaces.Example;

public class Tablet1 : IDysplayable, IChargeable
{
    public int SerialNumber;
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet dysplay: {information}"); // реализация отображения на экране планшета
    }

    public void Charge()
    {
        Console.WriteLine("Tablet заряжается....");
    }
}