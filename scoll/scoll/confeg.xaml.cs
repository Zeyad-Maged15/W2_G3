using scoll;
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
using System.Xml.Linq;

namespace scoll
{
    /// <summary>
    /// Interaction logic for confeg.xaml
    /// </summary>
    public partial class confeg : Page
    {
        schoolEntities db = new schoolEntities();
        public confeg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loigin a = db.loigins.FirstOrDefault(x => x.Aname == aname.Text && x.Apass == apass.Text);

            if (a == null)
            {
                MessageBox.Show("you are wrong ");
            }
            else if (aname.Text == a.Aname && apass.Text == a.Apass)

            {
                admen x = new admen();
                this.NavigationService.Navigate(x);
            }

        }
    }
}
