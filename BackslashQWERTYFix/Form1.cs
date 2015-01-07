using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackslashQWERTYFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hotkey hk;

        private void Form1_Load(object sender, EventArgs e)
        {
            Hotkey hk = new Hotkey();

            hk.KeyCode = Keys.OemPipe;
            hk.Alt = true;
            hk.Pressed += delegate {
                Clipboard.SetText("\\");
            };

            hk.Register(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hk != null)
             hk.Unregister(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
