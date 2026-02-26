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

namespace WpfApp3.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        MainWindow mainWindow;
        public Main(MainWindow mw)
        {
            InitializeComponent();
            this .mainWindow = mw;
        }

        private void ToSearch(object sender, RoutedEventArgs e)
        {
            string fromCity = From.Text;
            string toCity = To.Text;

            if (string.IsNullOrWhiteSpace(fromCity) || string.IsNullOrWhiteSpace(toCity))
            {
                MessageBox.Show("Пожалуйста, укажите город отправления и назначения.", "Ошибка");
                return;
            }

            Ticket ticketPage = new Ticket(mainWindow, fromCity, toCity);

            mainWindow.frame.Navigate(ticketPage);
        }

        private void ToExit(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}
