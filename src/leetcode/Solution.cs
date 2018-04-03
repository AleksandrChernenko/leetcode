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

        /// <summary>
        /// 13. Roman to Integer
        /// </summary>
        /// https://leetcode.com/problems/roman-to-integer/description/

        private readonly Dictionary<char, int> romanToIntDictionary = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        public int RomanToInt(string s)
        {
            int i = 0, intNumber = 0, blockSum = 0;

            while (i < s.Length)
            {
                if (i + 1 >= s.Length || romanToIntDictionary[s[i]] > romanToIntDictionary[s[i+1]])
                {
                    intNumber = intNumber + romanToIntDictionary[s[i]];
                    ++i;
                    continue;
                }

                if (romanToIntDictionary[s[i]] == romanToIntDictionary[s[i + 1]])
                {
                    intNumber = romanToIntDictionary[s[i]] + intNumber;
                    ++i;
                    continue;
                }

                if (romanToIntDictionary[s[i]] < romanToIntDictionary[s[i + 1]])
                {
                    intNumber = intNumber - romanToIntDictionary[s[i]] ;
                    ++i;
                    continue;
                }
            }

            return intNumber;
        }

        /// <summary>
        /// 268. Missing Number
        /// </summary>
        /// https://leetcode.com/problems/missing-number/description/
        public int MissingNumber(int[] nums)
        {

            var tempHashSet = new HashSet<int>();

            foreach (var num in nums)
            {
                tempHashSet.Add(num);
            }

            for (int i = 0; i <= nums.Length; i++)
            {
                if (!tempHashSet.Contains(i))
                    return i;
            }

            return 0;
        }

        /// <summary>
        /// 283. Move Zeroes
        /// </summary>
        /// https://leetcode.com/problems/move-zeroes/description/
        public int[] MoveZeroes(int[] nums)
        {
            var insertPosition = 0;

            foreach (var num in nums)
            {
                if (num != 0)
                {
                    nums[insertPosition++] = num;
                }
            }

            while (insertPosition < nums.Length)
            {
                nums[insertPosition++] = 0;
            }

            return nums;
        }

        
    }
}
