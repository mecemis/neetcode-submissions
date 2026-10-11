public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = [];
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            if(nums[i] > 0)
            break;
            
            if (i > 0 && nums[i] == nums[i - 1])
            continue;

            int target = -nums[i];
            for (int j = i + 1, k = nums.Length - 1; j < k;) {
                int sum = nums[k] + nums[j];
                if(sum < target) j++;
                else if(sum > target) k--;
                else {
                    result.Add([nums[i], nums[j], nums[k]]);

                    while (j < k && nums[j] == nums[j + 1])
                    j++;

                    while (j < k && nums[k] == nums[k - 1])
                    k--;
                    
                    j++;
                    k--;
                }
            }
        }
        return result;
    }
}
