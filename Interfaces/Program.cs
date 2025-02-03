using Interfaces.Example;
using Interfaces.Explicitimpl;
using Interfaces.FinalExample;

// See https://aka.ms/new-console-template for more information

// ==================================== Interfaces =========================================

// нельзя создать объект интерфейса
// IDysplayable obj1 = new IDysplayable(); ----- ошибка

Smartphone smartphone = new Smartphone();
Tablet tablet = new Tablet();

// ================== Обычное применение метода ==============

smartphone.DisplayInformation("Hello from smartphone!");
tablet.DisplayInformation("Hello from tablet!");


// ================== Продвинутое применение метода ==============

// Создаем метод, который принимает любой объект с интерфейсом IDysplayable;
static void DisplayInformationOnDevice(IDysplayable device, string information)
{
    // Вызываем метод отображения вне зависимости от типа устройства - смартфон, планшет или что-то еще
    device.DisplayInformation(information);
}

// Таким образом, можно использовать следующую форму
DisplayInformationOnDevice(smartphone, "Hello Smartphone!");
DisplayInformationOnDevice(tablet, "Hello Tablet!");


// ================== Множественная реализация интерфейсов ===========

//поскольку класс Tablet1 наследуется от 2 интерфейсов: IDysplayable и IChargeable, экземплярам этого класса доступны методы обоих интерфейсов
Tablet1 tablet1 = new Tablet1();
tablet1.DisplayInformation("Hello");          // метод интерфейса IDysplayable
tablet1.Charge();                             // метод интерфейса IChargeable


                         // ================== Интерфейсы в преобразовании типов ===========


// можно реализовать объект какого-либо интерфейса, если этот интерфейс имплементирован в классе.
// например в примере ниже интерфейс IChargeable есть в классе tablet1. Реализуем этот интерфейс:
IChargeable tablet21 = new Tablet1();
tablet21.Charge();                    // у такого объекта будет доступен только метод интерфейса, но не всего класса

// При этом, не все объекты интерфейса IChargeable являются объектами класса Tablet1. Необходимо явное приведение
Tablet1 anotherTablet1 = tablet1;          // можно создать новый объект и присвоить ему уже существующий, если это объект класса
// Tablet1 anotherTablet2 = tablet21;         // однако, нельзя присвоить новому объекту объект существующего интерфейса. Тут будет ошибка


// В примере ниже, делаем сначала проверку что tablet 21 представляет класс Tablet1, и если проверка успешна - выполняем преобразование.
// И после преобразования можем использовать методы интерфейса
if (tablet21 is Tablet1 anotherTablet3) anotherTablet3.DisplayInformation("Hello!");


                                   // ================== Явная реализация интерфейса ===========


BaseAction baseAction = new BaseAction();
//baseAction.Move()        -----------------   тут так сделать не получится (см. класс BaseAction). При явной имплементации в классе нужно явное приведение

// "Небезопасное" приведение
((IAction)baseAction).Move(); // вот так выглядит явное приведение. Так можем использовать метод Move интерфейса IAction

// "Безопасное" приведение
if (baseAction is IAction action) action.Move();   // Звучит так: "Если baseAction является членом интерфейса IAction, то создать переменную action и вызвать в ней метод Move"

// или так:
IAction baseAction2 = new BaseAction();
baseAction2.Move();


// далее посмотрим, как можно вызвать метод определенного интерфейса, если в классе реализованы два интерфейса с одинаковыми методами (см. NewAction)
NewAction newAction3 = new NewAction();  // либо так
((IAction)newAction3).Move();

IMovable newAction4 = new NewAction();   // либо так
newAction4.Move();

BaseAction1 baseAction1 = new BaseAction1();
baseAction1.Move();

HeroAction heroAction = new HeroAction();
heroAction.Move();


// ======================= ЗАДАЧА ====================================
ApplicationTester myTest = new ApplicationTester();  // создаем объект тестера
myTest.AddTest(new IntegrationTest());               // в этом объекте добавим тесты, вызвав метод AddTest (см. класс ApplicationTester)
myTest.RunTests();                                  // запускаем тесты методом, который имплементирован за счет интерфейса ITestable

var myTest2 = new ApplicationTester();              // можно создать объект класса ApplicationTester и таким образом (без явного указания его типа)


UnitTest myUnitTest = new UnitTest();               // можно сделать так: создать объект определенного вида тестов (IntegrationTest, UITest или UnitTest)
myTest.AddTest(myUnitTest);                         // далее передать этот объект как аргумент в объект созданного тестера