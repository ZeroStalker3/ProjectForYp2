using Azure.Core;
using ProjectForYp2.data;
using ProjectForYp2.Model;
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

namespace ProjectForYp2.pages.SecondPage
{
    /// <summary>
    /// Логика взаимодействия для PageEditSelectRequest.xaml
    /// </summary>
    public partial class PageEditSelectRequest : Page
    {
        classdata data = new classdata();
        int reId;
        public PageEditSelectRequest(int reqId)
        {
            InitializeComponent();
            var req = data.GetRequests();
            reId = reqId;
            data.GetStatys();
            data.GetUsers();
            var result = req.Where(x => x.Id == reqId).FirstOrDefault();

            cmbStatys.DisplayMemberPath = "Name";
            cmbStatys.SelectedValuePath = "Id";
            cmbStatys.ItemsSource = data.userContext.Statys.ToList();
            cmbEmployee.DisplayMemberPath = "Name";
            cmbEmployee.SelectedValuePath = "Id";
            cmbEmployee.ItemsSource = data.userContext.Users.Where(x => x.Type.Id == 2).ToList();
            cmbStatys.SelectedItem = result.Id_Statys;
            descriptionTxt.Text = result.RepairParts;
            cmbEmployee.SelectedItem = result.Master;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            string status = Convert.ToString(cmbStatys.SelectedIndex);
            int emp = Convert.ToInt32(cmbEmployee.SelectedValue);

            //foreach (var item in cmbStatys.Items)
            //{
            //    cmbStatys.SelectedItem = item;
            //    if (status == (string)cmbStatys.Text)
            //    {
            //        break;
            //    }
            //}

            //foreach (var item in cmbEmployee.Items)
            //{
            //    cmbEmployee.SelectedItem = item;
            //    if (emp == (string)cmbEmployee.Text)
            //    {
            //        break;
            //    }
            //}
            var requestt = data.userContext.Requests.Find(reId);

            requestt.RepairParts = descriptionTxt.Text;
            requestt.Master = data.GetUsers().Where(x => x.Id == emp).FirstOrDefault(); ;
            data.userContext.SaveChangesAsync();
            //data.userContext.SaveChanges();
            data.userContext.Update();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            descriptionTxt.Text = string.Empty;
            cmbEmployee.SelectedIndex = 0;
            cmbStatys.SelectedIndex = 0;
        }
    }
}
