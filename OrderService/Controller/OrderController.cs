using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet,Route("GetOrder")]
        public async Task<List<Order>> GetOrders()
        {
            return await Task.Run(() =>
            {
                List<Order> orders = new List<Order>(); 
                orders.Add(new Order() { OrderId = 1, OrderAmount = 1000, OrderDate = DateTime.Now });
                orders.Add(new Order() { OrderId = 2, OrderAmount = 2000, OrderDate = DateTime.Now });
                orders.Add(new Order() { OrderId = 3, OrderAmount = 3000, OrderDate = DateTime.Now });
                orders.Add(new Order() { OrderId = 4, OrderAmount = 4000, OrderDate = DateTime.Now });
                return orders;

            });
        } 
    }
}