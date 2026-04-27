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

namespace Lab000
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Contact NewContact { get; private set; }
        public Window1()
        {
            InitializeComponent();
            NewContact = new Contact();
            DataContext = NewContact;
        }

        private void AddContact(object sender, RoutedEventArgs s)
        {
            DialogResult = true;
            Close();
        }
        private void Cancel(object sender, RoutedEventArgs s) {
        DialogResult = false;
            Close();
        }
        
    }
}
