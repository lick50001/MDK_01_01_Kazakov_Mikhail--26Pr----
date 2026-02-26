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
        public Main()
        {
            InitializeComponent();
        }

        private void ToSearch(object sender, RoutedEventArgs e)
        {
            mainWindow.frame.Navigate(new Pages.Ticket(mainWindow, from.text, to.Text));
        }

        private void ToExit(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}
