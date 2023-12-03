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

namespace scoll
{
  
    /// <summary>
    /// Interaction logic for admen.xaml
    /// </summary>
    public partial class admen : Page
    {
        schoolEntities db = new schoolEntities();
        public admen()
        {
            InitializeComponent();
        }

       
     
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            student q = db.students.Remove(db.students.First(x =>  x.sname== name.Text));
            MessageBox.Show("removed");
            db.SaveChanges();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.students.ToList();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.students.Where(x => x.sname.Contains(name.Text)).ToList();
        }
    }
}
