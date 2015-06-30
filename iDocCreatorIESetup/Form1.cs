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
        bool dirty = false;
        string defaultMessage = "Enter A Trusted Site";
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "iDocCreator Standards";
            this.TrustedURL.Leave += new EventHandler(TrustedURL_LostFocus);
            this.TrustedURL.Enter += new EventHandler(TrustedURL_Focus); // enter event==get focus event 
            this.TrustedURL.KeyPress += new KeyPressEventHandler(TrustedURL_key);
            this.TrustedURL.Text = defaultMessage;
            this.TrustedURL.Cursor = Cursors.Arrow; TrustedURL.ForeColor = Color.Gray;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadRegistry();
        }

        private void recurseRegKey(RegistryKey registryKey)
        {
            if (registryKey.SubKeyCount > 0)
            {
                foreach (var key in registryKey.GetSubKeyNames())
                {
                    lstTrustedSites.Items.Add((string)key);
                }
            }
        }
        private void loadRegistry()
        {
            const string regPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains";
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(regPath))
            {
                recurseRegKey(registryKey);
            }
        }

        protected void TrustedURL_Focus(object sender, EventArgs e)
        {
            if (TrustedURL.Text == "")
            {
                dirty = false;
            }
            if (!dirty)
            {
                TrustedURL.Text = "";
                TrustedURL.ForeColor = Color.Gray;
            }
        }
        protected void TrustedURL_LostFocus(object sender, EventArgs e)
        {
            TrustedURL.ForeColor = Color.Gray;
            if (TrustedURL.Text == "")
            {
                TrustedURL.ForeColor = Color.Gray;
                dirty = false;
            }
            if (!dirty)
            {
                this.TrustedURL.Text = defaultMessage;
            }
        }
        protected void TrustedURL_key(object sender, EventArgs e)
        {
            TrustedURL.ForeColor = Color.Black;
            dirty = true;
        }
    }
}
