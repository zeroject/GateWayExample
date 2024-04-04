using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Order
    {
        public int Id { get; set; }
        public List<product> Products { get; set; }
        public int TotalPricelist { get; set; }
    }
}
