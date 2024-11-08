using System;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            

            int[] array = { 1, 8, 14, -4, 0, 7 };
            PrintArray();
            
            Console.WriteLine();
            
            Array.Reverse(array);
            PrintArray();
            
            void PrintArray()
            {
                foreach (int item in array)
                {
                    Console.Write($"{item}\t"); 
                }
            }
            Console.WriteLine();
            //========================== МЕТОД БЕЗ ПАРАМЕТРОВ =============================
            
            void MethodWithoutParameters()
            {
                // тело метода
            }
            
            //========================== МЕТОД БЕЗ ВОЗВРАЩАЕМОГО ЗНАЧЕНИЯ ==================
            
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            PrintMessage("Hello");
            string msg = "Hello, World!";
            PrintMessage(msg);
            
            //========================== МЕТОД С ВОЗВРАЩАЕМЫМ ЗНАЧЕНИЕМ ==================

            string GetInfo()
            {
                return "Test";
            }

            string result = GetInfo();
            Console.WriteLine(result);
            
            //========================== МЕТОД С ПАРАМЕТРАМИ ПО УМОЛЧАНИЮ ==================

            void DisplayGreeting(string greetingMessage, string name = "Гость")
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }
            
            DisplayGreeting("Hello");
            DisplayGreeting("Hello", "Boss");
            
            //========================== МЕТОД С ПЕРЕМЕННЫМ ЧИСЛОМ АРГУМЕНТОВ ==================

            int CalculateSum(params int[] numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }

                return sum;
            }

            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // пустой вызов
            
            Console.WriteLine("Sum1: " + sum1);
            Console.WriteLine("Sum2: " + sum2);
            
            //========================= ПЕРЕДАЧА ПАРАМЕТРОВ ==============================
            
            //-------------------- ПО ЗНАЧЕНИЮ
            void SimpleAdd(int x, int y) //по умолчанию аргументы передаются по значению
            {
                int ans = x + y;
            }
            
            //-------------------- ПО ССЫЛКЕ
            //----- 1 вариант - Out (значения выходных параметров должны быть установлены внутри вызываемого метода)
            void OutAdd(int x, int y, out int ans)
            {
                ans = x + y;
            }

            int ans;
            OutAdd(90,90, out ans);
            Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);
            
            // практическое применение в тестировании - возврат данных
            void manyValues(out int a, out string b, out bool c)
            {
                a = 9;
                b = "Hello";
                c = true;
            }
            
            
            //----- 2 вариант - Ref
            void ModifyValue(ref int value)
            {
                value = value * 2; 
            }

            int MainValue = 5;                       //практически то же самое, что out, но тут переменная должна быть проинициализирована
            Console.WriteLine($"Первоначальное значение: {MainValue}");
            ModifyValue(ref MainValue);
            Console.WriteLine($"Значение после применения метода: {MainValue}");
            
            //=========================== ВОЗВРАТ НЕСКОЛЬКИХ ЗНАЧЕНИЙ ================================
            //----- КОРТЕЖ
            (string, int) GetPersonInfo()
            {
                return ("Kirs", 33);
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");




        }
    }
}
