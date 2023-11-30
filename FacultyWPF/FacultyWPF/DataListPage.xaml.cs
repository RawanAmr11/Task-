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
    /// Interaction logic for DataListPage.xaml
    /// </summary>
    public partial class DataListPage : Page
    {
        FacultyEntities1 db = new FacultyEntities1();
        public DataListPage()
        {
            InitializeComponent();
            dg.ItemsSource = db.Students.ToList();  
        }

        private void RefreshBtn(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = db.Students.ToList();
        }

        private void SearchBtn(object sender, RoutedEventArgs e)
        {
            var subArray = Combo.SelectedItem.ToString().Split(' ');
            string dep = subArray.Last();
            dg.ItemsSource = db.Students.Where(x => x.Name.Contains(searchByName.Text) && x.DepName == dep).ToList();
            
        }

    }
}
