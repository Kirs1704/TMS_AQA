namespace Interfaces.BaseImpl;

public class Table3 : Device
{
    public override void DisplayInformation(string information)
    {
        Console.WriteLine($"Table3 display: {information}");
    }
}