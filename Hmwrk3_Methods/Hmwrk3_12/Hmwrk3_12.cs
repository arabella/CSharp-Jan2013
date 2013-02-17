using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Extend the program to support also subtraction and multiplication of polynomials.(see Hmwrk3_11)

class Hmwrk3_12
{
    static int lenght = 0;
    static int[] polyCoeff = new int[lenght];
    static int[] firstP = EnterPolynomial();
    static int[] secondP = EnterPolynomial();

    static int[] EnterPolynomial()
    {
        Console.WriteLine("Enter the lenght of your polynomial:");
        lenght = int.Parse(Console.ReadLine());
        polyCoeff = new int[lenght];

        for (int i = lenght - 1; i >= 0; i--)
        {
            Console.Write("x^{0} =  ", i);
            polyCoeff[i] = int.Parse(Console.ReadLine());
        }
        return polyCoeff;
    }
    static int[] Print(int[] polyCoeff)
    {
        for (int i = polyCoeff.Length - 1; i >= 0; i--)
        {
            if (polyCoeff[i] == 0)
            {
                continue;
            }
            if (i == 0)
            {
                Console.Write(polyCoeff[i]);
            }
            else if (i == 1)
            {
                Console.Write("{0} * x", polyCoeff[i]);
            }
            else
            {
                Console.Write("{0} * x^{1}", polyCoeff[i], i);
            }
            if (i > 0)
            {
                Console.Write(" + ");
            }
            
        }
        return polyCoeff;
    }

    static int[] Subtract(int[] polyCoeff)
    {
        int minLength = Math.Min(firstP.Length, secondP.Length);
        int maxLength = Math.Max(firstP.Length, secondP.Length);
        int[] result = new int[maxLength];

        for (int i = maxLength - 1; i >= 0; i--)
        {
            if (i < minLength)
            {
                result[i] = firstP[i] - secondP[i];
            }
            else if (i > firstP.Length - 1)
            {
                result[i] = -secondP[i];
            }
            else if (i > secondP.Length - 1)
            {
                result[i] = firstP[i];
            }
            Console.WriteLine();
        }
        return result;
    }
    static int[] MultiplyP(int[] polyCoeff)
    {
        int[] result = new int[firstP.Length + secondP.Length - 1];

        for (int i = 0; i < firstP.Length; i++)
        {
            for (int j = 0; j < secondP.Length; j++)
            {
                result[i + j] += firstP[i] * secondP[j];  
            }
            Console.WriteLine();
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("First polynomial is :");
        Print(firstP);
        Console.WriteLine();
        Console.WriteLine("Second polynomial is: ");
        Print(secondP);
        Console.WriteLine();
        Console.WriteLine("Subtraction of your polynomials equals: ");
        Print(Subtract(polyCoeff));
        Console.WriteLine();
        Console.WriteLine("The product of your polynomials equals:");
        Print(MultiplyP(polyCoeff));
        Console.WriteLine();
    }
}