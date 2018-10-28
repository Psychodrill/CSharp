using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework7
{
    class Udvoitel
    {
        int finish;
        int current;

        public Udvoitel(int min,int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min,max+1);
            current = 1;
        }
        
        public void Plus()
        {
            current++;
        }

        public void Multi()
        {
            current *= 2;
        }

        public void Reset()
        {
            current = 1;
        }

        public int Current
        {
            get { return current; }
        }

        public int Finish
        {
            get { return finish; }

        }
        

    }
}
