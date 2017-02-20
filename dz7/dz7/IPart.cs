using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    interface IPart
    {
        bool constructionStatus { get; set; }
        void Construct();
    }
}
