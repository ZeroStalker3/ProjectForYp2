using Microsoft.EntityFrameworkCore;
using ProjectForYp2.classes;
using ProjectForYp2.data;
using System.Windows;
using System.Windows.Controls;

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        internal readonly UserContext userContext;

        public PageLogin()
        {
            InitializeComponent();
            userContext = new UserContext();

            databaseload();
        }

        void databaseload()
        {
            userContext.Users.Load();
            userContext.Types.Load();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageReg());
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string logiin = login.Text;
            string pas = password.Password;
            if (password.Password == "")
            {
                MessageBox.Show("Пароль не введен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var result = userContext.Users.FirstOrDefault(u => u.Login == logiin && u.Password == pas);

                //if (logiin == "login1")
                //{
                //    //FrameApp.frmObj
                //}
                //else if (logiin == "login2")
                //{
                //    MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

                //}
                //else if (logiin == "login4")
                //{
                //    MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

                //}
                //else if (logiin == "login11")
                //{
                //    MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);

                //}

                if (result == null)
                {
                    MessageBox.Show("Пользователь не найден", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (result != null)
                {
                    if(result.Type.Id == 1)
                    {
                        MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("ЖОПА", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
