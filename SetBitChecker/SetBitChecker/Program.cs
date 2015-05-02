using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetBitChecker
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = int.MaxValue;

         // implementation 1: Wont work for negative numbers
         int tempNumber = number & 0x1;
         int count = 0;
         do
         {
            if (tempNumber == 1)
               count++;
            number = number >> 0x1;
            tempNumber =  number & 0x1;
         } while (number!=0);
         
         Console.WriteLine("Number of bits set in number {1} are: {0}", count, number);
         Console.ReadKey();

         number = int.MinValue+1;
         count = 0;
         long tempNumber1;

         // implementation 2 : for working with negative values
         for (long i = 1; i<=UInt32.MaxValue; i = i * 2)
         {
            tempNumber1 = number & i;
            if (tempNumber1 != 0)
               count++;
         }
         Console.WriteLine(sizeof(int));
         Console.WriteLine(sizeof(long));
         Console.WriteLine("Number of bits set in number {1} are: {0}", count, number);
         Console.WriteLine("Max int is : {0} , Min int is {1}", int.MaxValue, int.MinValue);
         Console.ReadKey();
      }
   }
}
