using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation.BL
{
    class shipBL
    {
        private string serialNumber;
        private angleBL latitude;
        private angleBL longitude;

        public void setSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }

        public void setLatitude(angleBL latitude)
        {
            this.latitude = latitude;
        }

        public void setLongitude(angleBL longitude)
        {
            this.longitude = longitude;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public angleBL getLatitude()
        {
            return latitude;
        }

        public angleBL getLongitude()
        {
            return longitude;
        }

        public shipBL(string serialNumber, int latDegrees, float latMinutes, char latDirection, int longDegrees, float longMinutes, char longDirection)
        {
            this.serialNumber = serialNumber;
         
            latitude = new angleBL(latDegrees, latMinutes, latDirection);
            longitude = new angleBL(longDegrees, longMinutes, longDirection);
        }

        public void printLocation()
        {
            Console.WriteLine("Shipe is at " + latitude.getDegrees() + "\u00b0" + latitude.getMinutes() + "'" + latitude.getDirection() + " and " + longitude.getDegrees() + "\u00b0" + longitude.getMinutes() + "'" + longitude.getDirection());
        }
        public void printSerialNumber()
        {
            Console.WriteLine("Ships Serial Number is " + serialNumber);
        }

    }
}