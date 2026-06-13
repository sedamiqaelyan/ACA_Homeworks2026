using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Homework11
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public bool isRunning = false;
        public Car(string Make, string Model, int Year)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.isRunning = isRunning;
        }

        public void Start()
        {
            isRunning = true;
            Console.WriteLine("Engine started");
        }
        public void Stop()
        {
            isRunning = false;
            Console.WriteLine("Engine stopped");
        }
        public void Describe()
        {
            Console.WriteLine($"{Year} {Make} {Model}"); 
        }

    }


}
