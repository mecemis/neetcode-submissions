public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        for (int i = 0, j = s.Length - 1; i < j; i++, j--) {
            while (!char.IsLetterOrDigit(s[i]) && i < j) {
                i++;
            }
            while (!char.IsLetterOrDigit(s[j]) && i < j) {
                j--;
            }
            if (s[i] != s[j])
                return false;
        }
        return true;
    }
}
