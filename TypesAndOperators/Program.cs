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
            int iceCreamPrice = 200;

            Console.Write("Введите начальную сумму: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            if (sum > 0)
            {
                Console.WriteLine($"Отлично! Ваша начальная сумма: {sum} рублей");
                if (isWhiteBreadFresh && sum>=WhiteBreadPrice)
                {
                    sum -= WhiteBreadPrice;
                    Console.WriteLine($"Хлеб купили, у нас осталось {sum} рублей.");
                }

                if (sum >= ButterPrice)
                {
                    sum -= ButterPrice;
                    Console.WriteLine($"Масло купили, у нас осталось {sum} рублей.");
                }
                else
                {
                    Console.WriteLine($"У нас осталось {sum} рублей. На масло этого не хватит.");
                }

                if (MilkFatPerc == 1.2F && sum >= MilkPrice)
                {
                    sum -= MilkPrice;
                    Console.WriteLine($"Молоко купили, у нас осталось {sum} рублей.");
                }
                else
                {
                    Console.WriteLine("С молоком не сростается..Увы");
                }

                if (sum >= iceCreamPrice)
                {
                    sum -= iceCreamPrice;
                    Console.WriteLine($"Шикарно! Даже мороженку купили.У нас осталось {sum} рублей.");
                }
                else
                {
                    Console.WriteLine("По мороженке отбой...");
                }
            }
            else
            {
                Console.WriteLine("На это не разгуляешься..Сумма должна быть больше 0");
            }
        }
    }
}

int x = 10;
int y = 20;
int z;

if (x < 10)
{
    z = x + y;
}
else
{
    z = x - y;
}