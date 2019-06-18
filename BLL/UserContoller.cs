using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class UserContoller
    {
        UserManagment userManagment;
    
        public UserContoller()
        {
            userManagment = new UserManagment();
          
        }
        public bool AddUserController(UserInformation uL)
        {
            userManagment.AddUser(uL);
            return true;
        }
        public bool IfExistUserController(UserInformation uL)
        {
                if (userManagment.IfExistUser(uL))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public bool UserLogincontrol(UserInformation uL)
        {
            if (userManagment.IfExistUserLogin(uL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetUserLoginEntityControl(UserInformation uL)
        {
                return userManagment.GetUserLoginEntity(uL);
           
        }
        public int GetUserIdControl(UserInformation uL)
        {
            return userManagment.GetUserId(uL);
        }
       
    }
}
