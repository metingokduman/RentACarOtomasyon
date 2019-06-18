using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
   public class CarImageController
    {
        CarImageManagment carImageManagment;
        public CarImageController()
        {
            carImageManagment = new CarImageManagment();

        }
        public bool AddCarImageController(CarImage c)
        {
            if (c.Image!=null)
            {
                carImageManagment.AddCarImage(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CarImage> ListCar(CarImage c)
        {
            return carImageManagment.ShowCarImageList(c);
        }
        
    }
}
