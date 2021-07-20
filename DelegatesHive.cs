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
        public static int SumOfBitees(long baseOfSumm, IEnumerable<Int32> arrayOfNumbers)
        {
            int returnedSum = 0;

            foreach(var el in arrayOfNumbers)
            {
                returnedSum += el;
            }

            return returnedSum;
        }
    }
}
