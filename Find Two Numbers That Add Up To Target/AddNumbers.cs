using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace C__Exercises.Find_Two_Numbers_That_Add_Up_To_Target
{
    public class FindTwoNumbersTests
    {
        [Fact]
        public void FindTwoNumbersThatAddUpToTarget_Success()
        {
            // Example 1: The two numbers 3 and 7 add up to 10
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var target = 10;
            var expected = new int[] { 3, 7 };
            var result = FindTwoNumbers.Find(input, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindTwoNumbersThatAddUpToTarget_SuccessWithNegativeNumbers()
        {
            // Example 2: The two numbers -3 and 7 add up to 4
            var input = new int[] { -3, 2, 1, 5, 7 };
            var target = 4;
            var expected = new int[] { -3, 7 };
            var result = FindTwoNumbers.Find(input, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void NoTwoNumbersAddUpToTarget()
        {
            // Example 3: No two numbers add up to 20
            var input = new int[] { 1, 2, 3, 4, 5 };
            var target = 20;
            var expected = new int[] { }; // Empty result
            var result = FindTwoNumbers.Find(input, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OnlyOnePairAddsUpToTarget()
        {
            // Example 4: Only one pair (5, 15) adds up to 20
            var input = new int[] { 5, 15, 2, 7 };
            var target = 20;
            var expected = new int[] { 5, 15 };
            var result = FindTwoNumbers.Find(input, target);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MultiplePairsAddingUpToTarget()
        {
            // Example 5: Multiple pairs adding up to target 10
            var input = new int[] { 1, 9, 2, 8, 3, 7, 4, 6 };
            var target = 10;

            // List of all valid pairs
            var validPairs = new List<int[]>
    {
        new int[] { 1, 9 },
        new int[] { 2, 8 },
        new int[] { 3, 7 },
        new int[] { 4, 6 }
    };

            // Call the method to find the pair
            var result = FindTwoNumbers.Find(input, target);

            // Assert that the result is one of the valid pairs
            Assert.Contains(result, pair => validPairs.Any(validPair => validPair.SequenceEqual(pair)));
        }

        [Fact]
        public void EmptyArray()
        {
            // Example 6: Test with an empty array
            var input = new int[] { };
            var target = 10;
            var expected = new int[] { }; // Empty result
            var result = FindTwoNumbers.Find(input, target);
            Assert.Equal(expected, result);
        }
    }

    public static class FindTwoNumbers
    {
        public static int[] Find(int[] numbers, int target)
        {
            // Main logic for finding two numbers that add up to the target
            // Leave the implementation for the person filling in

            // Example placeholder return
            return new int[] { };  // Placeholder to be filled in with actual logic
        }
    }
}
