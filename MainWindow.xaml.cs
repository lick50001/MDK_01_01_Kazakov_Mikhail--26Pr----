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
using MySql.Data.MySqlClient;
using WorkingBD;
using WpfApp3.Pages;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<TicketClass> ticketClasses = new List<TicketClass>();
        public MainWindow()
        {
            InitializeComponent();

            LoadTikets();

            var main = new Pages.Main(this);

            frame.Visibility = Visibility.Visible;

            frame.Navigate(main);
        }

        public void OpenPages(Page Page)
        {
            frame.Navigate(Page);
        }

        private void LoadTikets()
        {
            ticketClasses.Clear();
            string conn = "Server=localhost;Port=3306;Database=airlines;Uid=root;Pwd=;";
            MySqlConnection myConn = new MySqlConnection(conn);
            myConn.Open();

            string query = "SELECT * FROM flights;";

            using (MySqlCommand cmd = new MySqlCommand(query, myConn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string from = reader["from"].ToString();
                    string to = reader["to"].ToString();
                    string price = reader["price"].ToString();
                    string timeStart = reader["time_start"].ToString();
                    string timeWay = reader["time_way"].ToString();

                    ticketClasses.Add(new TicketClass(from, to, price, timeStart, timeWay));
                }
            }

            myConn.Close();
        }
    }
}
