namespace Collections.Helper;

public static class PrintHelper  // Делаем класс и метод статическим, чтобы можно было использовать его без new PrintHelper()
{
    // Этот метод для вывода в консоль коллекции типа Ilist
    public static void PrintCollection(System.Collections.IList list) // На вход методу передается интерфейс Ilist
    {
        foreach (var item in list) 
        {
            Console.WriteLine(item);
        }
    }
    
    // Этот метод для вывода в консоль коллекции типа LinkedList
    public static void PrintCollection(LinkedList<string> list) // На вход методу передается интерфейс LinkedList
    {
        foreach (var item in list) 
        {
            Console.WriteLine(item);
        }
    }
}