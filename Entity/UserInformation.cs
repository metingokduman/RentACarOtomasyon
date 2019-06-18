using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserInformation
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserTitle { get; set; }
        public virtual List<RentedDetail> RentedDetails { get; set; }
    }
}
