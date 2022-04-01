using System;

namespace Static_Exercise
{
    public static class TempConverter
    {
        public static class TempConverter 
        {
            public static double FahrenheitToCelsius(double fahrenheit) 
            {
                var result = (fahrenheit - 32) / 1.8;

                return result;  
            }

            public static double CelciusToFahrenheit(double celcius) 
            {
                return (celcius * 9) / 5 + 32;
            }
       
                
                
                
                
                
                
        }



        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelciusToFahrenheit(20);


            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"celcius {fahrenheit}");



        }
    }
}
