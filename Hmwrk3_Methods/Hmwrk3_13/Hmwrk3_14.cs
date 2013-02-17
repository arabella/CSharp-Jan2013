using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.


class Hmwrk3_14
{
   
    static int MinSet(params int[] integerSet)
    {
        int minimum = integerSet[0];
        for (int i = 0; i < integerSet.Length; i++)
        {
            if (minimum > integerSet[i])
            {
                minimum = integerSet[i];
            }
        }
        return minimum;
    }

    static int MaxSet(params int[] integerSet)
    {
        int maximum = integerSet[0];
        for (int i = 1; i < integerSet.Length; i++)
        {
            if (maximum < integerSet[i])
            {
                maximum = integerSet[i];  
            }
        }
        return maximum;
    }

    static int Sum(params int[] integerSet)
    {
        int sum = integerSet[0];
        for (int i = 1; i < integerSet.Length; i++)
        {  
               sum += integerSet[i];
        }
        return sum;
    }
    static double AvgSet(params int[] integerSet)
    {
        int average, sum = integerSet[0];
        for (int i = 0; i < integerSet.Length; i++)
        {
           sum += integerSet[i];
        }
        average = sum / integerSet.Length;
        return average;
    }

    static int Product(params int[] integerSet)
    {
        int product = integerSet[0];
        for (int i = 1; i < integerSet.Length; i++)
        {
            product *= integerSet[i];
        }
        return product;
    }
    static void Main()
    {
        
        Console.WriteLine("The minimum of this set of integers is {0}", MinSet(2, 6, 6, 1, 0));
        Console.WriteLine("The maximum of this set of integers is {0}", MaxSet(5, 7, -9, 235));
        Console.WriteLine("The average of this set of integers is {0}", AvgSet(1, 4, 23, 78, 98,234));
        Console.WriteLine("The sum of this set of integers is {0}", Sum(1, 4, 23, 78, 98, 234));
        Console.WriteLine("The product of this set of integers is {0}", Product(34, 2, -13, 65, 100, 23));
        Console.WriteLine();
    }
}

