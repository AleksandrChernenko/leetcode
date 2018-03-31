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

        /// <summary>
        /// 657. Judge Route Circle
        /// </summary>
        /// https://leetcode.com/problems/judge-route-circle/description/
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'R':
                        x = ++x;
                        break;
                    case 'L':
                        x = --x;
                        break;
                    case 'U':
                        y = ++y;
                        break;
                    case 'D':
                        y = --y;
                        break;
                }
            }

            return x == 0 && y == 0;
        }

        /// <summary>
        /// 171. Excel Sheet Column Number
        /// </summary>
        /// https://leetcode.com/problems/excel-sheet-column-number/description/
        public int TitleToNumber(string s)
        {
            var titleNumber = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                titleNumber = (int) ((s[i] - 64) * Pow(26, s.Length - 1 - i) + titleNumber);
            }

            return titleNumber;
        }

        private int Pow(int @base, int exponent)
        {
            var result = 1;
            while (exponent > 0)
            {
                result = result * @base;
                exponent = --exponent;
            }

            return result;
        }
    }
}
