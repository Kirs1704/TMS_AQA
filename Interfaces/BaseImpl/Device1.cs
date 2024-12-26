using Interfaces.Example;

namespace Interfaces.BaseImpl;

public  class Device1 : IDysplayable
{
    public  virtual void DisplayInformation(string information)
    {
        Console.WriteLine($"Tablet4 display: {information}");
    }
}
