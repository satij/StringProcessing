using System;

namespace StringProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Please Select Operation To Perform:", "1. Check unique characters", "2. Check if 2 strings are permutation of each other", "3. Replace all spaces in string with %20", "4. Check if strings are 1 or 0 edits away" };
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
            string str = Console.ReadLine();
            if (str == "1")
            {
                StringProcess.uniqueCharacters();
            }
            if (str == "2")
            {
                StringProcess.Permutation();
            }
            if (str == "3")
            {
                StringProcess.Replace();
            }
            if (str == "4")
            {
                StringProcess.stringOperation();
            }
            else
            {
                Console.WriteLine("Please select from above");
                Main(args);
            }
            
            
        }

    }
}
