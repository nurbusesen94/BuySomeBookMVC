using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuySomeBook.BOL.Entities
{
    [Table("Author")]
    public class Author
    {
        public int ID { get; set; }

        [StringLength(150), Column(TypeName = "varchar"), Display(Name = "Yazar Adı")]
        public string NameSurname { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}