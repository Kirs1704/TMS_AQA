using System;
using Properties;


namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Стандартный вариант работы с блоком данных (см. класс Person)
            Person person = new Person();                     // создали объект класса Person
            person.SetName("Kirs");                          // с помощью метода из этого класса задали значение
            Console.WriteLine($"{person.GetName()}");        // с помощью метода из класса получили заданное значение
            
            // Вариант № 2 (см. класс Person)

            person.Name = "Kirs";
            Console.WriteLine($"{person.Name}");
            Console.WriteLine($"{person.Surname}");
            Console.WriteLine($"{person.Fullname}");

            person.Salary = "500";
            Console.WriteLine($"{person.Salary}");
            
            Console.WriteLine($"{person.Salary1}");


        }
    }
}