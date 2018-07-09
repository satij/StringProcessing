using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing.Data
{
    public class StringProcess
    {
        public static void uniqueCharacters()
        {
            Console.WriteLine("Please input string ");
            var input = Console.ReadLine();
            bool res=true;
            if (input != null)
            {
                for (int i = 0; i < input.Count(); i++)
                {
                    for (int j = i + 1; j < input.Count(); j++)
                    {
                        if (input[i] == input[j])
                        {
                            res= false;
                        }
                    }
                }
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
    }
}
