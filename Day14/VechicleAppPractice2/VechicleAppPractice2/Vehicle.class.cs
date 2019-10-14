using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        public string VehicleName { get; set; }
        public string RegistrationNumber { get; set; }
        
        private List<double> SpeedList = new List<double>();

        public void SetSpeed(double speed)
        {
            if(speed != 0) SpeedList.Add(speed);
        }

        public double GetMaxSpeed()
        {            
            this.SpeedList.Sort();
            double maxSpeed = SpeedList.Count > 0 ? SpeedList[SpeedList.Count - 1] : 0.0;
            return maxSpeed;
        }

        public double GetMinSpeed()
        {
            this.SpeedList.Sort();
            double minSpeed = SpeedList.Count > 0 ? SpeedList[0] : 0.0;
            return minSpeed;
        }

        public double GetAverageSpeed()
        {
            double average = SpeedList.Count > 0 ? SpeedList.Average() : 0.0;
            return average;
        }
    }
}
