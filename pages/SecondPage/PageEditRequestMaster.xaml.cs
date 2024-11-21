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
    /// Логика взаимодействия для PageEditRequestMaster.xaml
    /// </summary>
    public partial class PageEditRequestMaster : Page
    {
        classdata data = new classdata();
        int reId;
        public PageEditRequestMaster(int reqId)
        {
            InitializeComponent(); 
            var req = data.GetRequests();
            reId = reqId;
            data.GetStatys();
            data.GetUsers();
            var result = req.Where(x => x.Id == reqId).FirstOrDefault();
            var comment = data.GetComments();
            var com = comment.Where(x => x.Id == reId).FirstOrDefault();
            if (com != null)
            { coment.Text = com.Message; }
            else
            {
                coment.Text = "";
            }
            cmbStatys.Text = result.Id_Statys.Name;
            descriptionTxt.Text = result.RepairParts;
            cmbEmployee.Text = result.Master.Name + " "
            + result.Master.FirstName + " " + result.Master.LastName ;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            string desc;
            var user = data.GetUsers();
            data.GetComments();
            var requestt = data.userContext.Requests.Find(reId);
            requestt.RepairParts = descriptionTxt.Text;
            requestt.Master = data.GetUsers().Where(x => x.Id == reId).FirstOrDefault();
            requestt.RepairParts = descriptionTxt.Text;

            Comment comment = new Comment()
            {
                Message = coment.Text,
                Master = data.GetUsers().Where(x => x.Id == reId).FirstOrDefault(),
                //reqId = 
                //type.Where(x => x.Id == Convert.ToInt32(cmbTechType.SelectedValue)).FirstOrDefault(),
            };

            data.userContext.Update(requestt);
            data.userContext.SaveChanges();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            descriptionTxt.Text = "";
            coment.Text = "";
        }
    }
}
