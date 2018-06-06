using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piirtoavut
{
    public class Piste
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public Piste(int x, int y)
        {
            X = x;
            Y = y;

        }
        public Piste() : this(0,0) { }

    }
}
