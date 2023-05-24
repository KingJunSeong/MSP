using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP.Forms
{
    public partial class Home : Form
    {
        public static string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MSP");
        public static string logfile = folder + @"\log.txt";
        public Home()
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Both;

            FileSystemWatcher fileSystemWatcher = new()
            {
                Path = folder,
                Filter = "log.txt",
                EnableRaisingEvents = true
            };
            fileSystemWatcher.Changed += new FileSystemEventHandler(ReadLogFile);
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
        private void Home_Load(object sender, EventArgs e)
        {
            LoadTheme();

            DirectoryInfo dir = new(folder);
            if (dir.Exists == false) dir.Create();

            textBox1.Invoke(() =>
            {
                textBox1.Clear();
            });
            string[] lines = File.ReadAllLines(logfile);

            foreach (string line in lines)
            {
                textBox1.Invoke(() =>
                {
                    textBox1.AppendText(line + Environment.NewLine);
                });
            }
        }
        private void ReadLogFile(object sender, FileSystemEventArgs e)
        {
            DirectoryInfo dir = new(folder);
            if (dir.Exists == false) dir.Create();

            textBox1.Invoke(() =>
            {
                textBox1.Clear();
            });
            string[] lines = File.ReadAllLines(logfile);

            foreach(string line in lines)
            {
                textBox1.Invoke(() =>
                {
                    textBox1.AppendText(line + Environment.NewLine);
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(logfile, string.Empty);
        }
    }
}
