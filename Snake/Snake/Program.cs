using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(120, 32);

            HorizontLine upLine = new HorizontLine(0, 118, 0, '+');
            HorizontLine downLine = new HorizontLine(0, 118, 29, '+');
            VerticalLine leftLine = new VerticalLine(0, 29, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 29, 118, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(10, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();


            Console.ReadLine();

        }
       
    }
}
