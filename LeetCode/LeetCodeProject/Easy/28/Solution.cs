using System;
using System.Collections.Generic;
using System.Text;

/* 28. Find the Index of the First Occurrence in a String
link - https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
*/

public class Solution_28_1
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}

public class Solution_28_2
{
    public int StrStr(string haystack, string needle)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                str.Append(haystack[i + j]);
            }
            if (str.ToString() == needle)
            {
                return i;
            }
            str.Clear();
        }
        return -1;
    }
}