using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для Converter.xaml
    /// </summary>
    public partial class Converter : Window
    {
        float num1 = 0;
        float num2 = 0;
        string mode = "dark";
        bool flag = true;
        public Converter(string mode)
        {
            InitializeComponent();
            area();
            ComboUp.Text = ComboDown.Text = "Acres";
            this.mode = mode;
            btn_up.IsEnabled = false;
        }
        private void ModeStandart(object sender, RoutedEventArgs e)
        {
            WpfApp2.MainWindow standart = new WpfApp2.MainWindow(mode, 0, 0, "");
            standart.Show();
            this.Close();
        }
        private void ModeScientific(object sender, RoutedEventArgs e)
        {
            WpfApp2.Other_modes.Scientific scientific = new WpfApp2.Other_modes.Scientific(mode, 0, 0, "");
            scientific.Show();
            this.Close();
        }
        private void ModeProgrammer(object sender, RoutedEventArgs e)
        {
            WpfApp2.Other_modes.Programmer programmer = new WpfApp2.Other_modes.Programmer(mode, 0, 0, "");
            programmer.Show();
            this.Close();
        }
        private void ClickHistory(object sender, RoutedEventArgs e)
        {

        }
        private void DarkLight(object sender, RoutedEventArgs e)
        {

        }
        private void btn_c_click(object sender, RoutedEventArgs e)
        {
            num1 = num2 = 0;
            txtValueUp.Text = txtValueDown.Text = "0";
        }
        private void btn_num_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string num = button.Content.ToString();
            if (flag)
            {
                if (txtValueUp.Text == "0")
                {
                    txtValueUp.Text = num;
                    num1 = float.Parse(txtValueUp.Text);
                }
                else
                {
                    txtValueUp.Text += num;
                    num1 = float.Parse(txtValueUp.Text);
                }
                Convert(num1, ref num2, ref txtValueDown, ComboUp, ComboDown);
            }
            else
            {
                if (txtValueDown.Text == "0")
                {
                    txtValueDown.Text = num;
                    num2 = float.Parse(txtValueDown.Text);
                }
                else
                {
                    txtValueDown.Text += num;
                    num2 = float.Parse(txtValueDown.Text);
                }
                Convert(num2, ref num1, ref txtValueUp, ComboDown, ComboUp);
            }
        }
        private void btn_back_click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                txtValueUp.Text = DropLastChar(txtValueUp.Text);
                num1 = float.Parse(txtValueUp.Text);
                Convert(num1, ref num2, ref txtValueDown, ComboUp, ComboDown);
            }
            else
            {
                txtValueDown.Text = DropLastChar(txtValueDown.Text);
                num2 = float.Parse(txtValueDown.Text);
                Convert(num2, ref num1, ref txtValueUp, ComboDown, ComboUp);
            }
        }
        private string DropLastChar(string text)
        {
            if (text.Length == 1)
                text = "0";
            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length - 1] == ',')
                    text = text.Remove(text.Length - 1, 1);
            }
            return text;
        }
        private void btn_up_click(object sender, RoutedEventArgs e)
        {
            flag = true;
            btn_up.IsEnabled = false;
            btn_down.IsEnabled = true;
        }
        private void btn_down_click(object sender, RoutedEventArgs e)
        {
            flag = false;
            btn_up.IsEnabled = true;
            btn_down.IsEnabled = false;
        }
        private void btn_plmi_click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                num1 *= -1;
                txtValueUp.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtValueDown.Text = num2.ToString();
            }
        }
        private void btn_dot_click(object sender, RoutedEventArgs e)
        {
            if (flag)
                SetDot(num1, ref txtValueUp);
            else
                SetDot(num2, ref txtValueDown);
        }
        private void SetDot(float num1, ref TextBox text)
        {
            if (text.Text.Contains('.'))
                return;
            text.Text += '.';
        }
        private void area()
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Acres", "Ares", "Hectares", "Square centimeters", "Square feet", "Square inches", "Square meters" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = false;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Acres";
        }
        private void area_click(object sender, RoutedEventArgs e) => area();
        private void length_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Millimeters", "Centimeters", "Meters", "Kilometers", "Inches", "Feet", "Yards", "Miles", "Nautical miles", "Mils" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = false;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Millimeters";
        }
        private void temp_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Celsius", "Fahrenheit", "Kelvin" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = false;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Celsius";
        }
        private void vol_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "UK gallons", "US gallons", "Liters", "Milliliters", "Cubic centimeters", "Cubic meters", "Cubic inches", "Cubic inches" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = false;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "UK gallons";
        }
        private void mass_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Tons", "UK tons", "US tons", "Pounds", "Ounces", "Kilograms", "Grams" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = false;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Tons";
        }
        private void data_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Bits", "Bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = false;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Bits";
        }
        private void speed_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Meters per second", "Meters per hour", "Kilometers per second", "Kilometers per hour", "Inches per second", "Inches per hour", "Feet per second", "Feet per hour", "Miles per second", "Miles per hour", "Knots" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = false;
            btn_time.IsEnabled = true;
            ComboUp.Text = ComboDown.Text = "Meters per second";
        }
        private void time_click(object sender, RoutedEventArgs e)
        {
            ComboUp.Items.Clear();
            ComboDown.Items.Clear();
            var arrstr = new string[] { "Milliseconds", "Seconds", "Minutes", "Hours", "Days", "Weeks" };
            foreach (var str in arrstr)
            {
                ComboUp.Items.Add(str);
                ComboDown.Items.Add(str);
            }
            btn_area.IsEnabled = true;
            btn_length.IsEnabled = true;
            btn_temperature.IsEnabled = true;
            btn_volume.IsEnabled = true;
            btn_mass.IsEnabled = true;
            btn_data.IsEnabled = true;
            btn_speed.IsEnabled = true;
            btn_time.IsEnabled = false;
            ComboUp.Text = ComboDown.Text = "Milliseconds";
        }
        private void Convert(float n1, ref float n2, ref TextBox txt, ComboBox combo1, ComboBox combo2)
        {
            if (btn_area.IsEnabled == false)
            {
                if (combo1.Text == "Acres")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1; break;
                        case "Ares": n2 = n1 * 40.468564224f; break;
                        case "Hectares": n2 = n1 * 0.4046856422f; break;
                        case "Square centimeters": n2 = n1 * 40468564.224f; break;
                        case "Square feet": n2 = n1 * 43560; break;
                        case "Square inches": n2 = n1 * 6272640; break;
                        case "Square meters": n2 = n1 * 4046.8564224f; break;
                    }
                }
                if (combo1.Text == "Ares")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 * 0.0247105381f; break;
                        case "Ares": n2 = n1; break;
                        case "Hectares": n2 = n1 * 0.01f; break;
                        case "Square centimeters": n2 = n1 * 1000000; break;
                        case "Square feet": n2 = n1 * 1076.391041671f; break;
                        case "Square inches": n2 = n1 * 155000.31000062f; break;
                        case "Square meters": n2 = n1 * 100; break;
                    }
                }
                if (combo1.Text == "Hectares")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 * 2.4710538147f; break;
                        case "Ares": n2 = n1 * 100; break;
                        case "Hectares": n2 = n1; break;
                        case "Square centimeters": n2 = n1 * 1000000000; break;
                        case "Square feet": n2 = n1 * 107639.1041671f; break;
                        case "Square inches": n2 = n1 * 15500031.000062f; break;
                        case "Square meters": n2 = n1 * 10000; break;
                    }
                }
                if (combo1.Text == "Square centimeters")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 / 40468564.224f; break;
                        case "Ares": n2 = n1 * 0.000001f; break;
                        case "Hectares": n2 = n1 / 1000000000; break;
                        case "Square centimeters": n2 = n1; break;
                        case "Square feet": n2 = n1 * 0.001076391f; break;
                        case "Square inches": n2 = n1 * 0.15500031f; break;
                        case "Square meters": n2 = n1 * 0.0001f; break;
                    }
                }
                if (combo1.Text == "Square feet")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 * 0.0000229568f; break;
                        case "Ares": n2 = n1 * 0.0009290304f; break;
                        case "Hectares": n2 = n1 * 0.0000092903f; break;
                        case "Square centimeters": n2 = n1 * 929.0304f; break;
                        case "Square feet": n2 = n1; break;
                        case "Square inches": n2 = n1 * 144; break;
                        case "Square meters": n2 = n1 * 0.09290304f; break;
                    }
                }
                if (combo1.Text == "Square inches")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 / 6272640; break;
                        case "Ares": n2 = n1 * 0.0000064516f; break;
                        case "Hectares": n2 = n1 / 15500031.000062f; break;
                        case "Square centimeters": n2 = n1 * 6.4516f; break;
                        case "Square feet": n2 = n1 * 0.0069444444f; break;
                        case "Square inches": n2 = n1; break;
                        case "Square meters": n2 = n1 * 0.00064516f; break;
                    }
                }
                if (combo1.Text == "Square meters")
                {
                    switch (combo2.Text)
                    {
                        case "Acres": n2 = n1 * 0.0002471054f; break;
                        case "Ares": n2 = n1 * 0.01f; break;
                        case "Hectares": n2 = n1 * 0.0001f; break;
                        case "Square centimeters": n2 = n1 * 10000; break;
                        case "Square feet": n2 = n1 * 10.7639104167f; break;
                        case "Square inches": n2 = n1 * 1550.0031000062f; break;
                        case "Square meters": n2 = n1; break;
                    }
                }
            }
            else if (btn_length.IsEnabled == false)
            {
                if (combo1.Text == "Millimeters")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1; break;
                        case "Centimeters": n2 = n1 * 0.1f; break;
                        case "Meters": n2 = n1 * 0.001f; break;
                        case "Kilometers": n2 = n1 * 0.000001f; break;
                        case "Inches": n2 = n1 * 0.0393700787f; break;
                        case "Feet": n2 = n1 * 0.0032808399f; break;
                        case "Yards": n2 = n1 * 0.0010936133f; break;
                        case "Miles": n2 = n1 / 1609344; break;
                        case "Nautical miles": n2 = n1 / 1852000; break;
                        case "Mils": n2 = n1 * 39.3700787402f; break;
                    }
                }
                if (combo1.Text == "Centimeters")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 10; break;
                        case "Centimeters": n2 = n1; break;
                        case "Meters": n2 = n1 * 0.01f; break;
                        case "Kilometers": n2 = n1 * 0.00001f; break;
                        case "Inches": n2 = n1 * 0.393700787f; break;
                        case "Feet": n2 = n1 * 0.032808399f; break;
                        case "Yards": n2 = n1 * 0.010936133f; break;
                        case "Miles": n2 = n1 * 0.0000062137f; break;
                        case "Nautical miles": n2 = n1 * 0.0000053996f; break;
                        case "Mils": n2 = n1 * 393.7007874016f; break;
                    }
                }
                if (combo1.Text == "Meters")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 1000; break;
                        case "Centimeters": n2 = n1 * 100; break;
                        case "Meters": n2 = n1; break;
                        case "Kilometers": n2 = n1 * 0.001f; break;
                        case "Inches": n2 = n1 * 39.3700787f; break;
                        case "Feet": n2 = n1 * 32.808399f; break;
                        case "Yards": n2 = n1 * 1.0936133f; break;
                        case "Miles": n2 = n1 * 0.00062137f; break;
                        case "Nautical miles": n2 = n1 * 0.00053996f; break;
                        case "Mils": n2 = n1 * 39370.078740157f; break;
                    }
                }
                if (combo1.Text == "Kilometers")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 1000000; break;
                        case "Centimeters": n2 = n1 * 100000; break;
                        case "Meters": n2 = n1 * 1000; break;
                        case "Kilometers": n2 = n1; break;
                        case "Inches": n2 = n1 * 39370.078740157f; break;
                        case "Feet": n2 = n1 * 3280.8398950131f; break;
                        case "Yards": n2 = n1 * 1093.613298337f; break;
                        case "Miles": n2 = n1 * 0.6213711922f; break;
                        case "Nautical miles": n2 = n1 * 0.5399568035f; break;
                        case "Mils": n2 = n1 * 39370078.740157f; break;
                    }
                }
                if (combo1.Text == "Inches")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 25.4f; break;
                        case "Centimeters": n2 = n1 * 2.54f; break;
                        case "Meters": n2 = n1 * 0.0254f; break;
                        case "Kilometers": n2 = n1 * 0.0000254f; break;
                        case "Inches": n2 = n1; break;
                        case "Feet": n2 = n1 * 0.0833333333f; break;
                        case "Yards": n2 = n1 * 0.0277777778f; break;
                        case "Miles": n2 = n1 * 0.0000157828f; break;
                        case "Nautical miles": n2 = n1 * 0.0000137149f; break;
                        case "Mils": n2 = n1 * 1000; break;
                    }
                }
                if (combo1.Text == "Feet")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 304.8f; break;
                        case "Centimeters": n2 = n1 * 30.48f; break;
                        case "Meters": n2 = n1 * 0.3048f; break;
                        case "Kilometers": n2 = n1 * 0.0003048f; break;
                        case "Inches": n2 = n1 * 12; break;
                        case "Feet": n2 = n1; break;
                        case "Yards": n2 = n1 * 0.33333333333f; break;
                        case "Miles": n2 = n1 * 0.0001893939f; break;
                        case "Nautical miles": n2 = n1 * 0.0001645788f; break;
                        case "Mils": n2 = n1 * 12000; break;
                    }
                }
                if (combo1.Text == "Yards")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 914.4f; break;
                        case "Centimeters": n2 = n1 * 91.44f; break;
                        case "Meters": n2 = n1 * 0.9144f; break;
                        case "Kilometers": n2 = n1 * 0.0009144f; break;
                        case "Inches": n2 = n1 * 36; break;
                        case "Feet": n2 = n1 * 3; break;
                        case "Yards": n2 = n1; break;
                        case "Miles": n2 = n1 * 0.0005691818f; break;
                        case "Nautical miles": n2 = n1 * 0.0004937365f; break;
                        case "Mils": n2 = n1 * 36000; break;
                    }
                }
                if (combo1.Text == "Miles")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 1609344f; break;
                        case "Centimeters": n2 = n1 * 160934.4f; break;
                        case "Meters": n2 = n1 * 1609.344f; break;
                        case "Kilometers": n2 = n1 * 1.609344f; break;
                        case "Inches": n2 = n1 * 63360; break;
                        case "Feet": n2 = n1 * 5280; break;
                        case "Yards": n2 = n1 * 1760; break;
                        case "Miles": n2 = n1; break;
                        case "Nautical miles": n2 = n1 * 0.8689762419f; break;
                        case "Mils": n2 = n1 * 63360000; break;
                    }
                }
                if (combo1.Text == "Nautical miles")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 1852000; break;
                        case "Centimeters": n2 = n1 * 185200; break;
                        case "Meters": n2 = n1 * 1852; break;
                        case "Kilometers": n2 = n1 * 1.852f; break;
                        case "Inches": n2 = n1 * 72913.385826772f; break;
                        case "Feet": n2 = n1 * 6076.1154855643f; break;
                        case "Yards": n2 = n1 * 2025.3718285214f; break;
                        case "Miles": n2 = n1 * 1.150779448f; break;
                        case "Nautical miles": n2 = n1; break;
                        case "Mils": n2 = n1 * 72913385826772; break;
                    }
                }
                if (combo1.Text == "Nautical miles")
                {
                    switch (combo2.Text)
                    {
                        case "Millimeters": n2 = n1 * 0.0254f; break;
                        case "Centimeters": n2 = n1 * 0.00254f; break;
                        case "Meters": n2 = n1 * 0.0000254f; break;
                        case "Kilometers": n2 = n1 / 39370078.740157f; break;
                        case "Inches": n2 = n1 * 0.001f; break;
                        case "Feet": n2 = n1 * 0.0000833333f; break;
                        case "Yards": n2 = n1 * 0.0000277778f; break;
                        case "Miles": n2 = n1 / 63360000; break;
                        case "Nautical miles": n2 = n1 / 72913385826772; break;
                        case "Mils": n2 = n1; break;
                    }
                }
            }
            else if (btn_temperature.IsEnabled == false)
            {
                if (combo1.Text == "Celsius")
                {
                    switch (combo2.Text)
                    {
                        case "Celsius": n2 = n1; break;
                        case "Fahrenheit": n2 = n1 * 32 + 1.8f; break;
                        case "Kelvin": n2 = n1 + 273.15f; break;
                    }
                }
                if (combo1.Text == "Fahrenheit")
                {
                    switch (combo2.Text)
                    {
                        case "Celsius": n2 = (n1 - 32) / 1.8f; break;
                        case "Fahrenheit": n2 = n1; break;
                        case "Kelvin": n2 = (n1 - 32) * 5 / 9 + 273.15f; break;
                    }
                }
                if (combo1.Text == "Kelvin")
                {
                    switch (combo2.Text)
                    {
                        case "Celsius": n2 = n1 - 273.15f; break;
                        case "Fahrenheit": n2 = (n1 - 32) * 9 / 5 + 32; break;
                        case "Kelvin": n2 = n1; break;
                    }
                }
            }
            else if (btn_volume.IsEnabled == false)
            {
                if (combo1.Text == "UK gallons")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1; break;
                        case "US gallons": n2 = n1 * 1.2009499255f; break;
                        case "Liters": n2 = n1 * 4.54609f; break;
                        case "Milliliters": n2 = n1 * 4546.09f; break;
                        case "Cubic centimeters": n2 = n1 * 4546.09f; break;
                        case "Cubic meters": n2 = n1 * 0.00454609f; break;
                        case "Cubic inches": n2 = n1 * 277.4194327916f; break;
                        case "Cubic feet": n2 = n1 * 0.16055436532f; break;
                    }
                }
                if (combo1.Text == "US gallons")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 0.8326741846f; break;
                        case "US gallons": n2 = n1; break;
                        case "Liters": n2 = n1 * 3.785411784f; break;
                        case "Milliliters": n2 = n1 * 3785.411784f; break;
                        case "Cubic centimeters": n2 = n1 * 3785.411784f; break;
                        case "Cubic meters": n2 = n1 * 0.0037854118f; break;
                        case "Cubic inches": n2 = n1 * 231; break;
                        case "Cubic feet": n2 = n1 * 0.1336805556f; break;
                    }
                }
                if (combo1.Text == "Liters")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 0.2199692483f; break;
                        case "US gallons": n2 = n1 * 0.2641720524f; break;
                        case "Liters": n2 = n1; break;
                        case "Milliliters": n2 = n1 * 1000; break;
                        case "Cubic centimeters": n2 = n1 * 1000; break;
                        case "Cubic meters": n2 = n1 * 0.001f; break;
                        case "Cubic inches": n2 = n1 * 61.0237440947f; break;
                        case "Cubic feet": n2 = n1 * 0.0353146667f; break;
                    }
                }
                if (combo1.Text == "Milliliters" || combo1.Text == "Cubic centimeters")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 0.0002199692f; break;
                        case "US gallons": n2 = n1 * 0.0002641721f; break;
                        case "Liters": n2 = n1 * 0.0001f; break;
                        case "Milliliters": n2 = n1; break;
                        case "Cubic centimeters": n2 = n1; break;
                        case "Cubic meters": n2 = n1 * 0.000001f; break;
                        case "Cubic inches": n2 = n1 * 0.0610237441f; break;
                        case "Cubic feet": n2 = n1 * 0.0000353147f; break;
                    }
                }
                if (combo1.Text == "Cubic meters")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 219.9692482991f; break;
                        case "US gallons": n2 = n1 * 264.1720523581f; break;
                        case "Liters": n2 = n1 * 1000; break;
                        case "Milliliters": n2 = n1 * 1000000; break;
                        case "Cubic centimeters": n2 = n1 * 1000000; break;
                        case "Cubic meters": n2 = n1; break;
                        case "Cubic inches": n2 = n1 * 61023.744094732f; break;
                        case "Cubic feet": n2 = n1 * 35.3146667215f; break;
                    }
                }
                if (combo1.Text == "Cubic inches")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 0.0036046501f; break;
                        case "US gallons": n2 = n1 * 0.0043290043f; break;
                        case "Liters": n2 = n1 * 0.016387064f; break;
                        case "Milliliters": n2 = n1 * 16.387064f; break;
                        case "Cubic centimeters": n2 = n1 * 16.387064f; break;
                        case "Cubic meters": n2 = n1 * 0.0000163871f; break;
                        case "Cubic inches": n2 = n1; break;
                        case "Cubic feet": n2 = n1 * 0.0005787037f; break;
                    }
                }
                if (combo1.Text == "Cubic feet")
                {
                    switch (combo2.Text)
                    {
                        case "UK gallons": n2 = n1 * 6.228835459f; break;
                        case "US gallons": n2 = n1 * 7.4805194805f; break;
                        case "Liters": n2 = n1 * 28.316846592f; break;
                        case "Milliliters": n2 = n1 * 28316.846592f; break;
                        case "Cubic centimeters": n2 = n1 * 28316.846592f; break;
                        case "Cubic meters": n2 = n1 * 0.0283168466f; break;
                        case "Cubic inches": n2 = n1 * 1728; break;
                        case "Cubic feet": n2 = n1; break;
                    }
                }
            }
            else if(btn_mass.IsEnabled == false)
            {

            }
            else if(btn_data.IsEnabled == false)
            {

            }
            else if(btn_speed.IsEnabled == false)
            {

            }
            else if(btn_time.IsEnabled == false)
            {

            }
            txt.Text = n2.ToString();
        }
    }
}
