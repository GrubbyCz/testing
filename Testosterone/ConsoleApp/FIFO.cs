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
            prvky = new int[5];

        }


        public int Count()
        {
            return pocet;
        }
    }
}
