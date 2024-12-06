using System;
using Task2.Models.Patient;


namespace Task2
{
    static class Program
    {
        static void Main(string[] args)
        {

            HealPlan healPlan = new HealPlan(0); // создан объект "План лечения"
            Patient patient = new Patient("Alex", 32, healPlan);
            patient.AssignDoctor();
            

        }
    }
}