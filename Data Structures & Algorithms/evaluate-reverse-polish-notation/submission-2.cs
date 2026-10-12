public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens.Length == 0) return 0;

        Stack<int> stack = new();

        foreach (string current in tokens) {
            if (current == "+" || current == "-" ||
                current == "*" || current == "/") {

                int right = stack.Pop();
                int left = stack.Pop();

                int res = current switch {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    _ => 0
                };

                stack.Push(res);
            }
            else {
                stack.Push(int.Parse(current));
            }
        }

        return stack.Pop();
    }
}
