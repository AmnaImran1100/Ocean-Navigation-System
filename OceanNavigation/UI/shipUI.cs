using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation.UI
{
    class shipUI
    {
        static public shipBL getInfoOfShip()
        {
            Console.Write("Enter Serial Number =");
            string serialNumber = Console.ReadLine();

            Console.WriteLine("Enter Ship Latitude ");
            Console.Write("Enter Latitude Degrees = ");
            int latDegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Minutes = ");
            float latMinutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude Direction = ");
            char latDirection = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Longitude ");
            Console.Write("Enter Longitude Degrees = ");
            int longDegrees = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Minutes = ");
            float longMinutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude Direction = ");
            char longDirection = char.Parse(Console.ReadLine());

            shipBL s = new shipBL(serialNumber, latDegrees, latMinutes, latDirection, longDegrees, longMinutes, longDirection);
            return s;
        }

        static public void findShip(string num)
        {
            bool flag = false;
            for (int x = 0; x < shipDL.shipList.Count; x++)
            {
                if (num == shipDL.shipList[x].getSerialNumber())
                {
                    shipDL.shipList[x].printLocation();
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.Write(" No Ship Exist with this Serial Number.");
            }
        }
    }

}
