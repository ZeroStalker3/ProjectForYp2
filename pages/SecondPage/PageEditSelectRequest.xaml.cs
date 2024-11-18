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
        public PageEditSelectRequest()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            string status = Convert.ToString(cmbStatys.SelectedIndex);
            string emp = Convert.ToString(cmbEmployee.SelectedIndex);

            foreach (var item in cmbStatys.Items)
            {
                cmbStatys.SelectedItem = item;
                if (status == (string)cmbStatys.Text)
                {
                    break;
                }
            }

            foreach (var item in cmbEmployee.Items)
            {
                cmbEmployee.SelectedItem = item;
                if (emp == (string)cmbEmployee.Text)
                {
                    break;
                }
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            descriptionTxt.Text = string.Empty;
            cmbEmployee.SelectedIndex = 0;
            cmbStatys.SelectedIndex = 0;
        }
    }
}
