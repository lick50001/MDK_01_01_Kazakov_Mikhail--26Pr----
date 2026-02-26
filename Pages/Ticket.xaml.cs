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
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        private MainWindow mainWindow;
        private string currentFrom;
        private string currentTo;
        public Ticket(MainWindow mw, string from, string to)
        {
            InitializeComponent();

            this.mainWindow = mw;
            this.currentFrom = from;
            this.currentTo = to;

            LoadFlights();
        }

        private void LoadFlights()
        {
            var filteredList = mainWindow.ticketClasses
                .Where(t => t.From.ToLower() == currentFrom.ToLower() &&
                            t.To.ToLower() == currentTo.ToLower())
                .ToList();

            FlightsContainer.ItemsSource = filteredList;

            if (filteredList.Count == 0)
            {
                MessageBox.Show("Рейсы не найдены!");
            }
        }

        private void ToBack(object sender, RoutedEventArgs e)
        {
            if (mainWindow != null && mainWindow.frame.CanGoBack)
            {
                mainWindow.frame.GoBack();
            }
        }
    }
}
