namespace AbstractClasses.Game;

public abstract class Character
{
    // блок переменных
    public int level;
    public string name;


    // блок метода
    public abstract void Move();  // когда метод абстрактный, предполагается, что у него не будет тела
}