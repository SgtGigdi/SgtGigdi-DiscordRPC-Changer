//You must include this or it will not work
using SgtGigdiRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thisisarpctest
{
    public partial class Detailchanger : Form
    {
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        public Detailchanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on form load what happens.
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Checks if file is present
            String Sgt = "";
            if (File.Exists("discord-rpc-w32.dll"))
            {
                Sgt = "true";
            }
            //Checks if discord RPC is available
            if (Sgt == "true")
            {
                //Continues without exiting
            }
            else
            {
                MessageBox.Show("The DLL Required To Run This Program Is Not In The Current Directory.");
                MessageBox.Show("Please redownload and try again.");
                Application.Exit();
            }
            //This changes the details
            this.handlers = default(DiscordRpc.EventHandlers);
            //This is my real client ID so please dont fuck with it.
            DiscordRpc.Initialize("859553225866084382", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("859553225866084382", ref this.handlers, true, null);
            this.presence.details = Details.Text;
            this.presence.state = State.Text;
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}
