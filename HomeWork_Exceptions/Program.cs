
// ====================== Задание № 1 ============================
/***
Задание 1:
Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра:
●  login,
●  password,
●  confirmPassword.

1.  Все поля имеют тип данных String.
2.  Длина login должна быть меньше 20 символов и не должен содержать пробелы.
3.  Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
4.  Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
5.  Также password и confirmPassword должны быть равны.
6.  Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
7.  WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию, второй принимает сообщение исключения и передает его в конструктор класса Exception.
8.  Метод возвращает true, если все значения верны или false в другом случае.
 ***/

/*using System.Net;
using HomeWork_Exceptions.Task1;

UserAutorization userAutorization = new UserAutorization();
userAutorization.UserEnter("Kirs", password:"kf1", "kf1");*/


 // Задание № 2. 

 /*** Задание 2:
Предположим, у вас есть система для обработки заказов в интернет-магазине. Вам нужно написать программу, которая проверяет корректность данных при создании заказа. Каждый заказ имеет уникальный номер.
Задача: Напишите программу, используя блоки try-catch, создайте свой класс исключения и используйте оператор throw, чтобы обрабатывать следующие сценарии:
1.  Некорректный номер заказа: Если номер заказа отрицательный, программа должна генерировать пользовательское исключение InvalidOrderNumberException.
2.  Пустой список товаров: Если заказ не содержит товаров, программа должна генерировать пользовательское исключение EmptyOrderException.
3.  Недостаточные данные для доставки: Если данные для доставки отсутствуют (например, пустой адрес), программа должна генерировать пользовательское исключение DeliveryInformationMissingException***/


using HomeWork_Exceptions.Task2;

ValidateOfOrder validator = new ValidateOfOrder(); // создали объект валидатора заказов
Order correctOrder = new Order(1, new List<string>() { "item1", "intem2" }, "Стофато,2");   // создаем заведомо ВАЛИДНЫЙ объект заказа
validator.OrderValidate(correctOrder);             // вызываем метод валидации у объекта "Валидатор" и передаем в качестве аргумента ранее созданный валидный объект заказа


Order orderWithoutNumber = new Order(-5, new List<string>() { "item1", "intem2" }, "Стофато,2"); // создаем заведомо НЕВАЛИДНЫЙ объект заказа с отрицательным номером
validator.OrderValidate(orderWithoutNumber);  

Order orderWithoutItems = new Order(2, new List<string>(), "Стофато,2"); // невалидный заказ с пустым списком товаров
validator.OrderValidate(orderWithoutItems);

Order orderWithoutAddres = new Order(2, new List<string>(){ "item1", "intem2" }, ""); // невалидный заказ без адреса
validator.OrderValidate(orderWithoutAddres);