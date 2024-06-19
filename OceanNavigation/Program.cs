using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "shipInfo.txt";
            if (shipDL.readFromFile(filePath))
            {
                Console.WriteLine("Ships Data Loaded Successfully");
            }
            menuUI.clear();
            int option = 0;
            while (option != 5)
            {
                option = menuUI.menu();
                Console.ReadKey();
                Console.Clear();
                if (option == 1)
                {
                    shipBL s = shipUI.getInfoOfShip();
                    shipDL.addShipInList(s);
                    shipDL.storeintoFile(filePath, s);
                    menuUI.clear();
                }
                else if (option == 2)
                {
                    Console.Write("Enter Serial Number to Find Ship =");
                    string num = Console.ReadLine();
                    shipUI.findShip(num);
                    menuUI.clear();
                }
                else if (option == 3)
                {
                    Console.Write("Enter Ships Latitude =");
                    string latitude = Console.ReadLine();
                    Console.Write("Enter Ships Longitude =");
                    string longitude = Console.ReadLine();
                    angleBL.splitString(latitude, longitude);
                    menuUI.clear();
                }
                else if (option == 4)
                {
                    Console.Write("Enter Serial Number to Find Ship =");
                    string num = Console.ReadLine();
                    angleUI.changeShipLoaction(num);
                    menuUI.clear();
                }
            }
        }   
    }
}