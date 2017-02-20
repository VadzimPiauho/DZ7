using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    class Window : IPart
    {
        public bool constructionStatus { get; set; } = false;

        public void Construct()
        {
            constructionStatus = true;
            Console.WriteLine("Окно");
        }
    }
}
