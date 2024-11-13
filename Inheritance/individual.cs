namespace Inheritance;

public class individual : Client
{
    public string FirstName;
    public string LastName;

    public individual(int id) : base(id) // вызывает конструктор родителя (base)
    {
        Console.WriteLine("Individual base HashCode: " + base.GetHashCode());
    }
    
}