using System;
using System.Linq;

namespace HashMapper
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] testArray = { 0xB4, 0xEC, 0x20, 0x52, 0x41, 0x53 };


            long testSum = 0L;

            testSum = DelegatesHive.SumOfBitees(testSum, testArray);


            DateTime dtNow = DateTime.Now;

            Console.WriteLine( dtNow.ToString("yy,MM,HH,hh,mm,ss"));

            Console.WriteLine("Всё, Хеловорд!");
        }
    }
}
