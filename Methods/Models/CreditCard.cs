namespace Methods.Models;

public class CreditCard
{
    // блок полей
    public long accNumber;
    public int balance = 0;


    // метод для пополнения баланса
    public void topUpBalance(params int [] sum)
    {
        foreach (var item in sum)
        {
            balance += item;
            Console.WriteLine($"Вы пополнили баланс на {item} рублей");
        }

        Console.WriteLine($"Ваш текущий баланс после пополнения составляет: {balance} рублей");
    }
    
    // метод для снятия суммы с карты
    public void getFromBalance(params int [] sum)
    {

        foreach (var item in sum)
        {
            if (balance >= item)
            {
                balance -= item;
                Console.WriteLine($"Вы сняли: {item} рублей");
            }
            else
            {
                Console.WriteLine($"Увы, у вас на балансе недостаточно средств");
            }
            Console.WriteLine($"Ваш текущий баланс {balance} рублей");
        }
        
        
    }
    
    // метод для проверки баланса
    public void checkBalance()
    {
        Console.WriteLine($"Ваш текущий баланс {this.balance} рублей");
    }
}