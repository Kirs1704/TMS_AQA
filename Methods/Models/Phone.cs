namespace Methods.Models;

public class Phone
{
    // блок полей и переменных
    public int number;
    public string model;
    public int weight;
    
    // блок конструкторов
    
    //------Конструктор № 1 (без параметров)
    public Phone()
    {
        number = 0;
        model = "Неизвестно";
        weight = 0;
    }
    
    //------Конструктор № 2 (с двумя параметрами для инициализации)
    public Phone(int number, string model)
    {
        this.number = number;
        this.model = model;
    }
    
    //------Конструктор № 3 (с тремя параметрами для инициализации)
    public Phone(int number, string model, int weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }
    
    
    // блок методов
    //----------Метод Print (для вывода параметров класса на консоль)
    public void Print()
    {
        Console.WriteLine($"Номер: {number}, Модель: {model}, Вес: {weight}");
    }
    
    //---------- Метод receiveCall (для вывода на консоль имени звонящего)

    public void receiveCall(string name = "Неизвестный")
    {
        Console.WriteLine($"Звонит {name}");
    }
    
    //---------- Метод getNumber (для вывода на консоль номера телефона)
    
    public void getNumber (long number = 89231111111)
    {
        Console.WriteLine($"Входящий вызов: {number}");
    }
    
    //---------- Метод sendMessage (для получения номера (номеров), на который(-ые) будет отправлено сообщение)

    public void sendMessage(params long[] numbers)
    {
        Console.WriteLine("Сообщения будут отправлены на номера: ");
        foreach (var number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }

}