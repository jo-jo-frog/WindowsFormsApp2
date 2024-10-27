using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Square : IFunction
    {
        public float calc(float x)
        {
            float res = (float)Math.Pow(x/5, 2.0);
            return res;
        }
    }
}
