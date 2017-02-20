using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team team = new Team();
            TeamLeader teamleader = new TeamLeader();
            Console.WriteLine(teamleader.name);
            //for (int i = 0; i < team.Length()-1; i++)
            //{
            //    team[i] = new Worker();
            //    team[i].name = $"Строитель {i+1}";
            //}
            int j = 0;
            int i = 0;
            while (house.roof == null)
            {
                if (j == 4)
                    j = 0;
                Console.WriteLine(team[j].name);
                team[j].Build(house);
                i++;
                j++;
                if (i == 4)
                {
                    Console.WriteLine("********************************");
                    teamleader.Build(house);
                    Console.WriteLine("********************************");
                }
            }
            Console.WriteLine("********************************");
            teamleader.Build(house);
            Console.WriteLine("********************************");
        }
    }
}
