public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) return false;
        if(s[0] == ')' || s[0] == ']' || s[0] == '}') return false;
        Stack<char> stack = new();

        for (int i = 0; i < s.Length; i++) {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            stack.Push(s[i]);
            else{
            if (stack.Count == 0)
                return false;
                char current = stack.Pop();
                if((current == '(' && s[i] != ')') || 
                (current == '{' && s[i] != '}') || 
                (current == '[' && s[i] != ']')) 
                return false;
            }
        }
        return stack.Count == 0;
    }
}
