using System;
using System.Windows;
using System.IO;

namespace Calculator
{
    public partial class History : Window
    {
        string mode = "dark";
        public History(string nmode)
        {
            InitializeComponent();
            ReadFile();
            mode = nmode;
            DarkLight();
        }
        private void DarkLight(object sender, RoutedEventArgs e) => DarkLight();
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
            menu.Style = (Style)Application.Current.Resources["MenuLight"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemLight"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemLight"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemLight"];
            HistoryList.Style = (Style)Application.Current.Resources["ListBoxLight"];
        }
        private void Darkmode()
        {
            mode = "dark";
            DLmode.Header = "Light mode";
            menu.Style = (Style)Application.Current.Resources["MenuDark"];
            menuitem1.Style = (Style)Application.Current.Resources["MenuItemDark"];
            menuitem2.Style = (Style)Application.Current.Resources["MenuItemDark"];
            DLmode.Style = (Style)Application.Current.Resources["MenuItemDark"];
            HistoryList.Style = (Style)Application.Current.Resources["ListBoxDark"];
        }
        private void Clear(object sender, RoutedEventArgs e) => File.WriteAllText("History.txt", string.Empty);
        private void Update(object sender, RoutedEventArgs e)
        {
            HistoryList.Items.Clear();
            ReadFile();
        }
        private void ReadFile()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("History.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    HistoryList.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                HistoryList.Items.Add(e.Message);  
            }
        }
    }
}
