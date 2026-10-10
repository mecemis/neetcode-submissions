public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        int[] res = new int[2];
        
        for (int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) 
        {
            if(dict.ContainsKey(target - nums[i])){
                if (i != dict[target - nums[i]]) {
                    res[0] = i;
                    res[1] = dict[target - nums[i]];
                    break;
                }
            }
        }
        return res;
    }
}
