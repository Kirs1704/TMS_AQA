namespace Interfaces.FinalExample;

public abstract class Test // Создали абстрактный класс для автотестов
{
    public string Name { get; set; }
    public string Description { get; set; }

    public abstract void Run(); // абстактный макет метода, имплементация которого возлагается на каждый дочерний класс
}