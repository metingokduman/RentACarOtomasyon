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
    public partial class AdminRegisterInterface : Form
    {
        UserInformation ul;
        UserContoller ulc;
        FormsHelper helper;
        AdminInterFace adminInterFace;
        public int AdminId { get; set; }
        public AdminRegisterInterface()
        {
            adminInterFace = new AdminInterFace();
            ul = new UserInformation();
            ulc = new UserContoller();
            helper = new FormsHelper();
            InitializeComponent();
        }

        private void btnModeratorRegister_Click(object sender, EventArgs e)
        {
            if (!helper.PanelControl(pnlAddModerator))
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz");
            }
            else
            {
                ul.EmailAdress = txtModeratorMailAdress.Text.Trim().ToLower();
                ul.Password = txtModeratorPassword.Text.Trim();
                ul.UserTitle = cmbxTitle.SelectedItem.ToString();
                if (!ulc.IfExistUserController(ul))
                {
                    ulc.AddUserController(ul);
                    DialogResult dialogResult = MessageBox.Show("İşlem başarı ile gerçekleşti yönetici sayfasına dönmek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        adminInterFace.AdminId = AdminId;
                        adminInterFace.Show();
                        this.Hide();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        helper.FormCleaner(pnlAddModerator);
                    }
                }
                else
                {
                    MessageBox.Show("Sistemde kaydınız bulunmaktadır, lütfen giriş yapınız.");
                }
            }
        }

        private void AdminAddModerator_Load(object sender, EventArgs e)
        {
            cmbxTitle.SelectedIndex = 0;
        }

        private void cmbxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;

        }

        private void txtModeratorPassword_TabStopChanged(object sender, EventArgs e)
        {
            txtModeratorPassword.MaxLength = 8;
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            adminInterFace.AdminId = AdminId;
            adminInterFace.Show();
            this.Hide();
        }
    }
}
