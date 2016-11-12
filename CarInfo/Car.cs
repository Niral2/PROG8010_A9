using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class Car
    {
        public string Make
        {
            get; set;
        }
        public int Year
        {
            get; set;
        }
        public int Speed
        {
            get; set;
        }
        public Car(string make, int year) {
            // Constructor that requires make and year
            Make = make;
            Year = year;
            Speed = 0;
        }
        public void Accelerate(int interval)
        {
            // Function to increment car speed
            Speed += interval;
        }
        public void Decelerate(int interval)
        {
            // Function to decrease car speed
            Speed -= interval;
        }
    }
}
