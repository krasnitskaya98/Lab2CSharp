using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x = 100;
            Int32 y = x + 100;
            Console.WriteLine(y);

            Decimal d = 20;
            Decimal e = d / 7;
            Console.WriteLine(e);

            String s = "Learning ";
            String t = s + "C#";
            Console.WriteLine(t);

            Boolean f = (x == y);
            Console.WriteLine("\t" + f);
            Console.WriteLine();

            Byte q = 0x00C9;
            Console.WriteLine(q);

            char ch = 'A';
            Console.WriteLine(ch);

            double w = 3D;
            Console.WriteLine(w);

            sbyte r = -102;
            Console.WriteLine(r);

            uint p = 3000000000;
            Console.WriteLine(p);

            float k = 3.5F;
            Console.WriteLine(k);

            long l = 4294967296;
            Console.WriteLine(l);

            short j = 1034;
            Console.WriteLine(j);

            ulong h = 7934076125;
            Console.WriteLine(h);

            double xx = 1234.7;
            int a;
            a = (int)xx;
            Console.WriteLine(a);

            //явное преобразование
            short sh = 45;
            byte b = (byte)sh;
            Console.WriteLine("Byte = {0}", b);

            //явное преобразование
            double pi = 3.1415926;
            int entier = (int)pi;
            Console.WriteLine(entier);

            //явное преобразование
            Double z = 42.72;
            int dd = checked((int)z);
            Console.WriteLine(d);

            //явное преобразование
            long ll = 1234;
            int i = Convert.ToInt32(l);
            Console.WriteLine("Int = {0}", i);

            //неявное преобразование
            byte ww = 5;
            short rr = b;
            int u = b;
            long pp = b;
            double n = l;
            Console.WriteLine("Short = {0}, Int = {1}, Long = {2}, Double = {3}", w, r, u, p);

            //неявное преобразование
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(bigNum);


            Point valPoint3 = new Point(); // Поле в объекте-типе
                                    // Настройка консоли
            Console.Title = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            Point valPoint = new Point(5, 10);// Инициализировали и поместили в стек
            valPoint.Show("Исходный объект в стеке: ");
            object refPoint = valPoint;// Упаковка: ссылка в стеке, объект в куче
            ((Point)refPoint).Show("\nИсходный объект в куче: ");
            object refPoint1 = refPoint;// Еще одна ссылка на объект в куче
            CreatePackPoint(ref refPoint1);// Создали еще один объект в куче
            ((Point)refPoint1).Show("\nНовый объект в куче: ");

            Point valPoint1 = new Point();
            valPoint1.Show("\nЕще один локальный объект в стеке: ");

            Point valPoint2;// Статическое объявление локального объекта
            valPoint2.x = 50;// Обязательная инициализация
            valPoint2.y = 70;// Обязательная инициализация
            valPoint2.Show("\nИ еще один локальный объект в стеке: ");

            valPoint3.Show("\nОбъект-поле в типе: ");


            // Эти переменные типизированы неявно. Они отнесены
            // к типу double,  поскольку инициализирующие их
            // выражения сами относятся к типу double,
            var s1 = 4.0;
            var s2 = 5.0;

            // Итак, переменная hypot типизирована неявно и
            // относится к типу double, поскольку результат,
            // возвращаемый методом Sqrt(),  имеет тип double,
            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

            Console.Write("Гипотенуза треугольника со сторонами " +
            s1 + " by " + s2 + " равна ");

            Console.WriteLine("{0:#.###}.", hypot);

            // Следующий оператор не может быть скомпилирован.
            // поскольку переменная s1 имеет тип double и
            // ей нельзя присвоить десятичное значение.
            // s1 = 12.2M;  // Ошибка!//Опять упаковываем


            int? figure = null;
            Console.WriteLine(figure.GetValueOrDefault()); // по умолчанию используется 0
            Console.WriteLine(figure.GetValueOrDefault(10)); // по умолчанию используется 10

            Nullable<State> state = null;
            if (state.HasValue)
                Console.WriteLine(state.Value.Name);
            state = new State() { Name = "Объектно-ориентированное программирование!" };
            if (state.HasValue)
                Console.WriteLine(state.Value.Name);

            // Nullable<Country> country = null; так нельзя

            Console.ReadLine();
        }

        static void CreatePackPoint(ref object arg)
        {
            Point point = (Point)arg;// Распаковываем
            point.Set(20, 30);// Изменяем
            arg = point;//Опять упаковываем
        }
    }
    class Country
    {
        public string Name { get; set; }
    }

    struct State
    {
        public string Name { get; set; }
    }

    struct Point
        {
            // Поля
            public int x, y;

            // Конструктор
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Функция доступа
            public void Set(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // Печать
            public void Show(string message)
            {
                Console.WriteLine(message + "x={0}, y={1}", x, y);
            }
        }
}
