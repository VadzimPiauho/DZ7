using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class House
    {
        public Basement basement { get; set; }
        public Walls[] walls { get; }
        public Door door { get; set; }
        public Window[] windows { get; }
        public Roof roof { get; set; }
        public House()
        {
            basement = null;
            walls = new Walls[4];
            door = null;
            windows = new Window[4];
            roof = null;
        }
    }
}
