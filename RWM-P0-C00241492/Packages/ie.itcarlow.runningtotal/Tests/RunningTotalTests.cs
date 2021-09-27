using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class RunningTotalTest
    {
        [Test]
        public void RunningTotalSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = RunningTotal.RunningTotalResults(input);
            int[] expected = { 4, 6, 14, 17, 26, 30, 40, 45, 56, 62 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
