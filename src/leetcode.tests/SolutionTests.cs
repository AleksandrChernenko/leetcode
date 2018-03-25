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
    }
}
