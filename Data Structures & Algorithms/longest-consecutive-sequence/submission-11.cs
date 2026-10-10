public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new();
        int res = 0;

        for (int i = 0; i < nums.Length; i++) 
            set.Add(nums[i]);
        
        foreach (var item in set) {
            if (set.Contains(item - 1)) continue;
            int length = 1;
            while(set.Contains(item + length))
                length++;
            
            res = Math.Max(res, length);
        }
        return res;
    }
}
