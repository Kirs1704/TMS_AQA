using System;

namespace Arrays
{
    static class Program
    {
        static void Main(string[] args)
        {
            //================ объявление массивов ==============================

            int[] array1 = { 1, 2, 3, 4, 6 };
            int[] array2 = new int[4];

            //объявление через переменную
            int[] array3;
            int n = 4;
            array3 = new int[n];

            Console.WriteLine("Length: " + array1.Length);                                   // количество всех элементов
            Console.WriteLine("Rank: " + array1.Rank);                                       // ранк массива
            Console.WriteLine("GetLength(0): " + array1.GetLength(0));               // количество строк (для многомерного массива)
            Console.WriteLine("GetUpperBound(0): " + array1.GetUpperBound(0));       // Верхний индекс строк (для многомерного массива)
            
            //обращение к элементу массива
            Console.WriteLine(array1[3]); //выведет элемент массива с индексом "3". То есть число 4 в массиве array1
            
            
            //изменить значение элемента массива
            Console.WriteLine(array1[0]); //выводит элемент массива с индексом "0"
            array1[0] = 9; // меняет число "1" в массиве на "9"
            Console.WriteLine(array1[0]); //выводит обновленный элемент массива с индексом "0"
            
            //получить последний элемент массива вариант # 1
            Console.WriteLine("Последний элемент массива: " + array1[array1.Length-1]);
            
            //получить последний элемент массива вариант # 2
            Console.WriteLine("Последний элемент массива: " + array1[array1.GetUpperBound(0)]); //типа самый правильный вариант
            
            //получить последний элемент массива вариант # 3
            Console.WriteLine("Последний элемент массива: " + array1[^1]); //самый удобный вариант
            
            //перебор элементов массива
            for (int i=0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            
            
            
        }
    }
}