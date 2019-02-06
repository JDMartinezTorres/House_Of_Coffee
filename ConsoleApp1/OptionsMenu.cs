using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeLibrary;

namespace CoffeeLibrary
{
    public class OptionsMenu:CoffeeMath
    {
        
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the House of Coffee");
            Console.WriteLine("Please enter a selection \n" +
                "1) Coffee Sales \n" +
                "2) Snacks Sales\n" +
                "3) Daily Reports \n" +
                "4) Payroll \n" +
                "5) Exit \n");
            SwitchSelection();
        }

        public void SwitchSelection()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    GetCoffeeSales();
                    Menu();
                    break;
                case "2":
                    GetSnackSales();
                    Menu();
                    break;
                case "3":
                    GetReports();
                    Menu();
                    break;
                case "4":
                    Payroll();
                    Menu();
                    break;
                default:
                    Console.WriteLine("Thank you, Come again!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
