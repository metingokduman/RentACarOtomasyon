using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ManagmentForms;

namespace UI
{

    public partial class AdminInterFace : Form
    {
        public int AdminId { get; set; }
        public AdminInterFace()
        {
            InitializeComponent();
        }

        private void arabaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd adminAddCar = new CarAdd();
            adminAddCar.AdminId = AdminId;
            adminAddCar.Show();
            this.Hide();
        }

        private void arabaÖzellikleriDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarInfoUpdate adminUpdateCar = new CarInfoUpdate();
            adminUpdateCar.AdminId = AdminId;
            adminUpdateCar.Show();
            this.Hide();
        }
        private void araçKiralamaAraYüzüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carlisting userInterFace = new Carlisting();
            userInterFace.UserId = AdminId;
            userInterFace.Show();
            this.Hide();
        }

        private void kullanıcıEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminRegisterInterface adminAddModerator = new AdminRegisterInterface();
            adminAddModerator.AdminId = AdminId;
            adminAddModerator.Show();
            this.Hide();
        }

        private void araçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarDeleting adminDeleteCar = new CarDeleting();
            adminDeleteCar.AdminId = AdminId;
            adminDeleteCar.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Close();
        }

        private void araçYıllıkKmGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminShowingCarKmPast adminShowingCarKmPast = new AdminShowingCarKmPast();
            adminShowingCarKmPast.Show();
            this.Close();
        }
    }
}
