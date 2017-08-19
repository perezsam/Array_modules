using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo01_test01
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int numeroAProbar = -49;
            bool isPrimeTest = isPrime(numeroAProbar);

            Console.WriteLine("---------------");
            Console.WriteLine("Module reduction");

            int[] f = new int[] { 7, 5, 9, 11 };
            int m = 3;

            PrintArray(f, "f");
            
            int[] g = reduceModule(f, m);
            PrintArray(g, "f mod 3");

            Console.WriteLine("---------------");

            Console.WriteLine("---------------");
            Console.WriteLine("Vector sum");

            int[] a = new int[] {3, 8, 9, 5, 6};
            PrintArray(a, "a");

            int[] b = new int[] {5, 2, 8, 7, 4};
            PrintArray(b, "b");

            int[] c = sum(a,b);

            PrintArray(c, "Sum(a,b)");





            Console.WriteLine("---------------");

            Console.WriteLine("---------------");
            Console.WriteLine("Dot multiplication");

            int[] x = new int[] { 9, 8, 7, 3, 4, 3, 2 };
            PrintArray(x, "x");

            int[] y = new int[] { 5, 5, 4, 2, 8, 7, 4 };
            PrintArray(y, "y");

            int[] z = dotMult(x, y);
            PrintArray(z, "dotMult(x, y)");

            Console.WriteLine("---------------");

            Console.ReadLine();

        }




        /// <summary>
        /// Given an integer, finds out if it is a prime or not.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool isPrime(int n)
        {
            // Special case
            if (n <= 1)
                return false;

            //Find all the possible divisors
            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }

                    
            }
            return true;
        }


        /// <summary>
        /// Given a matrix of integers apply a given module and return the reduced array
        /// </summary>
        /// <param name="f"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int[] reduceModule(int[]f, int m)
        {
            int sizeOf_f = f.Length;
            int[] g = new int[sizeOf_f];

            for (int i = 0; i < sizeOf_f; i++)
            {
                g[i] = f[i] % m;
            }
                
            return g;
        }


        /// <summary>
        /// Perform the sum of two given arrays
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] sum(int[]a, int[] b)
        {
            int sizeOf_a = a.Length;
            int[] total = new int[sizeOf_a];

            for (int i = 0; i < sizeOf_a; i++)
            {
                total[i] = a[i] + b[i];
            }

            return total;
        }


        /// <summary>
        /// Dot Multiplication of two given matrices
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] dotMult(int[] a, int[] b)
        {
            int sizeOf_a = a.Length;
            int[] product = new int[sizeOf_a];

            for (int i = 0; i < sizeOf_a; i++)
            {
                product[i] = a[i] * b[i];
            }

            return product;
        }


        /// <summary>
        /// Prints the values of an array to console
        /// </summary>
        /// <param name="f"></param>
        /// <param name="name"></param>
        public static void PrintArray(int[] f, string name)
        {
            Console.Write(name + "=[");
            int sizeOf_f = f.Length; 

            for (int i = 0; i < sizeOf_f; i++)
            {
                Console.Write(f[i]);

                if (i < sizeOf_f - 1)
                {
                    Console.Write(", ");
                }
                    
            }

            //Console.Write("]");

            Console.WriteLine("]");
        }


    }
}
