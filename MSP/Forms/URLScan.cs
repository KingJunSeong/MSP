using MSP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP.Forms
{
    public partial class URLScan : Form
    {
        public URLScan()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    //btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void URLScan_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btn_ScanStart_Click(object sender, EventArgs e)
        {
            if(textbox_url.Text == "")
            {
                MessageBox.Show("URL을 입력해주세요!");
                return;
            }
            if (!urlCheck.IsUrl(textbox_url.Text))
            {
                MessageBox.Show("URL형식이 올바르지 않아요!");
                return;
            }
            MessageBox.Show(urlEncoding.UrlEncode(textbox_url.Text));
        }
    }
}
