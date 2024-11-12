namespace Methods.Models;

public class Students
{
    public string name;
    public int group;
    public int diplomMark;

    public Students()
    {
    }

    public Students(string name)
    {
        this.name = name;
        group = 1;
        diplomMark = new Random().Next(1, 6);
    }


    public void Print()
    {
        Console.WriteLine($"Имя студента: {name}, Группа: {group}, Оценка: {diplomMark}");
        Console.WriteLine();
    }
}