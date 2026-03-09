using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3.Elements
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is TicketClass ticket)
            {
                CalculateDuration(ticket);
            }
        }

        private void CalculateDuration(TicketClass ticket)
        {
            try
            {
                DateTime start = DateTime.Parse(ticket.Time_start);
                DateTime end = DateTime.Parse(ticket.Time_way);
                TimeSpan diff = (end < start) ? (end.AddDays(1) - start) : (end - start);

                if (lDuration != null)
                    lDuration.Content = $"В пути {Math.Floor(diff.TotalHours)}ч {diff.Minutes}м";

                if (TimeEnd != null)
                    TimeEnd.Content = end.ToString("HH:mm");
            }
            catch { }
        }
    }
}