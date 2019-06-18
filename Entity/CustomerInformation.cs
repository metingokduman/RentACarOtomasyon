using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CustomerInformation
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdentityNo { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string City { get; set; }
        public virtual List<RentedDetail> RentedDetails { get; set; }
    }
}
