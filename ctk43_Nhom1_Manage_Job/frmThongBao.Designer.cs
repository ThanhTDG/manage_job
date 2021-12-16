namespace ctk43_Nhom1_Manage_Job
{
    partial class frmThongBao
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
				this.label2 = new System.Windows.Forms.Label();
				this.label1 = new System.Windows.Forms.Label();
				this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
				this.lvThongBaoCongViec = new System.Windows.Forms.ListView();
				this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
				this.label8 = new System.Windows.Forms.Label();
				this.textBox6 = new System.Windows.Forms.TextBox();
				this.label7 = new System.Windows.Forms.Label();
				this.label6 = new System.Windows.Forms.Label();
				this.label5 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.textBox5 = new System.Windows.Forms.TextBox();
				this.textBox4 = new System.Windows.Forms.TextBox();
				this.textBox3 = new System.Windows.Forms.TextBox();
				this.textBox2 = new System.Windows.Forms.TextBox();
				this.textBox1 = new System.Windows.Forms.TextBox();
				this.textBox7 = new System.Windows.Forms.TextBox();
				this.label9 = new System.Windows.Forms.Label();
				this.tsTongCongViec = new System.Windows.Forms.ToolStrip();
				this.tslTongSoCongViec = new System.Windows.Forms.ToolStripLabel();
				this.tsTongCongViec.SuspendLayout();
				this.SuspendLayout();
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.ForeColor = System.Drawing.Color.ForestGreen;
				this.label2.Location = new System.Drawing.Point(90, 22);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(154, 27);
				this.label2.TabIndex = 1;
				this.label2.Text = "Lịch công việc";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.ForeColor = System.Drawing.Color.ForestGreen;
				this.label1.Location = new System.Drawing.Point(559, 22);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(198, 27);
				this.label1.TabIndex = 3;
				this.label1.Text = "Công việc hôm nay";
				// 
				// monthCalendar1
				// 
				this.monthCalendar1.Location = new System.Drawing.Point(27, 62);
				this.monthCalendar1.Name = "monthCalendar1";
				this.monthCalendar1.TabIndex = 5;
				this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
				// 
				// lvThongBaoCongViec
				// 
				this.lvThongBaoCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.lvThongBaoCongViec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
				this.lvThongBaoCongViec.FullRowSelect = true;
				this.lvThongBaoCongViec.GridLines = true;
				this.lvThongBaoCongViec.HideSelection = false;
				this.lvThongBaoCongViec.Location = new System.Drawing.Point(338, 62);
				this.lvThongBaoCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
				this.lvThongBaoCongViec.Name = "lvThongBaoCongViec";
				this.lvThongBaoCongViec.Size = new System.Drawing.Size(693, 404);
				this.lvThongBaoCongViec.TabIndex = 6;
				this.lvThongBaoCongViec.UseCompatibleStateImageBehavior = false;
				this.lvThongBaoCongViec.View = System.Windows.Forms.View.Details;
				// 
				// columnHeader1
				// 
				this.columnHeader1.Text = "Công việc";
				this.columnHeader1.Width = 360;
				// 
				// columnHeader2
				// 
				this.columnHeader2.Text = "Thời gian";
				this.columnHeader2.Width = 320;
				// 
				// label8
				// 
				this.label8.AutoSize = true;
				this.label8.Location = new System.Drawing.Point(144, 447);
				this.label8.Name = "label8";
				this.label8.Size = new System.Drawing.Size(155, 17);
				this.label8.TabIndex = 34;
				this.label8.Text = "công việc chưa bắt đầu";
				// 
				// textBox6
				// 
				this.textBox6.BackColor = System.Drawing.Color.LightSkyBlue;
				this.textBox6.Enabled = false;
				this.textBox6.Location = new System.Drawing.Point(27, 444);
				this.textBox6.Name = "textBox6";
				this.textBox6.Size = new System.Drawing.Size(100, 22);
				this.textBox6.TabIndex = 33;
				// 
				// label7
				// 
				this.label7.AutoSize = true;
				this.label7.Location = new System.Drawing.Point(144, 416);
				this.label7.Name = "label7";
				this.label7.Size = new System.Drawing.Size(121, 17);
				this.label7.TabIndex = 32;
				this.label7.Text = "2 ngày < thời gian";
				// 
				// label6
				// 
				this.label6.AutoSize = true;
				this.label6.Location = new System.Drawing.Point(144, 391);
				this.label6.Name = "label6";
				this.label6.Size = new System.Drawing.Size(168, 17);
				this.label6.TabIndex = 31;
				this.label6.Text = "5 giờ < thời gian < 2 ngày";
				// 
				// label5
				// 
				this.label5.AutoSize = true;
				this.label5.Location = new System.Drawing.Point(144, 363);
				this.label5.Name = "label5";
				this.label5.Size = new System.Drawing.Size(156, 17);
				this.label5.TabIndex = 30;
				this.label5.Text = "2 giờ < thời gian < 5 giờ";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(144, 335);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(156, 17);
				this.label4.TabIndex = 29;
				this.label4.Text = "1 giờ < thời gian < 2 giờ";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(144, 307);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(109, 17);
				this.label3.TabIndex = 28;
				this.label3.Text = "thời gian < 1 giờ";
				// 
				// textBox5
				// 
				this.textBox5.BackColor = System.Drawing.Color.Blue;
				this.textBox5.Enabled = false;
				this.textBox5.Location = new System.Drawing.Point(27, 416);
				this.textBox5.Name = "textBox5";
				this.textBox5.Size = new System.Drawing.Size(100, 22);
				this.textBox5.TabIndex = 27;
				// 
				// textBox4
				// 
				this.textBox4.BackColor = System.Drawing.Color.Green;
				this.textBox4.Enabled = false;
				this.textBox4.Location = new System.Drawing.Point(27, 388);
				this.textBox4.Name = "textBox4";
				this.textBox4.Size = new System.Drawing.Size(100, 22);
				this.textBox4.TabIndex = 26;
				// 
				// textBox3
				// 
				this.textBox3.BackColor = System.Drawing.Color.Yellow;
				this.textBox3.Enabled = false;
				this.textBox3.Location = new System.Drawing.Point(27, 360);
				this.textBox3.Name = "textBox3";
				this.textBox3.Size = new System.Drawing.Size(100, 22);
				this.textBox3.TabIndex = 25;
				// 
				// textBox2
				// 
				this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
				this.textBox2.Enabled = false;
				this.textBox2.Location = new System.Drawing.Point(27, 332);
				this.textBox2.Name = "textBox2";
				this.textBox2.Size = new System.Drawing.Size(100, 22);
				this.textBox2.TabIndex = 24;
				// 
				// textBox1
				// 
				this.textBox1.BackColor = System.Drawing.Color.Red;
				this.textBox1.Enabled = false;
				this.textBox1.Location = new System.Drawing.Point(27, 304);
				this.textBox1.Name = "textBox1";
				this.textBox1.Size = new System.Drawing.Size(100, 22);
				this.textBox1.TabIndex = 23;
				// 
				// textBox7
				// 
				this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.textBox7.Enabled = false;
				this.textBox7.Location = new System.Drawing.Point(27, 276);
				this.textBox7.Name = "textBox7";
				this.textBox7.Size = new System.Drawing.Size(100, 22);
				this.textBox7.TabIndex = 35;
				// 
				// label9
				// 
				this.label9.AutoSize = true;
				this.label9.Location = new System.Drawing.Point(144, 281);
				this.label9.Name = "label9";
				this.label9.Size = new System.Drawing.Size(124, 17);
				this.label9.TabIndex = 36;
				this.label9.Text = "công việc quá hạn";
				// 
				// tsTongCongViec
				// 
				this.tsTongCongViec.Dock = System.Windows.Forms.DockStyle.Bottom;
				this.tsTongCongViec.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.tsTongCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTongSoCongViec});
				this.tsTongCongViec.Location = new System.Drawing.Point(0, 479);
				this.tsTongCongViec.Name = "tsTongCongViec";
				this.tsTongCongViec.Size = new System.Drawing.Size(1044, 31);
				this.tsTongCongViec.TabIndex = 37;
				this.tsTongCongViec.Text = "toolStrip1";
				// 
				// tslTongSoCongViec
				// 
				this.tslTongSoCongViec.Name = "tslTongSoCongViec";
				this.tslTongSoCongViec.Size = new System.Drawing.Size(140, 28);
				this.tslTongSoCongViec.Text = "Tổng số công việc : ";
				// 
				// frmThongBao
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(1044, 510);
				this.Controls.Add(this.tsTongCongViec);
				this.Controls.Add(this.label9);
				this.Controls.Add(this.textBox7);
				this.Controls.Add(this.label8);
				this.Controls.Add(this.textBox6);
				this.Controls.Add(this.label7);
				this.Controls.Add(this.label6);
				this.Controls.Add(this.label5);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.textBox5);
				this.Controls.Add(this.textBox4);
				this.Controls.Add(this.textBox3);
				this.Controls.Add(this.textBox2);
				this.Controls.Add(this.textBox1);
				this.Controls.Add(this.lvThongBaoCongViec);
				this.Controls.Add(this.monthCalendar1);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.label2);
				this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
				this.Name = "frmThongBao";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Thông báo công việc";
				this.Load += new System.EventHandler(this.frmThongBao_Load);
				this.tsTongCongViec.ResumeLayout(false);
				this.tsTongCongViec.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView lvThongBaoCongViec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
		  private System.Windows.Forms.Label label8;
		  private System.Windows.Forms.TextBox textBox6;
		  private System.Windows.Forms.Label label7;
		  private System.Windows.Forms.Label label6;
		  private System.Windows.Forms.Label label5;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.TextBox textBox5;
		  private System.Windows.Forms.TextBox textBox4;
		  private System.Windows.Forms.TextBox textBox3;
		  private System.Windows.Forms.TextBox textBox2;
		  private System.Windows.Forms.TextBox textBox1;
		  private System.Windows.Forms.TextBox textBox7;
		  private System.Windows.Forms.Label label9;
		  private System.Windows.Forms.ToolStrip tsTongCongViec;
		  private System.Windows.Forms.ToolStripLabel tslTongSoCongViec;
	 }
}