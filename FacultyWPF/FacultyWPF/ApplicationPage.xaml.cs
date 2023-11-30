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

namespace FacultyWPF
{
    /// <summary>
    /// Interaction logic for ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        public ApplicationPage()
        {
            InitializeComponent();
        }
        

        private void OpenData_Click(object sender, RoutedEventArgs e)
        {
            DataListPage dataListPage = new DataListPage();
            this.NavigationService.Navigate(dataListPage);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            FacultyEntities1 db = new FacultyEntities1();
            Student student = new Student();
            student.Name = nameTxt.Text;
            student.Address = addTxt.Text;
            student.Age = int.Parse(ageTxt.Text);
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Done");
            nameTxt.Text = "";
            addTxt.Text = "";
            ageTxt.Text = "";
        }

        private void ageTxt_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
