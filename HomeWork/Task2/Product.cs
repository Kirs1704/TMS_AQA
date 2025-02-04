namespace HomeWork.Task2;

public class Product : BaseProduct
{
    public Product(string name, int price)
    {
        this.Name = name;
        this.Price = price;

    }
    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Название товара: {Name}\nЦена товара: {Price}\nДата производства: {Date}\nСрок годности: {Expiration}");
    }

    public override void CheckDate()
    {
        DateTime expirationDate = Date.Add(Expiration);   // создаем переменную, в которую сохраняем результат операции справа: К дате производства добвляем количество дней срока годности ( см. BaseProduct)
        if (DateTime.Today > expirationDate)              // если текущая дата больше, чем дата произв-ва + срок годности....
        {
            Console.WriteLine($"Товар {Name} просрочен");  // выводим на консоль инф-ю о том, что товар просрочен
        }
        else
        {
            Console.WriteLine($"Товар {Name} годен!");       // иначе годен
        }
        
    }
}