using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez egy teszt program! Árvíztűrő tükörfúrógép");
            Console.ReadLine();
        }

        static int osszeg;
        static void osszegzes(int[] A, int osszeg)
        {
            osszeg = 0;
            for (int i = 0; i<A.Length;i++)
            {
                osszeg += A[i];
            }
        }

        static int darab;
        static void megszamlalas(int[] A, int szam, int darab)
        {
            darab = 0;
            for (int i = 0; i<A.Length; i++)
            {
                if (A[i] == szam)
                {
                    darab++;
                }
            }
        }

        static int max;
        static void maxkiv(int[] A, int max)
        {
            max = A[0];
            for (int i = 0; i<A.Length;i++)
            {
                if (max<A[i])
                {
                    max = A[i];
                }
            }
        }

        static int min;
        static void minkiv(int[] A, int min)
        {
            min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                }
            }
        }
    }
}
