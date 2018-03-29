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
    }
}
