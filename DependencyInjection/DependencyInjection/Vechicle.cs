using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
        public interface IVehicle 
        { 
            int Doors { get; set; } 
            int Wheels { get; set; } 
            Color VehicleColor { get; set; } 
            int TopSpeed { get; set; } 
            int Cylinders { get; set; } 
            int CurrentSpeed { get; } 
            string DisplayTopSpeed(); 
            void Accelerate(int step);    
        }

        public class Motorcycle : IVehicle
        {
            private int _currentSpeed = 0;
            public int Doors { get; set; }
            public int Wheels { get; set; }
            public Color VehicleColor { get; set; }
            public int TopSpeed { get; set; }
            public int HorsePower { get; set; }
            public int Cylinders { get; set; }
            public int CurrentSpeed
            {
                get { return _currentSpeed; }
            }
            public Motorcycle(int doors, int wheels, Color color, int topSpeed, int horsePower, int cylinders, int currentSpeed)
            {
                this.Doors = doors;
                this.Wheels = wheels;
                this.VehicleColor = color;
                this.TopSpeed = topSpeed;
                this.HorsePower = horsePower;
                this.Cylinders = cylinders;
                this._currentSpeed = currentSpeed;
            }

            public string DisplayTopSpeed()
            {
                return "Top speed is: " + this.TopSpeed;
            }

            public void Accelerate(int step)
            {
                this._currentSpeed += step;
            }
        }

    class Vechicle
    {
    }
}
