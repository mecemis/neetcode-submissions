public class Solution {

    public string Encode(IList<string> strs) {
        return strs.Count == 0 ? null : string.Join("~", strs);
    }

    public List<string> Decode(string s) {
        return s == null ? [] : s.Split("~").ToList();
   }
}
