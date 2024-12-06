namespace Task2.Models.Doctor;

public class Dentist:Doctor
{

    public override void Heal()
    {
        Console.WriteLine("Вам назначено лечение дантиста");
    }
}