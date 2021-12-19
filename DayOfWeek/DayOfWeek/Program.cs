using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter Year of birthday");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month of birthday");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of birthday Now");
             int day = int.Parse(Console.ReadLine());

            DayOfWeek d1 = new DayOfWeek(year, month, day);
            d1.Solution();

            */
            /*
            //Temperature Conversation

            Console.WriteLine("Enter Option 1 to convert into celsious and 2 for Fahrenheit: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value you want ot convert: ");
            int input = int.Parse(Console.ReadLine());

            TemperatureConversion.SolutionForConversion(option, input);
            */



            Console.WriteLine("Enter amount of Loan");
            int LoanAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount Percentage Rate");
            float PercRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of year you want to pay");
            int year = int.Parse(Console.ReadLine());

            MonthlyPayment.Solution(LoanAmount, PercRate, year);





        }
    }
}
