using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s11 = "foo";
            string s22 = s11;
            string s33 = "foo";
            string s44 = "bar";
            Console.WriteLine(s11 == s33);
            Console.WriteLine(s11 == s44);
            Console.WriteLine((Object)s11 == (Object)s33);
            Console.WriteLine((Object)s11 == (Object)s22);

            string s1 = "Факультет";
            string s2 = "Информационных";
            string s3 = "Технологий";
            Console.WriteLine(String.Concat(s1 + " " + s2 + " " + s3));//сцепление строк
            //копирование строки
            string s4 = String.Copy(s1);
            Console.WriteLine("Копия строки s1: {0}", s4);
            //выделение подстроки
            int startIndex = 0;
            int length = 8;
            String substring = s3.Substring(startIndex, length);
            Console.WriteLine(substring);
            //разбиение строки на слова
            const string txt = "Программное обеспечение информационной безопасности мобильных систем";
            string[] words = txt.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //вставка подстроки в заданную позицию
            string s = "Hello World";
            Console.WriteLine(s.Insert(5, ",")); // вставляет запятую на 5 позицию 
            Console.ReadLine();
            //удаление заданной подстроки
            Console.WriteLine(s1.Remove(3, 3));


            string s111 = "abcd";
            string s222 = "";
            string s333 = null;

            Console.WriteLine("String s1 {0}.", Test(s111));
            Console.WriteLine("String s2 {0}.", Test(s222));
            Console.WriteLine("String s3 {0}.", Test(s333));

            StringBuilder MyStringBuilder = new StringBuilder("Факультет Информационных технологий");
            MyStringBuilder.Remove(5, 7);
            Console.WriteLine(MyStringBuilder);

            MyStringBuilder.Insert(0, "БГТУ ");
            Console.WriteLine(MyStringBuilder);

            MyStringBuilder.Append(" ПОИБМС");
            Console.WriteLine(MyStringBuilder);

        }

        public static String Test(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "Имеет значение null";
            else
                return String.Format("(\"{0}\") Не является пустой или null", s);
        }

    }
}

