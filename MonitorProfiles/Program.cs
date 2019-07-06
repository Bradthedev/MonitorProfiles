using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorProfiles
{
    class Program
    {
        public static Screen PrimaryScreen { get; }
        static void Main(string[] args)
        {
            Screen[] screens = Screen.AllScreens;
            Console.WriteLine("****************************");
            foreach (Screen s in screens) {
                Console.WriteLine("Device Name: " + s.DeviceName);
                Console.WriteLine("Bounds: " + s.Bounds.ToString());
                Console.WriteLine("Type: " + s.GetType().ToString());
                Console.WriteLine("Working Area: " + s.WorkingArea.ToString());
                Console.WriteLine("Primary Screen: " + s.Primary.ToString());
                Console.WriteLine("Primary Screen: " + s.Primary.ToString());
                Console.WriteLine("****************************");
            }
            Console.ReadLine();
        }
    }
}
