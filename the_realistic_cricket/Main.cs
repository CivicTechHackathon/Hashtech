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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM15";
            serialPort1.Open();
            //serialPort1.Write("send,");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        String ReadScore;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ReadScore = serialPort1.ReadTo(",");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ReadScore == "2")
            {
                label2.Text = "YOUR SCORE IS..!!!!";
                pictureBox1.Image = Properties.Resources._2RUN;
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                timer1.Enabled = false;
                
            }
            else if (ReadScore == "4")
            {
                label2.Text = "YOUR SCORE IS..!!!!";
                pictureBox1.Image = Properties.Resources._4;
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                timer1.Enabled = false;
               
            }
            else if (ReadScore == "1")
            {
                label2.Text = "YOUR SCORE IS..!!!!";
                pictureBox1.Image = Properties.Resources._1;
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                timer1.Enabled = false;

            }
            else
            {
                label2.Text = "PLEASE WAIT FOR YOUR SCORE..!!!!";
                pictureBox1.Visible = false;

            }
        }
        int time1 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time1 == 40)
            {
  
                serialPort1.Close();
                bowlers t = new bowlers();
                t.Show();
                timer2.Enabled = false;
                this.Hide(); 
            }
            time1++;
            
        }
      
        

        
    }
}
