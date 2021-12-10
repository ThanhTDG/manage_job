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
				this.SuspendLayout();
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.ForeColor = System.Drawing.Color.ForestGreen;
				this.label2.Location = new System.Drawing.Point(127, 22);
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
				this.label1.Location = new System.Drawing.Point(109, 278);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(198, 27);
				this.label1.TabIndex = 3;
				this.label1.Text = "Công việc hôm nay";
				// 
				// monthCalendar1
				// 
				this.monthCalendar1.Location = new System.Drawing.Point(59, 62);
				this.monthCalendar1.Name = "monthCalendar1";
				this.monthCalendar1.TabIndex = 5;
				this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
				// 
				// lvThongBaoCongViec
				// 
				this.lvThongBaoCongViec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
				this.lvThongBaoCongViec.FullRowSelect = true;
				this.lvThongBaoCongViec.GridLines = true;
				this.lvThongBaoCongViec.HideSelection = false;
				this.lvThongBaoCongViec.Location = new System.Drawing.Point(15, 321);
				this.lvThongBaoCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
				this.lvThongBaoCongViec.Name = "lvThongBaoCongViec";
				this.lvThongBaoCongViec.Size = new System.Drawing.Size(387, 326);
				this.lvThongBaoCongViec.TabIndex = 6;
				this.lvThongBaoCongViec.UseCompatibleStateImageBehavior = false;
				this.lvThongBaoCongViec.View = System.Windows.Forms.View.Details;
				// 
				// columnHeader1
				// 
				this.columnHeader1.Text = "Công việc";
				this.columnHeader1.Width = 177;
				// 
				// columnHeader2
				// 
				this.columnHeader2.Text = "Thời gian còn lại";
				this.columnHeader2.Width = 107;
				// 
				// frmThongBao
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(417, 655);
				this.Controls.Add(this.lvThongBaoCongViec);
				this.Controls.Add(this.monthCalendar1);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.label2);
				this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
				this.Name = "frmThongBao";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Thông báo công việc";
				this.Load += new System.EventHandler(this.frmThongBao_Load);
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
    }
}