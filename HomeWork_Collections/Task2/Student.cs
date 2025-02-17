namespace HomeWork_Collections.Task2;

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Course { get; set; }
    public int Score { get; set; }
    
    public override string ToString()
    {
        return $"Имя: {Name}, Возраст: {Age}, Курс: {Course}, Балл: {Score}";
    }
}