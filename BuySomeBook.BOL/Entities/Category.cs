﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuySomeBook.BOL.Entities
{
    [Table("Category")]
    public class Category
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int PIndex { get; set; }
        
        public int? ParentID { get; set; }

        [ForeignKey("ParentID")]
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}