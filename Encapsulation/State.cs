namespace Encapsulation;

// сам основной класс приватным быть не может, в отличие от его полей и методов
// по умолчанию класс без указанного модификатора доступа является internal
public class State
{
    // если не указывать конкретно модификатор доступа, по умолчанию всегда будет private
    string defaultVar = "default";
    
    // поле доступно только из текущего класса
    private string privateVar = "private";
    
    
    // доступно в любом месте программы, а также для других программ и сборок
    public string publicVar = "public";
    
    // доступна из текущего класса и производных классов
    protected string protectedVar = "protected";

    // однако, класс внутри основного класса может быть приватным
    private class StateInside
    {
        
    }
    
    // вот пример приватного метода
    private void PrintPrivate() => Console.WriteLine(privateVar);
    

    void Test()
    {
        PrintPrivate();
    }

}