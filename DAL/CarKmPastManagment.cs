using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
  public  class CarKmPastManagment
    {
        DataContext database;
        public CarKmPastManagment()
        {
            database = new DataContext();
        }

        public bool AddCarKm(CarKmPast c)
        {
            CarKmPast car;
            car = database.CarKmPasts.Add(c);
            database.SaveChanges();
            return true;
        }

        public List<CarKmPast> ShowCarKmInf(CarKmPast c)
        {
            List<CarKmPast> car;
            car = database.CarKmPasts.Where(x => x.CarId == c.CarId  ).ToList()// yıllara göre çekilecek
                .Select(x => new CarKmPast { KmInf=x.KmInf , UpdateDate=x.UpdateDate}).ToList();
            return car;

        }
    }
}
