using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    {
        // Создаем список для хранения строк
        List<string> stringList = new List<string>(); // Если конкретно указываем тип (например как тут: string), то в коллекции могут быть только объекты такого типа
        List<string> stringList2 = new List<string>(16); // можно сразу установить Capacity (вместимость)
        Console.WriteLine($"Capacity 1: {stringList.Capacity}"); // вывод емкости коллекции на консоль
        Console.WriteLine($"Capacity 2: {stringList2.Capacity}");
        
        // Добавление элементов в List. Метод Add.
        stringList.Add("Первый элемент");
        stringList.Add("Второй элемент");
        stringList.Add("Третий элемент");
        stringList.AddRange(new []{"test","test1","test2"}); // можно добавить в коллекцию сразу несколько объектов (массивом)
        
        // Вставка элементов по индексу
        stringList.Insert(1, "Новый второй элемент"); // Первым указывается индекс, куда вставить элемент, вторым - сам элемент
        PrintHelper.PrintCollection(stringList);
        
        // Получение элемента по индексу
        string getElementForIndex = stringList[2];     // В данном случае выведется "Второй эелемент", так как его индекс в этой коллекции - 2
        
        // Проверка наличия элемента в коллекции
        bool isElementHere = stringList.Contains("Третий элемент"); // Вернет true, так как данный элемент есть в коллекции
        
        // Сортировка элементов
        stringList.Sort();         // Числа (int) отсортируются по возрастанию, текст (string) - по алфавиту
        
        // Бинарный поиск элемента
        // Перед бинарным поиском РЕКОМЕНДУЕТСЯ сначала отсортировать коллекцию
        var binSearch = stringList.BinarySearch("Первый элемент");    // вернет индекс элемента, если он есть в коллекции. Если такого нет, индекс будет отрицательный
        
        // Поиск индекса элемента (аналог Бинарного поиска). В основном лучше пользоваться этим
        var index = stringList.IndexOf("Первый элемент");             // вернет индекс элемента
        
        // Удаление элемента
        // Есть 4 варианта удаления (Remove): RemoveAll, RemoveAt, RemoveRange, Remove
        stringList.RemoveAt(2);                    // в качестве аргумента передается индекс элемента, который нужно удалить
        stringList.RemoveRange(2,3);          // с какого индекса начать и сколько удалить
        stringList.RemoveAll(item => item.Length > 10); // тут используется лямбда выражение: item => это какой-то элемент коллекции, item.Length > 10 - это условие. Если элемент соответствует условию, он будет удален
        stringList.Remove("Третий элемент");        // удаляет конкретный элемент (по значению) + возвращает true, если нашел и удалил, false - если нет
        
        // Reverse. Переворот коллекции задом наперед
        stringList.Reverse();                              // переворачивает полностью всю коллекцию
        stringList.Reverse(1, 2);                 // перевернет 2 элемента после элемента с индексом 1 (включая сам этот элемент)
        
        // Очистка
        stringList.Clear();                                // Удаляет все элементы из коллекции
        
        // Получение диапазона и копирование в новую коллекцию
        var newCollection = stringList.GetRange(1, 3);                    // скопирует 3 элемента, начиная с 1 индекса и поместит их в переменную newCollection
        
        // ЕЩЕ ОДИН ВАРИАНТ ПРОСТОГО ВЫВОДА КОЛЛЕКЦИИ В КОНСОЛЬ
        stringList.ForEach(eachItem => Console.WriteLine(eachItem));


    }
    
}