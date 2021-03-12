using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace exercise
{
    class Ex2
    {
        public static void ex2()
        {
           Regex re = new Regex(@"[c]",RegexOptions.IgnoreCase);
           
           String[] names = {"aaa", "bbb", "ccc", "Mary", "Tom"};
           
           String longestName = "";
           List<String> namesContainsC = new List<String>();

           foreach(var s in names)
           {
               if (s.Length > longestName.Length)longestName = s;
               var a = re.IsMatch(s);
               if(a)namesContainsC.Add(s);               
           }

           Console.WriteLine($"The Longest name is: {longestName}.");
           Console.WriteLine($"There are {namesContainsC.Count} names with alphabet c.");
        }

    }
}
