using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LoginWindow logDlg = new LoginWindow();
            logDlg.ShowDialog();
            if (logDlg.DialogResult != true)
            {
                Application.Current.Shutdown();
            }
                       
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        
    }
}
