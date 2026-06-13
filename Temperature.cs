using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    internal class Temperature
    {
        private double _celsius;

        public double Celsius
        {
            get { return _celsius; }
            set
            {
                if (value >= -273.15)
                {
                    _celsius = value;
                }
            }

        }
        public double Fahrenheit
        {
            get { return _celsius * 9.0 / 5.0 + 32; }
        }
        public Temperature(double Celsius)
        {
            {
                if (Celsius >= -273.15)
                    _celsius = Celsius;
                else
                    _celsius = 0;
            }
        }
        public void Describe()
        {
            Console.WriteLine($"{_celsius}°C = {Fahrenheit}°F");
        }



    }
}
