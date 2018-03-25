using System.Collections.Generic;

namespace leetcode
{
    public class Solution
    {
        // 771. Jewels and Stones
        // https://leetcode.com/problems/jewels-and-stones/description/
        public int NumJewelsInStones(string J, string S)
        {
            var stoneCounts = new Dictionary<char, int>();
            foreach (var stone in S)
            {
                if (stoneCounts.ContainsKey(stone))
                {
                    stoneCounts[stone] = ++stoneCounts[stone];
                }
                else
                {
                    stoneCounts.Add(stone, 1);
                }
            }

            var jewelCount = 0;
            foreach (var jewel in J)
            {
                if (stoneCounts.ContainsKey(jewel))
                {
                    jewelCount = jewelCount + stoneCounts[jewel];
                }
            }

            return jewelCount;
        }
    }
}
