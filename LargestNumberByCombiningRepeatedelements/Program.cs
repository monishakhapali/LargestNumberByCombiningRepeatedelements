using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNumberByCombiningRepeatedelements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //List<int> arr = new List<int> { 1,2,3 };
            //Console.WriteLine(LargestNumberInArray(arr));
            int[] arr = { 1,1,2,4,7,8};
            int n = arr.Length;

            // Function Calling 
            Console.Write(largest_sum(arr, n));
            Console.ReadLine();
           
            
        }
        static int largest_sum(int[] arr, int n)
        {
            // Variable to store the largest sum 
            int maximum = -1;

            // Map to store the frequencies 
            // of each element 
            Dictionary<int, int> m = new Dictionary<int, int>();

            for(int i=0;i<n;i++)
            {
                if(m.ContainsKey(arr[i]))
                {
                    m[arr[i]]++;
                }
                else
                {
                    m.Add(arr[i], 1);
                }
            }
            for(int i=0;i<n;i++)
            {
                if(m[arr[i]] > 1)
                {
                    if(m.ContainsKey(2* arr[i]))
                    {
                        m[2 * arr[i]] = m[2 * arr[i]] + m[arr[i]] / 2;
                    }
                    else
                    {
                        m.Add(2 * arr[i], m[arr[i]] / 2);
                    }
                }
                if(maximum < 2 * arr[i])
                {
                    maximum = 2 * arr[i];
                }
            }

            

            // Returns the largest sum 
            return maximum;
        }

        //public static int LargestNumberInArray(List<int> arr)
        //{
        //    HashSet<int> hashset = new HashSet<int>();
        //    int res =-1;
        //    if (!(arr.GroupBy(x => x).Any(g => g.Count() > 1)))
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        int i = 0;
        //        while(i < arr.Count) 
        //        {
        //            arr.Sort();
        //            if (!(hashset.Contains(arr[i])))
        //            {
        //                hashset.Add(arr[i]);
        //            }
        //            else
        //            {
        //                int sum = arr[i] + arr[i];
        //                arr = arr.Where(e => e != arr[i]).ToList();
        //                arr.Add(sum);
        //                hashset.Clear();

        //                i = 0;
        //                continue;
        //            }
        //            i++;
        //        }
        //        if(arr.Count ==2)
        //        {
        //            res =Math.Max(arr[0], arr[1]);
        //        }   
        //    }
        //    return res;
        //}
    }
}
