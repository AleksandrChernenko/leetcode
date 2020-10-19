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

        /// <summary>
        /// 169. Majority Element
        /// </summary>
        /// https://leetcode.com/problems/majority-element/solution/
        public int MajorityElement(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                

                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]] = counts[nums[i]] + 1;

                }
                else
                {
                    counts.Add(nums[i], 1);
                }

                if (counts[nums[i]] > nums.Length / 2)
                    return nums[i];
            }

            return 0;
        }

        /// <summary>
        /// 217. Contains Duplicate
        /// </summary>
        /// https://leetcode.com/problems/contains-duplicate/description/
        public bool ContainsDuplicate(int[] nums)
        {
            var counts = new HashSet<int>();
            foreach (var num in nums)
            {
                if (counts.Contains(num))
                {
                    return true;
                }
                else
                {
                    counts.Add(num);
                }
            }
            return false;
        }

        /// <summary>
        /// 69. Sqrt(x)
        /// </summary>
        /// https://leetcode.com/problems/sqrtx/description/
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            int left = 1, right = x, ans = 0;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (mid <= x / mid)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans;
        }
        
        /// <summary>
        /// 1480. Running Sum of 1d Array
        /// </summary>
        /// https://leetcode.com/problems/running-sum-of-1d-array/
        public int[] RunningSum(int[] nums) {
        for (var i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }

            return nums;
    }

    }
}
