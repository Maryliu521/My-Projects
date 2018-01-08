using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.DTO
{
    public partial class PizzaPrice
    {
        public int Id { get; set; }
        public decimal SmallSize { get; set; }
        public decimal MediumSize { get; set; }
        public decimal LargeSize { get; set; }
        public decimal RegularCrust { get; set; }
        public decimal ThinCurst { get; set; }
        public decimal ThickCurst { get; set; }
        public decimal Sausage { get; set; }
        public decimal Pepperoni { get; set; }
        public decimal Onions { get; set; }
        public decimal GreenPeppers { get; set; }
    }
}
