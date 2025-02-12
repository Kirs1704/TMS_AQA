using Collections.Helper;

namespace Collections.IList;

public class LinkedListExample
{
    public void Run()
    {
        LinkedList<string> linkedList = new LinkedList<string>();  // В данном случае нельзя сразу задать емкость (Capacity) как в List
        
        // Добавление элементов в конец коллекции LinkedList
        linkedList.AddLast("Первый элемент");
        linkedList.AddLast("Второй элемент");
        linkedList.AddLast("Второй элемент");
        linkedList.AddLast("Второй элемент");
        linkedList.AddLast("Третий элемент");                 // т.о. каждый последующий добавленный элемент, будет вставать в конец списка
        
        // Добавление в начало списка
        linkedList.AddFirst("Элемент в начале списка");
        PrintHelper.PrintCollection(linkedList);
        
        // Использование свойств First и Last для получения первого и последнего элементов
        var firstElement = linkedList.First;                             // можно через var
        LinkedListNode<string> lastElement = linkedList.Last;                              // можно указать конкретно тип
        Console.WriteLine($"Первый элемент: {firstElement.Value}");                        // для вывода в консоль используется свойство Value
        Console.WriteLine($"Последний элемент: {lastElement.Value}");
        
        // Использование Contains для проверки наличия элемента в коллекции (точно так же, как и в Ilist)
        bool containsItem = linkedList.Contains("Первый элемент");                 // вернет True, если такой элемент есть, False - если нет
        Console.WriteLine($"Коллекция содержит элемент 'Первый элемент': {containsItem}");
        
        // Поиск элемента с помощью Find и вставка перед элементом AddBefore
        // ------------------------------------- Варинат № 1
        var findElement = linkedList.Find("Второй элемент");
        Console.WriteLine($"Найденный элемент: {findElement.Value}");
        
        // ------------------------------------- Вариант № 2
        LinkedListNode<string> findElement2 = linkedList.Find("Третий элемент");
        Console.WriteLine($"Найденный элемент: {findElement2?.Value}");               // В данном случае используется знак "?" для того, чтобы обработать ситуацию, если элемент найден не будет (null)
        
        // Выше мы нашли определенный элемент (findElement2). Теперь нам нужно вставить элемент перед ним. Это делается так:
        linkedList.AddBefore(findElement2, "test");     // 1 аргумент - элемент, перед которым вставляем, 2 - вставляемый элемент
        PrintHelper.PrintCollection(linkedList);
        
        // Использование Remove для удаления
        linkedList.Remove("test");
        Console.WriteLine("Результат после удаления элемента 'test': ");
        PrintHelper.PrintCollection(linkedList);

        // Для удаления всех ОДИНАКОВЫХ элементов из коллекции LinkedList, можно воспользоваться циклом
        while (linkedList.Remove("Второй элемент"))     // т.о. цикл будет удалять указанный элемент ПОКА не удалит все, а после - завершится
        {
        }
        Console.WriteLine("Рзультат после удаления одинаковых элементов: ");
        PrintHelper.PrintCollection(linkedList);
        
        // Чистка коллекции командой Clear
        linkedList.Clear();
        Console.WriteLine("Результат после очистки коллекции: ");
        PrintHelper.PrintCollection(linkedList);
        PrintHelper.PrintCollection(linkedList);
        


    }
}