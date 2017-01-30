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

            Point p1 = new Snake.Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            p1.Drow();

            Point p2 = new Snake.Point();
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            p2.Drow();
                       
            Console.ReadLine();

        }
       
    }
}
