using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class TicketClass
    {
        public string Price { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Time_start { get; set; }
        public string Time_way { get; set; }

        public TicketClass(string from, string to, string price, string time_start, string time_way)
        {
            this.From = from;
            this.To = to;
            this.Price = price;
            this.Time_start = time_start;
            this.Time_way = time_way;
        }
    }
}
