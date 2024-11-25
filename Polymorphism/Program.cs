using System;
using Polymorphism;


namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.CountBill(10,10); // метод используется с 2 параметрами 
            client.CountBill(10,10, 10); // метод используется с 3 параметрами (это называется перегрузка метода, можно так, а можно так)

            //вызываем различные реализации метода SendNotification из классов Individual и Corporate

            individual individual = new individual(1);
            individual.SendNotification();

            Corporate corporate = new Corporate(1);
            corporate.SendNotification();
            
            //вызываем различные реализации метода SendNotification из классов ChildIndividual и ChildCorporate

            ChildIndividual childIndividual = new ChildIndividual(1);
            childIndividual.SendNotification();

            // здесь вызовется метод, унаследованный из род. класса (см. класс ChildCorporate)
            ChildCorporate Childcorporate = new ChildCorporate(1);
            Childcorporate.SendNotification();
 

        }
    }
}