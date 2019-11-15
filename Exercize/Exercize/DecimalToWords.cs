using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize
{
    public class DecimalToWords
    {
        public static string GetWords(decimal num)
        {
            string result = "";

            string number;

            string[] one = {"zero", "one ", "two ", "three ", "four ",
                       "five ", "six ", "seven ", "eight ",
                       "nine ", "ten ", "eleven ", "twelve ",
                       "thirteen ", "fourteen ", "fifteen ",
                       "sixteen ", "seventeen ", "eighteen ",
                       "nineteen "};

            string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                       "fifty ", "sixty ", "seventy ", "eighty ",
                       "ninety ","hundred"};


            int p1 = 0;

            int p2 = 0;

            number = num.ToString();
            #region Creating of WordNumber
            if (number.Contains('.'))
            {
                string[] parts = number.Split('.');
                p1 = int.Parse(parts[0]);
                p2 = int.Parse(parts[1]);
            }
            else
                p1 = Convert.ToInt32(num);
            if (p1 > 100 || p2 > 100)
            {
                return result = "your number too big";
            }

            if (p1 >= 0 && p1 <= 19 && p2 == 0)
            {
                return result = one[Convert.ToInt16(num)];
            }
            else if (p1 > 19 && p2 == 0)
            {
                return result += ten[p1 / 10] + one[p1 % 10];
            }
            else if (p1 == 0 && p2 <= 19)
            {
                if (p2 == 10)
                {
                    return result += ten[p1 / 10] + one[p1 % 10] + " point " + one[p2 / 10];
                }
                return result += one[p1] + " point " + one[p2];
            }
            else if (p1 == 0 && p2 > 19)
            {
                return result += one[p1] + " point " + ten[p2 / 10] + one[p2 % 10];
            }
            else if (p1 <= 19 && p2 <= 19)
            {
                if (p2 == 10)
                {
                    return result += one[p1] + " point " + one[p2];
                }
                return result += one[p1] + " point " + one[p2];
            }
            else if (p1 <= 19 && p2 > 19)
            {
                if (p2 == 100)
                {
                    return result += one[p1] + " point " + one[p2 / 10000];
                }
                return result += one[p1] + " point " + ten[p2 / 10] + one[p2 % 10];
            }
            else if (p1 > 19 && p2 <= 19)
            {
                if (p2 == 10)
                {
                    return result += ten[p1 / 10] + one[p1 % 10] + " point " + one[p2 / 10];
                }
                return result += ten[p1 / 10] + one[p1 % 10] + " point " + one[p2];
            }
            else if (p1 > 19 && p2 > 19)
            {
                if (p2 == 100)
                {
                    return result += ten[p1 / 10] + one[p1 % 10] + " point " + one[p2 / 100];
                }
                else
                    return result += ten[p1 / 10] + one[p1 % 10] + " point " + ten[p2 / 10] + one[p2 % 10];
            }
            #endregion
            return result;
        }

    }
}
