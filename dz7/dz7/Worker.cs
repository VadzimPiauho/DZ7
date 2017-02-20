using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class Worker : IWorker

    {
        public Worker() { }
        public string name { get; set; }
        public void Build(House house)
        {
            if (house.basement == null)
            {
                house.basement = new Basement();
                house.basement.Construct();
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.walls[i] == null)
                {
                    house.walls[i] = new Walls();
                    house.walls[i].Construct();
                    return;
                }
            }
            if (house.door == null)
            {
                house.door = new Door();
                house.door.Construct();
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.windows[i] == null)
                {
                    house.windows[i] = new Window();
                    house.windows[i].Construct();
                    return;
                }
            }
            if (house.roof == null)
            {
                house.roof = new Roof();
                house.roof.Construct();
            }
        }
    }
}
