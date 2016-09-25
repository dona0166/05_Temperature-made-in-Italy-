using System;

namespace _05_Temperature
{
    public enum Unit
    {
        Celcius,
        Fahrenheit
    };

    public class Temperature
    {
        private double fahrenheit;
        private double celcius;

        public double Fahrenheit
        {
            get { return this.fahrenheit; }
            set { this.fahrenheit = value; }
        }

        public double Celcius
        {
            get { return this.celcius; }
            set { this.celcius = value; }
        }

        

        public Temperature()
        {

        }
        
        public Temperature(Unit someunit, double sometemp)
        {
            if (someunit == Unit.Celcius)
            {
                this.celcius = sometemp;
            }
            else
            {
                this.fahrenheit = sometemp;
            }
        }


        public static double FahrenheitToCelcius(double f)
        {
            double c;
            c = (5 / (double)9) * (f - 32);
            return c;
        }

        public static double CelciusToFahrenheit(double c)
        {
            double f;
            f = (c * 9 / 5) + 32;
            return f;
        }


        
    }
}