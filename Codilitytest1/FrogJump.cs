using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class FrogJump
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (X == Y) return 0;
            if (D < 1 || D> 1000000000) throw new Exception("Error: The step D must be between  than 1 and 1000000000 !!");
            if (X > Y) throw new ArgumentOutOfRangeException("Error 02: X should be less or equal then Y");

            return (Y - X) / D + (((Y - X) % D == 0) ? 0 : 1);
        }
    }
}
