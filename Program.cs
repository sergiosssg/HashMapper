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

            DateTime dtBeginingOfThisYear;

            DateTime dtNow = DateTime.Now;

            int iYear = dtNow.Year;

            dtBeginingOfThisYear = new DateTime( iYear, 1, 1);

            int iDayOfYearDtBeginingOfThisYear = dtBeginingOfThisYear.DayOfYear;
            int iDayOfYearDtNow = dtNow.DayOfYear;

            int iDtDifference = iDayOfYearDtNow - iDayOfYearDtBeginingOfThisYear + 1;

            int iSeconds = dtNow.Hour * 3600 + dtNow.Minute * 60 + dtNow.Second;

            Console.WriteLine( dtNow.ToString("yy,MM,dd,HH,mm,ss"));

            Console.WriteLine("Всё, Хеловорд!");
        }
    }
}
