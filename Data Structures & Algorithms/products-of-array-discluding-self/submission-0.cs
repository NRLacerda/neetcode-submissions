public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            int product = 1; // the default for product is always 1, for sum is zero.

            for(int j = 0; j < nums.Length; j++)
            {
                
                if(j == i) continue;

                product *= nums[j];
            }

            output[i] = product;
        }

        return output;
    }
}
