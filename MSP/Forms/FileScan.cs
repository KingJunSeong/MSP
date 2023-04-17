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
    public partial class FileScan : Form
    {
        public string hash;
        public FileScan()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach(Control btns in this.Controls)
            {
                if(btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FileScan_Load(object sender, EventArgs e)
        {
            LoadTheme();
            textbox_filePath.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Filter = "All Files | *.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                textbox_filePath.Text = openfile.FileName;
                textbox_filePath.Enabled = false;
                hash = Utils.FileHash.Getmd5FromFiles(openfile.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textbox_filePath.Text == string.Empty)
            {
                MessageBox.Show("파일을 먼저 선택하여 주세요!");
                return;
            }
            MessageBox.Show("시간이 다소 소요될 수 있습니다. . .\n확인 버튼을 누르면 시작합니다.");

            Utils.FileScan.APIFileScan(hash);
        }

        public void virusCount()
        {
            string count = Utils.FileScan.virusCount;
            
        }
        public void engineCount(string count)
        {
            label_engine_count.Text = count;
        }
    }
}
