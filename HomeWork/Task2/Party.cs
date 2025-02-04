namespace HomeWork.Task2;

public class Party : BaseProduct
{
    public int Quantity { get; set; }      // реализуем параметр количества товаров в партии. Остальные параметры унаследуются от BaseProduct

    public Party(Product[] products, int quantity)
    {
        this.Quantity = quantity;
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine(
            $"Название товара: {Name}\nЦена товара: {Price}\nДата производства: {Date}\nСрок годности: {Expiration}");
    }

    public override void CheckDate()
    {
        Console.WriteLine();
    }
};
