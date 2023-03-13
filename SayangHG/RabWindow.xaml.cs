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
    /// Логика взаимодействия для RabWindow.xaml
    /// </summary>
    public partial class RabWindow : Window
    {
        
        public RabWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow inpectorWindow = new MainWindow();
            inpectorWindow.Show();
            this.Close();
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Visible;
            rooms.ItemsSource = HGContext.GetContext().Rooms.ToList();
        }



        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Hidden;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sotr.Visibility = Visibility.Visible;
            ObjectsDG.ItemsSource = HGContext.GetContext().Booking.ToList();


        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var bookingRemoving = ObjectsDG.SelectedItems.Cast<Booking>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить пользователя?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HGContext.GetContext().Booking.RemoveRange(bookingRemoving);
                    HGContext.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    ObjectsDG.ItemsSource = HGContext.GetContext().Booking.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void IVC(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HGContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ObjectsDG.ItemsSource = HGContext.GetContext().Booking.ToList();
            }
        }

        private void IVC2(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HGContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                rooms.ItemsSource = HGContext.GetContext().Rooms.ToList();
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Sotr.Visibility = Visibility.Hidden;
        }

        private void Button_Click222(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click111(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Hidden;
        }
    }
}
