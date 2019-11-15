using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercize
{
   public class FindName
    {
        public static string GetRightName(string randomNames, string lookingForName, string lookingForFirstName)
        {
            string names = "";
            string[] namesList = randomNames.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var n in namesList)
            {
                if (Regex.IsMatch(n, lookingForName, System.Text.RegularExpressions.RegexOptions.IgnoreCase) || Regex.IsMatch(n, lookingForFirstName, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    names += n + "\r\n";
                }
            }
                       
            return names;
        }


    }
}
