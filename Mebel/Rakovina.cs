using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebel
{
    class Rakovina : Furniture
    {
        public string Color;
    }
    class Rakovina50 : Rakovina
    {
        public Rakovina50()
        {
            Width = 50;
        }
    }
    class Rakovina70 : Rakovina
    {
        public Rakovina70()
        {
            Width = 70;
        }
    }
}
