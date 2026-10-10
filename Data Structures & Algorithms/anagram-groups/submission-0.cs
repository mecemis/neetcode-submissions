public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    List<List<string>> res = new();
    Dictionary<string, List<string>> dict = new();

    for (int i = 0; i < strs.Length; i++) {
        char[] chars = strs[i].ToCharArray();
        Array.Sort(chars);
        string sortedStr = new string(chars);
        if (dict.ContainsKey(sortedStr))
        {
            dict[sortedStr].Add(strs[i]);
        }
        else
        {
            dict[sortedStr] = new List<string>(){strs[i]};
        }
    }
    res.AddRange(dict.Values);
    return res;
}
}
