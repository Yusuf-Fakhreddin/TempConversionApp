using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // From Fahrenheit
        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void convertFromFahrenheit()
        {
            float f = 0;

            if (txt_fahrenheit.TextLength > 0)
            {
                try
                {
                    f = float.Parse(txt_fahrenheit.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Try Numbers!!");
                }


                float celsiusResult = 5f / 9f * (f - 32);
                float kelvinResult = celsiusResult - 273;

                txt_celsius.Text = celsiusResult.ToString();
                txt_kelvin.Text = kelvinResult.ToString();
            }
            else
            {

                txt_celsius.Text = "";
                txt_kelvin.Text = "";
            }
        }

        // From Celsius
        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void convertFromCelsius()
        {
            float c = 0;
            if (txt_celsius.TextLength > 0)
            {
                try
                {
                    c = float.Parse(txt_celsius.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Try Numbers!!");
                }


                float fahrenheitResult = (9f / 5f) * c + 32;
                float kelvinResult = c + 273;

                txt_fahrenheit.Text = fahrenheitResult.ToString();
                txt_kelvin.Text = kelvinResult.ToString();
            }
            else
            {
                txt_fahrenheit.Text = "";
                txt_kelvin.Text = "";

            }
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }
        private void convertFromKelvin()
        {
            float k = 0;
            if (txt_kelvin.TextLength > 0)
            {
                try
                {
                    k = float.Parse(txt_kelvin.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Try Numbers!!");
                }


                float fahrenheitResult = (9f / 5f) * (k - 273) + 32;
                float celsiusResult = k - 273;

                txt_fahrenheit.Text = fahrenheitResult.ToString();
                txt_celsius.Text = celsiusResult.ToString();
            }
            else
            {
                txt_fahrenheit.Text = "";
                txt_celsius.Text = "";
            }
        }

        private void onFahrenheitTextChange(object sender, EventArgs e)
        {
            if (!txt_fahrenheit.Focused ) return;
            convertFromFahrenheit();
        }

        private void onCelsiusTextChange(object sender, EventArgs e)
        {
            if (!txt_celsius.Focused) return;

            convertFromCelsius();
        }

        private void onKelvinTextChange(object sender, EventArgs e)
        {
            if (!txt_kelvin.Focused) return;

            convertFromKelvin();
        }
    }
}
