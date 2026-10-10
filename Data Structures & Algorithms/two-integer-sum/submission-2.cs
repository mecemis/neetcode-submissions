public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        
        for (int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) 
        {
            if(dict.ContainsKey(target - nums[i])){
                if (i != dict[target - nums[i]]) {
                    return new int[]{i, dict[target - nums[i]]};
                }
            }
        }
        return new int[]{};
    }
}
