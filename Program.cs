int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
Console.WriteLine(MissingNumber(nums));


int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        result ^= i;
    }
    foreach (int num in nums)
    {
        result ^= num;
    }
    return result;
}