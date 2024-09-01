using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loof//
            Console.WriteLine("This is for loof");
            for (int i = 10; i < 30; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("This is while loof");
            //while loof
            int j = 1;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            //do while
            Console.WriteLine("This is do while");
            int n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 20);


            //try catch
            int o = 0;
            int p = 0;
            try
            {
                p = 100 / o;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("This is catch");
            }
            finally
            {
                Console.WriteLine("Finally we found result");
            }
            Console.WriteLine(p);
            //check and uncheck
            int b = int.MaxValue;
            unchecked
            {
                Console.WriteLine(b+3);
            }
            try
            {
                checked
                {
                    Console.WriteLine(b+3);
                }

            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("This is use from catch");
            }
            Console.ReadLine();

        }
    }
}
