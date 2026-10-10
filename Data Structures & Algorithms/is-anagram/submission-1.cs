public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict = s.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        for (int i = 0; i < t.Length; i++)
        {
            if (dict.TryAdd(t[i], 1)) return false;
            dict[t[i]]--;
        }
        if(dict.Values.Any(x => x != 0)) return false;
        return true;
    }
}
