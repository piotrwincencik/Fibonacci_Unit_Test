using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Unit_Test
{
    public class Fibonacci
    {
        public long Kalkulator(int position)
        {
            if (position == 1 || position == 2)
            {
                return 1;
            }

            int fibonnaci1 = 1;
            int fibonnaci2 = 1;
            int result = -1;

            for (int i = 3; i <= position; i++)
            {
                result = fibonnaci1 + fibonnaci2;
                fibonnaci1 = fibonnaci2;
                fibonnaci2 = result;
            }

            return result;
        }
    }
}
