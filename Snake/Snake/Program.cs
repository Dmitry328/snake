using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key==ConsoleKey.LeftArrow)
                    {
                        snake.direction = Direction.LEFT;
                    }
                    else if(key.Key==ConsoleKey.RightArrow)
                    {
                        snake.direction = Direction.RIGHT;
                    }
                    else if(key.Key==ConsoleKey.UpArrow)
                    {
                        snake.direction = Direction.UP;
                    }
                    else if(key.Key==ConsoleKey.DownArrow)
                    {
                        snake.direction = Direction.DOWN;
                    }
                }
                Thread.Sleep(100);
                    snake.Move();
            }

            Console.ReadLine();

        }
       
    }
}
