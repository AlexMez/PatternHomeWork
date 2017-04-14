using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace patternHW
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Print Pattern (a)
            //PrintHashTriangle();

            while(true)
            {
                PrintHashTriangle();
                PrintUpSideTriangle();
            }
            //Console.WriteLine("-----------------------");

            ////Print Pattern (b)
            //PrintUpSideTriangle();

            //better idea loop these tomake wave
            
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            //PrintHashTriangle();
            //PrintUpSideTriangle();
            // Console.WriteLine();
        }

        public static void PrintHashTriangle()
        {
            for (int i = 0; i < 9; i++)
            {
                PrintHashNTimes(i);
                Console.WriteLine();
            }
        }


        public static void PrintHashNTimes(int Ntimes)
        {
            for (int i = 0; i < Ntimes; i++)
            {
                Console.Write("#");
                Thread.Sleep(5);
            }
        }
        
        //just make it so print more then decrement
        public static void PrintUpSideTriangle()
        {
            for (int i = 9; i > 0; i--)
            {
                PrintHashNTimes(i);
                Console.WriteLine();
            }
        }

        //just make it so print more first
        //public static void PrintHashFlip(int Ntimes)
        //{
        //    for (int i = 0; i < Ntimes; i++)
        //    {
        //        Console.Write("#");
        //    }
        //}

    }
}
