using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }  // Navigation property
        public string ItemType { get; set; }  // 'Car' or 'CarPart'
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

}
