using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thisisarpctest
{
    static class Program
    {
        //Starts the program
        [STAThread]
        static void Main()
        {
            //makes the string available.
            String Sgt = "";
            if (File.Exists("discord-rpc-w32.dll"))
            {
                Sgt = "true";
            }
            //Checks if discord RPC is available
            if (Sgt == "true")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Detailchanger());
            }
            else
            {
                MessageBox.Show("The DLL Required To Run This Program Is Not In The Current Directory.");
                MessageBox.Show("Please redownload and try again.");
                Application.Exit();
            }
        }
    }
}
