using System;


namespace Exercize
{
    public class SortedSearch
    {
        public static int CountNumbersLessThan(int[] arr, int num)
        {
            int result=0;
            // sort array in assending order
            int t;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }            
            for (int i = 0; i < arr.Length; i++)
            {
                // if array is biger than my number i wil just take elemeents of the array with index that less than my number
                if (arr[i]<num && i<num )
                {
                    result++;
                }
                
            } 
            return result ;
        }
    }
}