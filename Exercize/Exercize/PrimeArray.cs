using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize
{
    public class PrimeArray
    {
        public static List<int> GetListOfIntegers(int[] arr, int maxNumber)
        {

            List<int> primeNumbers = new List<int>();
            foreach (int num in arr)
            {
                if (!(num > maxNumber))
                {
                    int flag = 0;

                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        primeNumbers.Add(num);
                }
            }
            return primeNumbers;
        }
    }
}

