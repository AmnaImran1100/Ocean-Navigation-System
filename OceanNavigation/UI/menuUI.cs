using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.UI
{
    class menuUI
    {
        static public int menu()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("               OCEAN NAVIGATION SYSTEM             ");
            Console.WriteLine("***************************************************");
            Console.WriteLine("1. Add Ship ");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your option = ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static public void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
