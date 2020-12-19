using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Zadatak.Model;
using Zadatak.ViewModel;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();

            mainViewModel = new MainWindowViewModel();
            this.DataContext = mainViewModel;
        }

       

        public void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = mainViewModel.CurrentUser;
           

            AddEditViewModel addEditViewModel = new AddEditViewModel(user);
            AddEditUser frm = new AddEditUser(addEditViewModel);
           
            frm.ShowDialog();


            if (frm.DialogResult==true)
            {


            }

        }



        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            

            AddEditViewModel addEditViewModel = new AddEditViewModel();
            AddEditUser frm = new AddEditUser(addEditViewModel);
            frm.ShowDialog();

            if (frm.DialogResult == true)
            {
               
                var newUser = addEditViewModel.CurrentUser;
                mainViewModel.UserList.Add(newUser);
                mainViewModel.CurrentUser = newUser;

            }
        }
   

    }
}
