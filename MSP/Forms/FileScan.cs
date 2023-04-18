﻿using MSP.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
                if (!fileAccessCheck.IsAccessAble(openfile.FileName))
                {
                    MessageBox.Show("File is in use by another process Please end it");
                    textbox_filePath.Text = "";
                    return;
                }
                textbox_filePath.Text = openfile.FileName;
                textbox_filePath.Enabled = false;
                hash = FileHash.Getmd5FromFiles(openfile.FileName);
                label_hash.Text = "MD5 : " + FileHash.Getmd5FromFiles(textbox_filePath.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textbox_filePath.Text == string.Empty)
            {
                MessageBox.Show("Please select a file first");
                return;
            }
            MessageBox.Show("This may take some time. Press the .\nOK button to start.");

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

            var analysis_stats = JObject.Parse(body)?["data"]?["attributes"]?["last_analysis_stats"];
            var analysis_id = JObject.Parse(body)?["data"]?["attributes"]?["last_analysis_results"];
            var engine_name = analysis_id?
                .Values<JProperty>()
                .Where(v => v?.Value["category"]?.ToString() == "malicious")
                .Select(v => v?.Value["engine_name"]?.ToString());
            var malware = analysis_id?.Count();
            var malwareCount = engine_name.Count();

            var harmless = analysis_stats["harmless"].ToString();
            var typeunsupported = analysis_stats["type-unsupported"].ToString();
            var suspicious = analysis_stats["suspicious"].ToString();
            var confirmedtimeout = analysis_stats["confirmed-timeout"].ToString();
            var timeout = analysis_stats["timeout"].ToString();
            var failure = analysis_stats["failure"].ToString();
            var malicious = analysis_stats["malicious"].ToString();
            var harundetectedmless = analysis_stats["undetected"].ToString();

            label1.Text = "harmless : " + harmless;
            label2.Text = "type-unsupported : " + typeunsupported;
            label3.Text = "suspicious : " + suspicious;
            label4.Text = "confirmed-timeout : " + confirmedtimeout;
            label5.Text = "timeout : " + timeout;
            label6.Text = "failure : " + failure;
            label7.Text = "malicious : " + malicious;
            label8.Text = "undetected : " + harundetectedmless;
        }
    }
}
