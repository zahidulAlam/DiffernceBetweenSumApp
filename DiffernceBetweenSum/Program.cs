using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffernceBetweenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquare = 0,  square ;
            for ( int i=1; i<=100; i++)
            {
                square = i * i;
                sumOfSquare = square + sumOfSquare;
 
            }
            Console.WriteLine("Sum of squares from 1 to 100 is : " + sumOfSquare);

            int squareOfSum = 0, sum=0;
            for ( int j=1; j<=100; j++)
            {
                sum = sum + j;
                squareOfSum = sum * sum;
            }
            Console.WriteLine("Squares of sum from 1 to 100 is: "+ squareOfSum);
            int difference;
            difference = squareOfSum - sumOfSquare;
            Console.WriteLine("The Difference between \"Squares of sum \" & \"Sum of squares \" is: " + difference );
            
            Console.ReadKey();

        }

    }
}
