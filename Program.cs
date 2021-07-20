using System;
using System.Linq;

namespace HashMapper
{
    class Program
    {
        static void Main(string[] args)
        {

            var xxMax =Convert.ToInt64(  Math.Floor(  Math.Abs( Math.Pow(byte.MaxValue, 6))));

            Type typeOfxxMax = xxMax.GetType();

            Console.WriteLine(" Тнп xxMax = {0}", typeOfxxMax.Name);

            var vEnumerable = Enumerable.Range(0, Int16.MaxValue).ToArray();

            Tuple<byte, byte, byte, byte, byte, byte> MACaddr =
                        new Tuple< byte, byte, byte, byte, byte, byte> ( 0, 0, 0, 0, 0, 0) ;




            /*
            Type typeOfvEnumerable = vEnumerable.GetType();

            Console.WriteLine("Тип vEnumerable = {0}", typeOfvEnumerable.Name);


            foreach(var eArray0 in vEnumerable)
            {
                Type typeOfEArray0 = eArray0.GetType();

                Console.WriteLine("тип e I уровня = {0}", typeOfEArray0.Name);

            }
            */

            Console.WriteLine("Всё, Хеловорд!");
        }
    }
}
