using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class UserManagment
    {
        DataContext database;
        public UserManagment()
        {
            database = new DataContext();
        }
        public bool AddUser(UserInformation uL)
        {
            database.UserInformations.Add(uL);
            database.SaveChanges();
            return true;

        }
        public bool IfExistUser(UserInformation uL)
        {
            var result = database.UserInformations.FirstOrDefault(x => x.EmailAdress == (uL.EmailAdress));

            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetUserLoginEntity(UserInformation uL)
        {
            UserInformation userLogin;
            userLogin = database.UserInformations.FirstOrDefault(x => x.EmailAdress == (uL.EmailAdress) && x.Password == (uL.Password));
            if (userLogin != null)
            {
                return userLogin.UserTitle;
            }
            else
            {
                return string.Empty;
            }
        }
        public int GetUserId(UserInformation uL)
        {
            UserInformation userLogin;
            userLogin = database.UserInformations.FirstOrDefault(x => x.EmailAdress == (uL.EmailAdress) && x.Password == (uL.Password));
            if (userLogin != null)
            {
                return userLogin.UserId;
            }
            else
            {
                return 0;
            }
        }
        public bool IfExistUserLogin(UserInformation uL)
        {
            var result = database.UserInformations.FirstOrDefault(x => x.EmailAdress == (uL.EmailAdress) && x.Password == (uL.Password));
            if (result != null)
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
