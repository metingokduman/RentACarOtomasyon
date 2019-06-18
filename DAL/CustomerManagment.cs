using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CustomerManagment
    {
        DataContext database;
        public CustomerManagment()
        {
            database = new DataContext();

        }

        public bool AddCustomer(CustomerInformation urd)
        {
            if (urd != null)
            {
                database.CustomerInformations.Add(urd);
                database.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCustomerId(CustomerInformation urd)
        {
            CustomerInformation customerInformation;
            customerInformation = database.CustomerInformations.FirstOrDefault(x => x.IdentityNo == (urd.IdentityNo));
            if (customerInformation != null)
            {
                return customerInformation.CustomerId;
            }
            else
            {
                return 0;
            }

        }
    

    }
}
