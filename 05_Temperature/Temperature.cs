using System;

namespace _05_Temperature
{
    
    
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

        public enum Unit
        {
            Celcius,
            Fahrenheit,
        };

        public Temperature()
        {

        }

        //public Unit cunit = Unit.Celcius;
        //public Unit funit = Unit.Fahrenheit;


        public Temperature(Unit someunit, double sometemp)
        {
            if (someunit == Unit.Celcius)
            {
                Celcius = sometemp;
            }
            if (someunit == Unit.Fahrenheit)
            {
                Fahrenheit = sometemp;
            }
        }



        //public Temperature(Unit v, int c)
        //{
        //    if (v == Unit.Celcius)
        //    {
        //        Celcius = c;
        //    }
        //    else
        //    {
        //        Fahrenheit = c;
        //    }
        //}
        //public Temperature()
        //{

        //}


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