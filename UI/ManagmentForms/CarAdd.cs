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
    public partial class CarAdd : Form
    {
        CarInformation car;
        CarController carController;
        AdminLogInf adminLogInf;
        AdminLogInfController adminLogInfController;
        FormsHelper helper;
        AdminInterFace adminInterFace;
        CarImage carImage;
        CarImageController carImageController;
        public int AdminId { get; set; }
        public CarAdd()
        {
            carImage = new CarImage();
            carImageController = new CarImageController();
            helper = new FormsHelper();
            adminInterFace = new AdminInterFace();
            car = new CarInformation();
            carController = new CarController();
            adminLogInf = new AdminLogInf();
            adminLogInfController = new AdminLogInfController();
            InitializeComponent();
        }

        static string carchasss;
        private void AdminAddCar_Load(object sender, EventArgs e)
        {
            carchasss = string.Empty;
        }
        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            CarInformation carrrr = new CarInformation();
            carrrr.ChassisNo = txtSaseNo.Text.Trim().ToUpper();
            if (!helper.PanelControl(pnlAdCarInf))
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz");
            }
            else
            {
                car.Brand = txtMarka.Text.Trim().ToUpper();
                car.ChassisNo = txtSaseNo.Text.Trim().ToUpper();
                car.KmInfo = Convert.ToInt32(txtKmBilgisi.Text.Trim());
                car.Model = txtModel.Text.Trim();
                car.ModelYear = Convert.ToInt32(txtModelYili.Text.Trim());
                car.DailyPrice = Convert.ToDouble(txtGunlukUcret.Text);
                if (!carController.IfExistChasissNoController(car))
                {
                    carController.AddCarController(car);
                    adminLogInf.AdminId = AdminId;
                    adminLogInf.CarId = carController.GetCarIdController(car);
                    adminLogInf.ProcessType = "AddCar";
                    adminLogInfController.AddAdminLogInfController(adminLogInf);
                    carImage.CarId = carController.GetCarIdController(carrrr);
                    for (int i = 0; i < imageList.Count; i++)
                    {
                        carImage.Image = imageList[i];
                        carImageController.AddCarImageController(carImage);
                    }
                    DialogResult dialogResult = MessageBox.Show("İşlem başarı ile gerçekleşti, tekrar araba eklemek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        helper.FormCleaner(pnlAdCarInf);
                        pctrBocCarImage.Image = null;
                        car = new CarInformation();
                        carImage = new CarImage();
                        imageList = new List<byte[]>();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        adminInterFace.AdminId = AdminId;
                        adminInterFace.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Sistemde böyle bir araba mevcut, şasi numarasını kontrol ediniz");
                }
            }
        }
        private void txtGunlukUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }


        private void btnGoBack_Click(object sender, EventArgs e)
        {
            adminInterFace.AdminId = AdminId;
            adminInterFace.Show();
            this.Hide();
        }
        List<Byte[]> imageList =new List<byte[]>();

        private void btnCarImageAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(dlg.FileName);
                    pctrBocCarImage.Image = bitmap;
                    byte[] byteArray = null;
                    ImageConverter converter = new ImageConverter();
                    byteArray = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
                    string converted = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                    imageList.Add(byteArray);
                }
            }
        }       
            
    }
}
