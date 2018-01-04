using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistance
{
    public class PriceRepository
    {
        public static DTO.PizzaPrice GetPrice()
        {
            var db = new PizzaDbEntities1();
            var price = db.Price.First();
            var dto = convertToDTO(price);
            return dto;

        }
        private static DTO.PizzaPrice convertToDTO(Price price)
        { var dtoPrice = new DTO.PizzaPrice();
            dtoPrice.SmallSize = price.SmallSize;
            dtoPrice.MediumSize = price.MediumSize;
            dtoPrice.LargeSize = price.LargeSize;
            dtoPrice.RegularCrust = price.RegularCrust;
            dtoPrice.ThinCurst = price.ThinCurst;
            dtoPrice.ThickCurst = price.ThickCurst;
            dtoPrice.Sausage = price.Sausage;
            dtoPrice.Pepperoni = price.Pepperoni;
            dtoPrice.Onions = price.Onions;
            dtoPrice.GreenPeppers = price.GreenPeppers;
            return dtoPrice;
         }
    }
}
