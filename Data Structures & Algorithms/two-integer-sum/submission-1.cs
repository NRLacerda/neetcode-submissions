public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int needs = target - nums[i];

            if(seen.ContainsKey(needs)) return [seen[needs], i];

            seen.Add(nums[i], i);
        }

        return [0, 0];
    }
}
