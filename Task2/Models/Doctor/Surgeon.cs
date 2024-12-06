namespace Task2.Models.Doctor;

public class Surgeon : Doctor
{

    public override void Heal()
    {
        Console.WriteLine("Вам назначено лечение хирурга");
    }
}