using System;

namespace Zadanie1._3._1
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string s)
        {
            int l = 0;
            int r = s.Length-1;

            while(l<r)
            {
                while (!char.IsLetterOrDigit(s[l]))
                {
                    l++;
                    if (l > r)
                        return false;
                }
                    
                while (!char.IsLetterOrDigit(s[r]))
                    r--;
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                    return false;
                l++;
                r--;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s0 = "e ._= w ,  ,e,";
            string s1 = "";
            string s2 = "Kobyła ma, mały bok.";
            string s3 = "123321";
            string s4 = "        e";
            string s5 = "alalalllallcal";
            string s6 = " rala o alaar  ";
            Console.WriteLine(s0.IsPalindrome());
            Console.WriteLine(s1.IsPalindrome());
            Console.WriteLine(s2.IsPalindrome());
            Console.WriteLine(s3.IsPalindrome());
            Console.WriteLine(s4.IsPalindrome());
            Console.WriteLine(s5.IsPalindrome());
            Console.WriteLine(s6.IsPalindrome());

        }
    }
}
