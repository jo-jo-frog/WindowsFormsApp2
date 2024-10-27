using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Sine : IFunction
    {
        public float calc(float x)
        {
            float res = (float)(Math.Sin((double)x/35) * 25);
            return res;
        }
    }
}
