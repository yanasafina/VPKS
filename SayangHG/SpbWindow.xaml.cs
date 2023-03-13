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
    /// Логика взаимодействия для SpbWindow.xaml
    /// </summary>
    public partial class SpbWindow : Window
    {
        public SpbWindow()
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
            SHotel1Window MHotel1Window = new SHotel1Window();
            MHotel1Window.Show();
            this.Close();
        }
    }
}
