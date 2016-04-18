using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    /*
    1) An interface can inherit from one or more base interfaces.
    2) When a base type list contains a base class and interfaces, the base class must come first in the list.
    3) A class that implements an interface can explicitly implement members of that interface. 
     An explicitly implemented member cannot be accessed through a class instance, but only through an instance of the interface, for example:
    */
    interface IPoint
    {
        // Property signatures:
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }
    }
    class Point : IPoint
    {
        // Fields:
        private int _x;
        private int _y;

        // Constructor:
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Property implementation:
        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }

    class MainClass
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }

        static void Main()
        {
            Point p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
        }
    }
}
