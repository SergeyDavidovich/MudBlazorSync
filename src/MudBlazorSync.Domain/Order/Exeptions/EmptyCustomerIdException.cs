using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorSync.Domain.Order.Exeptions
{
    public class EmptyOrderIdException : Exception
    {
        public EmptyOrderIdException(string message)
            : base(message) { }
    }
}
