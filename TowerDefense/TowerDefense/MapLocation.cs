using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    // Sub Class of the Point Class
    class MapLocation : Point
    {
        // Needs to call the Point class constructor and pass the parameters  : base(x, y)
        public MapLocation(int x, int y) : base(x, y)
        {

        }
    }
}
