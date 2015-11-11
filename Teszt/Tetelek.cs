using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Tetelek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ez egy teszt program! Árvíztűrő tükörfúrógép");
            Console.ReadLine();
        }

        public int osszeg;
        public void osszegzes(int[] A, int osszeg)
        {
            osszeg = 0;
            for (int i = 0; i<A.Length;i++)
            {
                osszeg += A[i];
            }
        }

        public int darab;
        public void megszamlalas(int[] A, int szam, int darab)
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

        public int max;
        public void maxkiv(int[] A, int max)
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

        public int min;
        public void minkiv(int[] A, int min)
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

        public bool igaz;
        public void eldontes(int[] A, int feltetel, bool igaz)
        {
            igaz = false;
            int i = 0;
            while (i<=A.Length && A[i] != feltetel)
            {
                i++;
            }
            if (i<A.Length)
            {
                igaz = true;
            }
        }

        public int sorszam;
        public void kivalasztas(int[] A, int feltetel, int sorszam)
        {
            sorszam = 0;
            int i = 0;
            while (i<=A.Length && feltetel != A[i])
            {
                i++;
            }
        }
    }
}
