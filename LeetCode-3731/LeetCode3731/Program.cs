using System.Globalization;

namespace LeetCode3731;

public class Solutions
{
    public IList<int> FindMissingElements(int[] nums) //nums = 1,4,2,5
    {
        int min = nums[0];
        int max = nums[0];

        IList<int> result = new List<int>();

        foreach (int num in nums)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("min = {0} max = {1}", min, max);

        for (int i = min; i <= max; i++)
        {
            int iteration = 1;
            foreach (var num in nums)
            {
                if (num == i)
                {
                    break;
                }

                if (iteration == nums.Length)
                {
                    result.Add(i);
                }

                iteration = iteration + 1;
            }
        }

        if (result == null)
        {
            return null;
        }
        else

            return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solutions solutions = new Solutions();
        int[] inputs = { 1, 6, 3 };
        var results = solutions.FindMissingElements(inputs);

        // Print the results
        Console.WriteLine("Missing elements:");
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
}
