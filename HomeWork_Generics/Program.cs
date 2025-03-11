// Задание № 1
using HomeWork_Generics.Task1;
using HomeWork_Generics.Task2;

Console.WriteLine("=========== Задание № 1 =============");
var point1 = new Point(3,4);
point1.ShowPoint();

// ============================
Console.WriteLine();
// ============================

// Задание № 2
Console.WriteLine("=========== Задание № 2 =============");
/***
 * Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
 * Также, данный класс должен иметь методы для:
 * добавления данных в массив,
 * удаления из массива,
 * получения элемента из массива по индексу и метод, возвращающий длину массива.

Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
см. класс ArrayContainer.cs
 */ 
ArrayContainer<int> testArray = new ArrayContainer<int>(4);
testArray.GetArrayLength();
testArray.AddItemToArray(3);
testArray.GetArrayLength();
testArray.GetItemFromArray(2);
testArray.DeleteItemFromArray(4);
testArray.GetArrayLength();
testArray.GetItemFromArray(2);

var testArray2 = new ArrayContainer<string>(3);
testArray2.GetArrayLength();
testArray2.AddItemToArray("Hello");
testArray2.GetItemFromArray(3);

// Задание № 3
/***
 * Реализовать класс машина у которого будет обобщенное поле двигатель.
 * Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, електро).
 * Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя.
 * Реализовать методы для движения автомобиля.
 */
Console.WriteLine("=========== Задание № 3 =============");
