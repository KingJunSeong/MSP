namespace MSP.Forms
{
    partial class URLScan
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
            this.label_virus_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_engine_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ScanStart = new System.Windows.Forms.Button();
            this.textbox_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_virus_count
            // 
            this.label_virus_count.AutoSize = true;
            this.label_virus_count.Font = new System.Drawing.Font("굴림", 16F);
            this.label_virus_count.Location = new System.Drawing.Point(210, 52);
            this.label_virus_count.Name = "label_virus_count";
            this.label_virus_count.Size = new System.Drawing.Size(0, 27);
            this.label_virus_count.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "위협 감지 수 : ";
            // 
            // label_engine_count
            // 
            this.label_engine_count.AutoSize = true;
            this.label_engine_count.Font = new System.Drawing.Font("굴림", 16F);
            this.label_engine_count.Location = new System.Drawing.Point(210, 88);
            this.label_engine_count.Name = "label_engine_count";
            this.label_engine_count.Size = new System.Drawing.Size(0, 27);
            this.label_engine_count.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "검사 엔진 수 : ";
            // 
            // btn_ScanStart
            // 
            this.btn_ScanStart.ForeColor = System.Drawing.Color.White;
            this.btn_ScanStart.Location = new System.Drawing.Point(612, 43);
            this.btn_ScanStart.Name = "btn_ScanStart";
            this.btn_ScanStart.Size = new System.Drawing.Size(120, 52);
            this.btn_ScanStart.TabIndex = 11;
            this.btn_ScanStart.Text = "Scan Start";
            this.btn_ScanStart.UseVisualStyleBackColor = true;
            this.btn_ScanStart.Click += new System.EventHandler(this.btn_ScanStart_Click);
            // 
            // textbox_url
            // 
            this.textbox_url.Location = new System.Drawing.Point(12, 12);
            this.textbox_url.Name = "textbox_url";
            this.textbox_url.Size = new System.Drawing.Size(720, 25);
            this.textbox_url.TabIndex = 10;
            // 
            // URLScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 346);
            this.Controls.Add(this.label_virus_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_engine_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ScanStart);
            this.Controls.Add(this.textbox_url);
            this.Name = "URLScan";
            this.Text = "URL Scan";
            this.Load += new System.EventHandler(this.URLScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_virus_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_engine_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ScanStart;
        private System.Windows.Forms.TextBox textbox_url;
    }
}