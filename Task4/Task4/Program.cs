using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наименование кортежей доступны начиная с версии C# 7.0 (Visual Studio 2017)
            //У меня VS2015.
            var myTuple = Tuple.Create<int, char, string, ulong, string>(12, 'C', "Name", 15, "Shura");
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item3);
            Console.WriteLine(myTuple.Item4);
            Console.ReadLine();

            //сравнение 2-х кортежей
            var t1 = Tuple.Create(123, "Hello");
            var t2 = Tuple.Create(123, "Hello");
            //распаковка кортежей
            var a = myTuple.Item1;
            var b = myTuple.Item2;
            Console.WriteLine(t1.Equals(t2));
        }
    }
}
