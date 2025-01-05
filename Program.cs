using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };

            // Length
            Console.WriteLine("Length: {0}" ,nums.Length);

            // IndexOf()
            var idx = Array.IndexOf(nums, 3);
            Console.WriteLine("Index of 3: {0}", idx);

            // Clear()
            Array.Clear(nums, 0, 1);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            // Copy()
            int[] another = new int[3];

            Array.Copy(nums, another, another.Length);

            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            // Sort()
            Array.Sort(another);

            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            // Reverse()
            Array.Reverse(another); 
        }
    }
}
