using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RentedDetail
    {
        [Key]
        public int RentedDetailId { get; set; }
        [Required]
        public DateTime FirstRentDate { get; set; }
        [Required]
        public DateTime LastRentDate { get; set; }
        [Required]
        public int? CountOfRentDay { get; set; }
        [Required]
        public double? TotalRentPrice { get; set; }
        [ForeignKey("CarInformation")]
        public int CarId { get; set; }
        [ForeignKey("CustomerInformation")]
        public int CutomerId { get; set; }
        [ForeignKey("UserInformation")]
        public int UserId { get; set; }
        public virtual CarInformation CarInformation { get; set; }
        public virtual CustomerInformation CustomerInformation { get; set; }
        public virtual UserInformation UserInformation { get; set; }
    }
}
