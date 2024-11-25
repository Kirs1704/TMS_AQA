namespace Polymorphism;

public class ChildCorporate : Corporate
{
    public ChildCorporate(int id) : base(id)
    {
        
    }
    
    // ниже видим ошибку при попытке переопределить метод, так как в род. классе Corporate мы использовали слово "sealed"
    
    /*
    public override void SendNotification1()
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
    */
    public void SendNotification1()
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
}