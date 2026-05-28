public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(frequencyMap.ContainsKey(nums[i]))
            {
               frequencyMap[nums[i]]++;
            }
            else
            {
                frequencyMap[nums[i]] = 1;
            }
        }


        return frequencyMap
        .OrderByDescending(x => x.Value)
        .Take(k)
        .Select(item => item.Key)
        .ToArray();
    }
}
