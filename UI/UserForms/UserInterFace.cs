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
    
    public partial class UserInterFace : Form
    {
        RentedDetail rentedDetail;
        RentedContoller rentedContoller;
        CarImage carImage;
        CarImageController carImageController;
        FormsHelper helper;
        public int UserId { get; set; }
        public UserInterFace()
        {
            helper = new FormsHelper();
            carImage = new CarImage();
            carImageController = new CarImageController();
            rentedContoller = new RentedContoller();
            rentedDetail = new RentedDetail();
            InitializeComponent();
        }
        private void UserInterFace_Load(object sender, EventArgs e)
        {
            lblInf.Visible = false;
            pctrBoxCarImage.Visible = false;
            btnCarPicture.Visible = false;
            dtgridbiewRentedPast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgridbiewRentedPast.MultiSelect = false;
            dtgridbiewRentedPast.Visible = false;
        }
        private void araçKiralaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Carlisting userInterFace = new Carlisting();
            userInterFace.UserId = UserId;
            userInterFace.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Close();
        }

        private void kiralamaGeçmişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            if (rentedContoller.ShowUserRentPastContoller(rentedDetail)==null)
            {
                dtgridbiewRentedPast.DataSource = null;
                
                lblInf.Visible = true;

            }
            else
            {
                dtgridbiewRentedPast.Visible = true;
                pctrBoxCarImage.Visible = true;
                rentedDetail.UserId = UserId;
                dtgridbiewRentedPast.DataSource = rentedContoller.ShowUserRentPastContoller(rentedDetail);
                helper.DatagridViewUserRentPastRowHide(dtgridbiewRentedPast);
                helper.DatagridviewDrawColoring(dtgridbiewRentedPast);
            }
            

         
        }


        int index = 0;
        List<Byte[]> imageList ;
        private void dtgridbiewRentedPast_Click(object sender, EventArgs e)
        {
            btnCarPicture.Visible = true;
            pctrBoxCarImage.Image = null;
            imageList = new List<Byte[]>();
            carImage.CarId = Convert.ToInt32(dtgridbiewRentedPast.SelectedRows[0].Cells[5].Value);

            foreach (CarImage itemmm in carImageController.ListCar(carImage))
            {
                imageList.Add(itemmm.Image);

            }
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
