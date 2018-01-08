using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class PizzaManager
    {
      public static void CreateOrder(DTO.Pizza orderDTO)
        {  //validation
            if (orderDTO.Name.Trim().Length == 0)
                throw new Exception("Name is required!");
            if (orderDTO.Address.Trim().Length == 0)
                throw new Exception("Address is required!");
            if (orderDTO.Zip.Trim().Length == 0)
                throw new Exception("zip is required!");
            if (orderDTO.Phone.Trim().Length == 0)
                throw new Exception("Phone is required!");
            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalPrice = PizzaPriceManager.CalculateCost(orderDTO);
            Persistance.PizzaRepository.CreateOrder(orderDTO);
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistance.PizzaRepository.CompleteOrder(orderId);
        }

        public static object GetOrder()
        {
            return Persistance.PizzaRepository.GetOrders();
        }

       
    }
}
