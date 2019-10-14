using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        public Refrigerator()
        {
          
        }
        public Refrigerator (int maxweight)
        {
            this.Maxweight = maxweight;
        }

        public int Maxweight { get; set; }
        public int Currentweight (int item,int itemweight)
        {
            int currentweight=0;
            
            return currentweight + (item * itemweight);
        }
        public void GetRemainWeight()
        {
            
            
        }


    }
}
