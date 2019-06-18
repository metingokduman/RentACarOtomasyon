using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
 public   class CarImageManagment
    {
        DataContext database;
        public CarImageManagment()
        {
            database = new DataContext();
        }

        public bool AddCarImage(CarImage c)
        {
            CarImage car;
            car = database.CarImages.Add(c);
            database.SaveChanges();
            return true;
        }

        public List<CarImage> ShowCarImageList(CarImage c)
        {
            List<CarImage> car;
            car = database.CarImages.Where(x => x.CarId ==c.CarId).ToList()
                .Select(x=> new CarImage {Image=x.Image }).ToList();
            return car;

        }

    }
}
