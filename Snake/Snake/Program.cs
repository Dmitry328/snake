﻿using System;
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

            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();

            //HorizontLine pLine = new HorizontLine(3, 7, 9, '+');
            //pLine.Drow();


            HorizontLine pLine = new HorizontLine(3, 8, 4, '+');
            pLine.Drow();

            Console.ReadLine();

        }
       
    }
}
