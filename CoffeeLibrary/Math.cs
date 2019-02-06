using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class CoffeeMath:Products
    {
        double TotalPay;
        Reports reports = new Reports();


        public void GetCoffeeSales()
        {
            Console.WriteLine("Please enter total small coffee sales");
            double SmallCoffeeSales = CheckInput(Console.ReadLine());
            reports.TotalS = SmallCoffeeSales * CoffeeRetail[(int)Coffee.small];
            Console.WriteLine($"Total small coffee sales are {reports.TotalS:c}.");

            Console.WriteLine("Please enter total medium coffee sales");
            double MediumCoffeeSales = CheckInput(Console.ReadLine());
            reports.TotalM = MediumCoffeeSales * CoffeeRetail[(int)Coffee.medium];
            Console.WriteLine($"Total medium coffee sales are {reports.TotalM:c}.");

            Console.WriteLine("Please enter total large coffee sales");
            double LargeCoffeeSales = CheckInput(Console.ReadLine());
            reports.TotalL = LargeCoffeeSales * CoffeeRetail[(int)Coffee.large];
            Console.WriteLine($"Total large coffee sales are {reports.TotalL:c}.");

            Console.ReadLine();
        }

        public void GetSnackSales()
        {
            Console.WriteLine("Please enter total egg sandwich sales");
            double EggSandwichSales = CheckInput(Console.ReadLine());
            reports.TotalEs = EggSandwichSales * SnackRetail[(int)Snack.egg_sandwich];
            Console.WriteLine($"Total egg sandwich sales are {reports.TotalEs:c}.");

            Console.WriteLine("Please enter total chicken biscuit sales");
            double ChickenBiscuitSales = CheckInput(Console.ReadLine());
            reports.TotalCb = ChickenBiscuitSales * SnackRetail[(int)Snack.chicken_biscuit];
            Console.WriteLine($"Total chicken biscuit sales are {reports.TotalCb:c}.");
            Console.ReadLine();
        }

        public void Payroll()
        {
            Employee_Payroll employeeP;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number of hours work by {(Employee)i}");
                double Hours = CheckInput(Console.ReadLine());
                double Pay = employeeP.Pay((int)Hours);
                TotalPay += Pay;
                Console.WriteLine($"Total pay for employees is {Pay:c}\n");
            }
                Console.WriteLine($"Total weekly payroll is {TotalPay:c}");
                Console.ReadLine();
        }

        public void GetReports()
        {
            
            reports.SalesReport();
            reports.CostReport();
            reports.ProfitReport();
        }

        

        public double CheckInput(string input)
        {
            double value = 0;
            try
            {
                value = double.Parse(input);
                if (value <= 0)
                {
                    Console.WriteLine("Please enter a valid value not equal to zero");
                    return CheckInput(Console.ReadLine());
                }
                else
                {
                    return value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! Please enter a positive numeric value");
                return CheckInput(Console.ReadLine());
            }
        }
    }
}
