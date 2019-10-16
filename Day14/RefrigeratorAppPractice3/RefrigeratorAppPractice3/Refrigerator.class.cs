using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        private int maxWeight;

        private List<int> noOfItemsList = new List<int>();
        private List<double> weightPerUnitList = new List<double>();
        private List<double> totalWeightList = new List<double>();

        public Refrigerator(int maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public int GetMaxWeight()
        {
            return this.maxWeight;
        }

        public string GetRefrigeratorDetails()
        {
            string refrigeratorDetails = "No. of Items - Weight/Unit - Total Weight \n";

            for (int i = 0; i < totalWeightList.Count(); i++)
            {
                refrigeratorDetails +=  noOfItemsList[i].ToString() + "          -           "
                                        + weightPerUnitList[i].ToString() + "          -           "
                                        + totalWeightList[i].ToString() + "\n";
            }

            refrigeratorDetails += "-------------------------------------------\n" + "Total Weight : " + GetCurrentweight();

            return refrigeratorDetails;
        }

        public void SetWeight(int noOfItems, double weightPerUnit)
        {
            double totalWeight = noOfItems * weightPerUnit;
            if (!CheckValidity(totalWeight)) return;
            if (totalWeight != 0)
            {
                this.noOfItemsList.Add(noOfItems);                
                this.weightPerUnitList.Add(weightPerUnit);
                this.totalWeightList.Add(totalWeight);
            }                
        }

        public double GetCurrentweight()
        {
            double currentWeight = totalWeightList.Count > 0 ? totalWeightList.Sum() : 0.0;
            return currentWeight;
        }

        public double GetRemainWeight()
        {
            double remainingWeight = this.maxWeight - GetCurrentweight();
            return remainingWeight;
        }

        public bool CheckValidity(double totalWeight)
        {
            if (totalWeight <= GetRemainWeight()) return true;
            return false;
        }

    }
}
