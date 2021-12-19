using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    static class MonthlyPayment
    {
        public static int LoanAmount;
        public static double PercRate;
        public static int year;
        public static int Pays;
       
        public static void Solution(int LoanAmount, float PercRate, int year)
        {
        int r = Convert.ToInt32(PercRate / (12 * 100));
        int  Power = Convert.ToInt32(1- Math.Pow((1 + r), -12));
        Pays =  LoanAmount * r  /Power;
            Console.WriteLine("Monthly Payment of {0}", + Pays);
    }   }
}














































































