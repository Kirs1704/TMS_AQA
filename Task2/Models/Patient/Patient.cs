using System.Diagnostics;

namespace Task2.Models.Patient;

using Task2.Models.Doctor;
public class Patient
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public HealPlan Plan { get; set; }

    public Patient(string name, int age, HealPlan plan)
    {
        Name = name;
        Age = age;
        Plan = plan;
    }

    public Doctor AssignDoctor()
    {
        Doctor doctor;
        switch(Plan.PlanId)
        {
            case 1:
                doctor = new Surgeon();
                break;
            case 2:
                doctor = new Dentist();
                break;
            default:
                doctor = new Therapist();
                break;
        }

        doctor.Heal();
        return doctor;
    }
}