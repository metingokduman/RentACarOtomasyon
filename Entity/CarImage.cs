using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class CarImage
    {
        [Key]
        public int CarImageId { get; set; }
        [Required]
        [Column (TypeName="image")]
        public byte[] Image { get; set; }
        [ForeignKey("CarInformation")]
        public int CarId { get; set; }
        public virtual CarInformation CarInformation { get; set; }
    }
}
