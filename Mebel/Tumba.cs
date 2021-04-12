using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebel
{
    class Tumba : Furniture
    {
        public string Color;
        public int CountBoxes;
    }

    class Tumba50 : Tumba
    {
        public Tumba50()
        {
            Width = 50;
        }
    }
    class Tumba70 : Tumba
    {
        public Tumba70()
        {
            Width = 70;
        }
    }
}
