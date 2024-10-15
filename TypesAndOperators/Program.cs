using System;

namespace TypesAndOperators
{
    static class Program
    {
        static void Main(string[] args)
        {

            /*
             float a1 = 12.5F;
            float a2 = 12.5f;

            decimal c1 = 1005.5M;
            decimal c2 = 1005.5m;

            //========= Неявная типизация =======================
            var d = 10;
            var d1 = 10.2F;
            var d2 = 'D';
            var d3 = "Hello";
            */
            
            // ======== Решение задачи ============
            //Подготовка данных
            
            bool isWhiteBreadFresh = true;
            int WhiteBreadPrice = 150;
            int ButterPrice = 230;
            int MilkPrice = 170;
            float MilkFatPerc = 1.2F;
            
            Console.Write("Введите свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);



        }
    }
}