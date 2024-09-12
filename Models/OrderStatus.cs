﻿namespace pharmacy.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
