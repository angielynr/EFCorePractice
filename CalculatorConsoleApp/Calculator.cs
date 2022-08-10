using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculator
    {
        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        public int Add(int a, int b)
        {
            var res = a + b;
            return res;
        }
    }
}
