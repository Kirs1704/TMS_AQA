namespace Task2.Models.Doctor;

public class Therapist:Doctor
{

    public override void Heal()
    {
        Console.WriteLine("Вам назначено наблюдение терапевта");
    }
}