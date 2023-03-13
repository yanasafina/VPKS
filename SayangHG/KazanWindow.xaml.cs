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
using System.Windows.Shapes;

namespace SayangHG
{
    /// <summary>
    /// Логика взаимодействия для KazanWindow.xaml
    /// </summary>
    public partial class KazanWindow : Window
    {
        public KazanWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
        void hyperlink_Click_Hotel1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Скоро открытие....", "Хан Сарай");
        }
        void hyperlink_Click_Hotel2(object sender, RoutedEventArgs e)
        {
            KHotel1Window MHotel2Window = new KHotel1Window();
            MHotel2Window.Show();
            this.Close();
        }
    }
}
