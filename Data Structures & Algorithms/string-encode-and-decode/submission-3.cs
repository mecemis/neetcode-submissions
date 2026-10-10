public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        for (int i = 0; i < strs.Count; i++) {
            sb.Append($"{strs[i].Length}#{strs[i]}");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = [];
        int i = 0;
        while(i < s.Length){
            string cnt = "";
            string tmp = "";
            while(s[i] != '#'){
                cnt += s[i];
                i++;
            }
            i++;
            int length = i + int.Parse(cnt);
            while(i < length){
                tmp += s[i];
                i++;
            }
            res.Add(tmp);
        }
        return res;
   }
}
