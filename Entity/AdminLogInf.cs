using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AdminLogInf
    {
        [Key]
        public int AdminId { get; set; }
        public int CarId { get; set; }
        public string ProcessType { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
