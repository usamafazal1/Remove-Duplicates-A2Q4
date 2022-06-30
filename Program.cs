using System;
using System.Linq;
namespace A2Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 3, 4, 5, 6, 6, 6, 7 };
            //Print initial
            Console.WriteLine("The initial array is: ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(" " + s[i]);
            }
            
            //for gap
            Console.WriteLine("\n\n");

            //print final array using Distinct().ToArray() command which we are able to use because of System.Linq
            int[] q = s.Distinct().ToArray();
            Console.WriteLine("The final array is: ");
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(" " + q[i]);
            }
        }
    }
}
