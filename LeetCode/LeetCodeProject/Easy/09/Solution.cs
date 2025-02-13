using System;

/* 9. Palindrome Number
link - https://leetcode.com/problems/palindrome-number/description/

Given an integer x, return true if x is a palindrome, and false otherwise.
*/

public class Solution_09_1
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int num = x;
        int revNum = 0;
        while (x > 0)
        {
            int remainder = x % 10;
            revNum = revNum * 10 + remainder;
            x /= 10;
        }
        if (num == revNum)
        {
            return true;
        }
        return false;
    }
}

public class Solution_09_2
{
    public bool IsPalindrome(int x)
    {
        string num = Convert.ToString(x);
        char[] revNum = new char[num.Length];
        for (int i = 0; i < revNum.Length ; i++)
        {
            revNum[i] = num[revNum.Length - 1 - i];
        }
        if (new string(revNum) == num)
        {
            return true;
        }
        return false;
    }
}
