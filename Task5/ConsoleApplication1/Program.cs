using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int, char> tuple = GetResult(new int[] { 2, 3, 4, 5, 6, 7, 8 }, "ShuraTop");
            Console.WriteLine("Min: " + tuple.Item1 +
                                "\nMax: " + tuple.Item2 +
                                "\nSum: " + tuple.Item3 +
                                "\nFirst: " + tuple.Item4);
            Console.ReadLine();
        }

        static Tuple<int, int, int, char> GetResult(int[] arr, string str)
        {
            int min = arr.Min();
            return new Tuple<int, int, int, char> (arr.Min(), arr.Max(), arr.Sum(), str.First());
        }

        }
    }
