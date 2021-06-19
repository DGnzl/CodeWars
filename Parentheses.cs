using System.Collections.Generic;
public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in input) {
            if (c == '(') {
                stack.Push(c);
            }
            else if (c == ')') {
                if (stack.Count > 0) {
                    stack.Pop();
                }
                else {
                    return false;
                }
            }
        }
        return (stack.Count == 0);
    }
}