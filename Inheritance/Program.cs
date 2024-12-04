using System;
using Inheritance;


namespace Strings
{
    static class Inheritance
    {
        static void Main(string[] args)
        {
            // =================== corporate =====================
            Corporate corporate = new Corporate();
            corporate.Id = 123;
            corporate.INN = "1234";
            Console.Out.WriteLine(corporate.Id);
            
            // =================== individual =====================
            Console.WriteLine();
            individual individual = new individual(2);
            individual.PhoneNumber = "12345";
            individual.Email = "individual@test.com";
            individual.FirstName = "Ivan";
            individual.LastName = "Ivanov";
            individual.Actiavte();
            
            Console.WriteLine();
            Corporate corporate1 = new Corporate();
            corporate1.PhoneNumber = "6789";
            corporate1.Email = "corporate1@test.com";
            corporate1.INN = "77777";
            corporate1.UNP = "88888";
            corporate1.Actiavte();
            corporate1.Pause();


        }
    }
}