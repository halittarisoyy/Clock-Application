using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Clock_Window
{
    public partial class Form2 : Form
    {
        private WeatherData weatherData;
        private string receivedData="İstanbul";
        public Form2()
        {
            InitializeComponent();
            this.KeyDown += Clock_KeyDown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hourState.Text = DateTime.Now.Hour.ToString("00");
            minuteState.Text = DateTime.Now.Minute.ToString("00");
            label3.Text= DateTime.Now.ToString("dd MMMM yyyy");
            GetWeather();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer1.Start();

            GetWeather();
            label2.Text = receivedData;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                receivedData = form1.GetData();
                // İkinci formdan alınan veriyi kullan
                GetWeather();
                label2.Text=receivedData;
                
            }
            


        }
        private async void GetWeather()
        {
            // OpenWeatherMap API anahtarı
            string apiKey = "dcd763a65f1b35dd4ff390310753b74c";

            // Şehir adı
            string cityName = this.receivedData;

            // Hava durumu bilgilerini al ve weatherData değişkenine atar
            weatherData = await GetWeatherData(apiKey, cityName);

            // Hava durumu bilgilerini ekrana yazdır
            if (weatherData != null)
            {
                label1.Text = $"{weatherData.Main.Temp.ToString("0")}°";
                
            }
            else
            {
                label1.Text = "N/A";

            }
        }


        // OpenWeatherMap API'ye istek göndererek hava durumu bilgilerini alır
        static async System.Threading.Tasks.Task<WeatherData> GetWeatherData(string apiKey, string cityName)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid={apiKey}");
                string responseJson = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseJson);
                    return weatherData;
                }
                else
                {
                    return null;
                }
            }
        }




        private void Clock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                fullscreenButton.Visible = true;
                fullscreenExitButton.Visible = false;
                button4.Visible = true;
                groupBox1.Size = new Size(180, 120);


            }
            if (e.Alt && e.KeyCode == Keys.Enter)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                fullscreenButton.Visible = false;
                fullscreenExitButton.Visible = true;
                button4.Visible = false;
                groupBox1.Size = new Size(120, 120);

            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tuş vuruşunu bastır
            }
        }

        private void bg1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            fullscreenButton.Visible = false;
            fullscreenExitButton.Visible = true;
            button4.Visible = false;
            groupBox1.Size = new Size(120, 120);

        }

        private void fullscreenExitButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
            fullscreenButton.Visible = true;
            fullscreenExitButton.Visible = false;
            button4.Visible = true;
            groupBox1.Size = new Size(180, 120);


        }

        public void label1_Click(object sender, EventArgs e)
        {
        }

        
    }

    public class WeatherData
    {
        public string Name { get; set; } // Şehir adı
        public MainData Main { get; set; } // Ana hava durumu verileri
        public List<Weather> Weather { get; set; } // Hava durumu açıklamaları
    }

    // Ana hava durumu verilerini temsil eden sınıf
    public class MainData
    {
        public float Temp { get; set; } // Sıcaklık
        public float FeelsLike { get; set; } // Hissedilen sıcaklık
    }

    // Hava durumu açıklamalarını temsil eden sınıf
    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; } // Hava durumu açıklaması
    }

    
}