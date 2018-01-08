using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance
{
    public class PizzaRepository
    {
        public static void CreateOrder(DTO.Pizza orderDTO)
        {
            var db = new PizzaDbEntities1();
            var order = convertToEntity(orderDTO);
            db.Orders.Add(order);
            db.SaveChanges();
      }  
        private static Orders  convertToEntity(DTO.Pizza orderDTO)
        {
            var order = new Orders();
            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.Zip = orderDTO.Zip;
            order.Phone = orderDTO.Phone;
            order.Payment = orderDTO.Payment;
            order.TotalPrice = orderDTO.TotalPrice;
            order.Completed = orderDTO.Completed;

           
            return order;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new PizzaDbEntities1();
            var order = db.Orders.FirstOrDefault(p =>p.OrderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }

        public static List<DTO.Pizza> GetOrders()
        {
            var db = new PizzaDbEntities1();
            var orders = db.Orders.Where(p =>p.Completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;
        }


        private static List<DTO.Pizza> convertToDTO(List<Orders> orders)
        {
            var ordersDTO = new List<DTO.Pizza>();
            foreach (var order in orders)
            {
                var orderDTO = new DTO.Pizza();
                orderDTO.OrderId = order.OrderId;
                orderDTO.Size = order.Size;
                orderDTO.Crust = order.Crust;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.Zip = orderDTO.Zip;
                orderDTO.Phone = order.Phone;
                orderDTO.Payment = order.Payment;
                orderDTO.Completed = order.Completed;
                orderDTO.TotalPrice = order.TotalPrice;

                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }
    }
   
}
