using System;
using System.Collections.Generic;
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


            foreach (var el in arrayOfNumbers)
            {
                returnedSum += (el & 0xFF) << bitesOfbyte * amountOfElementsInArrayOfNumbers--;
            }

            return returnedSum;
        }
    }
}
