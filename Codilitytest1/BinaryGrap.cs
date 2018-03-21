using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class BinaryGrap
    {
        public int solution(int N)
        {
            string binValue = Convert.ToString(N, 2);
            Regex regularExpression = new Regex("([0-0]+)1");
            MatchCollection matches = regularExpression.Matches(binValue);
            int maxLengthValue = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                if (maxLengthValue < matches[i].Groups[1].Value.Length)
                    maxLengthValue = matches[i].Groups[1].Value.Length;
            }

            return maxLengthValue;
        }
    }
}
