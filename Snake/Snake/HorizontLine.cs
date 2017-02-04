using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine : Figure
    {
        public HorizontLine(int xA, int xD, int y, char sim)
        {
            pList = new List<Point>();
            for (int x = xA; x <= xD; x++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
    }
}
