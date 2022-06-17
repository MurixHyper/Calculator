using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        float num1 = 0;
        float num2 = 0;
        string op = "";
        string mode ="dark";
        public MainWindow() => InitializeComponent();
        public MainWindow(string nmode, float n1, float n2, string oper)
        {
            InitializeComponent();
            mode = nmode;
            num1 = n1;
            num2 = n2;
            op = oper;
            txtValue.Text = n1 == 0 ? num2.ToString() : num1.ToString();
            DarkLight();
        }
        private void ModeScientific(object sender, RoutedEventArgs e)
        {
            Other_modes.Scientific sceintific = new Other_modes.Scientific(mode, num1, num2, op);
            sceintific.Show();
            this.Close();     
        }
        private void ModeProgrammer(object sender, RoutedEventArgs e)
        {
            Other_modes.Programmer programmer = new Other_modes.Programmer(mode, (int)num1, (int)num2, op);
            programmer.Show();
            this.Close();
        }
        private void ModeConverter(object sender, RoutedEventArgs e)
        {
            Calculator.Converter converter = new Calculator.Converter(mode);
            converter.Show();
            this.Close();
        }
        private void ClickHistory(object sender, RoutedEventArgs e)
        {
            Calculator.History history = new Calculator.History(mode);
            history.Show();
            
        }
        private void DarkLight(object sender, RoutedEventArgs e)
        {
            if (DLmode.Header.ToString() == "Light mode")
                Lightmode();
            else Darkmode();
        }
        private void DarkLight()
        {
            if (mode == "light")
                Lightmode();
            else Darkmode();
        }
        private void Lightmode()
        {
            mode = "light";
            DLmode.Header = "Dark mode";
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FFFFFF");
            grid.Background = brush;
            btn_0.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_1.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_2.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_3.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_4.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_5.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_6.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_7.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_8.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_9.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_plmi.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_plus.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_dot.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_minmax.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_pow.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mult.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_percent.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_sqrt.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_C.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            btn_CE.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            btn_back.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            txtValue.Style = (Style)Application.Current.Resources["TextBoxLight"];
            menu.Style = (Style)Application.Current.Resources["MenuLight"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem3.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem4.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem5.Style = (Style)Application.Current.Resources["MenuItemLight"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemLight"];
        }
        private void Darkmode()
        {
            mode = "dark";
            DLmode.Header = "Light mode";
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#000000");
            grid.Background = brush;
            btn_0.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_1.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_2.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_3.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_4.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_5.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_6.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_7.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_8.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_9.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_plmi.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_plus.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_dot.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_minmax.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_pow.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mult.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_percent.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_sqrt.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_C.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            btn_CE.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            btn_back.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            txtValue.Style = (Style)Application.Current.Resources["TextBoxDark"];
            menu.Style = (Style)Application.Current.Resources["MenuDark"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem3.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem4.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem5.Style = (Style)Application.Current.Resources["MenuItemDark"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemDark"];
        }
        private void WriteNewLine(string str)
        {
            File.AppendAllText("History.txt", Environment.NewLine);
            File.AppendAllText("History.txt", str);
        }
        private void Write(string str) => File.AppendAllText("History.txt", str);
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string num = button.Content.ToString();
            if (txtValue.Text == "0")
                txtValue.Text = num;
            else
                txtValue.Text += num;
            if (op == "")
                num1 = float.Parse(txtValue.Text);
            else
                num2 = float.Parse(txtValue.Text);
        }
        private void btn_op_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValue.Text = "0";
        }
        private void Result(ref float result)
        {
            if (op != "min/max")
                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = num1 / num2; break;
                    case "^": result = (float)Math.Pow(num1, num2); break;
                    case "mod": result = (float)((int)num1 % (int)num2); break;
                }
            else
            {
                txtValue.Text = "Max: " + Math.Max(num1, num2).ToString() + " Min: " + Math.Min(num1, num2).ToString();
                WriteNewLine(txtValue.Text);
            }
        }
        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("Sqrt(" + num1.ToString() + ")=" + ((float)Math.Sqrt(num1)).ToString());
                num1 = (float)Math.Sqrt(num1);
                txtValue.Text = num1.ToString();
            }
            else
            {
                WriteNewLine("Sqrt(" + num2.ToString() + ")=" + ((float)Math.Sqrt(num2)).ToString());
                num2 = (float)Math.Sqrt(num2);
                txtValue.Text = num2.ToString();
            }
        }
        private void btn_perc_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine(num1.ToString() + "%=" + (num1 / 100.0f).ToString());
                num1 /= 100.0f;
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + num2.ToString() + "%=");
                num2 =(num1 * num2) / 100.0f;
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_eqs_Click(object sender, RoutedEventArgs e)
        {
            float result = 0;
            Result(ref result);
            txtValue.Text = result.ToString();
            WriteNewLine(num1.ToString() + op + num2.ToString() + "=" + result.ToString());
            op = "";
            num1 = result;
            num2 = 0;
        }
        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtValue.Text = "0";
        }
        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                num1 = 0;
            else num2 = 0;
            txtValue.Text = "0";
        }
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = DropLastChar(txtValue.Text);
            if (op == "")
                num1 = float.Parse(txtValue.Text);
            else
                num2 = float.Parse(txtValue.Text);
        }
        private string DropLastChar(string text)
        {
            if (text.Length == 1)
                text = "0";
            else
            {
                text = text.Remove(text.Length - 1, 1);
                if (text[text.Length-1]==',')
                    text = text.Remove(text.Length - 1, 1);
            }
            return text;
        }
        private void btn_plmi_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 *= -1;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtValue.Text = num2.ToString();
            }
        }
        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                SetDot(num1);
            else
                SetDot(num2);
        }
        private void SetDot(float num1)
        {
            if (txtValue.Text.Contains('.'))
                return;
            txtValue.Text += '.';
        }
    }
}
