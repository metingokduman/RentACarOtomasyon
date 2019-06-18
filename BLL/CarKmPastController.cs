using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
   public class CarKmPastController
    {
        CarKmPastManagment carKmPastManagment;
        public CarKmPastController()
        {
            carKmPastManagment = new CarKmPastManagment();

        }
        public bool AddCarKmController(CarKmPast c)
        {
            if (c.UpdateDate != null)
            {
                carKmPastManagment.AddCarKm(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CarKmPast> ListCarKm(CarKmPast c)
        {
            return carKmPastManagment.ShowCarKmInf(c);
        }
    }
}
