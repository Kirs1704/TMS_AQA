using System;

namespace Arrays
{
    static class Program
    {
        static void Main(string[] args)
        {
            //================ объявление массивов ==============================

            /*
            int[] array1 = { 1, 2, 3, 4, 6 };
            int[] array2 = new int[4];

            //объявление через переменную
            int[] array3;
            int n = 4;
            array3 = new int[n];

            Console.WriteLine("Length: " + array1.Length);                                   // количество всех элементов
            Console.WriteLine("Rank: " + array1.Rank);                                       // ранк массива
            Console.WriteLine("GetLength(0): " + array1.GetLength(0));               // количество строк (для многомерного массива)
            
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
            
            //цикл foreach
            foreach (int item in array1)
            {
                Console.Write($"{item} ");
            }

            //оператор break
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            
            //оператор continue
            
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
            
            //циклы do...while
            int b = 5;
            do
            {
                Console.WriteLine(b);
                b--;
            } while (b>0);
            */
            //======================= Двумерный массив ===================================

            int[,] numbers = new int[4, 5];
            Console.WriteLine("Length: " + numbers.Length);                                   // количество всех элементов
            Console.WriteLine("Rank: " + numbers.Rank);                                       // ранк массива
            Console.WriteLine("GetLength(0): " + numbers.GetLength(0));               // количество элементов в первой строке
            Console.WriteLine("GetUpperBound(0): " + numbers.GetUpperBound(0));       // Верхний индекс строк (для многомерного массива)                                
            Console.WriteLine("GetLength(1): " + numbers.GetLength(1));               // количество элементов во второй строке
            Console.WriteLine("GetUpperBound(1): " + numbers.GetUpperBound(1));       // Верхний индекс столбцов(для многомерного массива)
            
            
            //задать значение в двумерном массиве

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = i + j;
                }
            }

            int rows = numbers.GetLength(0);
            int columns = numbers.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i,j]} \t");
                }
                Console.WriteLine();
            }



        }
    }
}
