using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
    public class CarManagment
    {
        DataContext database;
        public CarManagment()
        {
            database = new DataContext();

        }
        public bool AddCar(CarInformation c)
        {
            try
            {
                c= database.CarInformations.Add(c);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool IfExistChasissNo(CarInformation c)
        {
            var result = database.CarInformations.FirstOrDefault(x => x.ChassisNo == (c.ChassisNo));
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteCar(CarInformation c)
        {
            CarInformation car;
            car = database.CarInformations.FirstOrDefault(x => x.ChassisNo == (c.ChassisNo));
            if (car != null)
            {
                database.CarInformations.Remove(car);
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateCar(CarInformation c)
        {
            CarInformation car;
            car = database.CarInformations.FirstOrDefault(x => x.ChassisNo == (c.ChassisNo));
            if (car != null)
            {
                car.KmInfo = c.KmInfo;
                car.DailyPrice = c.DailyPrice;
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateIsActiveForRenting(CarInformation c)
        {
            CarInformation car;
            car = database.CarInformations.FirstOrDefault(x => x.ChassisNo == (c.ChassisNo));
            if (car != null)
            {
                car.IfAvaibleForRenting = c.IfAvaibleForRenting;
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
  



        public List<CarInformation> ShowCar( List<CarInformation> cars)
        {
            List<int> idList = new List<int>();
            foreach (CarInformation item in cars)
            {
                idList.Add(item.CarId);
            }
            var result = database.CarInformations.FirstOrDefault(x =>!idList.Contains(x.CarId));

            if (result != null)
            {
                List<CarInformation> car = database.CarInformations.Where(x => !idList.Contains(x.CarId)).ToList()
                 .Select(x => new CarInformation
                 {
                     CarId = x.CarId,
                     ChassisNo = x.ChassisNo,
                     Brand = x.Brand,
                     Model = x.Model,
                     ModelYear = x.ModelYear,
                     KmInfo = x.KmInfo,
                     DailyPrice = x.DailyPrice,
                     IfAvaibleForRenting = x.IfAvaibleForRenting
                 }).ToList();
                return car;
            }
            else
            {
                return null;
            }

        }

        public List<CarInformation> ShowCarList()
        {
            List<CarInformation> car;

            car = database.CarInformations.Where(x => x.CarId > 0).ToList();

            return car;

        }

        public int GetCarId(CarInformation car)
        {
            var result = database.CarInformations.FirstOrDefault(x => x.ChassisNo == (car.ChassisNo));

            if (result != null)
            {
                return result.CarId;
            }
            else
            {
                return 0;
            }
        }


        public bool UpdateCarStateForUpdateDelete(CarInformation c)
        {
            CarInformation car;
            car = database.CarInformations.FirstOrDefault(x => x.CarId == c.CarId);
            if (car != null)
            {
                car.IfAvaibleForRenting = c.IfAvaibleForRenting;
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
