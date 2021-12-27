namespace ctk43_Nhom1_Manage_Job
{
    partial class frmDSChiTiet
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
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtMoTaCongViec = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDSChiTiet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbCountUp = new System.Windows.Forms.Label();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbChiTiet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 141;
            this.label6.Text = "Mô tả";
            // 
            // rtxtMoTaCongViec
            // 
            this.rtxtMoTaCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtMoTaCongViec.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtMoTaCongViec.Enabled = false;
            this.rtxtMoTaCongViec.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMoTaCongViec.Location = new System.Drawing.Point(125, 92);
            this.rtxtMoTaCongViec.Name = "rtxtMoTaCongViec";
            this.rtxtMoTaCongViec.ReadOnly = true;
            this.rtxtMoTaCongViec.Size = new System.Drawing.Size(315, 82);
            this.rtxtMoTaCongViec.TabIndex = 2;
            this.rtxtMoTaCongViec.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 135;
            this.label1.Text = "Tên công việc";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenCongViec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenCongViec.Enabled = false;
            this.txtTenCongViec.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCongViec.Location = new System.Drawing.Point(125, 18);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.ReadOnly = true;
            this.txtTenCongViec.Size = new System.Drawing.Size(315, 25);
            this.txtTenCongViec.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenCongViec);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtxtMoTaCongViec);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 180);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công việc";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy  H:mm:ss";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(125, 50);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(314, 25);
            this.dtpEnd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 157;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 149;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvDSChiTiet);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 239);
            this.groupBox2.TabIndex = 151;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // lvDSChiTiet
            // 
            this.lvDSChiTiet.CheckBoxes = true;
            this.lvDSChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDSChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSChiTiet.FullRowSelect = true;
            this.lvDSChiTiet.GridLines = true;
            this.lvDSChiTiet.HideSelection = false;
            this.lvDSChiTiet.Location = new System.Drawing.Point(3, 21);
            this.lvDSChiTiet.Name = "lvDSChiTiet";
            this.lvDSChiTiet.Size = new System.Drawing.Size(440, 215);
            this.lvDSChiTiet.TabIndex = 0;
            this.lvDSChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvDSChiTiet.View = System.Windows.Forms.View.Details;
            this.lvDSChiTiet.SelectedIndexChanged += new System.EventHandler(this.lvDSChiTiet_SelectedIndexChanged);
            this.lvDSChiTiet.Click += new System.EventHandler(this.lvDSChiTiet_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dự kiến ";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thực tế";
            this.columnHeader3.Width = 120;
            // 
            // lbCountUp
            // 
            this.lbCountUp.AutoSize = true;
            this.lbCountUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCountUp.Location = new System.Drawing.Point(67, 26);
            this.lbCountUp.Name = "lbCountUp";
            this.lbCountUp.Size = new System.Drawing.Size(71, 20);
            this.lbCountUp.TabIndex = 152;
            this.lbCountUp.Text = "00:00:00";
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.Controls.Add(this.btnPause);
            this.gbChiTiet.Controls.Add(this.btnStop);
            this.gbChiTiet.Controls.Add(this.groupBox3);
            this.gbChiTiet.Controls.Add(this.btnStart);
            this.gbChiTiet.Controls.Add(this.lbCountUp);
            this.gbChiTiet.Location = new System.Drawing.Point(473, 12);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(200, 422);
            this.gbChiTiet.TabIndex = 153;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Chi tiết công việc";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(81, 63);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(48, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(146, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbMoTa);
            this.groupBox3.Location = new System.Drawing.Point(0, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 324);
            this.groupBox3.TabIndex = 154;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mô tả";
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMoTa.Enabled = false;
            this.rtbMoTa.Location = new System.Drawing.Point(3, 16);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(194, 305);
            this.rtbMoTa.TabIndex = 0;
            this.rtbMoTa.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(48, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmDSChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 449);
            this.Controls.Add(this.gbChiTiet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDSChiTiet";
            this.Text = "Danh sách chi tiết công việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDSChiTiet_FormClosing);
            this.Load += new System.EventHandler(this.frmDSChiTiet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbChiTiet.ResumeLayout(false);
            this.gbChiTiet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtMoTaCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDSChiTiet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbCountUp;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}