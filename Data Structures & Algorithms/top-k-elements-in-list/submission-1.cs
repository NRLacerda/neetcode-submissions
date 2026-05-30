public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(frequencyMap.ContainsKey(num)) frequencyMap[num]++;
            else{
                frequencyMap[num] = 1;
            }
        }

        return frequencyMap
        .OrderByDescending(d => d.Value)
        .Take(k)
        .Select(c => c.Key)
        .ToArray();
    }
}
