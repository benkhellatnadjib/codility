using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class Solution
    {
        public int solution(int[] A)
        {
            return A.Aggregate((x, y) => x ^ y);
        }
    }
}
