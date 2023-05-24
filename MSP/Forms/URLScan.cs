using MSP.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            try
            {
                var res = JsonConvert.DeserializeObject<URLResponse>(body);
                var stats = res.Data.Attributes.LastAnalysisStats;

                label1.Text = "harmless : " + stats.Harmless;
                label3.Text = "suspicious : " + stats.Suspicious;
                label5.Text = "timeout : " + stats.Timeout;
                label7.Text = "malicious : " + stats.Malicious;
                label8.Text = "undetected : " + stats.Undetected;
                label_result.Text = "Scan Success!";

                DrawPieChart(chart1, (int)stats.Harmless, (int)stats.Suspicious, (int)stats.Timeout, (int)stats.Malicious, (int)stats.Undetected);
                Print_URLScanLog(textbox_url.Text);
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
            } 
        }
        private void Print_URLScanLog(string URL)
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MSP");
            var logfile = folder + @"\log.txt";
            DirectoryInfo dir = new DirectoryInfo(folder);
            if (dir.Exists == false)
            {
                dir.Create();
            }
            string datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            using var writer = new StreamWriter(logfile, append: true);
            writer.WriteLine($"{datetime} - {URL}");
        }

        private void DrawPieChart(Chart chart, int value1, int value2, int value3, int value4, int value5)
        {

            chart.Series.Clear();
            chart.Legends.Clear();
            chart.Legends.Add("MyLegend");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Right;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].BorderColor = Color.Black;

            string seriesname = "MySeriesName";
            chart.Series.Add(seriesname);

            chart.Series[seriesname].ChartType = SeriesChartType.Pie;

            if (0 < value1) chart.Series[seriesname].Points.AddXY("harmless", value1);
            if (0 < value2) chart.Series[seriesname].Points.AddXY("suspicious", value2);
            if (0 < value3) chart.Series[seriesname].Points.AddXY("timeout", value3);
            if (0 < value4) chart.Series[seriesname].Points.AddXY("malicious", value4);
            if (0 < value5) chart.Series[seriesname].Points.AddXY("undetected", value5);
        }
    }
}
