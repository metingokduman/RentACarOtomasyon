using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class CustomerController
    {
        CustomerManagment customerManagment;
        public CustomerController()
        {
            customerManagment = new CustomerManagment();
        }
        
        public bool AddUserRentDetailController(CustomerInformation urd)
        {
            if (!string.IsNullOrWhiteSpace(urd.Name) && !string.IsNullOrWhiteSpace(urd.LastName) && !string.IsNullOrWhiteSpace(urd.IdentityNo) && !string.IsNullOrWhiteSpace(urd.City))
            {
                customerManagment.AddCustomer(urd);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCustomerIdController(CustomerInformation urd)
        {
            if (urd.IdentityNo != null)
            {
                return customerManagment.GetCustomerId(urd);
            }
            else
            {
                MessageBox.Show("İdentityNo is null");
                return 0;
            }

        }
        
    }
}
