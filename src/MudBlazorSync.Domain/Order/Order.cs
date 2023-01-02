using MudBlazorSync.Domain.Order.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MudBlazorSync.Domain.Order
{
    public class Order
    {
        private Order() { }

        internal Order(int orderId, string customerId, DateTime orderDate, double? freight)
        {
            OrderID = orderId;
            CustomerID = customerId;
            OrderDate = orderDate;
            Freight = freight;
        }

        public int? OrderID { get; set; }
        public string? CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }

    }
}
