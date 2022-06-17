using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
namespace WpfApp2.Other_modes
{
    /// <summary>
    /// Логика взаимодействия для Programmer.xaml
    /// </summary>
    public partial class Programmer : Window
    {
        string mode="dec";
        string num1_hex;
        string num2_hex;
        int num1_dec;
        int num2_dec;
        string num1_oct;
        string num2_oct;
        string num1_bin;
        string num2_bin;
        string op = "";
        string mode1 = "dark";
        public Programmer(string nmode, int n1, int n2, string oper)
        {
            InitializeComponent();
            btn_A.IsEnabled = false;
            btn_B.IsEnabled = false;
            btn_C.IsEnabled = false;
            btn_D.IsEnabled = false;
            btn_E.IsEnabled = false;
            btn_F.IsEnabled = false;
            mode1 = nmode;
            num1_dec = n1;
            num2_dec = n2;
            num1_hex = dec_to_hex(n1);
            num2_hex = dec_to_hex(n2);
            num1_oct = dec_to_oct(n1);
            num2_oct = dec_to_oct(n2);
            num1_bin = dec_to_bin(n1);
            num2_bin = dec_to_bin(n2);
            txtValueHex.Text = n1 == 0 ? num2_hex : num1_hex;
            txtValueDec.Text = n1 == 0 ? num2_dec.ToString() : num1_dec.ToString();
            txtValueOct.Text = n1 == 0 ? num2_oct : num1_oct;
            txtValueBin.Text = n1 == 0 ? num2_bin : num1_bin;
            op = oper;
            DarkLight();
        }
        private void DarkLight(object sender, RoutedEventArgs e)
        {
            if (DLmode.Header.ToString() == "Light mode")
                Lightmode();
            else Darkmode();
        }
        private void DarkLight()
        {
            if (mode1 == "light")
                Lightmode();
            else Darkmode();
        }
        private void Lightmode()
        {
            mode1 = "light";
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
            btn_A.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_B.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_C.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_D.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_E.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_F.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_plus.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_mult.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumLight"];
            btn_Clear.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            btn_CE.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            btn_back.Style = (Style)Application.Current.Resources["ButtonClearLight"];
            txtValueHex.Style = (Style)Application.Current.Resources["TextBoxLight"];
            txtValueDec.Style = (Style)Application.Current.Resources["TextBoxLight"];
            txtValueOct.Style = (Style)Application.Current.Resources["TextBoxLight"];
            txtValueBin.Style = (Style)Application.Current.Resources["TextBoxLight"];
            menu.Style = (Style)Application.Current.Resources["MenuLight"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem3.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem4.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem5.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem6.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem7.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem8.Style = (Style)Application.Current.Resources["MenuItemLight"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemLight"];
            empty1.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty2.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty3.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty4.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty5.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty6.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty7.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty8.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty9.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
            empty10.Style = (Style)Application.Current.Resources["EmptyButtonLight"];
        }
        private void Darkmode()
        {
            mode1 = "dark";
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
            btn_A.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_B.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_C.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_D.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_E.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_F.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_plus.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mi.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_mult.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_div.Style = (Style)Application.Current.Resources["ButtonOpNumDark"];
            btn_Clear.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            btn_CE.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            btn_back.Style = (Style)Application.Current.Resources["ButtonClearDark"];
            txtValueHex.Style = (Style)Application.Current.Resources["TextBoxDark"];
            txtValueDec.Style = (Style)Application.Current.Resources["TextBoxDark"];
            txtValueOct.Style = (Style)Application.Current.Resources["TextBoxDark"];
            txtValueBin.Style = (Style)Application.Current.Resources["TextBoxDark"];
            menu.Style = (Style)Application.Current.Resources["MenuDark"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem3.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem4.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem5.Style = (Style)Application.Current.Resources["MenuItemDarl"];
            menuitem6.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem7.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem8.Style = (Style)Application.Current.Resources["MenuItemDark"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemDark"];
            empty1.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty2.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty3.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty4.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty5.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty6.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty7.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty8.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty9.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
            empty10.Style = (Style)Application.Current.Resources["EmptyButtonDark"];
        }
        //переключення на звичайний калькулятор
        private void ModeStandart(object sender, RoutedEventArgs e)
        {
            MainWindow standart = new MainWindow(mode1, num1_dec, num2_dec, op);
            standart.Show();
            this.Close();
        }
        //переключення на науковий калькулятор
        private void ModeScientific(object sender, RoutedEventArgs e)
        {
            Other_modes.Scientific sceintific = new Other_modes.Scientific(mode1, num1_dec, num2_dec, op);
            sceintific.Show();
            this.Close();
        }
        //відкриття історії обчислень
        private void ClickHistory(object sender, RoutedEventArgs e)
        {
            Calculator.History history = new Calculator.History(mode1);
            history.Show();
        }
        //метод запису у файл на новій строкі
        private void WriteNewLine(string str)
        {
            File.AppendAllText("History.txt", Environment.NewLine);
            File.AppendAllText("History.txt", str);
        }
        //метод запису у файл на тій же строкі
        private void Write(string str)
        {
            File.AppendAllText("History.txt", str);
        }
        //переключення на 16у систему
        private void hex(object sender, RoutedEventArgs e)
        {
            mode = "hex";
            btn_A.IsEnabled = true;
            btn_B.IsEnabled = true;
            btn_C.IsEnabled = true;
            btn_D.IsEnabled = true;
            btn_E.IsEnabled = true;
            btn_F.IsEnabled = true;
            btn_0.IsEnabled = true;
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;
            btn_4.IsEnabled = true;
            btn_5.IsEnabled = true;
            btn_6.IsEnabled = true;
            btn_7.IsEnabled = true;
            btn_8.IsEnabled = true;
            btn_9.IsEnabled = true;
        }
        //переключення на 10у систему
        private void dec(object sender, RoutedEventArgs e)
        {
            
            mode = "dec";
            btn_A.IsEnabled = false;
            btn_B.IsEnabled = false;
            btn_C.IsEnabled = false;
            btn_D.IsEnabled = false;
            btn_E.IsEnabled = false;
            btn_F.IsEnabled = false;
            btn_0.IsEnabled = true;
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;
            btn_4.IsEnabled = true;
            btn_5.IsEnabled = true;
            btn_6.IsEnabled = true;
            btn_7.IsEnabled = true;
            btn_8.IsEnabled = true;
            btn_9.IsEnabled = true;
        }
        //переключення на 8у систему
        private void oct(object sender, RoutedEventArgs e)
        {
            mode = "oct";
            btn_A.IsEnabled = false;
            btn_B.IsEnabled = false;
            btn_C.IsEnabled = false;
            btn_D.IsEnabled = false;
            btn_E.IsEnabled = false;
            btn_F.IsEnabled = false;
            btn_0.IsEnabled = true;
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;
            btn_4.IsEnabled = true;
            btn_5.IsEnabled = true;
            btn_6.IsEnabled = true;
            btn_7.IsEnabled = true;
            btn_8.IsEnabled = false;
            btn_9.IsEnabled = false;
        }
        //переключення на 2у систему
        private void bin(object sender, RoutedEventArgs e)
        {
            mode = "bin";
            btn_A.IsEnabled = false;
            btn_B.IsEnabled = false;
            btn_C.IsEnabled = false;
            btn_D.IsEnabled = false;
            btn_E.IsEnabled = false;
            btn_F.IsEnabled = false;
            btn_0.IsEnabled = true;
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = false;
            btn_3.IsEnabled = false;
            btn_4.IsEnabled = false;
            btn_5.IsEnabled = false;
            btn_6.IsEnabled = false;
            btn_7.IsEnabled = false;
            btn_8.IsEnabled = false;
            btn_9.IsEnabled = false;
        }
        //метод для переводу з 10ї у 16у систему
        private string dec_to_hex(int dec) => dec.ToString("X");
        //метод для переводу з 10ї у 8у систему
        private string dec_to_oct(int dec) => Convert.ToString(dec, 8);
        //метод для переводу з 10ї у 2у систему
        private string dec_to_bin(int dec) => Convert.ToString(dec, 2);
        //метод для переводу з 16ї у 10у систему
        private int hex_to_dec(string hex) => Convert.ToInt32(hex, 16);
        //метод для переводу з 8ї у 10у систему
        private int oct_to_dec(string oct) => Convert.ToInt32(oct, 8);
        //метод для переводу з 2ї у 10у систему
        private int bin_to_dec(string bin) => Convert.ToInt32(bin, 2);
        //метод вводу цифри у число
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string num = button.Content.ToString();
            switch(mode)
            {
                case "hex": txtValueHex.Text = txtValueHex.Text == "0" ? num : txtValueHex.Text + num; break;
                case "dec": txtValueDec.Text = txtValueDec.Text == "0" ? num : txtValueDec.Text + num; break;
                case "oct": txtValueOct.Text = txtValueOct.Text == "0" ? num : txtValueOct.Text + num; break;
                case "bin": txtValueBin.Text = txtValueBin.Text == "0" ? num : txtValueBin.Text + num; break;
                default: break;
            } 
            if (op == "")
            {
                switch (mode)
                {
                    case "hex": num1_hex = txtValueHex.Text; break;
                    case "dec": num1_dec = int.Parse(txtValueDec.Text); break;
                    case "oct": num1_oct = txtValueOct.Text; break;
                    case "bin": num1_bin = txtValueBin.Text; break;
                    default: break;
                }
            }
            else
            {
                switch (mode)
                {
                    case "hex": num2_hex = txtValueHex.Text; break;
                    case "dec": num2_dec = int.Parse(txtValueDec.Text); break;
                    case "oct": num2_oct = txtValueOct.Text; break;
                    case "bin": num2_bin = txtValueBin.Text; break;
                    default: break;
                }
            }
        }
        //метод обчислення результату(допоміжний метод для btn_eqs_Click(object, RoutedEventArgs))
        private void Calculating(int num1, int num2)
        {
            int result = 0;
            switch(op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num1 / num2; break;
                default:break;
            }
            txtValueHex.Text = dec_to_hex(result);
            txtValueDec.Text = result.ToString();
            txtValueOct.Text = dec_to_oct(result);
            txtValueBin.Text = dec_to_bin(result);
            WriteNewLine("Hex: " + dec_to_hex(num1) + op + dec_to_hex(num2) + "=" + dec_to_hex(result));
            WriteNewLine("Dec: " + num1.ToString() + op + num2.ToString() + "=" + result.ToString());
            WriteNewLine("Oct: " + dec_to_oct(num1) + op + dec_to_oct(num2) + "=" + dec_to_oct(result));
            WriteNewLine("Bin: " + dec_to_bin(num1) + op + dec_to_bin(num2) + "=" + dec_to_bin(result));
            num1_dec = result;
            num1_hex = dec_to_hex(result);
            num1_oct = dec_to_oct(result);
            num1_bin = dec_to_bin(result);

            num2_dec = 0;
            num2_hex = "0";
            num2_oct = "0";
            num2_bin = "0";
            op = "";
        }
        //метод оберання операції
        private void btn_op_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValueHex.Text = "0";
            txtValueDec.Text = "0";
            txtValueOct.Text = "0";
            txtValueBin.Text = "0";
        }
        //метод для розрахування результату
        private void btn_eqs_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                switch (mode)
                {
                    case "hex":
                        txtValueDec.Text = hex_to_dec(txtValueHex.Text).ToString();
                        txtValueOct.Text = dec_to_oct(hex_to_dec(txtValueHex.Text));
                        txtValueBin.Text = dec_to_bin(hex_to_dec(txtValueHex.Text));
                        WriteNewLine("Hex: " + txtValueHex.Text);
                        WriteNewLine("Dec: " + hex_to_dec(txtValueHex.Text).ToString());
                        WriteNewLine("Oct: " + dec_to_oct(hex_to_dec(txtValueHex.Text)));
                        WriteNewLine("Bin: " + dec_to_bin(hex_to_dec(txtValueHex.Text)));
                        break;
                    case "dec":
                        txtValueHex.Text = dec_to_hex(int.Parse(txtValueDec.Text));
                        txtValueOct.Text = dec_to_oct(int.Parse(txtValueDec.Text));
                        txtValueBin.Text = dec_to_bin(int.Parse(txtValueDec.Text));
                        WriteNewLine("Hex: " + dec_to_hex(int.Parse(txtValueDec.Text)));
                        WriteNewLine("Dec: " + txtValueDec.Text);
                        WriteNewLine("Oct: " + dec_to_oct(int.Parse(txtValueDec.Text)));
                        WriteNewLine("Bin: " + dec_to_bin(int.Parse(txtValueDec.Text)));
                        break;
                    case "oct":
                        txtValueHex.Text = dec_to_hex(oct_to_dec(txtValueOct.Text));
                        txtValueDec.Text = oct_to_dec(txtValueOct.Text).ToString();
                        txtValueBin.Text = dec_to_bin(oct_to_dec(txtValueOct.Text));
                        WriteNewLine("Hex: " + dec_to_hex(oct_to_dec(txtValueOct.Text)));
                        WriteNewLine("Dec: " + oct_to_dec(txtValueOct.Text).ToString());
                        WriteNewLine("Oct: " + txtValueOct.Text);
                        WriteNewLine("Bin: " + dec_to_bin(oct_to_dec(txtValueOct.Text)));
                        break;
                    case "bin":
                        txtValueHex.Text = dec_to_hex(bin_to_dec(txtValueBin.Text));
                        txtValueDec.Text = bin_to_dec(txtValueBin.Text).ToString();
                        txtValueOct.Text = dec_to_oct(bin_to_dec(txtValueBin.Text));
                        WriteNewLine("Hex: " + dec_to_hex(bin_to_dec(txtValueBin.Text)));
                        WriteNewLine("Dec: " + bin_to_dec(txtValueBin.Text).ToString());
                        WriteNewLine("Oct: " + dec_to_oct(bin_to_dec(txtValueBin.Text)));
                        WriteNewLine("Bin: " + txtValueBin);
                        break;
                    default: break;
                }
            }
            else
            {
                switch (mode)
                {
                    case "hex": Calculating(hex_to_dec(num1_hex), hex_to_dec(num2_hex)); break;
                    case "dec": Calculating(num1_dec, num2_dec); break;
                    case "oct": Calculating(oct_to_dec(num1_oct), oct_to_dec(num2_oct)); break;
                    case "bin": Calculating(bin_to_dec(num1_bin), bin_to_dec(num2_bin)); break;
                    default: break;

                }
            }
        }
        //допоміжний метод для btn_Clear_Click(object, RoutedEventArgs)
        private void Clear()
        {
            num1_hex = "0";
            num1_dec = 0;
            num1_oct = "0";
            num1_bin = "0";
            num2_hex = "0";
            num2_dec = 0;
            num2_oct = "0";
            num2_bin = "0";
            op = "";
            txtValueHex.Text = "0";
            txtValueDec.Text = "0";
            txtValueOct.Text = "0";
            txtValueBin.Text = "0";
        }
        //метод стирання обох чисел та операції
        private void btn_Clear_Click(object sender, RoutedEventArgs e) => Clear();
        //метод стирання першого, або другого числа
        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1_hex = "0";
                num1_dec = 0;
                num1_oct = "0";
                num1_bin = "0";
            }
            else
            {
                num2_hex = "0";
                num2_dec = 0;
                num2_oct = "0";
                num2_bin = "0";
            }
            txtValueHex.Text = "0";
            txtValueDec.Text = "0";
            txtValueOct.Text = "0";
            txtValueBin.Text = "0";
        }
        //метод стирання останньої цифри
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            switch (mode)
            {
                case "hex": txtValueHex.Text = DropLastChar(txtValueHex.Text); break;
                case "dec": txtValueDec.Text = DropLastChar(txtValueDec.Text); break;
                case "oct": txtValueOct.Text = DropLastChar(txtValueOct.Text); break;
                case "bin": txtValueBin.Text = DropLastChar(txtValueBin.Text); break;
                default: break;
            }
            if (op == "")
            {
                switch (mode)
                {
                    case "hex": num1_hex = txtValueHex.Text; break;
                    case "dec": num1_dec = int.Parse(txtValueDec.Text); break;
                    case "oct": num1_oct = txtValueOct.Text; break;
                    case "bin": num1_bin = txtValueBin.Text; break;
                    default: break;
                }
            }
            else
            {
                switch (mode)
                {
                    case "hex": num2_hex = txtValueHex.Text; break;
                    case "dec": num2_dec = int.Parse(txtValueDec.Text); break;
                    case "oct": num2_oct = txtValueOct.Text; break;
                    case "bin": num2_bin = txtValueBin.Text; break;
                    default: break;
                }
            }
        }
        //допоміжний метод для btn_back_Click(object, RoutedEventArgs)
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
    }
}
