using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_realistic_cricket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    Main a = new Main();
                    a.Show();
                    Thread.Sleep(6000);
                    this.Hide();
                    bowlers k = new bowlers();
                    k.Show();
                    timer1.Enabled = false;
                    
                    
                }

        }

        
    
    }
}
