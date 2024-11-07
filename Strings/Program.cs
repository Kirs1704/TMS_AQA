using System;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*string oldPath = "C:\\Program Files\\tmp.txt";
            string newPath = @"C:\Program Files\tmp.txt";
            
            //============ варианты создания строки ==============

            string s1 = "Hello";
            string s2 = new String('a', 6); //результат вывода 'aaaaaa'
            string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1,3); // orl
            
            Console.WriteLine(s1); //Hello
            Console.WriteLine(s2); // aaaaaa
            Console.WriteLine(s3); // world
            Console.WriteLine(s4); // orl
            
            // ========== сравнение строк =================

            string msg1 = "hello";
            string msg2 = "hello";
            Console.WriteLine(msg1==msg2); //true
            Console.WriteLine(msg1.Equals(msg2)); //более правильный вариант сравнения
            
            //обращение к символу в строке по индексу
            Console.WriteLine(msg1[0]); // h
            
            //перебор символов в строке с помощью цикла

            foreach (char c in msg1)
            {
                Console.Write($"{c} ");
            }
                Console.WriteLine();
                
            //=============== многострочный текст ==================

            string txt11 = """
                         <element attr="content">
                         <body>
                         </body>
                         </element>
                         """;
                Console.WriteLine(txt11);
                
                //================ объединение строк с помощью JOIN =====================
                string s5 = "apple";
                string s6 = "a day";
                string s7 = "keeps";
                string s8 = "a doctor";
                string s9 = "away";
                string[] values = new string[] { s5, s6, s7, s8, s9 };
                string s10 = string.Join(" ", values); // apple a day keeps a doctor away*/
                
                /*
                //================== Метод CompareTo ===============================
                string s11 = "hello";
                string[] compare_values = new string[] { "hello", "nice", "day" };
                foreach (string item in compare_values)
                {
                    Console.WriteLine($"Результат сравнения: {s11.CompareTo(item)}");
                }
                //=================== Поиск в строке =============================
                string target_text = "Have a nice day!";
                
                //================== метод IndexOf and IndexOfAny
                Console.WriteLine(target_text.IndexOf('v')); // с учетом регистра
                Console.WriteLine(target_text.IndexOf('V', StringComparison.OrdinalIgnoreCase)); //без учета регистра
                Console.WriteLine(target_text.IndexOf('a', 3)); //с указанием начала поиска

                char[] chars1 = { 't', 'v', 'j' };
                Console.WriteLine(target_text.IndexOfAny(chars1)); //этот метод работает с массивами
                
                
                //============ метод StartsWith
                
                var files = new string[]
                {
                    "myapp.exe",
                    "forest.jpg",
                    "main.exe"
                };

                foreach (string file in files)
                {
                    Console.WriteLine($"Начинается ли файл {file} с маленькой буквы m(с учетом регистра): {file.StartsWith('m')}");
                    Console.WriteLine($"Начинается ли файл {file} с большой буквы M (с учетом регистра): {file.StartsWith('M')}");
                    Console.WriteLine($"Начинается ли файл {file} с 'My' (без учета регистра): {file.StartsWith("My", StringComparison.OrdinalIgnoreCase)}");
                }
                
                //============ метод EndsWith
                
                foreach (string file in files)
                {
                    Console.WriteLine($"Заканчивается ли файл {file} на '.jpg' (с учетом регистра): {file.EndsWith(".jpg")}");
                    Console.WriteLine($"Заканчивается ли файл {file} на '.JpG' (с учетом регистра): {file.EndsWith(".JpG")}");
                    Console.WriteLine($"Заканчивается ли файл {file} на 'exe' (без учета регистра): {file.EndsWith(".exe", StringComparison.OrdinalIgnoreCase)}");
                }*/
                
                /*
                //============= разделение строк (Split)

                string txt9 = "Such:a:nice:day!";
                string txt10 = "10: 99: :: 55";

                string[] arrayFrom_txt9 = txt9.Split(":");
                foreach (string ch in arrayFrom_txt9)
                {
                    Console.Write($"'{ch}' ");
                }           
                Console.WriteLine();

                string[] arrayFrom_txt10 = txt10.Split(":", StringSplitOptions.TrimEntries);
                foreach (string ch in arrayFrom_txt10)
                {
                    Console.Write($"'{ch}' ");
                }
                */
                
                //====================== обрезка строк (Trim)
                
                string original_txt = " Hello, World! ";
                Console.WriteLine($"Первоначальный вид: '{original_txt}'");
                original_txt = original_txt.Trim();
                Console.WriteLine($"Преобразованный вид: '{original_txt}'");
                
                Console.WriteLine();

                string original_txt_2 = " *Hello, World!* ";
                Console.WriteLine($"Первоначальный вид: '{original_txt_2}'");
                char[] chars_to_remove = { '*', ' ' };
                original_txt_2 = original_txt_2.Trim(chars_to_remove);
                Console.WriteLine($"Преобразованный вид: '{original_txt_2}'");
                
                Console.WriteLine();
                //======= TrimStart (используется для удаления символов только в начале)
                string original_txt_3 = " Hello, World! ";
                Console.WriteLine($"Первоначальный вид: '{original_txt_3}'");
                original_txt_3 = original_txt_3.TrimStart();
                Console.WriteLine($"Преобразованный вид: '{original_txt_3}'");
                
                //======= TrimEnd (используется для удаления символов только в конце)
                
                //======= Извлечение определенной части строки (SubString)
                string txt99 = "Hello World!";
                
                //------ Пример № 1. Извлечение подстроки, начиная с определенной позиции
                string substr1 = txt99.Substring(6); //вырежет часть строки начиная с индекса 6
                Console.WriteLine(substr1);
                
                //------- Пример № 2. Извлечение из определенного диапазона
                string substr2 = txt99.Substring(6, 5); //первый параметр - стартовый индекс, второй - количество символов для вырезки
                Console.WriteLine(substr2);
                
                //-------- Пример № 3. Извлечение подстроки через переменные
                int startIndex = 6;
                int length = 5;
                string substr3 = txt99.Substring(startIndex, length);
                Console.WriteLine($"Substring ({startIndex}, {length}): {substr3}");
                
                // ЛИБО
                int startIndex1 = 6;
                string word = "World";
                string substr4 = txt99.Substring(startIndex1, word.Length);
                Console.WriteLine($"Substring ({startIndex1}, {word.Length}): {substr4}");
                
                
                //================================= ВСТАВКА (insert) =========================
                string txt11 = "Hello World!";
                
                //------------------ ПРИМЕР № 1. ВСТАВКА В СЕРЕДИНУ СТРОКИ
                string insert_txt = txt11.Insert(6, "beautiful ");
                Console.WriteLine(insert_txt);

                //------------------ ПРИМЕР № 2. ВСТАВКА В НАЧАЛО СТРОКИ
                string insert_txt1 = txt11.Insert(0, "Greetings: ");
                Console.WriteLine(insert_txt1);
                
                //------------------ ПРИМЕР № 3. ВСТАВКА В КОНЕЦ СТРОКИ
                string insert_txt2 = txt11.Insert(txt11.Length, " Have a nice day!");
                Console.WriteLine(insert_txt2);
                
                
            //================================ УДАЛЕНИЕ (REMOVE) ==================================

            string example = "Hello, World!";
            string remove_example = example.Remove(7); //начиная с индекса 7
            Console.WriteLine(remove_example);
            
            string example1 = "Hello, World!";
            string remove_example1 = example1.Remove(7, 3); //начиная с индекса 7 будет удалено 3 символа
            Console.WriteLine(remove_example1);
            
            string example2 = "Hello, World!";
            string remove_example2 = example2.Remove(example2.Length-3); //удалит 3 символа с конца
            Console.WriteLine(remove_example2);
            
            
            
            //================================= ЗАМЕНА (REPLACE) ===========================================
            string example3 = "Hello, World! Hello, Everybody!";
            string replace_example = example3.Replace("Hello", "Hi"); //поменяет первое значение во всей строке на второе
            Console.WriteLine(replace_example);
            
            //================================ СМЕНА РЕГИСТРА ===============================================
            string hello = "Hello, World!";
            Console.WriteLine(hello.ToLower()); // hello, world!
            Console.WriteLine(hello.ToUpper()); // HELLO, WORLD!
            
            //===================== ПРОВЕРКА НА СОДЕРЖАНИЕ ЧЕГО-ТО В СТРОКЕ (CONTAINS)=======================
            string hello1 = "Hello, World!";
            
            //----Проверка наличия подстроки
            bool sub_hello = hello1.Contains("World");
            Console.WriteLine(sub_hello);                           // True
            
            //----Проверка наличия подстроки (регистрозавимая)
            bool sub_hello1 = hello1.Contains("WORLD", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(sub_hello1);                           // True
            
            //----Проверка наличия символа
            bool sub_hello2 = hello1.Contains(",");
            Console.WriteLine(sub_hello2);                           // True
            
            
            // =========================== ФОРМАТИРОВАНИЕ СТРОК (string.Format) ========================

            string name = "Kirill";
            int age = 33;
            Console.WriteLine("Hello! My name is {0}, i'm {1} years!", name, age);


            string greetings = string.Format("Hello, {0}! Today is {1}!", "Kirs", DateTime.Now.DayOfWeek);
            Console.WriteLine(greetings);
            
            //-------Форматирование чисел
            // C - форматирование валюты
            string formattedString1 = string.Format("The price is: {0:C}", 123.45); // Вывод: The price is: 123.45 ($, руб. - в зависимости от локали) 
            Console.WriteLine(formattedString1);
            
            //------настраиваемый формат
            long number = 19876543210;
            string result = string.Format("{0:+# (###) ###-##-##}", number); // Вывод: +1 (987) 654-32-10

            Console.WriteLine(result);
            
            // ================================ StringBuilder ===========================================
            //-------------Constructor
            StringBuilder sb = new StringBuilder("Hello, "); // инициализировали
            sb.Append("world!");                             // добавили слово
            Console.WriteLine(sb);
            
            
            Console.WriteLine();
            
            //------------- AppendLine
            // добавляет необходимое и переводит каретку на новую строку
            StringBuilder sb1 = new StringBuilder("Hello, ");
            sb1.AppendLine("world!");
            sb1.AppendLine("How are you?");
            Console.WriteLine(sb1);
            
            //==================== РЕГУЛЯРНЫЕ ВЫРАЖЕНИЯ (Regex) ==============================
            
            //------------------ Соответствие строки регулярному выражению
            string input = "Hello, 123!";
            string pattern = @"(\d+)"; //Шаблон: одна или более цифр
            
            
            //==================================== HOMEWORK ========================================
            
            //------------------ Задание № 1
            //Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами
            
            Console.WriteLine("========= Задание № 1 ===========");
       
            string origin_txt = "Hello everybody, hello world! Hello sun, hello new day! Today is 22 and 33 and 44 cool facts!";
            Console.WriteLine($"Первоначальный вид: {origin_txt}");
            string replace_txt = origin_txt.Replace("Hello", "Hi", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Измененный вид: {replace_txt}");
            string pattern1 = @"(\d+)";
            string final_txt = Regex.Replace(replace_txt, pattern1, "");
            Console.WriteLine($"Измененный вид без чисел: {final_txt}");
            
            Console.WriteLine();
            //------------------ Задание № 2
            
            /*
            Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
            Welcome to the TMS lessons.
            Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
            */
            
            Console.WriteLine("========= Задание № 2 ===========");
            string start_txt = "Welcome to the TMS lessons";
            Console.WriteLine($"Первоначальный вид: {start_txt}");

            string[] final_txt1 = start_txt.Split(" ");
            Console.Write("Модифицированный вид: ");
            foreach (string words in final_txt1)
            {
                Console.Write($"'{words}' ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //------------------ Задание № 3
            Console.WriteLine("========= Задание № 3 ===========");
            
            /*
            Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
            Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, 
            а также всё, что после них во вторую.
            Результат вывести в консоль.
            */

            string start_txt2 = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            Console.WriteLine($"Стартовое сообщение: {start_txt2}");
            string before_abc = start_txt2.Substring(0,24);
            string after_abc = start_txt2.Substring(27);
            Console.WriteLine($"До 'abc': {before_abc}");
            Console.WriteLine($"После 'abc': {after_abc}");
            
            Console.WriteLine();
            //------------------ Задание № 4
            Console.WriteLine("========= Задание № 4 ===========");
            
            /*
            Дана строка: “Плохой день.”
            Необходимо с помощью метода substring удалить слово "плохой". 
            После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
            Заменить последний "!" на "?"
            */
            string start_txt3 = "Плохой день.";
            Console.WriteLine($"Стартовая строка: {start_txt3}");
            string delete_badDay = start_txt3.Substring(7);
            string good_day = delete_badDay.Insert(0, "Хороший ");
            good_day += "!!!!!!!!!";
            good_day = good_day.Remove(good_day.Length - 1, 1).Insert(good_day.Length - 1, "?");
            Console.WriteLine($"Преобразованная строка: {good_day}");

            Console.WriteLine();
            //------------------ Задание № 5
            Console.WriteLine("========= Задание № 5 ===========");
            string start_txt4 = "1234-fff-3333-bbb-1a1b";
            string pattern2 = @"(\d{4})";
            MatchCollection matches = Regex.Matches(start_txt4, pattern2);
            Console.Write("Первые два блока с цифрами: ");
            foreach (Match item in matches)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            string pattern3 = @"[A-Za-z]{3}";
            string result3 = Regex.Replace(start_txt4, pattern3, "***");
            Console.WriteLine($"Замена букв на '*': {result3}");
            



        }
    }
}
