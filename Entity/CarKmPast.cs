using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class CarKmPast
    {
        [Key]
        public int CarKmId { get; set; }
        public int? KmInf { get; set; }
        public DateTime UpdateDate { get; set; }
        [ForeignKey("CarInformation")]
        public int CarId { get; set; }
        public virtual CarInformation CarInformation { get; set; }
    }
}
