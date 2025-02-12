using System.Collections;
using System.Text;
using Collections.Helper;

namespace Collections.IList;

public class ArrayListExample
{
    public void Run()
    {
        // Создаем ArrayList для хранения строк

        ArrayList stringList = new ArrayList();
        Console.WriteLine(stringList.Capacity); // этот метод покажет сколько элементов может содержать данный массив. Тут покажет 0
        
        
        // Добавляем элементы в ArrayList
        stringList.Add("Первый элемент");
        stringList.Add("Второй элемент");
        stringList.Add("Третий элемент");
        Console.WriteLine(stringList.Capacity); // а тут покажет уже 4
        
        
        // Создаем ArrayList для хранения строк в C# 12
        /*
         ArrayList stringList2 = 
        [
            "Первый";
            2,
            false,
            new StringBuilder("Object")
        ];
        */
        
        // Выводим элементы ArrayList
        Console.WriteLine("Элементы в ArrayList:");

        // foreach (string item in stringList2) // Ошибка, так как в данной коллекции элементы не только типа string. Правильнее написать так: foreach (var item in stringList2)
        foreach (var item in stringList) // Рекомендуемый вариант. + Так как этот метод будет использоваться часто, его удобнее вынести в отдельный класс (см. директорию Helper, класс PrintHelper)
        {
            Console.WriteLine(item);
        }
        
        //После создания отдельного класса PrintHelper (см. Helper) для вывода элементов коллекции можно использовать определенный в этом классе метод
        PrintHelper.PrintCollection(stringList);
        
        // Можно добавить элементы в ArrayList с разными типами данных таким способом:
        stringList.Add(4);                                // Допустимо, но не рекомендуется
        stringList.Add(true);                            // Допустимо, но не рекомендуется
        stringList.Add(new StringBuilder("Object"));    // Допустимо, но не рекомендуется
        Console.WriteLine(stringList.Capacity);        // здесь покажет уже 8, так как при добавлении новых элементов и превышении предыдущего Capacity, оно расширяется на х2
    }
}
