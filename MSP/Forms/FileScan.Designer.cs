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
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_filePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_engine_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_virus_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
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
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(612, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Scan Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "검사 엔진 수 : ";
            // 
            // label_engine_count
            // 
            this.label_engine_count.AutoSize = true;
            this.label_engine_count.Font = new System.Drawing.Font("굴림", 16F);
            this.label_engine_count.Location = new System.Drawing.Point(224, 132);
            this.label_engine_count.Name = "label_engine_count";
            this.label_engine_count.Size = new System.Drawing.Size(0, 27);
            this.label_engine_count.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(26, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "위협 감지 수 : ";
            // 
            // label_virus_count
            // 
            this.label_virus_count.AutoSize = true;
            this.label_virus_count.Font = new System.Drawing.Font("굴림", 16F);
            this.label_virus_count.Location = new System.Drawing.Point(224, 170);
            this.label_virus_count.Name = "label_virus_count";
            this.label_virus_count.Size = new System.Drawing.Size(0, 27);
            this.label_virus_count.TabIndex = 7;
            // 
            // FileScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 346);
            this.Controls.Add(this.label_virus_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_engine_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox_filePath);
            this.Controls.Add(this.button1);
            this.Name = "FileScan";
            this.Text = "File Scan";
            this.Load += new System.EventHandler(this.FileScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_filePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_engine_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_virus_count;
    }
}