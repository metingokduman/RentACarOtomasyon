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
    public partial class RentPage : Form
    {
        public RentPage()
        {
            InitializeComponent();
        }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public double? TotalPrice { get; set; }
        public int? RentDay { get; set; }
        public string ChassisNo { get; set; }
        public DateTime FirstRentDay { get; set; }
        public DateTime LastRentDay { get; set; }
        CustomerInformation customer;
        CustomerController customerController;
        RentedDetail rentedDetail;
        RentedContoller rentedContoller;
        CarInformation car;
        CarController carController;
        FormsHelper helper;
        UserInterFace userInterFace;
        private void CustomerRentForm_Load(object sender, EventArgs e)
        {
            userInterFace = new UserInterFace();
            helper = new FormsHelper();
            car = new CarInformation();
            carController = new CarController();
            customer = new CustomerInformation();
            customerController = new CustomerController();
            rentedDetail = new RentedDetail();
            rentedContoller = new RentedContoller();

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int birthdate = dtpckerBirthDate.Value.Year;
            int today = DateTime.Now.Year;
            int year = today - birthdate;
            if (!helper.PanelControl(pnlCustomerRentForm) || txtUserIdentity.TextLength != 11 || year < 18)
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz doldurunuz, (18 yaşından küçükler işlem yapamaz.) ");
            }
            else
            {
                customer.Name = txtUserName.Text.Trim().ToUpper();
                customer.LastName = txtUserSurname.Text.Trim().ToUpper();
                customer.IdentityNo = txtUserIdentity.Text.Trim();
                customer.BirthDate = dtpckerBirthDate.Value;
                customer.City = txtUserCity.Text.Trim().ToUpper();

                if (customerController.AddUserRentDetailController(customer))
                {

                    rentedDetail.FirstRentDate = FirstRentDay;
                    rentedDetail.LastRentDate = LastRentDay;
                    rentedDetail.CarId = CarId;
                    rentedDetail.UserId = UserId;
                    rentedDetail.CountOfRentDay = RentDay;
                    rentedDetail.TotalRentPrice = TotalPrice;
                    rentedDetail.CutomerId = customerController.GetCustomerIdController(customer);
                    CarUpdate();
                    rentedContoller.AddUserDetailContoller(rentedDetail);


                    DialogResult dialogResult = MessageBox.Show("Kiralama işlem başarı ile gerçekleşti tekrar araba kiralamak ister misiniz? ", "Bilgi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Carlisting carlisting = new Carlisting();
                        carlisting.UserId = UserId;
                        carlisting.Show();
                        this.Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        userInterFace.UserId = UserId;
                        userInterFace.Show();
                        this.Hide();

                    }
                }
                
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtUserIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CarUpdate()
        {
            car.CarId = CarId;
            car.ChassisNo = ChassisNo;
            car.IfAvaibleForRenting = IfAvaibleForRenting.Passive;
            carController.UpdateIfIsActiveForRenting(car);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            userInterFace.UserId = UserId;
            userInterFace.Show();
            this.Hide();
        }

        private void btnGoBackCarListing_Click(object sender, EventArgs e)
        {
            Carlisting carlisting = new Carlisting();
            carlisting.UserId = UserId;
            carlisting.Show();
            this.Hide();
        }
    }
}
