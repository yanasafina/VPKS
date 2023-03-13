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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Visible;

        }



        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            bg.Visibility = Visibility.Hidden;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sotr.Visibility = Visibility.Visible;
            ObjectsDG.ItemsSource = HGContext.GetContext().Users.ToList();


        }

        private void AddDriverBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Fio.Text.Length > 0)
            {
                if (Login.Text.Length > 0)
                {
                    if (Password.Text.Length > 0)
                    {
                        if (Password.Text.Length > 0)
                        {
                            if (Phone.Text.Length > 0 && Phone.Text.Length < 12)
                            {
                                if (Place.Text.Length > 0)
                                {
                                    HGContext db = new HGContext();
                                    Users newB = new Users();
                                    newB.Fio = Fio.Text;
                                    newB.Login = Login.Text;
                                    newB.Password = Password.Text;
                                    newB.Phone = Phone.Text;
                                    newB.Place = Convert.ToInt32(Place.Text);

                                    db.Users.Add(newB);
                                    db.SaveChanges();
                                    MessageBox.Show(String.Format("Работник добавлен!"));
                                    CreateDriverSp.Visibility = Visibility.Hidden;

                                }
                                else MessageBox.Show("Место работы не указано");
                            }
                            else MessageBox.Show("Укажите номер телефона");
                        }
                        else MessageBox.Show("Укажите пароль");
                    }
                    else MessageBox.Show("Укажите Логин");
                }
                else MessageBox.Show("Укажите ФИО");

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var usersRemoving = ObjectsDG.SelectedItems.Cast<Users>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить пользователя?", "Внимание",  MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HGContext.GetContext().Users.RemoveRange(usersRemoving);
                    HGContext.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    ObjectsDG.ItemsSource = HGContext.GetContext().Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sotr.Visibility = Visibility.Hidden;
            CreateDriverSp.Visibility = Visibility.Visible;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CreateDriverSp.Visibility = Visibility.Hidden;
        }

        private void IVC(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility==Visibility.Visible)
            {
                HGContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ObjectsDG.ItemsSource = HGContext.GetContext().Users.ToList();
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
    }
}
