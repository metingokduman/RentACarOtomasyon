using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class RentedContoller
    {

        RentedManagment rentedManagment;
        public RentedContoller()
        {
            rentedManagment = new RentedManagment();
        }

        public bool AddUserDetailContoller(RentedDetail ucd)
        {
            if (!ucd.TotalRentPrice.HasValue && !ucd.CountOfRentDay.HasValue)
            {
                return false;
            }
            else
            {
                rentedManagment.AddRentedDetail(ucd);
                return true;
            }
        }

        public List<RentedDetail> ShowRentDaysController(RentedDetail r)
        {
            if (r.FirstRentDate != null && r.LastRentDate != null)
            {
                return rentedManagment.ShowRentDays(r);
            }
            else
            {
                return null;
            }

        }

        public List<RentedDetail> ShowRentDaysForDtgridview(RentedDetail r)
        {
            if (r.CarId != 0)
            {
                return rentedManagment.ShowRentDayForDataGridWiew(r);
            }
            else
            {
                return null;
            }

        }

        public bool IfAvaibleConroller(RentedDetail r)
        {
            return rentedManagment.IfAvaible(r);
        }

        public List<RentedDetail> ShowUserRentPastContoller(RentedDetail r)
        {
            if (r.UserId != 0)
            {
                return rentedManagment.ShowUserRentPast(r);
            }
            else
            {
                return null;
            }

        }
        public List<RentedDetail> UpdateCarStateController()
        {
            return rentedManagment.UpdateCarState();

        }

    }
}
