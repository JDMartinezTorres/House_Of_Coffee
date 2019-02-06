using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeLibrary;



namespace HouseOfCoffee
{
    class Program:OptionsMenu
    {
        static void Main(string[] args)
        {
            OptionsMenu menu = new OptionsMenu();
            menu.Menu();
        }
    }
}
