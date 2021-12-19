using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{   
    /*
    To the Util Class add temperaturConversion static function, given the temperature
    in fahrenheit as input outputs the temperature in Celsius or vice versa using the
    formula
    Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
    Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
    */


    static class TemperatureConversion
    {
        //All data type should hav static keyword in it 

        public static int input;
        public static int Option;

        //All methods has static word in it
        public static void SolutionForConversion(int Option, int input)
        {
            if (Option == 1)
            {
                int result = (input * 9 / 5) + 32;
                Console.WriteLine(input + "Celsius to fahrenheit is " + result);
            }
            else
            {
                int result = (input - 32) * 5 / 9;
                Console.WriteLine(input + " fahrenheit to celsius is " + result);

            }
        }


    }
}
