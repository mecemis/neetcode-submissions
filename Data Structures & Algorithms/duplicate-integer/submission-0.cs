public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> result = new();

        for (int i = 0; i < nums.Length; i++)
            if(!result.Add(nums[i]))
                return true;
        
        return false;
    }
}