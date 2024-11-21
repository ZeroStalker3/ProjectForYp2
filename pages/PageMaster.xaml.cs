﻿using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.Model;
using ProjectForYp2.pages.SecondPage;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Логика взаимодействия для PageMaster.xaml
    /// </summary>
    public partial class PageMaster : Page
    {
        classdata data = new classdata();
        string login;
        int reqId;

        public PageMaster(string log)
        {
            InitializeComponent();
            
            data.GetUsers();
            login = log;
            var user =  data.userContext.Users.Where(u => u.Login == login).FirstOrDefault();
            UserGrid.ItemsSource = data.userContext.Requests.Where(r => r.Master.Id == user.Id).ToList();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
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
            EditFrame.frmEdit.Navigate(new PageEditRequestMaster(reqId));
        }

        private void upddate_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMaster(login));
        }

        private void sort_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var user = data.userContext.Users.Where(u => u.Login == login).FirstOrDefault();
            string select = Convert.ToString(sort.Text.ToUpper());
            UserGrid.ItemsSource = data.userContext.Requests.Local.Where(x => x.OrgTechManufacture.ToUpper().Contains(select)/* && x.Master.Id == user.Id*/).ToList();
        }
    }
}
