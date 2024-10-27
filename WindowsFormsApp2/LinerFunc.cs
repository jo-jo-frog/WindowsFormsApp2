using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class LinerFunc : IFunction
    {
        public float calc(float x)
        {
            float res = 2 * x + 5 + 120;
            return res;
        }
    }
}
