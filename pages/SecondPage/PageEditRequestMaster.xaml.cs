using ProjectForYp2.data;
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
            var coment = data.GetComments();
            var com = coment.Where(x => x.Id == reId).FirstOrDefault();
        }
    }
}
