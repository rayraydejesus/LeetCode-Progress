public sealed class Solution_1_Hashmap: ISolution_1
{
	public Solution_1_Hashmap(){}

	public int[] TwoSum(int[] nums, int target)
	{
        if (nums.Length == 2)
            return new int[] { 0, 1 };

        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        hashMap.Add(nums[0], 0);
        int compliment;

        for (int i = 1; i < nums.Length; ++i)
        {
            compliment = target - nums[i];
            if (hashMap.ContainsKey(compliment))
                return new int[] { hashMap[compliment], i };
            else
            {
                if (hashMap.ContainsKey(nums[i]))
                    hashMap[nums[i]] = i;
                else
                    hashMap.Add(nums[i], i);
            }
        }

        return new int[] { -1, -1 };
    }
}


