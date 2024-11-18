using ProjectForYp2.classes;
using ProjectForYp2.Model;
using ProjectForYp2.pages.SecondPage;
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
    /// Логика взаимодействия для PageEditRequest.xaml
    /// </summary>
    public partial class PageEditRequest : Page
    {
        public PageEditRequest()
        {
            InitializeComponent();
            EditFrame.frmEdit = Frmedit;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            EditFrame.frmEdit.Navigate(new PageEditSelectRequest(/*(sender as Button).DataContext as Requests*/));
        }

        private void upddate_Click(object sender, RoutedEventArgs e)
        {
            //ОБновление DataGrid
        }
    }
}
