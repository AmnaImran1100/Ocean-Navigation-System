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
    class angleUI
    {
        static public void findSerialNumber(int latDegrees, float latMinutes, char latDirection, int longDegrees, float longMinutes, char longDirection)
        {
            bool flag = false;
            for (int x = 0; x < shipDL.shipList.Count; x++)
            {
                if (shipDL.shipList[x].getLatitude().getDegrees() == latDegrees && shipDL.shipList[x].getLatitude().getMinutes() == latMinutes && shipDL.shipList[x].getLatitude().getDirection() == latDirection && shipDL.shipList[x].getLatitude().getDegrees() == longDegrees && shipDL.shipList[x].getLongitude().getMinutes() == longMinutes && shipDL.shipList[x].getLongitude().getDirection() == longDirection)
                {
                    shipDL.shipList[x].printSerialNumber();
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("There is no Ship with this Location");
            }
        }

        static public void changeShipLoaction(string num)
        {
            for (int x = 0; x < shipDL.shipList.Count; x++)
            {
                if (num == shipDL.shipList[x].getSerialNumber())
                {
                    Console.WriteLine("Enter Ship Latitude ");
                    Console.Write("Enter Latitude Degrees = ");
                    int latDegrees = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Minutes = ");
                    float latMinutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude Minutes = ");
                    char latDirection = char.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Ship Longitude ");
                    Console.Write("Enter Longitude Degrees = ");
                    int longDegrees = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Minutes = ");
                    float longMinutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude Direction = ");
                    char longDirection = char.Parse(Console.ReadLine());

                    shipDL.shipList[x].getLatitude().changeLocation(latDegrees, latMinutes, latDirection);
                    shipDL.shipList[x].getLongitude().changeLocation(longDegrees, longMinutes, longDirection);
                }
                else
                {
                    Console.Write(" No Ship Exist with this Serial Number.");
                }
            }
        }
    }
}
