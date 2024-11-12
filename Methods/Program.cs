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
            CreditCard creditCard = new CreditCard(777, 0); 
            creditCard.topUpBalance(1000); // пополнили баланс на 1000
            //-------------------------------------
            creditCard.getFromBalance(800); // сняли 800
            //-------------------------------------
            creditCard.checkBalance();              // проверили баланс
            //-------------------------------------

            CreditCard creditCard1 = new CreditCard(888, 0);
            creditCard1.topUpBalance(500);
            CreditCard creditCard2 = new CreditCard(999, 100);
            creditCard2.topUpBalance(400);
            CreditCard creditCard3 = new CreditCard(000, 200);
            creditCard3.getFromBalance(100);
            creditCard1.checkBalance();
            creditCard2.checkBalance();
            creditCard3.checkBalance();
            



        }
    }
}
