namespace ctk43_Nhom1_Manage_Job
{
    partial class frmLoc
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdAllMucDo = new System.Windows.Forms.RadioButton();
            this.rdAllTrangThai = new System.Windows.Forms.RadioButton();
            this.rdTrangThaiChitiet = new System.Windows.Forms.RadioButton();
            this.rdMucDo = new System.Windows.Forms.RadioButton();
            this.mucdo0 = new System.Windows.Forms.CheckBox();
            this.mucdo1 = new System.Windows.Forms.CheckBox();
            this.mucdo2 = new System.Windows.Forms.CheckBox();
            this.mucdo3 = new System.Windows.Forms.CheckBox();
            this.mucdo4 = new System.Windows.Forms.CheckBox();
            this.trangthai3 = new System.Windows.Forms.CheckBox();
            this.trangthai2 = new System.Windows.Forms.CheckBox();
            this.trangthai1 = new System.Windows.Forms.CheckBox();
            this.trangthai0 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(457, 22);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(169, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(129, 22);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(169, 20);
            this.dtpEnd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFind.Location = new System.Drawing.Point(484, 183);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 33);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(588, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mucdo4);
            this.groupBox1.Controls.Add(this.mucdo3);
            this.groupBox1.Controls.Add(this.mucdo2);
            this.groupBox1.Controls.Add(this.mucdo1);
            this.groupBox1.Controls.Add(this.mucdo0);
            this.groupBox1.Controls.Add(this.rdMucDo);
            this.groupBox1.Controls.Add(this.rdAllMucDo);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mức độ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trangthai3);
            this.groupBox2.Controls.Add(this.trangthai2);
            this.groupBox2.Controls.Add(this.trangthai1);
            this.groupBox2.Controls.Add(this.trangthai0);
            this.groupBox2.Controls.Add(this.rdTrangThaiChitiet);
            this.groupBox2.Controls.Add(this.rdAllTrangThai);
            this.groupBox2.Location = new System.Drawing.Point(14, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 57);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "trạng thái";
            // 
            // rdAllMucDo
            // 
            this.rdAllMucDo.AutoSize = true;
            this.rdAllMucDo.Location = new System.Drawing.Point(7, 22);
            this.rdAllMucDo.Name = "rdAllMucDo";
            this.rdAllMucDo.Size = new System.Drawing.Size(56, 17);
            this.rdAllMucDo.TabIndex = 0;
            this.rdAllMucDo.TabStop = true;
            this.rdAllMucDo.Text = "Tất cả";
            this.rdAllMucDo.UseVisualStyleBackColor = true;
            this.rdAllMucDo.CheckedChanged += new System.EventHandler(this.rdAllMucDo_CheckedChanged);
            // 
            // rdAllTrangThai
            // 
            this.rdAllTrangThai.AutoSize = true;
            this.rdAllTrangThai.Location = new System.Drawing.Point(7, 19);
            this.rdAllTrangThai.Name = "rdAllTrangThai";
            this.rdAllTrangThai.Size = new System.Drawing.Size(56, 17);
            this.rdAllTrangThai.TabIndex = 0;
            this.rdAllTrangThai.TabStop = true;
            this.rdAllTrangThai.Text = "Tất cả";
            this.rdAllTrangThai.UseVisualStyleBackColor = true;
            this.rdAllTrangThai.CheckedChanged += new System.EventHandler(this.rdAllTrangThai_CheckedChanged);
            // 
            // rdTrangThaiChitiet
            // 
            this.rdTrangThaiChitiet.AutoSize = true;
            this.rdTrangThaiChitiet.Location = new System.Drawing.Point(69, 19);
            this.rdTrangThaiChitiet.Name = "rdTrangThaiChitiet";
            this.rdTrangThaiChitiet.Size = new System.Drawing.Size(57, 17);
            this.rdTrangThaiChitiet.TabIndex = 0;
            this.rdTrangThaiChitiet.TabStop = true;
            this.rdTrangThaiChitiet.Text = "Chi tiết";
            this.rdTrangThaiChitiet.UseVisualStyleBackColor = true;
            this.rdTrangThaiChitiet.CheckedChanged += new System.EventHandler(this.rdTrangThaiChitiet_CheckedChanged);
            // 
            // rdMucDo
            // 
            this.rdMucDo.AutoSize = true;
            this.rdMucDo.Location = new System.Drawing.Point(65, 22);
            this.rdMucDo.Name = "rdMucDo";
            this.rdMucDo.Size = new System.Drawing.Size(61, 17);
            this.rdMucDo.TabIndex = 0;
            this.rdMucDo.TabStop = true;
            this.rdMucDo.Text = "Chi Tiết";
            this.rdMucDo.UseVisualStyleBackColor = true;
            this.rdMucDo.CheckedChanged += new System.EventHandler(this.rdMucDo_CheckedChanged);
            // 
            // mucdo0
            // 
            this.mucdo0.AutoSize = true;
            this.mucdo0.Location = new System.Drawing.Point(132, 23);
            this.mucdo0.Name = "mucdo0";
            this.mucdo0.Size = new System.Drawing.Size(80, 17);
            this.mucdo0.TabIndex = 1;
            this.mucdo0.Text = "checkBox1";
            this.mucdo0.UseVisualStyleBackColor = true;
            // 
            // mucdo1
            // 
            this.mucdo1.AutoSize = true;
            this.mucdo1.Location = new System.Drawing.Point(239, 23);
            this.mucdo1.Name = "mucdo1";
            this.mucdo1.Size = new System.Drawing.Size(80, 17);
            this.mucdo1.TabIndex = 1;
            this.mucdo1.Text = "checkBox1";
            this.mucdo1.UseVisualStyleBackColor = true;
            // 
            // mucdo2
            // 
            this.mucdo2.AutoSize = true;
            this.mucdo2.Location = new System.Drawing.Point(329, 22);
            this.mucdo2.Name = "mucdo2";
            this.mucdo2.Size = new System.Drawing.Size(80, 17);
            this.mucdo2.TabIndex = 1;
            this.mucdo2.Text = "checkBox1";
            this.mucdo2.UseVisualStyleBackColor = true;
            // 
            // mucdo3
            // 
            this.mucdo3.AutoSize = true;
            this.mucdo3.Location = new System.Drawing.Point(428, 22);
            this.mucdo3.Name = "mucdo3";
            this.mucdo3.Size = new System.Drawing.Size(80, 17);
            this.mucdo3.TabIndex = 1;
            this.mucdo3.Text = "checkBox1";
            this.mucdo3.UseVisualStyleBackColor = true;
            // 
            // mucdo4
            // 
            this.mucdo4.AutoSize = true;
            this.mucdo4.Location = new System.Drawing.Point(531, 20);
            this.mucdo4.Name = "mucdo4";
            this.mucdo4.Size = new System.Drawing.Size(80, 17);
            this.mucdo4.TabIndex = 1;
            this.mucdo4.Text = "checkBox1";
            this.mucdo4.UseVisualStyleBackColor = true;
            // 
            // trangthai3
            // 
            this.trangthai3.AutoSize = true;
            this.trangthai3.Location = new System.Drawing.Point(493, 18);
            this.trangthai3.Name = "trangthai3";
            this.trangthai3.Size = new System.Drawing.Size(80, 17);
            this.trangthai3.TabIndex = 3;
            this.trangthai3.Text = "checkBox1";
            this.trangthai3.UseVisualStyleBackColor = true;
            // 
            // trangthai2
            // 
            this.trangthai2.AutoSize = true;
            this.trangthai2.Location = new System.Drawing.Point(376, 18);
            this.trangthai2.Name = "trangthai2";
            this.trangthai2.Size = new System.Drawing.Size(80, 17);
            this.trangthai2.TabIndex = 4;
            this.trangthai2.Text = "checkBox1";
            this.trangthai2.UseVisualStyleBackColor = true;
            // 
            // trangthai1
            // 
            this.trangthai1.AutoSize = true;
            this.trangthai1.Location = new System.Drawing.Point(259, 19);
            this.trangthai1.Name = "trangthai1";
            this.trangthai1.Size = new System.Drawing.Size(80, 17);
            this.trangthai1.TabIndex = 5;
            this.trangthai1.Text = "checkBox1";
            this.trangthai1.UseVisualStyleBackColor = true;
            // 
            // trangthai0
            // 
            this.trangthai0.AutoSize = true;
            this.trangthai0.Location = new System.Drawing.Point(142, 19);
            this.trangthai0.Name = "trangthai0";
            this.trangthai0.Size = new System.Drawing.Size(80, 17);
            this.trangthai0.TabIndex = 6;
            this.trangthai0.Text = "checkBox1";
            this.trangthai0.UseVisualStyleBackColor = true;
            // 
            // frmLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Name = "frmLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm công việc";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAllMucDo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTrangThaiChitiet;
        private System.Windows.Forms.RadioButton rdAllTrangThai;
        private System.Windows.Forms.RadioButton rdMucDo;
        private System.Windows.Forms.CheckBox mucdo4;
        private System.Windows.Forms.CheckBox mucdo3;
        private System.Windows.Forms.CheckBox mucdo2;
        private System.Windows.Forms.CheckBox mucdo1;
        private System.Windows.Forms.CheckBox mucdo0;
        private System.Windows.Forms.CheckBox trangthai3;
        private System.Windows.Forms.CheckBox trangthai2;
        private System.Windows.Forms.CheckBox trangthai1;
        private System.Windows.Forms.CheckBox trangthai0;
    }
}