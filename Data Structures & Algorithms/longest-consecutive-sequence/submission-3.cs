public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new();
        List<int> cands = [];
        int res = 0;

        for (int i = 0; i < nums.Length; i++) 
            set.Add(nums[i]);
        
        for (int i = 0; i < nums.Length; i++)
            if(!set.Contains(nums[i] - 1)){
                cands.Add(nums[i]);
            }
        
        for (int i = 0; i < cands.Count; i++) {
            int current = cands[i];
            int length = 1;
            while(set.Contains(current + 1)){
                current++;
                length++;
            }
            res = Math.Max(res, length);
        }
        return res;
    }
}
