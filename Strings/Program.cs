using System;
using System.Runtime.InteropServices.JavaScript;

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
                //------ Пример № 1. Извлечение подстроки, начиная с определенной позиции
                
        }
    }
}
