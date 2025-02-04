namespace HomeWork.Task2;

public abstract class BaseProduct
{
    public string Name { get; set; } = "Undefined";                                // Название товара
    public int Price { get; set; }                                                 // Цена

    public DateTime Date { get; set; } = DateTime.Now;                            // Дата производства (захардкожена текущая дата)
    // с такой реализацией переменной Date, товар всегда будет годен, так как всегда будет сегодняшняя дата. Чтобы сделать просроченным можно написать так: public DateTime Date { get; set; } = DateTime.Now.AddDays(-8)
    public TimeSpan Expiration { get; set; } = TimeSpan.FromDays(7);              // Срок годности. Указан в днях (7 дней)
    
    public abstract void ShowInfo();                  // абстрактный метод для вывода информации о товаре
    public abstract void CheckDate();               // абстрактный метод для проверки срока годности
}