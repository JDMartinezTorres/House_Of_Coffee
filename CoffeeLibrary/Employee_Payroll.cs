using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public struct Employee_Payroll
    {
        public double Pay(int hours)
        {
            if(hours - 40 > 0 )
            {
               return (hours * 12.50) + ((hours - 40) * 6.25);
            }
            else
            {
                return hours * 12.50;
            }

        }
    }

}
