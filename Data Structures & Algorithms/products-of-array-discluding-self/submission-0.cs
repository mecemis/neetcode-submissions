public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] res = new int[nums.Length];

        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;
        
        for (int i = 1, j = nums.Length - 2; i < nums.Length; i++, j--) {
            prefix[i] = prefix[i - 1] * nums[i - 1];
            suffix[j] = suffix[j + 1] * nums[j + 1];
        }

        for (int i = 0; i < nums.Length; i++) {
            res[i] = prefix[i] * suffix[i];
        }

        return res;
    }
}
