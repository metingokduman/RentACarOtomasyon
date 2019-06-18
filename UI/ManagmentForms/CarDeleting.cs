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
    public partial class CarDeleting : Form
    {
        FormsHelper helper;
        CarInformation car;
        CarController carController;
        AdminInterFace adminInterFace;
        public int AdminId { get; set; }
        AdminLogInf adminLogInf;
        AdminLogInfController adminLogInfController;
        public CarDeleting()
        {
            adminInterFace = new AdminInterFace();
            adminLogInf = new AdminLogInf();
            adminLogInfController = new AdminLogInfController();
            helper = new FormsHelper();
            car = new CarInformation();
            carController = new CarController();
            InitializeComponent();
        }

        private void dtgrdDeleteCar_Click(object sender, EventArgs e)
        {

            if ((IfAvaibleForRenting)dtgrdDeleteCar.SelectedRows[0].Cells[7].Value == IfAvaibleForRenting.Active)
            {
                car.CarId = Convert.ToInt32(dtgrdDeleteCar.SelectedRows[0].Cells[0].Value);
                car.DailyPrice = Convert.ToDouble(dtgrdDeleteCar.SelectedRows[0].Cells[6].Value);
                car.ChassisNo = dtgrdDeleteCar.SelectedRows[0].Cells[5].Value.ToString();
                int carId = car.CarId;
                double? dailyPrice = car.DailyPrice;
                txtSaseNo.Text = car.ChassisNo;
            }
            else
            {
                MessageBox.Show("Bu araba kullanımda, silemezsiniz");
            }

        }

        private void AdminDeleteCar_Load(object sender, EventArgs e)
        {
            dtgrdDeleteCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrdDeleteCar.MultiSelect = false;

            dtgrdDeleteCar.DataSource = carController.List();
            helper.DatagridViewCarListAdminHeaderText(dtgrdDeleteCar);
            helper.DatagridviewDrawColoring(dtgrdDeleteCar);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            car.ChassisNo = txtSaseNo.Text.Trim().ToUpper();
            DialogResult dialogResult = MessageBox.Show("Bu araba sistemden silinecek, emin misiniz?", "WARNING!!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                carController.DeleteCarController(car);
               
                adminLogInf.AdminId = AdminId;
                adminLogInf.CarId = carController.GetCarIdController(car);
                adminLogInf.ProcessType = "DeleteCar";
                adminLogInfController.AddAdminLogInfController(adminLogInf);
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti");
                dtgrdDeleteCar.DataSource = carController.List();
                helper.DatagridViewCarListAdminHeaderText(dtgrdDeleteCar);
                helper.DatagridviewDrawColoring(dtgrdDeleteCar);
                txtSaseNo.Text = string.Empty;


            }
            else if (dialogResult == DialogResult.No)
            {
                adminInterFace.AdminId = AdminId;
                adminInterFace.Show();
                this.Hide();

            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            adminInterFace.AdminId = AdminId;
            adminInterFace.Show();
            this.Hide();
        }
    }
}
