namespace Inheritance;

public class Corporate : Client // т.о. говорим, что класс 'Corporate' наследник класса 'Client'
{
    // тут добавляем уникальные, присущие только этому классу свойства (которых нет в родительском классе)
    public string INN;
    public string UNP;


    public Corporate() : base(new Random().Next(100)) // вызывает конструктор родителя (base)
    {
    }
}