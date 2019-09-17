using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MvvmDemo.Customers;
using System.Transactions;
using MvvmDemo.Data;

namespace MvvmDemo.Services
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly DataStoreContext _context = new DataStoreContext();
        public async Task<List<Order>> GetOrdersForCustomersAsync(Guid customerId) => await _context.Orders.Where(o => o.CustomerId == customerId).ToListAsync();
        public async Task<List<Order>> GetAllOrdersAsync() => await _context.Orders.ToListAsync();
        public async Task<Order> AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
        public async Task<Order> UpdateOrderAsync(Order order)
        {
            if (_context.Orders.Local.All(o => o.Id != order.Id))
                _context.Orders.Attach(order);
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return order;
        }
        public async Task DeleteOrderAsync(int orderId)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var order = _context.Orders.Include("OrderItems").Include("OrderItems.OrderItemOptions").FirstOrDefault(o => o.Id == orderId);
                if (order != null)
                {
                    foreach (OrderItem item in order.OrderItems)
                    {
                        foreach (var orderItemOption in item.Options)
                            _context.OrderItemOptions.Remove(orderItemOption);
                        _context.OrderItems.Remove(item);
                    }
                    _context.Orders.Remove(order);
                }
                await _context.SaveChangesAsync();
                scope.Complete();
            }
        }
        public async Task<List<Product>> GetProductsAsync() => await _context.Products.ToListAsync();
        public async Task<List<ProductOption>> GetProductOptionsAsync() => await _context.ProductOptions.ToListAsync();
        public async Task<List<ProductSize>> GetProductSizesAsync() => await _context.ProductSizes.ToListAsync();
        public async Task<List<OrderStatus>> GetOrderStatusesAsync() => await _context.OrderStatuses.ToListAsync();
    }
}