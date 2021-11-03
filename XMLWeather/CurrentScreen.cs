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
    public partial class CurrentScreen : UserControl
    {
        Image stormImage;
        Image rainImage;
        Image snowImage;
        Image sunImage;
        Image cloudImage;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            stormImage = Properties.Resources.thunderStormImage;
            snowImage = Properties.Resources.snowImage;
            rainImage = Properties.Resources.Rain3;
            sunImage = Properties.Resources.sunImage;
            cloudImage = Properties.Resources.cloudImage;

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            if (Convert.ToInt32(Form1.days[0].condition) >= 200 && Convert.ToInt32(Form1.days[0].condition) < 300)
            {
                pictureBox1.Image = stormImage;
            }
            if (Convert.ToInt32(Form1.days[0].condition) >= 300 && Convert.ToInt32(Form1.days[0].condition) < 600)
            {
                pictureBox1.Image = rainImage;
            }
            if (Convert.ToInt32(Form1.days[0].condition) >= 600 && Convert.ToInt32(Form1.days[0].condition) < 700)
            {
                pictureBox1.Image = snowImage;
            }
            if (Convert.ToInt32(Form1.days[0].condition) >= 700 && Convert.ToInt32(Form1.days[0].condition) < 800)
            {
                pictureBox1.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[0].condition) >= 801 && Convert.ToInt32(Form1.days[0].condition) < 900)
            {
                pictureBox1.Image = cloudImage;
            }
            if (Convert.ToInt32(Form1.days[0].condition) == 800)
            {
                pictureBox1.Image = sunImage;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }


    }
}
