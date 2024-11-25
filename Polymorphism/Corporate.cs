namespace Polymorphism;

public class Corporate : Client // т.о. говорим, что класс 'Corporate' наследник класса 'Client'
{
    // тут добавляем уникальные, присущие только этому классу свойства (которых нет в родительском классе)
    public string INN;
    public string UNP;


    public Corporate(int id) : base(new Random().Next(100)) // вызывает конструктор родителя (base)
    {
    }

    // с помощью слова "override" переопределяется метод родительского класса (см. класс "Client")
    public override void SendNotification()
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
    
    // с помощью слова "sealed" мы запрещаем дальнейшее переопределение метода для следующих дочерних классов
    // см. класс "ChildCorporate"
    public override sealed void SendNotification1()
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
}