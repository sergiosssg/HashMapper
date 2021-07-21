using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashMapper
{
    public class DelegatesHive
    {
        /**
         *    Todo 
         * 
         * 
         */
        public static long SumOfBitees(long baseOfSumm, IEnumerable<Int32> arrayOfNumbers)
        {
            long returnedSum = 0L;

            const int bitesOfbyte = 8;

            int amountOfElementsInArrayOfNumbers = 0;


            foreach(long e0 in arrayOfNumbers) { amountOfElementsInArrayOfNumbers++; }


            foreach (long el in arrayOfNumbers)
            {
                int bitesforShifting = bitesOfbyte * amountOfElementsInArrayOfNumbers--;
                returnedSum += (el & 0xFF) << bitesforShifting;
            }

            return returnedSum;
        }


        public static IEnumerable<Int32> StringToArrayOfBytes(string sourceString)
        {
            return Enumerable.Range(0, sourceString.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToInt32(sourceString.Substring(x, 2), 16));
        }






        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

    }
}
