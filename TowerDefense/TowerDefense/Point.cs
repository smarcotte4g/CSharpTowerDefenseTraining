using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        // Constructor
        public Point(int x, int y)
        {
            // Initialize Values
            X = x;
            Y = y;
        }


        // DistanceTo Method that calculates the distance between 2 point objects
        // Overloaded Method is the same name but take different parameters
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }

        public int DistanceTo(int x, int y)
        {
            // This code is the same as the line that is not commented out
            //int xDiff = X - x;
            //int yDiff = Y - y;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        
    }
}
