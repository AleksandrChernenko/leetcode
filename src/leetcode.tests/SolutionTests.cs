using NUnit.Framework;

namespace leetcode.tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test, TestCaseSource(nameof(NumJewelsInStonesTestCases))]
        public void NumJewelsInStones_InitData_Valid(string jewels, string stones, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.NumJewelsInStones(jewels, stones)));
        }

        private static readonly object[] NumJewelsInStonesTestCases =
        {
            new object[] {"aA", "aAAbbbb", 3},
            new object[] {"z", "ZZ", 0},
        };

        [Test, TestCaseSource(nameof(JudgeCircleTestCases))]
        public void JudgeCircle_InitData_Valid(string moves, bool result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.JudgeCircle(moves)));
        }

        private static readonly object[] JudgeCircleTestCases =
        {
            new object[] {"UD", true},
            new object[] {"LL", false},
            new object[] {"ULDR", true},
            new object[] { "RLUURDDDLU", true},
        };

        [Test, TestCaseSource(nameof(TitleToNumberTestCaseSource))]
        public void TitleToNumber_InitData_Valid(string input, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.TitleToNumber(input)));
        }

        public static object[] TitleToNumberTestCaseSource =
        {
            new object[] {"A", 1},
            new object[] {"B", 2},
            new object[] {"C", 3},
            new object[] {"Z", 26},
            new object[] {"AA", 27},
            new object[] {"AB", 28},
            new object[] {"ZZ", 702},
        };

        [Test, TestCaseSource(nameof(RomanToIntTestCaseSource))]
        public void RomanToInt_InitData_Valid(string s, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.RomanToInt(s)));
        }

        private static readonly object[] RomanToIntTestCaseSource =
        {
            new object[] {"I", 1},
            new object[] {"MM", 2000},
            new object[] { "MMMCMXCIX", 3999}
        };

        [Test, TestCaseSource(nameof(MissingNumberTestCaseSource))]
        public void MissingNumber_InitData_Valid(int[] nums, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.MissingNumber(nums)));
        }

        public static object[] MissingNumberTestCaseSource =
        {
            new object[] {new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1}, 8},
            new object[] {new int[] {0}, 1},
            new object[] {new int[] {1}, 0},
            new object[] {new int[] {1}, 0},
            new object[] {new int[] {0, 1}, 2},
        };

        [Test, TestCaseSource(nameof(MoveZeroesTestCaseSource))]
        public void MoveZeroes_InitData_Valid(int[] nums, int[] result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.MoveZeroes(nums)));
        }

        public static object[] MoveZeroesTestCaseSource =
        {
            new object[] {new[] { 0, 1, 0, 3, 12 }, new[] {1, 3, 12, 0, 0}}
        };

        [Test, TestCaseSource(nameof(MajorityElementTestCases))]
        public void MajorityElement_InitData_Valid(int[] nums, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.MajorityElement(nums)));
        }

        public static object[] MajorityElementTestCases =
        {
            new object[] {new[]{6, 5, 5}, 5},
            new object[] {new[]{1}, 1},
        };

        [Test, TestCaseSource(nameof(MySqrtTestCases))]
        public void MySqrt_InitData_Valid(int x, int result)
        {
            var solution = new Solution();

            Assert.That(result, Is.EqualTo(solution.MySqrt(x)));
        }

        public static object[] MySqrtTestCases =
        {
            new object[] {1, 1},
            new object[] {0, 0},
            new object[] {9, 3},
            new object[] {16, 4},
            new object[] {25, 5},
            new object[] {36, 6},
            new object[] {8, 2},
        };
    }
}
