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
    public partial class bowlers : Form
    {
        public bowlers()
        {
            InitializeComponent();
        }

        private void bowlers_Load(object sender, EventArgs e)
        {
            
            serialPort1.PortName = "COM13";
            timer1.Enabled = true;
            serialPort1.Close();

        }
        int a = 0;
        int chkSerial = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 40)
            {
                pictureBox1.Image = Properties.Resources._2;
                chkSerial = 1;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer2.Enabled = true;
                serialPort1.Open();
            }
            a++;
            
        }
        String SerialRecieve;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (chkSerial == 1)
            {

                SerialRecieve = serialPort1.ReadLine();
            
                chkSerial = 0;
            

            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            


            if (SerialRecieve == "Amit Mishra\r")
            {
                Form3 b = new Form3();
                b.Show();

                this.Hide();
                SerialRecieve = " ";
            }

            if (SerialRecieve == "mustafizur Rahman\r")
            {
                Form4 c = new Form4();
                c.Show();

                this.Hide();
                SerialRecieve = " ";
            }

            if (SerialRecieve == "Dale Steyn\r")
            {
                Form6 d = new Form6();
                d.Show();

                this.Hide();
                SerialRecieve = " ";
            }

            if (SerialRecieve == "Andrew Flintoff\r")
            {
                Form7 f = new Form7();
                f.Show();

                this.Hide();
                SerialRecieve = " ";
            }

                if (SerialRecieve == "Shane Watson\r")
              {
                    Form5 k = new Form5();
                    k.Show();

                    this.Hide();
                    SerialRecieve = " ";

                }
                if (SerialRecieve == "Shane Watson\r")
                {
                    Form8 g = new Form8();
                    g.Show();

                    this.Hide();
                    SerialRecieve = " ";

                }
            }
        }
    }

