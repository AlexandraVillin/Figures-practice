using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_attempt_2
{
    class Program
    {
        static void Foo()
        {
            Rectangle foo1 = new Rectangle(1, 1, "boo", 1, 1);
            Rectangle foo2 = new Rectangle(1, 1, "goo", 1, 1);
        }
        static void Main(string[] args)
        {
            Rectangle p1 = new Rectangle(2, 2, "ppp", 3, 3);
            Console.WriteLine(p1);
            Console.WriteLine("\n number of rectangles:");
            Console.WriteLine(p1.GetInstanceNumber());
            Console.WriteLine("\n");

            Rectangle p2 = new Rectangle(3, 6, "ddd", 4, 1);
            Console.WriteLine(p2);
            Console.WriteLine("\n number of rectangles:");
            Console.WriteLine(p2.GetInstanceNumber());
            Console.WriteLine("\n");

            Rectangle p3 = new Rectangle(0, 0, "sss", 6, 9);
            Console.WriteLine(p3);
            Console.WriteLine("\n number of rectangles:");
            Console.WriteLine(p3.GetInstanceNumber());
            Console.WriteLine("\n");

            Foo();
            Console.WriteLine("\n number of rectangles:");
            Console.WriteLine(p3.GetInstanceNumber());

            Elipse e1 = new Elipse(1, 2, "ccc", 3, 4);
            Elipse e2 = new Elipse(5, 6, "iii", 7, 8);

            Console.WriteLine("\n number of figures:");
            Console.WriteLine(e2.GetFigureInstanceNumber());

            //without static

            Console.ReadLine();
        }
    }
}
