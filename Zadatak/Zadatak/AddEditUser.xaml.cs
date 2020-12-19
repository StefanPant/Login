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
using Zadatak.ViewModel;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for AddEditUser.xaml
    /// </summary>
    public partial class AddEditUser : Window
    {
        public AddEditUser(AddEditViewModel _addEditViewModel)
        {
            InitializeComponent();
            this.grdMainGrid.DataContext = _addEditViewModel;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
            
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            // setText();
            if (checkBox.IsChecked == true)
            {
                return;
            }
            else if (checkBox.IsChecked == false)
            {
                return;
            }
           
        }
    }
}
