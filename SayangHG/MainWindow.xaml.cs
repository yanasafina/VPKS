using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SayangHG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        void hyperlink_Click_Moscow(object sender, RoutedEventArgs e)
        {
            MoscowWindow MoscowWindow = new MoscowWindow();
            MoscowWindow.Show();
            this.Close();
        }

        void hyperlink_Click_Spb(object sender, RoutedEventArgs e)
        {
            SpbWindow SpbWindow = new SpbWindow();
            SpbWindow.Show();
            this.Close();
        }

        void hyperlink_Click_Kazan(object sender, RoutedEventArgs e)
        {
            KazanWindow KazanWindow = new KazanWindow();
            KazanWindow.Show();
            this.Close();
        }

        void hyperlink_Click_Sohci(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скоро открытие....", "Отели Сочи");
        }

        private void BtnClickSotr(object sender, RoutedEventArgs e)
        {
            LoginWindow LoginWindow = new LoginWindow();
            LoginWindow.Show();
            this.Close();
        }
    }
}
