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
    /// Interaction logic for welcom.xaml
    /// </summary>
    public partial class welcom : Page
    {
        public welcom()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Text == "student")
            {
                user x = new user();
                this.NavigationService.Navigate(x);
            }
            if (combo.Text == "admen")
            {
                confeg a = new confeg();
                this.NavigationService.Navigate(a);
            }
        }
    }
}
