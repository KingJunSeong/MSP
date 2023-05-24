using MSP.JsonObject;
using MSP.Utils;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSP.Forms
{
    public partial class FileScan : Form
    {
        public string hash;
        public string filenames;
        public FileScan()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in Controls)
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
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                if (!fileAccessCheck.IsAccessAble(openfile.FileName))
                {
                    MessageBox.Show("File is in use by another process Please end it");
                    return;
                }
                textbox_filePath.Text = openfile.FileName;
                textbox_filePath.Enabled = false;
                hash = FileHash.Getmd5FromFiles(openfile.FileName);
                filenames = openfile.SafeFileName;
                textbox_md5.Text = FileHash.Getmd5FromFiles(textbox_filePath.Text);
                textbox_sha1.Text = FileHash.Getsha1FromFiles(textbox_filePath.Text);
                textbox_sha256.Text = FileHash.Getsha256FromFiles(textbox_filePath.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox_filePath.Text == string.Empty)
            {
                MessageBox.Show("Please select a file first");
                return;
            }
            MessageBox.Show("This may take some time. Press the .\nOK button to start.");
            label_result.Text = "Scanning...";
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
            try
            {
                var res = JsonConvert.DeserializeObject<FileResponse>(body);
                var stats = res.Data.Attributes.LastAnalysisStats;

                label1.Text = "harmless : " + stats.Harmless;
                label2.Text = "type-unsupported : " + stats.TypeUnsupported;
                label3.Text = "suspicious : " + stats.Suspicious;
                label4.Text = "confirmed-timeout : " + stats.ConfirmedTimeout;
                label5.Text = "timeout : " + stats.Timeout;
                label6.Text = "failure : " + stats.Failure;
                label7.Text = "malicious : " + stats.Malicious;
                label8.Text = "undetected : " + stats.Undetected;
                label_result.Text = "Scan Success!";

                DrawPieChart(chart1, (int)stats.Harmless, (int)stats.TypeUnsupported, (int)stats.Suspicious, (int)stats.ConfirmedTimeout, (int)stats.Timeout, (int)stats.Failure, (int)stats.Malicious, (int)stats.Undetected);
                Print_FileScanLog(textbox_filePath.Text, "Success");
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Print_FileScanLog(textbox_filePath.Text, "Failed");
            }
        }
        private void Print_FileScanLog(string filepath, string result)
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MSP");
            var logfile = folder + @"\log.txt";
            DirectoryInfo dir = new DirectoryInfo(folder);
            if(dir.Exists == false)
            {
                dir.Create();
            }
            string datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            using var writer = new StreamWriter(logfile, append: true);
            writer.WriteLine($"{datetime} - {filepath}, {result}");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FileHash.Getmd5FromFiles(textbox_filePath.Text));
            MessageBox.Show("Copyed!");
        }   

        private void DrawPieChart(Chart chart, int value1, int value2, int value3, int value4, int value5, int value6, int value7, int value8)
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
            if (0 < value2) chart.Series[seriesname].Points.AddXY("type-unsupported", value2);
            if (0 < value3) chart.Series[seriesname].Points.AddXY("suspicious", value3);
            if (0 < value4) chart.Series[seriesname].Points.AddXY("confirmed-timeout", value4);
            if (0 < value5) chart.Series[seriesname].Points.AddXY("timeout", value5);
            if (0 < value6) chart.Series[seriesname].Points.AddXY("failure", value6);
            if (0 < value7) chart.Series[seriesname].Points.AddXY("malicious", value7);
            if (0 < value8) chart.Series[seriesname].Points.AddXY("undetected", value8); 
        }
    }
}
