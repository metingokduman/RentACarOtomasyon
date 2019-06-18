using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
    public class RentedManagment
    {
        DataContext database;
        public RentedManagment()
        {
            database = new DataContext();
        }
        public bool AddRentedDetail(RentedDetail ucd)
        {
            if (ucd != null)
            {
                database.RentedDetails.Add(ucd);
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<RentedDetail> ShowRentDays(RentedDetail r)
        {
            List<RentedDetail> rentedDetails = new List<RentedDetail>();
            var result = database.RentedDetails.FirstOrDefault(x => x.FirstRentDate <= r.LastRentDate && x.LastRentDate >= r.FirstRentDate);
            if (result == null)
            {
                return rentedDetails;
            }
            else
            {
                List<RentedDetail> rentedDetail = database.RentedDetails.Where(x => x.FirstRentDate <= r.LastRentDate && x.LastRentDate >= r.FirstRentDate).ToList()
               .Select(x => new RentedDetail { CarId = x.CarId }).ToList();
                return rentedDetail;
            }
        }

        public List<RentedDetail> ShowRentDayForDataGridWiew(RentedDetail r)
        {
            List<RentedDetail> rentedDetail = database.RentedDetails.Where(x => x.CarId == r.CarId).ToList()
                .Select(x => new RentedDetail
                {
                    FirstRentDate = x.FirstRentDate,
                    LastRentDate = x.LastRentDate
                }).ToList();
            return rentedDetail;
        }
        public bool IfAvaible(RentedDetail r)
        {
            var result = database.RentedDetails.FirstOrDefault(x => x.FirstRentDate <= r.LastRentDate && x.LastRentDate >= r.FirstRentDate );
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public List<RentedDetail> ShowUserRentPast(RentedDetail r)
        {
            List<RentedDetail> rentedDetail = database.RentedDetails.Where(x => x.UserId == r.UserId).ToList()
                .Select(x => new RentedDetail
                {
                    CarId = x.CarId,
                    RentedDetailId = x.RentedDetailId,
                    FirstRentDate = x.FirstRentDate,
                    LastRentDate = x.LastRentDate,
                    CountOfRentDay = x.CountOfRentDay,
                    TotalRentPrice = x.TotalRentPrice
                }).ToList();

            return rentedDetail;

        }


        public List<RentedDetail> CarRentedTimesContoller()
        {
            List<RentedDetail> rentedDetails;
            rentedDetails = database.RentedDetails.Where(x => x.LastRentDate < DateTime.Now ).ToList().Select(x=> new RentedDetail { CarId= x.CarId } ).ToList();
            if (rentedDetails.Count == 0)
            {
                return null;
            }
            else
            {
                return rentedDetails;
            }

        }
        public List<RentedDetail> UpdateCarState()
        {
            List<RentedDetail> rentedDetails;
            List<int> idList = new List<int>();
            foreach (RentedDetail item in CarRentedTimesContoller())
            {
                idList.Add(item.CarId);
            }
             rentedDetails = database.RentedDetails.Where(x => idList.Contains(x.CarId) && x.LastRentDate<DateTime.Now).ToList().Select(x => new RentedDetail { CarId = x.CarId }).ToList(); ;

            if (rentedDetails.Count == 0)
            {
                return null;
            }
            else
            {
                return rentedDetails;
            }

        }



    }
}
