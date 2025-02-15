using System;
using System.Collections.Generic;
using System.Text;

/* 20. Valid Parentheses
link - https://leetcode.com/problems/valid-parentheses/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/

public class Solution_20
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            {'(', ')' },
            {'{', '}' },
            {'[', ']' }
        };
        Stack<char> openingBrackets = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (brackets.ContainsKey(s[i]))
            {
                openingBrackets.Push(s[i]);
            }
            else if (s[i] == brackets[openingBrackets.Peek()])
            {
                openingBrackets.Pop();
            }
            else
            {
                return false;
            }
        }

        return openingBrackets.Count == 0;
    }
}
