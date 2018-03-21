using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 0;
            HashSet<int> A1 = new HashSet<int>(A);
            HashSet<int> PerfectArray = new HashSet<int>(Enumerable.Range(1, A.Length));
            if (A1.SetEquals(PerfectArray)) return 1;
            return 0;
        }
    }
}
