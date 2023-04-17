using MSP.Utils;
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
                hash = FileHash.Getmd5FromFiles(openfile.FileName);
                label3.Text = "MD5 : " + FileHash.Getmd5FromFiles(textbox_filePath.Text);
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

            Task task = APIFileScan(hash);
            
        }

        public async Task APIFileScan(string hash)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://www.virustotal.com/api/v3/files/{hash}"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "x-apikey", $"{APIKey.apikey}" },
                },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var analysis_id = JObject.Parse(body)?["data"]?["attributes"]?["last_analysis_results"];
            var engine_name = analysis_id?
                .Values<JProperty>()
                .Where(v => v?.Value["category"]?.ToString() == "malicious")
                .Select(v => v?.Value["engine_name"]?.ToString());
            var malware = analysis_id?.Count();
            var malwareCount = engine_name.Count();

            label_virus_count.Text = malwareCount.ToString();
            label_engine_count.Text = malware.ToString();
        }
    }
}
