using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation.DL
{
    class shipDL
    {
        static public List<shipBL> shipList = new List<shipBL>();

        static public void addShipInList(shipBL s)
        {
            shipList.Add(s);
        }

        public static void storeintoFile(string path, shipBL s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.getSerialNumber() + "," + s.getLatitude().getDegrees() + "," + s.getLatitude().getMinutes() + "," + s.getLatitude().getDirection() +  "," + s.getLongitude().getDegrees() + "," + s.getLongitude().getMinutes() + "," + s.getLongitude().getDirection());
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string serialNumber = splittedRecord[0];
                    int latDegrees  = int.Parse(splittedRecord[1]);
                    float latMinutes = float.Parse(splittedRecord[2]);
                    char latDirection = char.Parse(splittedRecord[3]);
                    int longDegrees = int.Parse(splittedRecord[4]);
                    float longMinutes = float.Parse(splittedRecord[5]);
                    char longDirection = char.Parse(splittedRecord[6]);
                    shipBL s = new shipBL(serialNumber, latDegrees, latMinutes, latDirection, longDegrees, longMinutes, longDirection);
                    shipDL.addShipInList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
