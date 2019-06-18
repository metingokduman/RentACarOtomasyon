using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class AdminLogInfController
    {
        AdminLongInfManagment adminLongInfManagment;
        public AdminLogInfController()
        {
            adminLongInfManagment = new AdminLongInfManagment();
        }

        public bool AddAdminLogInfController(AdminLogInf a)
        {
            adminLongInfManagment.AddAdminLogInf(a);
            return true;
        }
    }
}
