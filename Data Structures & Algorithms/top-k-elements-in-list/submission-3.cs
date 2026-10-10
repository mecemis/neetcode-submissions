public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> res = new();
        List<int>[] bucket = new List<int>[nums.Length + 1];
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++) {
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }else{
                dict[nums[i]] = 1;
            }
        }
        
        foreach (var item in dict)
        {
            if (bucket[item.Value] == null) {
                bucket[item.Value] = new List<int>();
            }
            bucket[item.Value].Add(item.Key);
        }

        for (int i = bucket.Length - 1; i > 0; i--)
        {
            if(bucket[i] == null) continue;
            foreach (var num in bucket[i]) {
                res.Add(num);
                if(res.Count == k) return res.ToArray();
            }
        }
        return res.ToArray();
    }
}