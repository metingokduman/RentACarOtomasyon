using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class LoginPage : Form
    {
        UserInformation ul;
        UserContoller ulc;
        UserInterFace userInterface;
        AdminInterFace adminInterFace;
        FormsHelper helper;
        CarInformation car;
        CarController carController;
       
        RentedContoller rentedContoller;

        public LoginPage()
        {
            helper = new FormsHelper();
            ulc = new UserContoller();
            ul = new UserInformation();
            userInterface = new UserInterFace();
            adminInterFace = new AdminInterFace();
            car = new CarInformation();
            carController = new CarController();
            
            rentedContoller = new RentedContoller();
         
            //txtMailAdress.Text = "metin@metin.com";
            //txtPassword.Text = "12345678";
            InitializeComponent();
            
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            if (rentedContoller.UpdateCarStateController()!=null)
            {
                foreach (RentedDetail item in rentedContoller.UpdateCarStateController())
                {
                    car.CarId = item.CarId;
                    car.IfAvaibleForRenting = IfAvaibleForRenting.Active;
                    carController.UpdateCarStateForUpdateDeleteController(car);
                }
            }
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!helper.PanelControl(pnlLogin))
            {
                MessageBox.Show("Lütfen email adresi ve şifre giriniz");
            }
            else
            {
                ul.EmailAdress = txtMailAdress.Text.Trim();
                ul.Password = txtPassword.Text.Trim();

                if (ulc.UserLogincontrol(ul))
                {
                    if (ulc.GetUserLoginEntityControl(ul) == "Müşteri")
                    {
                        userInterface.UserId = ulc.GetUserIdControl(ul);
                        userInterface.Show();
                        this.Hide();
                    }

                    else
                    {
                        adminInterFace.AdminId = ulc.GetUserIdControl(ul);
                        adminInterFace.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Sistemde kayıtlı değilsiniz lütfen kayıt olun.");
                }
            }
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!helper.PanelControl(pnlLogin))
            {
                MessageBox.Show("Lütfen email adresi ve şifre giriniz");
            }
            else
            {
                ul.EmailAdress = txtMailAdress.Text.Trim();
                ul.Password = txtPassword.Text.Trim();
                ul.UserTitle = "Müşteri";
                if (!helper.UserEmailControl(ul))
                {
                    MessageBox.Show("Lütfen email formatına uygun giriş yapınız");
                }
                else
                {
                    if (!ulc.IfExistUserController(ul))
                    {
                        ulc.AddUserController(ul);
                        DialogResult dialogResult = MessageBox.Show("işlem başarı ile gerçekleşti kullanıcı sayfanıza gitmek istermisiniz", "Bilgi", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (ulc.GetUserLoginEntityControl(ul) != "Müşteri")
                            {
                                adminInterFace.AdminId = ulc.GetUserIdControl(ul);
                                adminInterFace.Show();
                                this.Hide();
                            }
                            else
                            {
                                userInterface.UserId = ulc.GetUserIdControl(ul);
                                userInterface.Show();
                                this.Hide();
                            }

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            FormsHelper formsHelper = new FormsHelper();
                            formsHelper.FormCleaner(pnlLogin);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sistemde kaydınız bulunmaktadır, lütfen giriş yapınız.");
                    }
                }
               
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        
    }
}
