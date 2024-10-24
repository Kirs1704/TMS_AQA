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

            Console.WriteLine("================ Задание # 2 ===============");

            int[] numbers1 = { 2, 4, 5, 8, 10, 11, 15, 5};
            Console.WriteLine($"Первоначальный массив:");
            foreach (int item in numbers1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.Write("Введите число для удаления из массива: ");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());
        }
    }
}
