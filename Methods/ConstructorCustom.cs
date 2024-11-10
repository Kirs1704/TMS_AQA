namespace Methods;

public class ConstructorCustom
{
    public int sizeMain;
    public string textMain;
    
    public ConstructorCustom(int size)
    {
        sizeMain = size;
    }

    public ConstructorCustom(string text)
    {
        textMain = text;
    }
    
    public ConstructorCustom(string text, int size)
    {
        textMain = text;
        sizeMain = size;
    }

}