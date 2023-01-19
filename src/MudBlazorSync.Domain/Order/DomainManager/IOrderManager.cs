using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorSync.Domain.Order.DomainManager
{
    public interface IOrderManager
    {
        public Task<Order> CreateOrderAsync(string name, float value, string? description);

        public Task<Order> UpdateOrderAsync(Guid id, string name, float value, string? description);
    }
}
