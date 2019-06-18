using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class AdminLongInfManagment
    {
        AdminLogInf adminLogInf;
        DataContext database;
        public AdminLongInfManagment()
        {
            adminLogInf = new AdminLogInf();
            database = new DataContext();

        }

        public bool AddAdminLogInf(AdminLogInf a)
        {
            AdminLogInf al;
            try
            {
                al = database.AdminLogInfs.Add(a);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
