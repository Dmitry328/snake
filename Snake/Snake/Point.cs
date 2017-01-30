using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}
