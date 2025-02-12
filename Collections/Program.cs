// See https://aka.ms/new-console-template for more information

using System.Collections;
using Collections.Helper;
using Collections.IList;

// ============================== IList ====================================
// ----------------------------- ArrayList ---------------------------------
//new ArrayListExample().Run();    // это называется анонимный объект. При таком подходе метод Run выполнится 1 раз и ссылка на анонимный объект будет уничтожена
/*ArrayList example = new ArrayList(); // создали новую коллекцию ArrayList
example.Add("Первый");                 // добавили элемент
PrintHelper.PrintCollection(example);*/ //так можно делать после того, как вывели метод для вывода элементов коллекции в отдельный класс

// ----------------------------- List ---------------------------------
/*List<int> list = new List<int>();
list.Add(2);
PrintHelper.PrintCollection(list);

Console.WriteLine("================");

List<int> list2 = new List<int>();
list2.Add(1);
list2.Add(2);
list2.Add(3);
list2.Add(4);
list2.Add(5); 
int result = list2.IndexOf(2);
list2.Insert(1, 5);
PrintHelper.PrintCollection(list2);
list2.Sort();
PrintHelper.PrintCollection(list2);
list2.Reverse();
Console.WriteLine("==================");
PrintHelper.PrintCollection(list2);
Console.WriteLine("Изначальный вариант:");
PrintHelper.PrintCollection(list2);
Console.WriteLine("Перевернутый вариант:");
list2.Reverse(1, 4);
PrintHelper.PrintCollection(list2);*/

// ----------------------------- LinkedList ---------------------------------
new LinkedListExample().Run();


