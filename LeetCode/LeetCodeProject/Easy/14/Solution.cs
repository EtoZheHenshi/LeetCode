using System;
using System.Collections.Generic;
using System.Text;

/* 14. Longest Common Prefix
link - https://leetcode.com/problems/longest-common-prefix/

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
*/

public class Solution_14
{
    public string LongestCommonPrefix(string[] strs)
    {
        int index = 0;
        StringBuilder pref = new StringBuilder("");
        string firstWord = strs[0];
        bool check = true;
        while (check)
        {
            if (firstWord.Length > index)
            {
                pref.Append(firstWord[index++]);
                foreach (string str in strs)
                {
                    if (!str.StartsWith(pref.ToString()))
                    {
                        pref.Remove(pref.Length - 1, 1);
                        check = false;
                        break;
                    }
                }
            }
            else
            {
                check = false;
            }
        }
        return pref.ToString();
    }
}
