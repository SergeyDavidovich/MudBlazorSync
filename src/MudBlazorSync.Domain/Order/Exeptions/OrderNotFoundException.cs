using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorSync.Domain.Order.Exeptions
{
    public class OrderNotFoundException:Exception
    {
        public OrderNotFoundException(string message)
           : base(message) { }
    }
}
