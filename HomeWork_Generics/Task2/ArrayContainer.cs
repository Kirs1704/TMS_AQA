using System.Runtime.InteropServices.JavaScript;

namespace HomeWork_Generics.Task2;

public class ArrayContainer<T> // создали обобщенный класс
{
    private T[] array = new T[0]; // объявили приватную переменную с обобщенным типом и инициализировали стартовый массив (пустой)

    public ArrayContainer(int startSize)  // создали конструктор, куда в качестве аргумента передаем начальный размер массива
    {
        array = new T[startSize];         // т.о. в конструкторе создается массив с размерностью, переданной в кач. аргумента
    }

    public void AddItemToArray(T newItem)  // метод добавления нового элемента в массив
    {
        T[] newArray = new T[array.Length + 1]; // создаем новый массив с размерностью на 1 больше начального массива
        Array.Copy(array, newArray, array.Length); // копируем все элементы начального массива в новый массив
        newArray[newArray.Length - 1] = newItem; // добавляем новый элемент в конец массива
        array = newArray;                        // перезаписываем первоначальный массив на новый
    }

    public void DeleteItemFromArray(int index)
    {
        T[] newArray = new T[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                
                if (i == index)
                {
                    continue;
                }
            }
            else
            {
                Array.Copy(array, newArray, array.Length);
            }
        }

        array = newArray;
    }
}