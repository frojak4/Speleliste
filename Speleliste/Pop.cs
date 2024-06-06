using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speleliste
{
    internal class Pop : ISong
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Length { get; set; }

        public Pop(string name, string artist, string length)
        {
            Name = name;
            Artist = artist;
            Length = length;
        }
    }
}
