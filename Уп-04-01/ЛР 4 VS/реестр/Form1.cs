using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace реестр
{
    public partial class Form1 : Form
    {
        private int _clr = -1;
        private string _str;
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "RegistrySetValueExample";
        const string keyName = userRoot + "\\" + subkey;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((int)Registry.GetValue(keyName, "clr", "-1") == 0)
                Collor(Color.Yellow, Color.Gray);
            if ((int)Registry.GetValue(keyName, "clr", "-1") == 1)
                Collor(Color.LightBlue, Color.White);
            if ((int)Registry.GetValue(keyName, "clr", "-1") == 2)
                Collor(Color.Pink, Color.White);

        }
       
        private void Collor(Color buttonc, Color backgroundc)
        {
            button1.BackColor = buttonc;
            button2.BackColor = buttonc;
            
            this.BackColor = backgroundc;
            label1.BackColor = buttonc;
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Collor(Color.Yellow, Color.Gray);
            _clr = 0;
            Registry.SetValue(keyName, "clr", 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Collor(Color.LightBlue, Color.White);
            _clr = 1;
            Registry.SetValue(keyName, "clr", 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Collor(Color.Pink, Color.White);
            _clr = 1;
            Registry.SetValue(keyName, "clr", 2);
        }
    }
}

