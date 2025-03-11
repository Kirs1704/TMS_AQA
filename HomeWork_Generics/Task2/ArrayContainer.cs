using System.Runtime.InteropServices.JavaScript;

namespace HomeWork_Generics.Task2;

public class ArrayContainer<T> // создали обобщенный класс
{
    private T[] array = new T[0]; // объявили приватную переменную с обобщенным типом и инициализировали стартовый массив (пустой)

    public
        ArrayContainer(int startSize) // создали конструктор, куда в качестве аргумента передаем начальный размер массива
    {
        array = new T[startSize]; // т.о. в конструкторе создается массив с размерностью, переданной в кач. аргумента
    }

    public void AddItemToArray(T newItem) // метод добавления нового элемента в массив
    {
        T[] newArray = new T[array.Length + 1]; // создаем новый массив с размерностью на 1 больше начального массива
        Array.Copy(array, newArray, array.Length); // копируем все элементы начального массива в новый массив
        newArray[newArray.Length - 1] = newItem; // добавляем новый элемент в конец массива
        array = newArray; // перезаписываем первоначальный массив на новый
    }

    public void DeleteItemFromArray(int index) // создаем метод для удаления элемента по введенному индексу
    {
        if (index < 0 || index > array.Length - 1) // тут проверяем, что введенный индекс соответствует условиям
        {
            throw new IndexOutOfRangeException("Введенный индекс не входит в границы массива"); // если индекс не соответствует, выбрасываем исключение
        }
        T[] newArray = new T[array.Length - 1]; // создаем новый массив, емкостью на 1 меньше, чем начальный (т.к. хотим удалить один элемент)
        int startIndex = 0;                     // объявляем переменную-счетчик для прохождения циклом по индексу
        for (int i = 0; i<array.Length; i++)
        {
            if (i!= index)                      // если индекс соответствует введенномому, его пропускаем и не копируем в новый массив
            {
                newArray[startIndex] = array[i]; // тут начинаем идти по новому массиву с 0, так как переменная счетчик изначально задана как 0. Присваиваем индексу нового массива значение из array
                startIndex++;                    // увеличиваем индекс (шаг) каждую итерацию
            }
        }

        array = newArray;                          // перезаписываем первоначальный массив на новый
    }

    public void GetItemFromArray(int index)
    {
        Console.WriteLine($"По вашему индексу нашелся элемент: {array[index]}");
    }

    public int GetArrayLength()
    {
        int x = array.Length;
        Console.WriteLine($"Длина массива составляет: {x}");
        return x;
    }
}