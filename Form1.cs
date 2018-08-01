using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace Traffic_light
{
    public partial class Form1 : Form
    {
        int time = 60;

       

        public Form1()
        {
            InitializeComponent();
            /* Thread t1 = new Thread(TrafficLightCountDown);
             Thread t2 = new Thread(CarMoveing);
             t1.Start();
             t2.Start();
             t1.Join();
             t2.Join();*/

        }
        public void CarMoveing()
        {
            for (; time >= 0; time--)
            {
                Point i = (Car.Location);
                i.X++;
                i.Y++;
            }

        }


        public void TrafficLightCountDown()
        {
            //倒數60秒後閃黃燈->紅燈
            for(; time >=0; time-- )
            {
                label1.Text = ("" + time);
                Thread.Sleep(1000);
                

            }
            TrafficLight.Image = Properties.Resources.RedLight;
        }


        private void start_Click(object sender, EventArgs e)
        {
            TrafficLight.Image = Properties.Resources.GreenLight;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            TrafficLight.Image = Properties.Resources.YellowLight;
        }
    }
}

