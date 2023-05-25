using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP.Forms
{
    public partial class Setting : Form
    {
        public static string apikey;
        public static event EventHandler Checkapiket;
        public static event EventHandler Editapiket;
        public Setting()
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
                }
            }
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            LoadTheme();
            button2.Enabled = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string url = String.Format($"https://www.virustotal.com/api/v3/files/0baeac29996d82b96e7599e8ffb35376");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("x-apikey", key);
                HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string json = await responseMessage.Content.ReadAsStringAsync();
                    JObject jObject = JObject.Parse(json);

                    if (jObject.Property("error") == null)
                    {
                        //api키 유효
                        Checkapiket(null, EventArgs.Empty);
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = true;
                        MessageBox.Show("키가 유효합니다.");
                        apikey = textBox1.Text;
                    }
                    else
                    {
                        //api키 재입력
                        MessageBox.Show("유효하지 않는 키 입니다. 다시 입력해주세요");
                    }
                }
                else
                {
                    //api키 재입력
                    MessageBox.Show("유효하지 않는 키 입니다. 다시 입력해주세요");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editapiket(null, EventArgs.Empty);
            textBox1.Enabled = true;
            button1.Enabled = true;
        }
    }
}
