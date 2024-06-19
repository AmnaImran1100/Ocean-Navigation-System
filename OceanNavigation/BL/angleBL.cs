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
    class angleBL
    {
        private int degrees;
        private float minutes;
        private char direction;

        public void setDegrees(int degrees)
        {
            this.degrees = degrees;
        }

        public void setMinutes(float minutes)
        {
            this.minutes = minutes;
        }
        public void setDirection(char direction)
        {
            this.direction = direction;
        }

        public int getDegrees()
        {
            return degrees;
        }

        public float getMinutes()
        {
            return minutes;
        }

        public char getDirection()
        {
            return direction;
        }

        public void changeLocation(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public angleBL(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        static public void splitString(string latitude, string longitude)
        {
            string[] splittedrecord = latitude.Split(',');
            int latDegrees = int.Parse(splittedrecord[0]);
            float latMinutes = float.Parse(splittedrecord[1]);
            char latDirection = char.Parse(splittedrecord[2]);
            string[] splittedrecord1 = longitude.Split(',');
            int longDegrees = int.Parse(splittedrecord1[0]);
            float longMinutes = float.Parse(splittedrecord1[1]);
            char longDirection = char.Parse(splittedrecord1[2]);
            angleUI.findSerialNumber(latDegrees, latMinutes, latDirection, longDegrees, longMinutes, longDirection);
        }
    }
}
