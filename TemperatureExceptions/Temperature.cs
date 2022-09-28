using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Exceptions.TemperatureExceptions
{
    public class Temperature
    {
        private double fahrenheit;
        public static double AbsoluteZeroFahrenheit { get; } = -459.67;

        /*public Temperature(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }*/

        public Temperature(double fahrenheit)
        {
            try
            {
                Fahrenheit = fahrenheit;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Fahrenheit = -459.67;
            }
        }

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {

                if (value < AbsoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero");
                }

                fahrenheit = value;
            }
        }
    }
}