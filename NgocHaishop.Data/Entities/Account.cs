using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NgocHaishop.Data.Entities
{
    public class Account
    {
        [Key]
        public int Acc_Id { get; set; }
        [Required]
        public string Acc_UserName { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$",ErrorMessage = "Mật khẩu phải gồm 8 ký tự bao gồm ít nhất 1 chữ viết hoa")]
        public string Acc_Password { get; set; }
        [ForeignKey("Customer")]
        public int Acc_Customer { get; set; }
        [Required]
        public StatusEnum Acc_Status { get; set; }
        public Customer Customer { get; set; }

    }
}
