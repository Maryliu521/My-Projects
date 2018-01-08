using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Domain
{
    public class PizzaPriceManager
    {   public static decimal CalculateCost(DTO.Pizza pizza)
        {
            decimal cost = 0.0M;
            var price = GetPrice();
            cost += calculateSizeCost(pizza,price);
            cost += calculateCrustCost(pizza, price);
            cost += calculateToppingCost(pizza, price);

            return cost;
        }

        private static decimal calculateToppingCost(DTO.Pizza pizza,DTO.PizzaPrice price)
        {
            decimal cost = 0.0M;
            cost += pizza.Sausage ? price.Sausage : 0M;                          
            cost += pizza.Pepperoni ? price.Pepperoni : 0M;
            cost += pizza.Onions ? price.Onions : 0M;
            cost += pizza.GreenPeppers ? price.GreenPeppers : 0M;

            return cost;
        }

        private static decimal calculateCrustCost(DTO.Pizza pizza, DTO.PizzaPrice price)
        {
            decimal cost = 0.0M;
            switch (pizza.Crust)
            {
                case DTO.Enums.CrustType.Regular:
                    cost = price.RegularCrust;
                    break;
                case DTO.Enums.CrustType.Thin:
                    cost = price.ThinCurst;
                    break;
                case DTO.Enums.CrustType.Thick:
                    cost = price.ThickCurst;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static decimal calculateSizeCost(DTO.Pizza pizza, DTO.PizzaPrice price)
        {
            decimal cost = 0.0M;
            switch (pizza.Size)
            {
                case DTO.Enums.SizeType.Small:
                    cost = price.SmallSize;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = price.MediumSize;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = price.LargeSize;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static DTO.PizzaPrice GetPrice()
        {
           var price = Persistance.PriceRepository.GetPrice();
            return price;
        }
     
    }
}
