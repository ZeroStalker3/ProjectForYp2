using System.Windows;
using System.Windows.Controls;

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddRequest.xaml
    /// </summary>
    public partial class PageAddRequest : Page
    {
        string FirstName;
        string LastName;
        string Name;
        Int64 Phone;
        string ModelTech;
        string ManufactureTech;
        string SeriialNumber;
        string TypeTech;
        string Descrp;

        public PageAddRequest()
        {
            InitializeComponent();

            FirstName = firstname.Text;
            LastName = secondname.Text;
            Name = name.Text;
            Phone = Convert.ToInt64(phone.Text);
            TypeTech = (string)cmbTechType.SelectedValue;
            ModelTech = modeltech.Text;
            ManufactureTech = manufacturetech.Text;
            SeriialNumber = numbermodel.Text;
            Descrp = descriptiontxt.Text;
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные отправлены");
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные очищены");

            firstname.Clear();
            secondname.Clear();
            name.Clear();
            phone.Clear();
            cmbTechType.SelectedValue = 0;
            modeltech.Clear();
            manufacturetech.Clear();
            numbermodel.Clear();
            descriptiontxt.Clear();
        }
    }
}

//Заявка может содержать данные о виде оргтехники, 
//    модели, описании проблемы, личную информацию (ФИО клиента и номер телефона). 