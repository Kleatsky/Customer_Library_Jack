using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackConsole
{
    internal interface IPart
    {
        public string[] Poem { get; set; }
        public string[] AddPart();

    }
}
