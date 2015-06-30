using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace iDocCreatorIESetup
{
    public partial class Form1 : Form
    {
        private ArrayList keys = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "iDocCreator Standards";
            this.TrustedURL.Enter += new EventHandler(TrustedURL_Focus); // enter event==get focus event 
            //this.TrustedURL.Text = "Trusted Sites"; this.TrustedURL.TextAlign = HorizontalAlignment.Center;
            this.TrustedURL.Cursor = Cursors.Arrow;
        }

        private void recurseRegKey(RegistryKey registryKey) {
            if (registryKey.SubKeyCount != null && registryKey.SubKeyCount > 0)
            {
                foreach (var VARIABLE in registryKey.GetSubKeyNames())
                {
                    Console.WriteLine(VARIABLE);//here I can see I have many keys
                    //no need to switch to x64 as suggested on other posts
                }
            }
        }
        private void loadRegistry() {
            const string regPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains";
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(regPath))
            {
                recurseRegKey(registryKey);
            }
        }

        protected void TrustedURL_Focus(object sender, EventArgs e)
        {
            TrustedURL.Text = "";
        }
        private void TrustedURL_LostFocus(object sender, EventArgs e){
            
        }
    }
}
