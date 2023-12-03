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
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page
    {
        schoolEntities db = new schoolEntities();
        public user()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, object e)
        {

            student s = new student();
            s.sname = uname.Text;
            s.sage = int.Parse(uage.Text);
            s.sadd = uadd.Text;
            s.spoh = upho.Text;
            db.students.Add(s);
            db.SaveChanges();
            admen r = new admen();
            r.DG.ItemsSource = db.students.ToList();
            MessageBox.Show("saved");

        }


    }
 }

