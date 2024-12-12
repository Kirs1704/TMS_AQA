namespace Interfaces;

public interface IExample   // Это интерфейс. В рамках него мы можем создавать ТОЛЬКО константы и статические переменные
{
    // константа
    const int minSpeed = 0;     // минимальная скорость
    
    // статиечская переменная
    static int maxSpeed = 60;   // максимальная скорость
    
    // метод
    void Move();
    
    // свойство
    string Name { get; set; }
}