using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
namespace WpfApp2.Other_modes
{
    public partial class Scientific : Window
    {

        float num1 = 0;
        float num2 = 0;
        string op = "";
        string mode = "dark";
        public Scientific(string nmode, float n1, float n2, string oper)
        {
            InitializeComponent();
            mode = nmode;
            num1 = n1;
            num2 = n2;
            op = oper;
            txtValue.Text = n1 == 0 ? num2.ToString() : num1.ToString();
            DarkLight();
        }
        private void ModeStandart(object sender, RoutedEventArgs e)
        {
            MainWindow standart = new MainWindow(mode, num1, num2, op);
            standart.Show();
            this.Close();
        }
        private void ModeProgrammer(object sender, RoutedEventArgs e)
        {
            Other_modes.Programmer programmer = new Other_modes.Programmer(mode, (int)num1, (int)num2, op);
            programmer.Show();
            this.Close();
        }
        private void DarkLight()
        {
            if (mode == "light")
                Lightmode();
            else Darkmode();
        }
        private void DarkLight(object sender, RoutedEventArgs e)
        {
            if (DLmode.Header.ToString() == "Light mode")
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
            btn_min_max.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_pow.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mult.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_percent.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_1x.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_abs.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_avg.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_cos.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_cot.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_ex.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_exp.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_fact.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_ln.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_log.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mod.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_pi.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_sin.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_tan.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
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
            btn_min_max.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_pow.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_1x.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_abs.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_avg.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_cos.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_cot.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_ex.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_exp.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_fact.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_ln.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_log.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mod.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_pi.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_sin.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_tan.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
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
            DLmode.Style = (Style)Application.Current.Resources["MenuItemDark"];
        }
        private void ClickHistory(object sender, RoutedEventArgs e)
        {
            Calculator.History history = new Calculator.History(mode);
            history.Show();
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
        private void btn_sin_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("sin(" + num1.ToString() + ")=");
                num1 = (float)Math.Sin(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "sin(" + num2.ToString() + ")=");
                num2 = (float)Math.Sin(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_cos_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("cos(" + num1.ToString() + ")=");
                num1 = (float)Math.Cos(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "cos(" + num2.ToString() + ")=");
                num2 = (float)Math.Cos(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_tan_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("tan(" + num1.ToString() + ")=");
                num1 = (float)(Math.Sin(num1) / Math.Cos(num1));
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "tan(" + num2.ToString() + ")=");
                num2 = (float)(Math.Sin(num2) / Math.Cos(num2));
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_cot_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("cot(" + num1.ToString() + ")=");
                num1 = (float)(Math.Cos(num1) / Math.Sin(num1));
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "cot(" + num2.ToString() + ")=");
                num2 = (float)(Math.Cos(num2) / Math.Sin(num2));
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_log_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("log(" + num1.ToString() + ")=");
                num1 = (float)Math.Log10(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "log(" + num2.ToString() + ")=");
                num2 = (float)Math.Log10(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_ln_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("ln(" + num1.ToString() + ")=");
                num1 = (float)Math.Log(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "ln(" + num2.ToString() + ")=");
                num2 = (float)Math.Log(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_1x_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("1/" + num1.ToString() + "=");
                num1 = 1 / num1;
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "1/" + num2.ToString() + "=");
                num2 = 1 / num2;
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private int Factorial(int num)
        {
            if (num > 1)
                return num * Factorial(num - 1);
            else
                return 1;
        }
        private void btn_fact_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine(num1.ToString() + "!=");
                num1 = Factorial((int)num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + num2.ToString() + "!=");
                num2 = Factorial((int)num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void Result(ref float result)
        {
            if (op == "min/max")
            {
                txtValue.Text = "Max: " + Math.Max(num1, num2).ToString() + " Min: " + Math.Min(num1, num2).ToString();
                WriteNewLine(txtValue.Text);
            }
            else if(op=="avg")
            {
                result = (num1 + num2) / 2f;
                txtValue.Text = result.ToString();
                WriteNewLine("(" + num1.ToString() + "+" + num2.ToString() + ")/2=" + result.ToString());
            }
            else
            {
                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = num1 / num2; break;
                    case "^": result = (float)Math.Pow(num1, num2); break;
                    case "mod": result = (float)((int)num1 % (int)num2); break;
                }
            }
        }
        private void btn_eqs_Click(object sender, RoutedEventArgs e)//метод для розрахування результату
        {
            float result = 0;
            Result(ref result);
            if (op != "min/max" && op != "avg")
            {
                txtValue.Text = result.ToString();
                WriteNewLine(num1.ToString() + op + num2.ToString() + "=" + result.ToString());
            }
            op = "";
            num1 = result;
            num2 = 0;
        }
        private void btn_C_Click(object sender, RoutedEventArgs e)//метод обох чисел
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtValue.Text = "0";
        }
        private void btn_CE_Click(object sender, RoutedEventArgs e)//метод першого, або другого числа
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
                if (text[text.Length - 1] == ',')
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
        private void btn_pi_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine((num1 == 0 ? "π=" : num1.ToString() + "π="));
                num1 = num1 == 0 ? (float)Math.E : num1 * (float)Math.E;
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + (num2 == 0 ? "π=" : num2.ToString() + "π="));
                num2 = num2 == 0 ? (float)Math.PI : num2 * (float)Math.PI;
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_exp_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine((num1 == 0 ? "e=" : num1.ToString() + "e="));
                num1 = num1 == 0 ? (float)Math.E : num1 * (float)Math.E;
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op  + (num2 == 0 ? "e=" : num2.ToString() + "e="));
                num2 = num2 == 0 ? (float)Math.E : num2 * (float)Math.E;
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("Sqrt(" + num1.ToString() + ")=");
                num1 = (float)Math.Sqrt(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "Sqrt(" + num2.ToString() + ")=");
                num2 = (float)Math.Sqrt(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_perc_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine(num1.ToString() + "%=");
                num1 /= 100.0f;
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + num2.ToString() + "%=");
                num2 = (num1 * num2) / 100.0f;
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("mod(" + num1.ToString() + ")=");
                num1 = (float)Math.Abs(num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "mod(" + num2.ToString() + ")=");
                num2 = (float)Math.Abs(num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
            }
        }
        private void btn_ex_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                WriteNewLine("e^" + num1.ToString() + "=");
                num1 = (float)Math.Pow((float)Math.E, num1);
                Write(num1.ToString());
                txtValue.Text = num1.ToString();
            }
            else
            {
                float result = 0;
                WriteNewLine(num1.ToString() + op + "e^" + num2.ToString() + "=");
                num2 = (float)Math.Pow((float)Math.E, num2);
                Result(ref result);
                txtValue.Text = result.ToString();
                Write(result.ToString());
                op = "";
                num1 = result;
                num2 = 0;
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