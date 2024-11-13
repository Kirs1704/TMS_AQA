using System;


namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Id = 1;
            client1.PhoneNumber = "+79999999990";
            client1.Email = "cient1@test.com";
            client1.Actiavte();
            
            Client client2 = new Client();
            client2.Id = 2;
            client2.PhoneNumber = "+79999999991";
            client2.Email = "cient2@test.com";
            client2.Pause();
            
            Console.Out.WriteLine(client1.Id);
            Console.Out.WriteLine(client1.PhoneNumber);
            
            Console.Out.WriteLine(client2.Id);
            Console.Out.WriteLine(client2.PhoneNumber);

        }
    }
}