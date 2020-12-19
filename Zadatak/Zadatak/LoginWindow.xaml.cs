using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Zadatak
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=SQLEXPRESS; Database=ADMIN_1, Itegrated Security=True;"))
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
                conn.Open();
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string query = "SELECT COUNT(1) FROM [User] WHERE UserName=@UserName AND Password=@Password AND IsDeleted=0";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@UserName", userName.Text);
                    command.Parameters.AddWithValue("@Password", password.Password);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        this.DialogResult = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Neispravna Lozinka ili korisničko ime");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }
    }
}