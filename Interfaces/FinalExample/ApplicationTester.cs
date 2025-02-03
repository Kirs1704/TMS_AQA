namespace Interfaces.FinalExample;

public class ApplicationTester : ITestable // Здесь создаем запускатор тестов, который имплементирует интерфейс Itesteble
{
    private Test[] _tests = new Test[10]; // создаем массив тестов в количестве 10 штук. _tests - приватная переменная, доступная только в этом классе
    private int _index = 0;               // индекс для отслеживания, какой по счету тест из 10 добавляется (нужно для метода ниже)


    public void AddTest(Test test) // метод для добавления тестов, который принимает на вход конкретный тест типа (класса) "Test" из массив _tests, который создан выше.(см. абстрактный класс Test)
    {
        _tests[_index++] = test;   // т.о. при вызове данного метода поочередно добавится 10 тестов из массива _tests
    }

    public void RunTests()          // этот метод имплементируется из интерфейса ITestable
    {
        for (int i = 0; i < _index; i++)
        {
            _tests[i].Run();
        }
    }
}