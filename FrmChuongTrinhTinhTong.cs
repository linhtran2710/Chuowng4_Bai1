using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuowng4_Bài1
{
    public partial class FrmChuongTrinhTinhTong : Form
    {
        public FrmChuongTrinhTinhTong()
        {
            InitializeComponent();
        }
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
                (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) ||
                 (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
              (e.KeyChar == '-') || (e.KeyChar == '.') ||
              (Convert.ToInt32(e.KeyChar) == 8) ||
               (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            if(a<b)
            {
                for(int i = a; i <= b; i++)
                { tong = tong + 1; }    
            } 
            if(a>b)
            {
                for(int i=b; i<=a; i++)
                { tong = tong + i; }    
            }    

            lbTong.Text = "Tong cac so tu" + a + "den" + b + tong.ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lbTong.Text = "";
        } 
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
