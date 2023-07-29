using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameStore.Models
{
    public class Item
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string UnitPrice { get; set; }
        public DateTime DateOrdered { get; set; }

    }
}
