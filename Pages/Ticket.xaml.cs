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
        MainWindow mainWindow;
        public Ticket()
        {
            InitializeComponent();
        }

        private void ToBack(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPages(MainWindow.pages.main);
        }
    }
}
