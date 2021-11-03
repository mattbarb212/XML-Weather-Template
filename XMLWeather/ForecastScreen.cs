using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        Image stormImage;
        Image rainImage;
        Image snowImage;
        Image sunImage;
        Image cloudImage;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }
        
        public void displayForecast()
        {
            stormImage = Properties.Resources.thunderStormImage;
            snowImage = Properties.Resources.snowImage;
            rainImage = Properties.Resources.Rain3;
            sunImage = Properties.Resources.sunImage;
            cloudImage = Properties.Resources.cloudImage;

            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            if (Convert.ToInt32(Form1.days[1].condition) >= 200 && Convert.ToInt32(Form1.days[1].condition) < 300)
            {
                pictureBox1.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[1].condition) >= 300 && Convert.ToInt32(Form1.days[1].condition) < 600)
            {
                pictureBox1.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[1].condition) >= 600 && Convert.ToInt32(Form1.days[1].condition) < 700)
            {
                pictureBox1.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[1].condition) >= 700 && Convert.ToInt32(Form1.days[1].condition) < 800)
            {
                pictureBox1.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[1].condition) >= 801 && Convert.ToInt32(Form1.days[1].condition) < 900)
            {
                pictureBox1.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[1].condition) == 800)
            {
                pictureBox1.Image = sunImage;
            }

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            if (Convert.ToInt32(Form1.days[2].condition) >= 200 && Convert.ToInt32(Form1.days[2].condition) < 300)
            {
                pictureBox2.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[2].condition) >= 300 && Convert.ToInt32(Form1.days[2].condition) < 600)
            {
                pictureBox2.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[2].condition) >= 600 && Convert.ToInt32(Form1.days[2].condition) < 700)
            {
                pictureBox2.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[2].condition) >= 700 && Convert.ToInt32(Form1.days[2].condition) < 800)
            {
                pictureBox2.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[2].condition) >= 801 && Convert.ToInt32(Form1.days[2].condition) < 900)
            {
                pictureBox2.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[2].condition) == 800)
            {
                pictureBox2.Image = sunImage;
            }

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            if (Convert.ToInt32(Form1.days[3].condition) >= 200 && Convert.ToInt32(Form1.days[3].condition) < 300)
            {
                pictureBox3.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[3].condition) >= 300 && Convert.ToInt32(Form1.days[3].condition) < 600)
            {
                pictureBox3.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[3].condition) >= 600 && Convert.ToInt32(Form1.days[3].condition) < 700)
            {
                pictureBox3.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[3].condition) >= 700 && Convert.ToInt32(Form1.days[3].condition) < 800)
            {
                pictureBox3.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[3].condition) >= 801 && Convert.ToInt32(Form1.days[3].condition) < 900)
            {
                pictureBox3.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[3].condition) == 800)
            {
                pictureBox3.Image = sunImage;
            }

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;
            if (Convert.ToInt32(Form1.days[4].condition) >= 200 && Convert.ToInt32(Form1.days[4].condition) < 300)
            {
                pictureBox4.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[4].condition) >= 300 && Convert.ToInt32(Form1.days[4].condition) < 600)
            {
                pictureBox4.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[4].condition) >= 600 && Convert.ToInt32(Form1.days[4].condition) < 700)
            {
                pictureBox4.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[4].condition) >= 700 && Convert.ToInt32(Form1.days[4].condition) < 800)
            {
                pictureBox4.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[4].condition) >= 801 && Convert.ToInt32(Form1.days[4].condition) < 900)
            {
                pictureBox4.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[4].condition) == 800)
            {
                pictureBox4.Image = sunImage;
            }

            date5.Text = Form1.days[5].date;
            min5.Text = Form1.days[5].tempLow;
            max5.Text = Form1.days[5].tempHigh;
            if (Convert.ToInt32(Form1.days[5].condition) >= 200 && Convert.ToInt32(Form1.days[5].condition) < 300)
            {
                pictureBox5.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[5].condition) >= 300 && Convert.ToInt32(Form1.days[5].condition) < 600)
            {
                pictureBox5.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[5].condition) >= 600 && Convert.ToInt32(Form1.days[5].condition) < 700)
            {
                pictureBox5.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[5].condition) >= 700 && Convert.ToInt32(Form1.days[5].condition) < 800)
            {
                pictureBox5.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[5].condition) >= 801 && Convert.ToInt32(Form1.days[5].condition) < 900)
            {
                pictureBox5.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[5].condition) == 800)
            {
                pictureBox5.Image = sunImage;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        
    }
}
