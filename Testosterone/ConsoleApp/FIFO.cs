using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FIFO
    {
        private int[] prvky;
        private int pocet = 0;

        public FIFO()
        { 
            prvky = new int[50];

        }


        public int Count()
        {
            return pocet;
        }

        public void Enqueue(int prvek)
        {
            if (pocet == prvky.Length)
            {
                int[] novePole = new int[2 * prvky.Length];

                for (int i = 0; i < prvky.Length; i++)
                    novePole[i] = prvky[i];

                prvky = novePole;
            }

            prvky[pocet] = prvek;
            pocet += 1;

            prvky[pocet] = prvek;
        }
   
        public int Dequeue()
        {
            return prvky[0]; 
        }

    }
}