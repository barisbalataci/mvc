using Project.WPFConsole.Model;
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
using System.Windows.Shapes;
using Project.WPFConsole.Model;

namespace Project.WPFConsole.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customers : Window
    {
        
        public Customers()
        {           
            InitializeComponent();
            DataContext = new CustomerViewModel();
        }

        private void Btn_Update_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInsert_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
