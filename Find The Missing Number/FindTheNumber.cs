using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Exercises.Find_The_Missing_Number
{
    public class FindTheNumber
    {
        [Fact]
        public void Missing_number_in_sequence()
        {
            // Example 1: The missing number is 5
            var input = new int[] { 1, 2, 4, 6, 3, 7, 8 };
            var expected = 5;
            Assert.Equal(expected, MissingNumber.Find(input));
        }

        [Fact]
        public void Missing_number_at_start()
        {
            // Example 2: The missing number is 1
            var input = new int[] { 2, 3, 4, 5, 6 };
            var expected = 1;
            Assert.Equal(expected, MissingNumber.Find(input));
        }

        [Fact]
        public void Missing_number_at_end()
        {
            // Example 3: The missing number is 6
            var input = new int[] { 1, 2, 3, 4, 5 };
            var expected = 6;
            Assert.Equal(expected, MissingNumber.Find(input));
        }

        [Fact]
        public void Array_with_one_element()
        {
            // Example 4: The missing number is 2
            var input = new int[] { 1 };
            var expected = 2;
            Assert.Equal(expected, MissingNumber.Find(input));
        }

        [Fact]
        public void All_numbers_present()
        {
            // Example 5: There is no missing number, function should return -1 or handle error
            var input = new int[] { 1, 2, 3, 4, 5 };
            var expected = -1;  // Indicating no missing number in this example
            Assert.Equal(expected, MissingNumber.Find(input));
        }

        [Fact]
        public void Missing_number_in_large_range()
        {
            // Example 6: Test with a large array
            var input = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            var expected = 4;
            Assert.Equal(expected, MissingNumber.Find(input));
        }
    }

    public static class MissingNumber
    {
        public static int Find(int[] numbers)
        {
            // Get previousValue
            int previousVal = 0;

            // Get Length
            int length = numbers.Length;

            if (length == 0) {
                // No numbers to compare
                return -1;
            }

            // Do for loop
            for (int i = 0; i < length; i++) {
                // Get current number in array
                var getNumber = numbers[i];

                // Check if the current number is not the previous value + 1
                if ( getNumber != previousVal + 1) { 
                    // Missing number is previousVal + 1
                    return previousVal +1;
                }

                // Update previousVal for the next iteration
                previousVal = getNumber;
            
            }

            // If no missing number was found, return -1 
            return -1;
        }
    }
}
