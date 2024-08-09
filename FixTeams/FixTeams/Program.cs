using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace FixTeams
{
    class Program
    {
        const UInt32 KEYEVENTF_EXTENDEDKEY = 0x0001;
        const UInt32 KEYEVENTF_KEYUP = 0x0002;
        const int VK_F15 = 0x7E;
        const int VK_NUMPAD0 = 0x60;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        [STAThread]
        static void Main(string[] args)
        {
            while(true)
            {
                keybd_event((byte)VK_F15, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                keybd_event((byte)VK_F15, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
                Console.WriteLine("[" + DateTime.Now.ToString("hh:mm:ss") + "] Click !");

                Thread.Sleep(15000);
            }
        }
    }
}
