using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackConsole
{
    internal interface IPart
    {
        ImmutableList<string> Poem { get; set; }
        public void AddPart(ImmutableList<string> list);

    }
}
