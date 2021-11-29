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
            currentOutput.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("#°C");
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("#0°C");
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("#0°C");
            

            if (Convert.ToInt32(Form1.days[0].condition) >= 200 && Convert.ToInt32(Form1.days[0].condition) < 300)
            {
                BackgroundImage = stormImage;
                conditionOutput.Text = "Thunderstorm";
            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 300 && Convert.ToInt32(Form1.days[0].condition) < 600)
            {
                BackgroundImage = rainImage;
                conditionOutput.Text = "Rain";
            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 600 && Convert.ToInt32(Form1.days[0].condition) < 700)
            {
                BackgroundImage = snowImage;
                conditionOutput.Text = "Snow";
            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 700 && Convert.ToInt32(Form1.days[0].condition) < 800)
            {
                BackgroundImage = cloudImage;
                conditionOutput.Text = "Cloudy";
            }
            else if (Convert.ToInt32(Form1.days[0].condition) >= 801 && Convert.ToInt32(Form1.days[0].condition) < 900)
            {
                BackgroundImage = cloudImage;
                conditionOutput.Text = "Cloudy";
            }
            else
            {
                BackgroundImage = sunImage;
                conditionOutput.Text = "Sunny";
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
