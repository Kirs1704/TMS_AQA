using NUnit.Framework;
using Task2.Models.Doctor;
using Task2.Models.Patient; //подключаем пространство имен из программы Task2 с классом Patient (юниты будут для этого класса)

namespace Task2.Tests;
// определяется пространство имен текущего проекта

[Parallelizable(ParallelScope.Self)] // говорит о том, что тесты в данном классе могут запускаться параллельно (экономит время)
[TestFixture] // Т.о. говорим, что данный класс содержит тестовые методы. Nunit найдет их по этому атрибуту при запуске
public class PatientTests //  Объявляем наш тестовый класс
{
    [Test]
    public void AssignDoctor_WinthPlanId1_ReturnSurgeon() // Объявляем юнит метод, который проверит как отрабатывает основной метод AssignDoctor
    {
        // Arrange
        var patient = new Patient("TestName", 32, new HealPlan(1)); // создаем тестового пациента с планом лечения "1"

        // Act
        var doctor = patient.AssignDoctor(); // вызываем проверяемый юнитом метод

        // Assert
        Assert.IsInstanceOf<Surgeon>(
            doctor); // Проверяем, что возвращенный объект (doctor) является экземпляром класса Surgeon


    }

    // ==========================================  Далее то же самое, что и выше, только для PlanId - 2 ===================
    
    [Test]
    public void AssignDoctor_WinthPlanId2_ReturnDentist() // Объявляем юнит метод, который проверит как отрабатывает основной метод AssignDoctor
    {
        // Arrange
        var patient = new Patient("TestName1", 33, new HealPlan(2)); // создаем тестового пациента с планом лечения "2"

        // Act
        var doctor = patient.AssignDoctor(); // вызываем проверяемый юнитом метод

        // Assert
        Assert.IsInstanceOf<Dentist>(doctor); // Проверяем, что возвращенный объект (doctor) является экземпляром класса Dentist
    }
}