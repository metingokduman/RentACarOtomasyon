using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CarInformation
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int? KmInfo { get; set; }
        [Required]
        public int? ModelYear { get; set; }
        [Required]
        public string ChassisNo { get; set; }
        [Required]
        public double? DailyPrice { get; set; }
        public virtual List<RentedDetail> RentedDetails { get; set; }
        public virtual List<CarImage> CarImages { get; set; }
        public virtual List<CarKmPast> CarKmPasts { get; set; }
        public IfAvaibleForRenting IfAvaibleForRenting { get; set; }
    }
    public enum IfAvaibleForRenting : byte
    {
        Active = 0,
        Passive = 1
    }

    public class DiscountfeeCalculator
    {
        public double? Day7to9(CarInformation carInformation) { return carInformation.DailyPrice * 0.70; }
        public double? Day10to29(CarInformation carInformation) { return carInformation.DailyPrice * 0.65; }
        public double? DayOverMonth(CarInformation carInformation) { return carInformation.DailyPrice * 0.60; }
    }

}
