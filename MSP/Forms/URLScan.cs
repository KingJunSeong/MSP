using MSP.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Policy;
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
            MessageBox.Show("딱좋다.");
            label_result.Text = "Scanning...";
            string encodeingurl = urlEncoding.UrlEncode(textbox_url.Text);
            APIURLScan(encodeingurl);
        }
        public async Task APIURLScan(string url)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://www.virustotal.com/api/v3/urls/{url}"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "x-apikey", $"{APIKey.apikey}" },
                },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            
            var res = JsonConvert.DeserializeObject<URLResponse>(body);
            var stats = res.Data.Attributes.LastAnalysisStats;
            
            label1.Text = "harmless : " + stats.Harmless;
            label3.Text = "suspicious : " + stats.Suspicious;
            label5.Text = "timeout : " + stats.Timeout;
            label7.Text = "malicious : " + stats.Malicious;
            label8.Text = "undetected : " + stats.Undetected;
            label_result.Text = "Scan Success!";
        }
    }
}
