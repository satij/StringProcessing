using System;
using System.Linq;
using System.Text;

namespace StringProcessing
{
    public class StringProcess
    {
        public static void uniqueCharacters()
        {
            Console.WriteLine("Please input string ");
            var input = Console.ReadLine();
            bool res = true;
            if (input != null)
            {
                res = isstringUnique(input);
                if (res)
                {
                    Console.WriteLine("All characters are unique");
                }
                else
                {
                    Console.WriteLine("Characters repeated");
                }
            }
            Console.ReadLine();
        }

        public static bool isstringUnique(string str)
        {
            for (int i = 0; i < str.Count(); i++)
            {
                for (int j = i + 1; j < str.Count(); j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Permutation()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            bool res = true;
            res = checkPermutation(str1, str2);
            if (res)
            {
                Console.WriteLine(str2 + " is permutation of " + str1);
            }
            else
            {
                Console.WriteLine(str2 + " is not permutation of " + str1);
            }
            Console.ReadLine();
        }
        public static bool checkPermutation(string str1, string str2)
        {
            if (str1.Count() != str2.Count())
            {
                return false;
            }
            else
            {
                char[] a = str1.ToArray();
                char[] b = str2.ToArray();
                Array.Sort(a);
                Array.Sort(b);
                int n = Math.Max(a.Count(), b.Count());
                for (int i = 0; i < n; i++)
                    if (a[i] != b[i])
                    {
                        return false;
                    }
            }
            return true;
        }

        public static void Replace()
        {
            Console.WriteLine("Enter a line");
            string input = Console.ReadLine();
            string res = stringReplace(input);
            Console.WriteLine(input + " is converted to " + res);
            Console.ReadLine();
        }
        public static string stringReplace(string str)
        {
            string newStr = str;
            int n = str.Count();
            int st = 0;

            foreach (var item in newStr)
            {
                st = newStr.IndexOf(" ");
                if (st >= 0)
                {
                    newStr = newStr.Remove(st, 1);
                    newStr = newStr.Insert(st, "%20");
                }
            }
            return newStr;
        }
        public static void stringOperation()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            bool res = modifyString(str1, str2);
            if (res)
            {
                Console.WriteLine(str1 + " and " + str2 + " is one edit away ");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " is more than one edit away ");
            }
            
            Console.ReadLine();
        }
        public static bool modifyString(string str1, string str2)
        {
            if (str1.Equals(str2))
                return false;

            int cnt1 = str1.Count();
            int cnt2 = str2.Count();
            if ((cnt1 - cnt2) > 1 || (cnt2 - cnt1) > 1)
            {
                return false;
            }
            int i = 0, j = 0;
            int diff = 0;
            while (i < cnt1 && j < cnt2)
            {
                char f = str1[i];
                char s = str2[j];
                if (f == s)
                {
                    i++; j++;
                }
                else
                {
                    diff++;
                    if (cnt1 > cnt2)
                        i++;
                    if (cnt2 > cnt1)
                        j++;
                    if (cnt1 == cnt2)
                        i++; j++;
                }
                if (diff > 1)
                {
                    return false;
                }
            }
            if (diff == 1 && cnt1 != cnt2 && (i != cnt1 || j != cnt2))
            {
                return false;
            }
            return true;
        }
    }
}
