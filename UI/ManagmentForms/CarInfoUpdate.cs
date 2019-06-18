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
    public partial class CarInfoUpdate : Form
    {
        public int AdminId { get; set; }
        CarInformation car;
        CarController carController;
        FormsHelper helper;
        AdminLogInf adminLogInf;
        AdminLogInfController adminLogInfController;
        CarKmPast carKmPast;
        CarKmPastController carKmPastController;

        public CarInfoUpdate()
        {
            carKmPast = new CarKmPast();
            carKmPastController = new CarKmPastController();
            adminLogInf = new AdminLogInf();
            adminLogInfController = new AdminLogInfController();
            helper = new FormsHelper();
            car = new CarInformation();
            carController = new CarController();
            InitializeComponent();
        }

        private void txtGunlukUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AdminUpdateCarInformation_Load(object sender, EventArgs e)
        {
            dtgrdUpdateCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrdUpdateCar.MultiSelect = false;
            dtgrdUpdateCar.DataSource = carController.List();
            helper.DatagridViewCarListAdminHeaderText(dtgrdUpdateCar);
            helper.DatagridviewDrawColoring(dtgrdUpdateCar);

        }

        private void dtgrdUpdateCar_Click(object sender, EventArgs e)
        {

            if ((IfAvaibleForRenting)dtgrdUpdateCar.SelectedRows[0].Cells[7].Value == IfAvaibleForRenting.Active)
            {
                car.CarId = Convert.ToInt32(dtgrdUpdateCar.SelectedRows[0].Cells[0].Value);
                car.DailyPrice = Convert.ToDouble(dtgrdUpdateCar.SelectedRows[0].Cells[6].Value);
                car.ChassisNo = dtgrdUpdateCar.SelectedRows[0].Cells[5].Value.ToString();

                int kmInfo = Convert.ToInt32(dtgrdUpdateCar.SelectedRows[0].Cells[3].Value);
                int carId = car.CarId;
                txtGunlukUcret.Text = car.DailyPrice.ToString();
                txtKmBilgisi.Text = car.ChassisNo;

            }
            else
            {
                MessageBox.Show("Bu araba kullanımda, araba bilgilerini güncelleyemezsiniz");
            }

        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            car.DailyPrice = Convert.ToDouble(txtGunlukUcret.Text.Trim());
            car.KmInfo = Convert.ToInt32(txtKmBilgisi.Text.Trim());

            if ((IfAvaibleForRenting)dtgrdUpdateCar.SelectedRows[0].Cells[7].Value == IfAvaibleForRenting.Active)
            {
                carController.UpdateCarController(car);

                adminLogInf.AdminId = AdminId;
                adminLogInf.CarId = carController.GetCarIdController(car);
                adminLogInf.ProcessType = "updateCar";
                adminLogInfController.AddAdminLogInfController(adminLogInf);
                carKmPast.CarId = carController.GetCarIdController(car);
                carKmPast.KmInf = car.KmInfo;
                carKmPast.UpdateDate = DateTime.Now;
                carKmPastController.AddCarKmController(carKmPast);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti");
                dtgrdUpdateCar.DataSource = carController.List();
                helper.DatagridViewCarListAdminHeaderText(dtgrdUpdateCar);
                helper.DatagridviewDrawColoring(dtgrdUpdateCar);
                helper.FormCleaner(pnlUpdatePrice);

            }
            else
            {
                MessageBox.Show("Bu araba kullanımda, araba bilgilerini güncelleyemezsiniz");
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            AdminInterFace adminInterFace = new AdminInterFace();
            adminInterFace.AdminId = AdminId;
            adminInterFace.Show();
            this.Hide();

        }
    }
}
