using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorSync.Domain.Order.Exeptions
{
    public class NullOrderIdExeption:Exception
    {
        public NullOrderIdExeption(string message)
          : base(message) { }
    }
}
