//Matthew Barber
//November 29
//To display weather information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;


namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // List to hold day objects
        public static List<Day> days = new List<Day>();

        public static string city = "Stratford,CA";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);


        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q="+ city+"&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //Day object
                Day newDay = new Day();

                //Fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                days.Add(newDay);
            }
        }

        private void ExtractCurrent()
        {
            //forecast file
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //Find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
        }
    }
}
