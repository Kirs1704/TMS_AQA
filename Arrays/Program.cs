using System;

namespace Arrays
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("================ Задание # 1 ===============");
            int[] numbers = { 2, 4, 5, 8, 10, 11, 15};
            Console.Write("Введите число для поиска в массиве: ");
            int numberToFind = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToFind)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine($"Число {numberToFind} входит в массив!");
            }
            else
            {
                Console.WriteLine($"Число {numberToFind} в массив не входит!");
            }*/

            /*
            Console.WriteLine("================ Задание # 2 ===============");

            int[] numbers1 = { 2, 4, 5, 8, 10, 11, 15, 5};
            Console.Write($"Первоначальный массив: ");
            foreach (int item in numbers1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("Введите число для удаления из массива: ");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (int item in numbers1)
            {
                if (item == numberToDelete)
                {
                    count++;
                }
            }

            if (count != 0)
            {

                int[] newNumbers = new int[numbers1.Length - count];
                int index = 0;
                for (int i = 0; i < numbers1.Length; i++)
                {
                    if (numbers1[i] != numberToDelete)
                    {
                        newNumbers[index++] = numbers1[i];
                    }
                }

                Console.Write("Новый массив: ");
                for (int i = 0; i < newNumbers.Length; i++)
                {
                    Console.Write($"{newNumbers[i]} ");
                }
            }
            else
            {
                Console.WriteLine($"Число {numberToDelete} в массиве не встречается!");
            }*/
            /*Console.WriteLine("================ Задание # 3 ===============");
            Console.Write("Введите желаемый размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers3 = new int[n];
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = new Random().Next(100);
            }
            Console.Write("Ваш массив: ");
            foreach (int item in numbers3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int maxValue = 0;
            int minValue = numbers3[0];
            int middleValue = 0;
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (maxValue < numbers3[i])
                {
                    maxValue = numbers3[i];
                }
            }
            Console.Write($"Максимальное значение массива: {maxValue}");
            Console.WriteLine();
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (minValue > numbers3[i])
                {
                    minValue = numbers3[i];
                }
            } 
            Console.Write($"Минимальное значение массива: {minValue}");
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < numbers3.Length; i++)
            {
                count += numbers3[i];
            }

            middleValue = count / numbers3.Length;
            Console.Write($"Среднее значение массива: {middleValue}");
            */
            
            /*
            Console.WriteLine("================ Задание # 4 ===============");
            int count1 = 0;
            int count2 = 0;
            int[] numbers4 = { 6, 7, 8, 9, 10 };
            Console.Write("Первый массив: ");
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.Write($"{numbers4[i]} ");
                count1 += numbers4[i];
            }
            Console.WriteLine();
            int[] numbers41 = { 6, 7, 8, 9, 10 };
            Console.Write("Второй массив: ");
            for (int i = 0; i < numbers41.Length; i++)
            {
                Console.Write($"{numbers41[i]} ");
                count2 += numbers41[i];
            }
            Console.WriteLine();
            Console.Write($"Среднее арифметическое первого массива = {count1}");
            Console.WriteLine();
            Console.Write($"Среднее арифметическое второго массива = {count2}");
            Console.WriteLine();
            if (count1 > count2)
            {
                Console.WriteLine("Среднее первого массива больше!");
            }
            else if (count2 > count1)
            {
                
                Console.WriteLine("Среднее второго массива больше!");
            }
            else
            {
                
                Console.WriteLine("Средние обоих массивов равны!");
            }
            */

            //======================= Инверсия массива ======================
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };/*
            int n = numbers.Length; // длина массива
            int k = n/2;              // середина массива
            int tempValue;            // вспомогательный элемент для обмена значениями

            Console.Write("Первоначальный массив: ");
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            } 
            
            Console.WriteLine();
            
            Console.Write("Инвертированный массив: ");
            for (int i = 0; i < k; i++)
            {
                tempValue = numbers[i];    // записали во временную переменную первый элемент массива
                numbers[i] = numbers[n - i - 1];      // записали в текущий индекс последний элемент массива
                numbers[n - i - 1] = tempValue;     // записали в последний элемент массива значение из временной переменной
            }

            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
            */
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
