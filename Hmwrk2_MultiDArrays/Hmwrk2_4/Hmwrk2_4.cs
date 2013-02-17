using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hmwrk2_4
  {
     static void Main()
      {
          /* Console.WriteLine("Enter a value for N:");
           Console.WriteLine("Enter a value for K:");

           int n = int.Parse(Console.ReadLine());
           int k = int.Parse(Console.ReadLine());
           int[] myArr = new int[n]; 
           int n = 8;*/


         int k = -5;

         int[] myArr = {2,4,6,8,12,14,17,20};
         Array.Sort(myArr);

         int index = Array.BinarySearch(myArr, k);


         if (index < -1)
	        {
	            Console.WriteLine("The biggest number that is smaller than or equal to {0} is {1}", k, myArr[~index - 1]);
	        }
	     else if (~index == 0)
	        {
	            Console.WriteLine("All the numbers in the array are bigger than {0}", k);
	        }
	     else 
	        {
                Console.WriteLine("The biggest number that is smaller than or equal to {0} is {1}", k, myArr[index]);
        }
         Console.WriteLine();
      }
}

