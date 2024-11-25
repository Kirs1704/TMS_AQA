namespace Polymorphism;

public class Client
{
    public int Id;
    public string PhoneNumber;
    public string Email;
    
    
    public void Activate(){}
    public void Pause(){}
    public void Deactivate(){}
    
    // конструктор по умолчанию
    public Client()
    {
    }
    
    // конструктор с одним параметром
    public Client(int id)
    {
        Id = id;
    }

    // ниже представлена "перегрузка" методов
    // в первом случае один и тот же метод имеет два параметра, во втором - три. Это и есть перегрузка. Возможность использовать метод по-разному
    public void CountBill(int hours, int rate)
    {
        int result = hours * rate;
        Console.WriteLine(result);
    }
    public void CountBill(int hours, int rate, int debt)
    {
        int result = hours * rate + debt;
        Console.WriteLine(result);
    }

   // слово "virtual" в методе ниже, говорит о том, что данный метод м.б. переопределен классом-наследником
   // см. класс "corporate". Там метод переопределен с помощью слова "override"
    public virtual void SendNotification()
    {
        Console.WriteLine("Base notofication...");
    }
    
    public virtual void SendNotification1()
    {
        Console.WriteLine("Base notofication...");
    }
    
}