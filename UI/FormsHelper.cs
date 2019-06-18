using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;


namespace UI
{
    public class FormsHelper
    {
        public FormsHelper()
        {
        }
        public void FormCleaner(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        public bool PanelControl(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text.Trim() == string.Empty)
                    {
                        return false;

                    }
                }

            }
            return true;
        }
        
        public void DatagridviewDrawColoring(DataGridView dataGridView)
        {
            int counter = dataGridView.Rows.Count;

            for (int i = 0; i < counter; i++)
            {
                if (i % 2==0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
            }
            //dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

        }
        public bool UserEmailControl(UserInformation UL)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(UL.EmailAdress, expresion))
            {
                if (Regex.Replace(UL.EmailAdress, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void DatagridViewRentDateRowHide(DataGridView dataGrid)
        {
            
            dataGrid.Columns[1].HeaderText = "BAŞLANGIÇ TARİHİ";
            dataGrid.Columns[2].HeaderText = "BİTİŞ TARİHİ";
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[3].Visible = false;
            dataGrid.Columns[4].Visible = false;
            dataGrid.Columns[5].Visible = false;
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
            dataGrid.Columns[10].Visible = false;
        }
        public void DatagridViewUserRentPastRowHide(DataGridView dataGrid)
        {

            dataGrid.Columns[0].HeaderText = "FATURA NO";
            dataGrid.Columns[2].HeaderText = "BİTİŞ TARİHİ";
            dataGrid.Columns[1].HeaderText = "BAŞLANGIÇ TARİHİ";
            dataGrid.Columns[3].HeaderText = "KİRALANMIŞ GÜN SAYISI";
            dataGrid.Columns[4].HeaderText = "TOPLAM ÜCRET";
            dataGrid.Columns[5].HeaderText = "ARABA NUMARASI";
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
            dataGrid.Columns[10].Visible = false;
        }
        public void DatagridViewCarListRowHide(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[5].Visible = false;
            dataGrid.Columns[7].Visible = false;
           
            
        }
        public void DatagridViewCarListUserHeaderText(DataGridView dataGrid)
        {
           
            dataGrid.Columns[1].HeaderText = "MARKA";
            dataGrid.Columns[2].HeaderText = "MODEL";
            dataGrid.Columns[3].HeaderText = "KM BİLGİSİ";
            dataGrid.Columns[4].HeaderText = "YIL";
            dataGrid.Columns[6].HeaderText = "GÜNLÜK FİYATI";
        
        }
        public void DatagridViewCarListAdminHeaderText(DataGridView dataGrid)
        {
            DatagridViewCarListUserHeaderText(dataGrid);

            dataGrid.Columns[0].HeaderText = "ARABA NO";
            dataGrid.Columns[5].HeaderText = "ŞASİ NO";
            dataGrid.Columns[7].HeaderText = "KİRADA OLMA DURUMU";
        }


    }
    
}
