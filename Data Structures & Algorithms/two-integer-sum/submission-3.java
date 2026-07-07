class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> seen = new HashMap<Integer, Integer>();

        for(int i = 0; i < nums.length; i++){
            int needs = target - nums[i];
            if(seen.containsKey(needs)) return new int[]{seen.get(needs), i};

            seen.put(nums[i], i);
        }

        return new int[]{0,0};
    }
}
