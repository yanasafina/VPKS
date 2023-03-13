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
    /// Логика взаимодействия для MoscowWindow.xaml
    /// </summary>
    public partial class MoscowWindow : Window
    {
        public MoscowWindow()
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
            MHotel1Window MHotel1Window = new MHotel1Window();
            MHotel1Window.Show();
            this.Close();
        }
        void hyperlink_Click_Hotel2(object sender, RoutedEventArgs e)
        {
            MHotel2Window MHotel2Window = new MHotel2Window();
            MHotel2Window.Show();
            this.Close();
        }
    }
}



