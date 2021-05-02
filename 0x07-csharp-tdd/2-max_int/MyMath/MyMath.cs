using System;

namespace MyMath
{
    /// <summary> Public class. </summary>
    public class Operations
    {
        /// <summary> Prototype. </summary>
        /// <param name="nums"> List of nums. </param>
        /// <returns> Max integer in list. </returns>
        public static int Max(List<int> nums)
        {
            int max = 0;

            if (nums == null)
            {
                return (0);
            }
            nums.sort();

            foreach (int i in nums)
            {
                max = i;
            }
            return (max);
        }
    }
}
