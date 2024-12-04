using System.Net.Sockets;

namespace Properties;

public class Person
{
    private string name;
    private int age;
    private string surname;
    private string adress;


    public Person()
    {
        surname = "Sveshnikov";
        Adress = "Centralnaya";  // здесь используем не переменную, а свойство
    }
    
    // Стандартный вариант работы с блоком данных

    public void SetName(string name)                  // этим методом задаем значение для переменной "name"
    {
        this.name = name;
    }

    public string GetName()                          // этим методом получаем значение из переменной "name"
    {
        return name;
    }
    
    // Вариант № 2. Свойства. В C# есть Свойство для доступа к полю "name"
    /***
     * Свойство визуально и структурно отличается от метода тем, что:
     * 1. У свойства отсутсвуют скобки в конце
     * 2. У свойства ВСЕГДА есть хотя бы один из блоков get или set
     *
     * Код ниже - это упрощенный и более лаконичный аналог кода выше (вместо GetName и SetName)
     */
    public string Name              // принято называть свойство так же, как и переменную, только с большой буквы
    {
        get
        {
            return name;
        }

        set
        {
            name = value;          // на место value мы можем подставить в данном случае любое стринговое значение в самой программе

        }
    }
    
    // Свойство только для записи. Можем записать, но не можем получить
    public int Age
    {
        set
        {
            age = value;
        }
    }
    
    // Свойство только для чтения. Можем прочитать уже заданную, но не можем задать самостоятельно
    // В свойстве get всегда должен быть return
    public string Surname
    {
        get
        {
            return surname;
        }
    }
    
    // Этот метод позволяет производить вычисления внутри него и с помощь чтения получить в результате полное имя
    public string Fullname
    {
        get
        {
            return $"{name} {surname}";
        }
    }
    
    // Для свойств get и set можно также использовать модификаторы доступа
    // Сделаем set приватным, а get публичным

    public string Adress
    {
        get { return adress; }                   // публичный
        private set { adress = value; }          // приватный
    }
    
    
    // Короткая запись get и set выглядит вот таким образом
    public string Salary { get; set; }                      // причем ранее переменная Salary не создавалась. Она делается в моменте свойством
    
    //можно задать значение по умолчанию
    public string Salary1 { get; set; } = "12500";
    
    //в сокращенной форме также можно указать модификатор доступа для get или set
    public string Salary2 { get; private set; }


}