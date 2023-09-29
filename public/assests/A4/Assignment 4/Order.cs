using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Order
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Toppings { get; set; }
        public int Quantity { get; set; }
        public string Coupon { get; set; }

        public Order()
        {
            Name = "Unknown";
            Phone = 0;
            Type = "";
            Size = "";
            Toppings = "";
            Quantity = 1;
            Coupon = "";
        }
        public Order(string name, int phone, string type, string size, string toppings, int quanity, string coupon)
        {
            Name = name;
            Phone = phone;
            Type = type;
            Size = size;
            Toppings = toppings;
            Quantity = quanity;
            Coupon = coupon;
        }
    }
}
