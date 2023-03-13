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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnClickSotr(object sender, RoutedEventArgs e)
        {
            if (Log.Text.Length > 0)
            {

                foreach (Users u in HGContext.GetContext().Users)
                {
                    if (Log.Text == u.Login &&
                        Pas.Text == u.Password)
                    {

                        if (u.Password == "qwerty123" && u.Login == "adminSaYR")
                        {
                            MessageBox.Show("Успешный вход!");
                            ManagerWindow inpectorWindow = new ManagerWindow();
                            inpectorWindow.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Успешный вход!");
                            RabWindow inpectorWindow = new RabWindow();
                            inpectorWindow.Show();
                            this.Close();
                        }



                    }

                }
            }
        }
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow inpectorWindow = new MainWindow();
            inpectorWindow.Show();
            this.Close();
        }

        
    }
}
