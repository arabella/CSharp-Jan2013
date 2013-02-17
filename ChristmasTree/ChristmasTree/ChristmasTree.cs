using System;
class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0  ; row < n-1; row++)
            {
                int dots = n - row - 2;
                int asterisk = 2*row + 1;

                Console.Write(new string('.', dots));
                Console.Write(new string('*', asterisk));
                Console.Write(new string('.', dots)); 

                Console.WriteLine();
                }
            string bottom = new string('.', (n - 2)) + "*" + new string('.', (n - 2));
            Console.WriteLine(bottom);
                
            }
        }
    
