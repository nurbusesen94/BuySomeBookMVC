﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuySomeBook.BOL.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int ID { get; set; }

        [Display(Name = "Sipariş")]
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int? ProductID { get; set; }
        public Product Product { get; set; }

        [StringLength(150), Column(TypeName = "varchar"), Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Miktar")]
        public int Quantity { get; set; }
    }
}