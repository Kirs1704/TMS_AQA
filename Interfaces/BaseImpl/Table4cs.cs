namespace Interfaces.BaseImpl;

public class Table4 : Device1
{
    public  override void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet4 NEW display: {information}");
    }
}