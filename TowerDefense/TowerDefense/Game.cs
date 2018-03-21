using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            //Assign MapLocation to a Point as it is created
            Point x = new MapLocation(4, 2);
            //Assign MapLocation to a Point
            Point p = x;
            //Even pass Maplocation objects into methods that are expecting a Point
            map.OnMap(new MapLocation(0, 0));

            Console.WriteLine(x.DistanceTo(5, 5));

            // Type Check
            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);

            //Point is not a MapLocation so output is FALSE
            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);

            // Pause the program so you can see the output
            Console.ReadLine();
        }
    }
}
