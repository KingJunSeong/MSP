namespace MSP.Forms
{
    partial class FileScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_filePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_md5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_sha256 = new System.Windows.Forms.Label();
            this.label_sha1 = new System.Windows.Forms.Label();
            this.textbox_md5 = new System.Windows.Forms.TextBox();
            this.textbox_sha1 = new System.Windows.Forms.TextBox();
            this.textbox_sha256 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(655, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "OpenFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_filePath
            // 
            this.textbox_filePath.Location = new System.Drawing.Point(12, 12);
            this.textbox_filePath.Name = "textbox_filePath";
            this.textbox_filePath.Size = new System.Drawing.Size(637, 25);
            this.textbox_filePath.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(612, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Scan Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_md5
            // 
            this.label_md5.AutoSize = true;
            this.label_md5.Font = new System.Drawing.Font("굴림", 10F);
            this.label_md5.Location = new System.Drawing.Point(7, 47);
            this.label_md5.Name = "label_md5";
            this.label_md5.Size = new System.Drawing.Size(39, 17);
            this.label_md5.TabIndex = 8;
            this.label_md5.Text = "MD5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "harmless : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "type-unsupported : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "confirmed-timeout : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "timeout : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "failure : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "malicious : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "undetected : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "suspicious : ";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("굴림", 11F);
            this.label_result.Location = new System.Drawing.Point(10, 115);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 19);
            this.label_result.TabIndex = 17;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(228, 104);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(530, 252);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // label_sha256
            // 
            this.label_sha256.AutoSize = true;
            this.label_sha256.Font = new System.Drawing.Font("굴림", 10F);
            this.label_sha256.Location = new System.Drawing.Point(5, 81);
            this.label_sha256.Name = "label_sha256";
            this.label_sha256.Size = new System.Drawing.Size(62, 17);
            this.label_sha256.TabIndex = 20;
            this.label_sha256.Text = "SHA256";
            // 
            // label_sha1
            // 
            this.label_sha1.AutoSize = true;
            this.label_sha1.Font = new System.Drawing.Font("굴림", 10F);
            this.label_sha1.Location = new System.Drawing.Point(7, 64);
            this.label_sha1.Name = "label_sha1";
            this.label_sha1.Size = new System.Drawing.Size(46, 17);
            this.label_sha1.TabIndex = 21;
            this.label_sha1.Text = "SHA1";
            // 
            // textbox_md5
            // 
            this.textbox_md5.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_md5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_md5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_md5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textbox_md5.Location = new System.Drawing.Point(89, 48);
            this.textbox_md5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_md5.Name = "textbox_md5";
            this.textbox_md5.ReadOnly = true;
            this.textbox_md5.Size = new System.Drawing.Size(516, 17);
            this.textbox_md5.TabIndex = 22;
            // 
            // textbox_sha1
            // 
            this.textbox_sha1.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_sha1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sha1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textbox_sha1.Location = new System.Drawing.Point(89, 66);
            this.textbox_sha1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_sha1.Name = "textbox_sha1";
            this.textbox_sha1.ReadOnly = true;
            this.textbox_sha1.Size = new System.Drawing.Size(516, 17);
            this.textbox_sha1.TabIndex = 23;
            // 
            // textbox_sha256
            // 
            this.textbox_sha256.BackColor = System.Drawing.SystemColors.Control;
            this.textbox_sha256.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sha256.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_sha256.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textbox_sha256.Location = new System.Drawing.Point(89, 84);
            this.textbox_sha256.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_sha256.Name = "textbox_sha256";
            this.textbox_sha256.ReadOnly = true;
            this.textbox_sha256.Size = new System.Drawing.Size(516, 17);
            this.textbox_sha256.TabIndex = 24;
            // 
            // FileScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 351);
            this.Controls.Add(this.textbox_sha256);
            this.Controls.Add(this.textbox_sha1);
            this.Controls.Add(this.textbox_md5);
            this.Controls.Add(this.label_sha1);
            this.Controls.Add(this.label_sha256);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_md5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox_filePath);
            this.Controls.Add(this.button1);
            this.Name = "FileScan";
            this.Text = "FileScan";
            this.Load += new System.EventHandler(this.FileScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_filePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_md5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_sha256;
        private System.Windows.Forms.Label label_sha1;
        private System.Windows.Forms.TextBox textbox_md5;
        private System.Windows.Forms.TextBox textbox_sha1;
        private System.Windows.Forms.TextBox textbox_sha256;
    }
}