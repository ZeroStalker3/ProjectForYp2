using ProjectForYp2.classes;
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

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageReg());
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string logiin = login.Text;
            string pas = password.Password;
            if (logiin == "login1")
            {
                MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                //FrameApp.frmObj
                }
            else if (logiin == "login2")
            {
                MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (logiin == "login4")
            {
                MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else if (logiin == "login11")
            {
                MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
