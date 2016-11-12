using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class ViewModel: ObservableObject
    {
        int kSpeedInterval = 5;
        Car CarModel;
        private string _make = "";
        private int _year = 0;
        private int defaultSpeed = 0;
        public string Make
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Make;
                } else
                {
                    return _make;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Make = value;
                    OnPropertyChanged();
                } else
                {
                    _make = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Year
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Year;
                } else
                {
                    return _year;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Year = value;
                    OnPropertyChanged();
                } else
                {
                    _year = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Speed
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Speed;
                } else
                {
                    return defaultSpeed;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Speed = value;
                    OnPropertyChanged();
                }
            }
        }
        public void CreateCar()
        {
            if (CarModel == null)
            {
                CarModel = new Car(_make, _year);
            }
        }
        public bool AccelerateCar()
        {
            if (CarModel != null)
            {
                Speed += kSpeedInterval;
                return true;
            }
            return false;
        }
        public bool DecelerateCar()
        {
            if (CarModel != null)
            {
                Speed -= kSpeedInterval;
                return true;
            }
            return false;
        }
    }
}
