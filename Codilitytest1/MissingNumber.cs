using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class MissingNumber
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 1;
            long n = A.Length;
            return Convert.ToInt32(((n + 1) * (n + 2) / 2) - A.Sum(x => (long)x));
        }
    }
}
