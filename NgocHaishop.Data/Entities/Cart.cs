using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Cart
    {
        [Key]
        public int Cart_Id { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        [Required]
        public DateTime Cart_CreateDate { get; set; }
        [Required]
        public OrderEnum Cart_Status { get; set; }
        public string Cart_Promo { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Không đúng định dạng số điện thoại")]
        public string Cart_PhoneNumber { get; set; }
        [Required]
        public string Cart_Adress { get; set; }
        [Required]
        public string Cart_Name { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
