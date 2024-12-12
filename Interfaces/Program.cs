using Interfaces.Example;
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

Tablet1 tablet1 = new Tablet1();
tablet1.Charge();