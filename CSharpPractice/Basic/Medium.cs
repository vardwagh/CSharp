using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Basic
{
    public class Medium
    {

        //Exercise-92 Next prime number of a given integer
        public int test(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) 
                { 
                    n++; 
                    i = 2; 
                }
            }
            return n;
        }
        //Exercise-91 Remove all the values except integer values from a given array of mixed values
        public int[] test(object[] nums)
        {
            return nums.OfType<int>().ToArray();
        }
    }
}
