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

            Point p1 = new Point(1, 3, '*');
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            p2.Drow();

            Point p3 = new Point(6, 8, '_');
            p3.Drow();

            Point p4 = new Point(9, 10, '^');
            p4.Drow();


            List<int> namList = new List<int>();
            namList.Add(0);
            namList.Add(1);
            namList.Add(2);

            foreach(int i in namList)
            {
                Console.WriteLine(i);
            }


            List<Point> pList = new List<Point>();


            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach(char i in namList)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
       
    }
}
