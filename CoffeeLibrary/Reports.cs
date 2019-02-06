using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Reports:Products
    {
        public double TotalS, TotalM, TotalL;
        public double TotalEs, TotalCb;
        public double TotalCost, TotalIncome;

        public void SalesReport()
        {
            double TotalCoffeeSales = TotalS + TotalM + TotalL;
            double TotalSnackSales = TotalEs + TotalCb;
            TotalIncome = TotalCoffeeSales + TotalSnackSales;
            Console.WriteLine($"Daily sales total is {TotalIncome:c}");
            Console.ReadLine();
        }

        public void CostReport()
        {
            double CoffeeCost = (TotalS * CoffeeNet[(int)Coffee.small]) + (TotalM * CoffeeNet[(int)Coffee.medium]) + (TotalL * CoffeeNet[(int)Coffee.large]);
            double SnackCost = (TotalEs * SnackNet[(int)Snack.chicken_biscuit]) + (TotalCb * SnackNet[(int)Snack.egg_sandwich]);
            TotalCost = CoffeeCost + SnackCost;
            Console.WriteLine($"The total overhead cost is {TotalCost:c}");
            Console.ReadLine();
        }

        public void ProfitReport()
        {
            double Profit = TotalIncome - TotalCost;
            Console.WriteLine($"Total profit is {Profit:c}");
            Console.ReadLine();
        }
    }
}
