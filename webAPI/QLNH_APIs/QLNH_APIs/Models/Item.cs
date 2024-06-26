﻿using System.ComponentModel.DataAnnotations;

namespace QLNH_APIs.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<ItemImage> ItemImage { get; set; }
    }
}
