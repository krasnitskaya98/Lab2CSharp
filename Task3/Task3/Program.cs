using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
             
            string[] stringArray = new string[7];
            string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            foreach (var v in weekDays)
                Console.WriteLine(v);
            //длина массива
            int n = weekDays.Length;
            Console.WriteLine(n);

            var arr1 = new[] { 1, 2, 3 };
            Console.WriteLine("Тип массива arr1 - {0}", arr1.GetType());

            var arr2 = new[] { "One", "Two", "Three" };
            Console.WriteLine("Тип массива arr2 - {0}", arr2.GetType());

            Console.ReadLine();

        }
    }
}
