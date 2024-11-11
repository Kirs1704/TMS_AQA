using System;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;
using Methods;
using Methods.Models;

namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            

            /*
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
            Console.WriteLine($"Первоначальное значение: {MainValue}"); // 5
            ModifyValue(ref MainValue);
            Console.WriteLine($"Значение после применения метода: {MainValue}"); // 10
            
            //=========================== ВОЗВРАТ НЕСКОЛЬКИХ ЗНАЧЕНИЙ ================================
            //----- КОРТЕЖ (Tulpe)
            
            (string, int) GetPersonInfo()
            {
                return ("Kirs", 33);
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");
            
            // ======================== СОКРАЩЕННАЯ ФОРМА МЕТОДА

            int shortAdd(int x, int y) => x + y; // эта форма аналогична форме ниже
            
            //---------------------------------------------------------------------

            int shortAdd1(int x, int y)
            {
                return x + y;
            }
            
            
            //====================== РЕКУРСИВНАЯ ФУНКЦИЯ

            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            int factorial4 = Factorial(4); // 24
            */
            
            
            
            // ============================ КЛАССЫ ============================================
            
            //----------Структура класса-------

            EmptyClass emptyClass = new EmptyClass();

            Person person = new Person();
            person.Print();
            person.name = "Kirs";   // переназначили значение переменной "name" у объекта person класса Person 
            person.age = 33;        // переназначили значение переменной "age" у объекта person класса Person 
            person.Print();         // вывели на консоль с новыми значениями
            
            
            
            //----------Создание конструкторов-------

            PersonWithConstructor personWithConstructor = new PersonWithConstructor();
            personWithConstructor.Print();

            ConstructorCustom constructorCustom = new ConstructorCustom(10);       // используем конструктор с параметром int
            Console.WriteLine(constructorCustom.GetHashCode());                       // проверяем hush-код
            
            ConstructorCustom constructorCustom1 = new ConstructorCustom("Test");  // используем конструктор с параметром string
            Console.WriteLine(constructorCustom1.GetHashCode());                      // проверяем hush-код
            
            constructorCustom = new ConstructorCustom("text");                    // переназначем объект с int на объект со string
            Console.WriteLine(constructorCustom.GetHashCode());                      // проверяем hush-код


            FullConstructor fullConstructor = new FullConstructor();                 // тут в скобках можно передать параметры (будут выведены методом ниже)
            fullConstructor.Print();


            PersonChain personChain = new PersonChain();
            personChain.Print();
            
            
            //===================================== HOMEWORK ===================================================
            Console.WriteLine("============ Задание № 1 ==================");

            /***
             * Задание 1:
Создайте класс Phone, который содержит переменные number, model и weight.

Добавить конструкторы в класс Phone: 
1.  конструктор без параметров.
2.  принимает на вход два параметра для инициализации переменных класса - number, model.
3.  принимает на вход три параметра для инициализации всех переменных класса Phone. Вызвать из этого конструктора конструктор с двумя параметрами.
Добавить в класс Phone методы: 
●  receiveCall, с одним параметром “имя звонящего”. 
Этот метод выводит на консоль сообщение “Звонит {name}”. 
●  getNumber 
Этот метод возвращает номер телефона.
●  sendMessage с аргументами переменной длины.  
Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов 

Создайте три экземпляра этого класса используя разные конструкторы.
Выведите на консоль значения их переменных.
Вызвать методы receiveCall и getNumber для каждого из объектов.
Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов.
             */
            
            Console.WriteLine("1 экземпляр. Без параметров: ");
            Phone phone = new Phone(); 
            phone.Print();
            Console.WriteLine("Вызов метода receiveCall без передачи имени: ");
            phone.receiveCall();
            Console.WriteLine("Вызов метода getNumber без номера: ");
            phone.getNumber();
            
            
            Console.WriteLine("2 экземпляр. С параметрами 'number' и 'model': ");
            Phone phone2 = new Phone(777, "Samsung");
            phone2.Print();
            Console.WriteLine("Вызов метода receiveCall с передачей имени: ");
            phone2.receiveCall("Дмитрий");
            Console.WriteLine("Вызов метода getNumber с передачей номера: ");
            phone2.getNumber(89232193666);

            Console.WriteLine("3 экземпляр. С параметрами 'number', 'model', 'weight': ");
            Phone phone3 = new Phone(888, "Nokia", 25);
            phone3.Print();
            Console.WriteLine("Вызов метода sendMessage с 2 номерами: ");
            phone3.sendMessage(79618985858, 79232193666);
            Console.WriteLine("Вызов метода sendMessage с 5 номерами: ");
            phone3.sendMessage(79610000000, 79610000001, 79610000002, 79610000003, 79610000004);
            
            Console.WriteLine();
            Console.WriteLine("============ Задание № 2 ==================");
            /***
             * Задание 2
Создать класс CreditCard c полями 
●  номер счета, 
●  текущая сумма на счету.

Добавьте методы: 
●  который позволяет зачислять сумму на кредитную карту;
●  который позволяет снимать некоторую сумму с карты;
●  который выводит текущую информацию о карточке.

Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма.

Тестовый сценарий для проверки:
Положите деньги на первые две карточки и снимите с третьей.
Выведите на экран текущее состояние всех трех карточек.
             */
            CreditCard creditCard = new CreditCard(); 
            creditCard.topUpBalance(1000); // пополнили баланс на 1000
            //-------------------------------------
            creditCard.getFromBalance(800); // сняли 800
            //-------------------------------------
            creditCard.checkBalance();              // проверили баланс
            //-------------------------------------


        }
    }
}
