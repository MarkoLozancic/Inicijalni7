using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p=0;
            int br;
            for(int i = 1; i < 100; i++)
            {
                br = 0;
                for (int y = 1; y < 100; y++)
                {
                    if(i%y==0)
                    {
                        br++;
                    }
                }
                if(i%1==0 && i%i==0 && br==2)
                {
                    p++;
                }     
            }
            Console.WriteLine("Primarnih brojeva do 100 ima: " + p);
            Console.ReadKey();
        }
    }
}
