namespace remove_duplicates_from_sorted_array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int index = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[index++] = nums[i];
                }
            }
            return index;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            
            int newLength = solution.RemoveDuplicates(nums);

            Console.Write("Array after removing duplicates: ");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine($"\nNew length: {newLength}");
        }
    }
}
