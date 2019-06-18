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

namespace UI.ManagmentForms
{
    public partial class AdminShowingCarKmPast : Form
    {
        FormsHelper helper;
        CarController carController;
        CarKmPast carKmPast;
        CarKmPastController carKmPastController;
        public AdminShowingCarKmPast()
        {
            carKmPastController = new CarKmPastController();
            carKmPast = new CarKmPast();
            carController = new CarController();
            helper = new FormsHelper();
            InitializeComponent();
        }

        private void AdminShowingCarKmPast_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = carController.List();
            helper.DatagridViewCarListAdminHeaderText(dataGridView1);
            helper.DatagridviewDrawColoring(dataGridView1);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource= carKmPastController.ListCarKm(carKmPast);
            carKmPast.CarId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            dataGridView2.Columns[1].HeaderText = "KM BİLGİSİ";
            dataGridView2.Columns[2].HeaderText = "GÜNCELLEME TARİHİ";
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
           
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            AdminInterFace adminInterFace = new AdminInterFace();
            adminInterFace.Show();
            this.Hide();
        }
    }
}
