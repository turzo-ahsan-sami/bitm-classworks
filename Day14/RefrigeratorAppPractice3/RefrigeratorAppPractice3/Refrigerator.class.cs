using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {        
        public int MaxWeight { get; set; }
        
        private List<double> WeightList = new List<double>();

        public void SetWeight(double totalWeight)
        {           
            if (!CheckValidity(totalWeight)) return;
            if (totalWeight != 0) WeightList.Add(totalWeight);
        }

        public double GetCurrentweight()
        {
            double currentWeight = WeightList.Count > 0 ? WeightList.Sum() : 0.0;
            return currentWeight;
        }

        public double GetRemainWeight()
        {
            double remainingWeight = MaxWeight - GetCurrentweight();
            return remainingWeight;
        }

        public bool CheckValidity(double totalWeight)
        {
            if (totalWeight <= GetRemainWeight()) return true;
            return false;
        }

    }
}
