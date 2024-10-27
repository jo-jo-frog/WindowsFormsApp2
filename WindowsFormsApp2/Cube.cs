using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Cube : IFunction
    {
        public float calc(float x)
        {
            float res = (float)(Math.Pow((double)x / 5, 3.0));
            return res;
        }
    }
}
