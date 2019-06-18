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
using System.IO;

namespace UI
{
    public partial class Carlisting : Form
    {
        int carId;
        double? dailyPrice;
        string chassisNo;
        double? totalprice;
        int day;
        public int UserId { get; set; }
        CarInformation car;
        CarController carController;
        FormsHelper helper;
        RentedDetail rentedDetail;
        RentedContoller rentedContoller;
        CarImage carImage;
        CarImageController carImageController;
        public Carlisting()
        {
            carImage = new CarImage();
            carImageController = new CarImageController();
            rentedDetail = new RentedDetail();
            rentedContoller = new RentedContoller();
            helper = new FormsHelper();
            carController = new CarController();
            car = new CarInformation();
            InitializeComponent();
        }

        private void UserInterFace_Load(object sender, EventArgs e)
        {
            btnCarPicture.Visible = false;
            dtGrdViewCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGrdViewCarList.MultiSelect = false;
            btnRentPage.Enabled = false;
            btnCalculate.Enabled = false;
            helper.DatagridviewDrawColoring(dtGrdViewCarList);
            dailyPrice = 0;
            totalprice = 0;
            carId = 0;
            day = 0;
            chassisNo = string.Empty;
            int UID = UserId;
        }
        int index = 0;
        List<Byte[]> imageList;
        private void dtGrdViewCarList_Click(object sender, EventArgs e)
        {
            index = 0;
            btnCarPicture.Visible = true;
            pctrBoxCarImage.Image = null;
            imageList = new List<Byte[]>();
            dtGrdViewCarList.ReadOnly = true;
            lblTotalPrice.Text = string.Empty + "0 TL ";
            totalprice = 0;
            btnRentPage.Enabled = false;
            RentedDetail RRR = new RentedDetail();
            btnCalculate.Enabled = true;
            car.CarId = Convert.ToInt32(dtGrdViewCarList.SelectedRows[0].Cells[0].Value);
            car.DailyPrice = Convert.ToDouble(dtGrdViewCarList.SelectedRows[0].Cells[6].Value);
            car.ChassisNo = dtGrdViewCarList.SelectedRows[0].Cells[5].Value.ToString();
            carId = car.CarId;
            dailyPrice = car.DailyPrice;
            chassisNo = car.ChassisNo;
            RRR.CarId = carId;
            dtgrdviewRentCarDates.DataSource = rentedContoller.ShowRentDaysForDtgridview(RRR);
            helper.DatagridViewRentDateRowHide(dtgrdviewRentCarDates);
            helper.DatagridviewDrawColoring(dtgrdviewRentCarDates);
            carImage.CarId = carId;
            foreach (CarImage itemmm in carImageController.ListCar(carImage))
            {
                imageList.Add(itemmm.Image);
            }
        }
        DateTime start;
        DateTime end;

        private void txtRentDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCarSearch_Click(object sender, EventArgs e)
        {
            start = dtFirstRentDate.Value.Date;
            end = dtLastRentDate.Value.Date;
            if (end <= start)
            {
                MessageBox.Show("Kiralama bitiş tarihi başlangıç tarihiyle aynı yada küçük olamaz.");
            }
            else
            {
                rentedDetail.FirstRentDate = start;
                rentedDetail.LastRentDate = end;

                if (rentedContoller.IfAvaibleConroller(rentedDetail))
                {
                    List<CarInformation> cars = new List<CarInformation>();

                    CarInformation carInf;
                    foreach (RentedDetail item in rentedContoller.ShowRentDaysController(rentedDetail))
                    {
                        carInf = new CarInformation();
                        carInf.CarId = item.CarId;
                        cars.Add(carInf);

                    }
                    dtGrdViewCarList.DataSource = carController.ListCar(cars);
                    helper.DatagridViewCarListRowHide(dtGrdViewCarList);
                    helper.DatagridViewCarListUserHeaderText(dtGrdViewCarList);
                    helper.DatagridviewDrawColoring(dtGrdViewCarList);
                }
                else
                {
                    dtGrdViewCarList.DataSource = carController.List();
                    helper.DatagridViewCarListRowHide(dtGrdViewCarList);
                    helper.DatagridViewCarListUserHeaderText(dtGrdViewCarList);
                    helper.DatagridviewDrawColoring(dtGrdViewCarList);
                }
            }


        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            day = Convert.ToInt32(end.Subtract(start).Days);


            btnRentPage.Enabled = true;
            DiscountfeeCalculator discountfee = new DiscountfeeCalculator();

            if (day < 7)
            {
                totalprice = dailyPrice * day;

            }
            else if (day >= 7 && day < 10)
            {
                totalprice = discountfee.Day7to9(car) * day;
            }
            else if (day >= 10 && day < 30)
            {
                totalprice = discountfee.Day10to29(car) * day;
            }
            else
            {
                totalprice = discountfee.DayOverMonth(car) * day;
            }
            lblTotalPrice.Text = totalprice.ToString() + "  TL";

        }

        private void btnRentPage_Click_1(object sender, EventArgs e)
        {
            RentPage crf = new RentPage();
            crf.CarId = carId;
            crf.UserId = UserId;
            crf.TotalPrice = totalprice;
            crf.RentDay = day;
            crf.ChassisNo = chassisNo;
            crf.FirstRentDay = start;
            crf.LastRentDay = end;
            crf.Show();
            this.Hide();
        }

        private void dtFirstRentDate_ValueChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
            btnRentPage.Enabled = false;
            dtGrdViewCarList.DataSource = null;
            dtgrdviewRentCarDates.DataSource = null;
            dtFirstRentDate.MinDate = DateTime.Now;
            dtLastRentDate.MinDate = DateTime.Now;
            lblTotalPrice.Text = string.Empty + " 0 TL";
        }

        private void btnGoBac_Click(object sender, EventArgs e)
        {
            UserInterFace userInterFace = new UserInterFace();
            userInterFace.UserId = UserId;
            userInterFace.Show();
            this.Hide();
        }



        private void dtGrdViewCarList_DoubleClick(object sender, EventArgs e)
        {
            dtGrdViewCarList.ReadOnly = true;
        }

        private void dtgrdviewRentCarDates_Click(object sender, EventArgs e)
        {
            dtgrdviewRentCarDates.ReadOnly = true;
        }

        private void dtgrdviewRentCarDates_DoubleClick(object sender, EventArgs e)
        {
            dtgrdviewRentCarDates.ReadOnly = true;
        }

        private void dtGrdViewCarList_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            btnCarSearch.Enabled = true;
        }

        private void dtGrdViewCarList_MouseDown(object sender, MouseEventArgs e)
        {
            btnCarSearch.Enabled = true;
        }



        private void btnCarPicture_Click(object sender, EventArgs e)
        {
            btnCarPicture.Text = "Sonraki Fotoğraf";
            if (index == imageList.Count)
            {
                index = 0;
            }
            MemoryStream ms = new MemoryStream(imageList[index]);
            pctrBoxCarImage.Image = Image.FromStream(ms);
            index++;
        }
    }
}
