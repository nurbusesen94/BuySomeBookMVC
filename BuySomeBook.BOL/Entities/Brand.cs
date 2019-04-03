using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuySomeBook.BOL.Entities
{
    [Table("Brand")]
    public class Brand
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Yayıncı Adı")]
        public string Name { get; set; }

        [StringLength(30), Column(TypeName = "varchar"), Display(Name = "Yayıncı Resmi")]
        public string Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}