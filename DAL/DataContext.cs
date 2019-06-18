using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Server=METIN\SQLEXPRESS;Database=RentACar;Integrated Security=true;")
        {

        }
        //public DataContext() : base(@"Server=BKLAB206PC15;Database=RentACar;UID=sa;Password=123;")
        //{

        //}
        public DbSet<CarInformation> CarInformations { get; set; }
        public DbSet<CustomerInformation> CustomerInformations { get; set; }
        public DbSet<RentedDetail> RentedDetails { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<AdminLogInf> AdminLogInfs { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CarKmPast> CarKmPasts { get; set; }


    }
}
