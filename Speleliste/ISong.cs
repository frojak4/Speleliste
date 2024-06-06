using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speleliste
{
    internal interface ISong
    {
        string Name { get; }
        string Artist { get; }
        string Length { get; }

    }
}
