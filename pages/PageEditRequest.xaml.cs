using Microsoft.EntityFrameworkCore;
using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.Model;
using ProjectForYp2.pages.SecondPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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
        classdata data = new classdata();
        Requests requests = new Requests();
        
        int reqId;

        public PageEditRequest()
        {
            InitializeComponent();

            UserGrid.ItemsSource = data.userContext.Requests.Local.ToList();

            EditFrame.frmEdit = Frmedit;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext;
            
            foreach (var item in data.userContext.Requests.Local)
            {
                if (item == req)
                {
                    reqId = item.Id;
                    break;
                }
            }
            EditFrame.frmEdit.Navigate(new PageEditSelectRequest(reqId));
        }

        private void upddate_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageEditRequest());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            UserGrid.ItemsSource = data.userContext.Requests.Local.OrderBy(x => x.StartDate).ToList();
        }
    }
}
