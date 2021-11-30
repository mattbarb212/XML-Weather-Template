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
            #region
            //Drawing information to the forcast screen

            stormImage = Properties.Resources.thunderStormImage;
            snowImage = Properties.Resources.snowImage;
            rainImage = Properties.Resources.Rain3;
            sunImage = Properties.Resources.sunImage;
            cloudImage = Properties.Resources.cloudImage;

            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("#0°C");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("#0°C");
            if (Convert.ToInt32(Form1.days[1].condition) >= 200 && Convert.ToInt32(Form1.days[1].condition) < 300)
            {
                pictureBox1.Image = stormImage;
                conditionOutput1.Text = "Thunderstorm";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 300 && Convert.ToInt32(Form1.days[1].condition) < 600)
            {
                pictureBox1.Image = rainImage;
                conditionOutput1.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 600 && Convert.ToInt32(Form1.days[1].condition) < 700)
            {
                pictureBox1.Image = snowImage;
                conditionOutput1.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 700 && Convert.ToInt32(Form1.days[1].condition) < 800)
            {
                pictureBox1.Image = cloudImage;
                conditionOutput1.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[1].condition) >= 801 && Convert.ToInt32(Form1.days[1].condition) < 900)
            {
                pictureBox1.Image = cloudImage;
                conditionOutput1.Text = "Cloudy";
            }
            else
            {
                pictureBox1.Image = sunImage;
                conditionOutput1.Text = "Sunny";
            }

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("#0°C");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("#0°C");
            if (Convert.ToInt32(Form1.days[2].condition) >= 200 && Convert.ToInt32(Form1.days[2].condition) < 300)
            {
                pictureBox2.Image = stormImage;
                conditionOutput2.Text = "Thunderstorm";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 300 && Convert.ToInt32(Form1.days[2].condition) < 600)
            {
                pictureBox2.Image = rainImage;
                conditionOutput2.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 600 && Convert.ToInt32(Form1.days[2].condition) < 700)
            {
                pictureBox2.Image = snowImage;
                conditionOutput2.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 700 && Convert.ToInt32(Form1.days[2].condition) < 800)
            {
                pictureBox2.Image = cloudImage;
                conditionOutput2.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[2].condition) >= 801 && Convert.ToInt32(Form1.days[2].condition) < 900)
            {
                pictureBox2.Image = cloudImage;
                conditionOutput2.Text = "Cloudy";
            }
            else
            {
                pictureBox2.Image = sunImage;
                conditionOutput2.Text = "Sunny";
            }

            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("#0°C");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("#0°C");
            if (Convert.ToInt32(Form1.days[3].condition) >= 200 && Convert.ToInt32(Form1.days[3].condition) < 300)
            {
                pictureBox3.Image = stormImage;
                conditionOutput3.Text = "Thunderstorm";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 300 && Convert.ToInt32(Form1.days[3].condition) < 600)
            {
                pictureBox3.Image = rainImage;
                conditionOutput3.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 600 && Convert.ToInt32(Form1.days[3].condition) < 700)
            {
                pictureBox3.Image = snowImage;
                conditionOutput3.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 700 && Convert.ToInt32(Form1.days[3].condition) < 800)
            {
                pictureBox3.Image = cloudImage;
                conditionOutput3.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[3].condition) >= 801 && Convert.ToInt32(Form1.days[3].condition) < 900)
            {
                pictureBox3.Image = cloudImage;
                conditionOutput3.Text = "Cloudy";
            }
            else
            {
                pictureBox3.Image = sunImage;
                conditionOutput3.Text = "Sunny";
            }

            date4.Text = Form1.days[4].date;
            min4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("#0°C");
            max4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("#0°C");
            if (Convert.ToInt32(Form1.days[4].condition) >= 200 && Convert.ToInt32(Form1.days[4].condition) < 300)
            {
                pictureBox4.Image = stormImage;
                conditionOutput4.Text = "Thunderstorm";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 300 && Convert.ToInt32(Form1.days[4].condition) < 600)
            {
                pictureBox4.Image = rainImage;
                conditionOutput4.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 600 && Convert.ToInt32(Form1.days[4].condition) < 700)
            {
                pictureBox4.Image = snowImage;
                conditionOutput4.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[4].condition) >= 700 && Convert.ToInt32(Form1.days[4].condition) < 800)
            {
                pictureBox4.Image = cloudImage;
                conditionOutput4.Text = "Cloudy";
            }
            if (Convert.ToInt32(Form1.days[4].condition) >= 801 && Convert.ToInt32(Form1.days[4].condition) < 900)
            {
                pictureBox4.Image = cloudImage;
                conditionOutput4.Text = "Cloudy";
            }
            else
            {
                pictureBox4.Image = sunImage;
                conditionOutput4.Text = "Sunny";
            }

            date5.Text = Form1.days[5].date;
            min5.Text = Convert.ToDouble(Form1.days[5].tempLow).ToString("#0°C");
            max5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("#0°C");
            if (Convert.ToInt32(Form1.days[5].condition) >= 200 && Convert.ToInt32(Form1.days[5].condition) < 300)
            {
                pictureBox5.Image = stormImage;
                conditionOutput5.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 300 && Convert.ToInt32(Form1.days[5].condition) < 600)
            {
                pictureBox5.Image = rainImage;
                conditionOutput5.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 600 && Convert.ToInt32(Form1.days[5].condition) < 700)
            {
                pictureBox5.Image = snowImage;
                conditionOutput5.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 700 && Convert.ToInt32(Form1.days[5].condition) < 800)
            {
                pictureBox5.Image = cloudImage;
                conditionOutput5.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[5].condition) >= 801 && Convert.ToInt32(Form1.days[5].condition) < 900)
            {
                pictureBox5.Image = cloudImage;
                conditionOutput5.Text = "Cloudy";
            }
            else
            {
                pictureBox5.Image = sunImage;
                conditionOutput5.Text = "Sunny";
            }
            #endregion
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.city = citySearchInput.Text;

            // clear the list of days
            Form1.days.Clear();
            //call extract forecast from form1
            Form1.ExtractForecast();
            //call extract current  from form1
            Form1.ExtractCurrent();

            displayForecast();
        }
    }
}
