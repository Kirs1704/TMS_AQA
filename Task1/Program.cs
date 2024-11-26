using System;


namespace Task1
{
    static class Program
    {
        static void Main(string[] args)
        {
            // ===============================  ПРЯМОУГОЛЬНЫЙ ТРЕУГОЛЬНИК ================================================
            Console.WriteLine("===============================  ПРЯМОУГОЛЬНЫЙ ТРЕУГОЛЬНИК ================================");
            
            // Считаем площадь по высоте и длине основания. См. класс "Pryamoug"
            Pryamoug pryamoug = new Pryamoug(10.5,2.5);
            Console.WriteLine($"Площадь данного треугольника равна: {pryamoug.getArea()}");

            // а тут мы сначала конструктором задали одно значение высоты, а потом с помощь свойства Height поменяли. Результат разный
            Pryamoug pryamoug1 = new Pryamoug(20,30);
            Console.WriteLine($"{pryamoug1.getArea()}");
            pryamoug1.Height = 80;
            Console.WriteLine($"{pryamoug1.getArea()}");
            
            

            // ===============================  РАВНОБЕДРЕННЫЙ ТРЕУГОЛЬНИК ================================================
            Console.WriteLine("===============================  РАВНОБЕДРЕННЫЙ ТРЕУГОЛЬНИК ================================");

            Ravnobedr ravnobedr = new Ravnobedr(2, 2, 3, 4);
            Console.WriteLine($"{ravnobedr.GetArea()}");
            
            // ===============================  РАВНОСТОРОННИЙ ТРЕУГОЛЬНИК ================================================
            Console.WriteLine("===============================  РАВНОСТОРОННИЙ ТРЕУГОЛЬНИК ================================");

            Ravnostor ravnostor = new Ravnostor(2,2,2,4);
            Console.WriteLine($"{ravnostor.GetArea()}");
            

        }
    }
}