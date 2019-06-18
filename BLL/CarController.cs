using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class CarController
    {
        CarManagment carManagment;
        public CarController()
        {
            carManagment = new CarManagment();

        }

        public bool AddCarController(CarInformation c)
        {
            if (!string.IsNullOrWhiteSpace(c.Brand) && !string.IsNullOrWhiteSpace(c.Model) && !string.IsNullOrWhiteSpace(c.ChassisNo) && c.KmInfo.HasValue && c.ModelYear.HasValue)
            {
                carManagment.AddCar(c);
                return true;
            }
            else
            {
                MessageBox.Show("boşlıkları doldur");
                return false;
            }
        }
        public bool IfExistChasissNoController(CarInformation c)
        {
            if (!string.IsNullOrWhiteSpace(c.ChassisNo))
            {
                if (carManagment.IfExistChasissNo(c))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                MessageBox.Show("boşlıkları doldur");
                return false;
            }


        }
        public bool DeleteCarController(CarInformation c)
        {
            if (!string.IsNullOrWhiteSpace(c.ChassisNo))
            {
                carManagment.DeleteCar(c);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdateCarController(CarInformation c)
        {
            if (c.KmInfo.HasValue)
            {
                carManagment.UpdateCar(c);
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool UpdateIfIsActiveForRenting(CarInformation c)
        {
            if (!string.IsNullOrWhiteSpace(c.ChassisNo))
            {
                carManagment.UpdateIsActiveForRenting(c);
                return true;
            }
            else
            {
                return false;
            }


        }

        public List<CarInformation> ListCar(List<CarInformation> c)
        {
            return carManagment.ShowCar(c);
        }

        public List<CarInformation> List()
        {
            return carManagment.ShowCarList();
        }

        public int GetCarIdController(CarInformation c)
        {
            if (!string.IsNullOrWhiteSpace(c.ChassisNo))
            {
                if (carManagment.IfExistChasissNo(c))
                {
                    return carManagment.GetCarId(c);
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                MessageBox.Show("boşlıkları doldur");
                return 0;
            }
        }

        public bool UpdateCarStateForUpdateDeleteController(CarInformation c)
        {
            if (carManagment.UpdateCarStateForUpdateDelete(c))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
