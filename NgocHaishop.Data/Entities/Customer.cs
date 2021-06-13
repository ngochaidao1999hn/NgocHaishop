using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Customer
    {
        [Key]
        public int Cus_Id { get; set; }
        public string Cus_Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Cus_Email { get; set; }
        [Required]
        public string Cus_Adress { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Không đúng định dạng số điện thoại")]
        public string Cus_Phone { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
