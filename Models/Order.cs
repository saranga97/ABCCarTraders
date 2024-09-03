﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 
        public double TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }  // 'Pending', 'Processing', 'Shipped', 'Delivered', 'Cancelled'
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

}
