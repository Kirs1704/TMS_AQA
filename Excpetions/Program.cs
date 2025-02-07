using Excpetions;


// ============== Ошибка =======================


/*
int[] array = new int[3];
int value = array[5];
*/


// ============= Исключение ====================
/*
Object obj = null;
obj.GetHashCode();
*/


// ================= Checked Exceptions ===================== (Контролируемые исключения)
CheckedExceptions checkedExceptions = new CheckedExceptions();
//checkedExceptions.ReadFile("file.txt");

// ================= Unchecked Exceptions ===================== (Неконтролируемые исключения)
UncheckedExceptions uncheckedExceptions = new UncheckedExceptions();
//uncheckedExceptions.DivideNumbers(1,0);


// ========= Использование try...catch...finally ===========================================
/*
ExceptionUsage exceptionUsage = new ExceptionUsage();
exceptionUsage.Template();


try
{
    checkedExceptions.TestException(1, 0);
}
catch
{
    Console.WriteLine("Возникло исключение в методе TestException");
}

exceptionUsage.FilterCatch(1,0);
*/

// ================================== Обработка исключений и условные конструкции ============================
/*string data = Console.ReadLine();

// вместо блоков try...catch иногда удобнее использовать условную коснтрукцию if
if (int.TryParse(data, out var x1))
{
    Console.WriteLine($"Результат: {x1}");
}
else
{
    Console.WriteLine("Некорректный ввод данных");
}*//**/


// а вот аналогичный, но менее предпочтительный в ДАННОМ случае вариант с блоками try...catch
/*try
{
    int x = Convert.ToInt32(data);
    Console.WriteLine($"Результат: {x}");
}
catch
{
    Console.WriteLine("Некорректный ввод");
}*/
// ================================== throw new Exception ====================================
// Генерация исключения и оператор throw

//Console.WriteLine("=================================");

/*try
{
Console.Write("Введите имя: ");
string name = Console.ReadLine();

    if (name == null || name.Length < 2)
    {
        throw new Exception("Имя не может быть короче двух символов!");       // вот так создается новый (кастомный) экземпляр Exception
    }
    else
    {
        Console.WriteLine($"Ваше имя: {name}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}*/

/*ThrowException throwException = new ThrowException();
//throwException.CheckUserName();

CustomExceptionRunner customExceptionRunner = new CustomExceptionRunner();
//customExceptionRunner.Run();
customExceptionRunner.ProcessInput("  ");*/
