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
    /// Логика взаимодействия для KHotel1Window.xaml
    /// </summary>
    
    public partial class KHotel1Window : Window
    {
        public KHotel1Window()
        {
            InitializeComponent();
            
        }

        int i;
        private void Button_Click_b(object sender, RoutedEventArgs e)
        {
            KazanWindow MainWindow = new KazanWindow();
            MainWindow.Show();
            this.Close();
        }
        private void RoomOpen_Click(object sender, RoutedEventArgs e)
        {
            viewer.Visibility = Visibility.Hidden;
            la.Visibility = Visibility.Visible;
            CreateBooking.Visibility = Visibility.Visible;
            i = 13;
            But_back.IsEnabled = false;
        }

        
        private void RoomOpen_Click2(object sender, RoutedEventArgs e)
        {
            viewer.Visibility = Visibility.Visible;
            la2.Visibility = Visibility.Visible;
            CreateBooking.Visibility = Visibility.Visible;
            i = 10;
            But_back.IsEnabled = false;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Name.Text.Length > 0)
            {
                if (FullName.Text.Length > 0)
                {
                    if (Coming.Text.Length > 0)
                    {
                        if (Leaving.Text.Length > 0)
                        {
                            if (Phone.Text.Length > 0 && Phone.Text.Length < 12)
                            {
                                HGContext db = new HGContext();
                                Booking newB = new Booking();
                                newB.Name = Name.Text;
                                newB.Fullame = FullName.Text;
                                newB.Parentname = Parentname.Text;
                                newB.Coming = Coming.Text;
                                newB.Leaving = Leaving.Text;
                                newB.Phone = Phone.Text;
                                newB.Room = i;
                                newB.Food = Food.Text;
                                newB.Cot = Cot.Text;

                                db.Booking.Add(newB);
                                db.SaveChanges();
                                MessageBox.Show(String.Format("Номер успешно забронирован!!"));
                                But_back.IsEnabled = true;
                                CreateBooking.Visibility = Visibility.Hidden;
                                la.Visibility = Visibility.Hidden;
                                la2.Visibility = Visibility.Hidden;
                            }
                            else MessageBox.Show("Телефон указан некорректно");
                        }
                        else MessageBox.Show("Укажите дату отъезда");
                    }
                    else MessageBox.Show("Укажите дату заезда");
                }
                else MessageBox.Show("Укажите Фамилию");
            }
            else MessageBox.Show("Укажите Имя");
        }

        private void Button_Click_Otm(object sender, RoutedEventArgs e)
        {
            viewer.Visibility = Visibility.Visible;
            But_back.IsEnabled = true;
            la.Visibility = Visibility.Hidden;
            la2.Visibility = Visibility.Hidden;
            CreateBooking.Visibility = Visibility.Hidden;
            
        }
    }
}
