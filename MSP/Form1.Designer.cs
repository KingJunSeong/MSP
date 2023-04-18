namespace MSP
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_URLScan = new System.Windows.Forms.Button();
            this.btn_FileScan = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Setting);
            this.panelMenu.Controls.Add(this.btn_URLScan);
            this.panelMenu.Controls.Add(this.btn_FileScan);
            this.panelMenu.Controls.Add(this.btn_Home);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 473);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Setting.Image = global::MSP.Properties.Resources.settings;
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 255);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Setting.Size = new System.Drawing.Size(220, 60);
            this.btn_Setting.TabIndex = 4;
            this.btn_Setting.Text = " Setting";
            this.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_URLScan
            // 
            this.btn_URLScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_URLScan.FlatAppearance.BorderSize = 0;
            this.btn_URLScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_URLScan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_URLScan.Image = global::MSP.Properties.Resources.www;
            this.btn_URLScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_URLScan.Location = new System.Drawing.Point(0, 195);
            this.btn_URLScan.Name = "btn_URLScan";
            this.btn_URLScan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_URLScan.Size = new System.Drawing.Size(220, 60);
            this.btn_URLScan.TabIndex = 3;
            this.btn_URLScan.Text = " URL Scan";
            this.btn_URLScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_URLScan.UseVisualStyleBackColor = true;
            this.btn_URLScan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_FileScan
            // 
            this.btn_FileScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FileScan.FlatAppearance.BorderSize = 0;
            this.btn_FileScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FileScan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_FileScan.Image = global::MSP.Properties.Resources.antivirus1;
            this.btn_FileScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FileScan.Location = new System.Drawing.Point(0, 135);
            this.btn_FileScan.Name = "btn_FileScan";
            this.btn_FileScan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_FileScan.Size = new System.Drawing.Size(220, 60);
            this.btn_FileScan.TabIndex = 2;
            this.btn_FileScan.Text = " File Scan";
            this.btn_FileScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FileScan.UseVisualStyleBackColor = true;
            this.btn_FileScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.Image = global::MSP.Properties.Resources.home;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 75);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(220, 60);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = " Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MalWare Scan";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 135);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = " File Scan";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 195);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = " URL Scan";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 255);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = " Setting";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btn_Min);
            this.panelTitle.Controls.Add(this.btn_Max);
            this.panelTitle.Controls.Add(this.btn_Close);
            this.panelTitle.Controls.Add(this.lbl_Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(762, 75);
            this.panelTitle.TabIndex = 5;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Min.ForeColor = System.Drawing.Color.White;
            this.btn_Min.Location = new System.Drawing.Point(681, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(30, 30);
            this.btn_Min.TabIndex = 3;
            this.btn_Min.Text = "─";
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Max.ForeColor = System.Drawing.Color.White;
            this.btn_Max.Location = new System.Drawing.Point(705, 0);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(30, 30);
            this.btn_Max.TabIndex = 2;
            this.btn_Max.Text = "█";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(732, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "✖";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(332, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(95, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 75);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(762, 398);
            this.panelDesktopPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 473);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MalWare Scan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_URLScan;
        private System.Windows.Forms.Button btn_FileScan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Max;
    }
}

