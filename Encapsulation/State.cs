namespace Encapsulation;

public class State
{
    // если не указывать конкретно модификатор доступа, по умолчанию всегда будет private
    string defaultcVar = "default";
    
    // поле доступно только из текущего класса
    private string privateVar = "private";
    
    // доступно в любом месте программы, а также для других программ и сборок
    public string publicVar = "public";
    
    // доступна из текущего класса и производных классов
    protected string protectedVar = "protected";

}