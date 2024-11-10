namespace Methods;

public class FullConstructor
{
    public int sizeMain;
    public string textMain;

    public FullConstructor()                          // конструктор № 1 (пустой)
    {
        sizeMain = 0;
        textMain = String.Empty;
    }
    
    public FullConstructor(int size)                 // конструктор № 2 (с параметром int)
    {
        sizeMain = size;
    }
 
    public FullConstructor(string text)             // конструктор № 3 (с параметром string)
    {
        textMain = text;
    }
    
    public FullConstructor(string text, int size)   // конструктор № 4 (с параметрами int и string)
    {
        textMain = text;
        sizeMain = size;
    }

    public void Print()                            // метод, который выводит в консоль сообщение с указанными параметрами, либо без них (если без, будет использован конструктор № 1)
    {
        Console.WriteLine($"Text: {textMain}, Size: {sizeMain}");
    }
}