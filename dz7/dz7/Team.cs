using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class Team
    {
        private Worker[] team;
        public Team()
        {
            team = new Worker[4];
            for (int i = 0; i < team.Length; i++)
            {
                team[i] = new Worker();
                team[i].name = $"Строитель {i + 1}";
            }
        }
        public int Length()
        {
            return team.Length;
        }
        public Worker this[int index]
        {
            get
            {
                if (index >= 0 && index <= 3)
                    return team[index];
                return null;
            }
            set { team[index] = value; }
        }
    }
}
