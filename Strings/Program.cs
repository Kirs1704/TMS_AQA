using System;
using System.Runtime.InteropServices.JavaScript;

namespace Strings
{
    static class Program
    {
        static void Main(string[] args)
        {
            string oldPath = "C:\\Program Files\\tmp.txt";
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
                string s10 = string.Join(" ", values); // apple a day keeps a doctor away

        }
    }
}