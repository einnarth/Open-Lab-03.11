using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            
            string rev = new string(ch);
            
            if (rev == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
