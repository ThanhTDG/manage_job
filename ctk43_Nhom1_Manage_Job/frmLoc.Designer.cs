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
            // base.Dispose(disposing);
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.grMucDo = new System.Windows.Forms.GroupBox();
            this.mucdo4 = new System.Windows.Forms.CheckBox();
            this.mucdo3 = new System.Windows.Forms.CheckBox();
            this.mucdo2 = new System.Windows.Forms.CheckBox();
            this.mucdo1 = new System.Windows.Forms.CheckBox();
            this.mucdo0 = new System.Windows.Forms.CheckBox();
            this.rdMucDo = new System.Windows.Forms.RadioButton();
            this.rdAllMucDo = new System.Windows.Forms.RadioButton();
            this.grTrangThai = new System.Windows.Forms.GroupBox();
            this.trangthai4 = new System.Windows.Forms.CheckBox();
            this.trangthai3 = new System.Windows.Forms.CheckBox();
            this.trangthai2 = new System.Windows.Forms.CheckBox();
            this.trangthai1 = new System.Windows.Forms.CheckBox();
            this.trangthai0 = new System.Windows.Forms.CheckBox();
            this.rdTrangThaiChitiet = new System.Windows.Forms.RadioButton();
            this.rdAllTrangThai = new System.Windows.Forms.RadioButton();
            this.grMucDo.SuspendLayout();
            this.grTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(176, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(169, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(500, 20);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(169, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFind.Location = new System.Drawing.Point(484, 219);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 33);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.Location = new System.Drawing.Point(588, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grMucDo
            // 
            this.grMucDo.Controls.Add(this.mucdo4);
            this.grMucDo.Controls.Add(this.mucdo3);
            this.grMucDo.Controls.Add(this.mucdo2);
            this.grMucDo.Controls.Add(this.mucdo1);
            this.grMucDo.Controls.Add(this.mucdo0);
            this.grMucDo.Controls.Add(this.rdMucDo);
            this.grMucDo.Controls.Add(this.rdAllMucDo);
            this.grMucDo.Location = new System.Drawing.Point(14, 53);
            this.grMucDo.Name = "grMucDo";
            this.grMucDo.Size = new System.Drawing.Size(656, 77);
            this.grMucDo.TabIndex = 17;
            this.grMucDo.TabStop = false;
            this.grMucDo.Text = "Mức độ";
            // 
            // mucdo4
            // 
            this.mucdo4.AutoSize = true;
            this.mucdo4.Location = new System.Drawing.Point(542, 48);
            this.mucdo4.Name = "mucdo4";
            this.mucdo4.Size = new System.Drawing.Size(80, 17);
            this.mucdo4.TabIndex = 4;
            this.mucdo4.Text = "checkBox1";
            this.mucdo4.UseVisualStyleBackColor = true;
            // 
            // mucdo3
            // 
            this.mucdo3.AutoSize = true;
            this.mucdo3.Location = new System.Drawing.Point(410, 47);
            this.mucdo3.Name = "mucdo3";
            this.mucdo3.Size = new System.Drawing.Size(80, 17);
            this.mucdo3.TabIndex = 3;
            this.mucdo3.Text = "checkBox1";
            this.mucdo3.UseVisualStyleBackColor = true;
            // 
            // mucdo2
            // 
            this.mucdo2.AutoSize = true;
            this.mucdo2.Location = new System.Drawing.Point(278, 47);
            this.mucdo2.Name = "mucdo2";
            this.mucdo2.Size = new System.Drawing.Size(80, 17);
            this.mucdo2.TabIndex = 2;
            this.mucdo2.Text = "checkBox1";
            this.mucdo2.UseVisualStyleBackColor = true;
            // 
            // mucdo1
            // 
            this.mucdo1.AutoSize = true;
            this.mucdo1.Location = new System.Drawing.Point(146, 48);
            this.mucdo1.Name = "mucdo1";
            this.mucdo1.Size = new System.Drawing.Size(80, 17);
            this.mucdo1.TabIndex = 1;
            this.mucdo1.Text = "checkBox1";
            this.mucdo1.UseVisualStyleBackColor = true;
            // 
            // mucdo0
            // 
            this.mucdo0.AutoSize = true;
            this.mucdo0.Location = new System.Drawing.Point(14, 48);
            this.mucdo0.Name = "mucdo0";
            this.mucdo0.Size = new System.Drawing.Size(80, 17);
            this.mucdo0.TabIndex = 0;
            this.mucdo0.Text = "checkBox1";
            this.mucdo0.UseVisualStyleBackColor = true;
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
            // grTrangThai
            // 
            this.grTrangThai.Controls.Add(this.trangthai4);
            this.grTrangThai.Controls.Add(this.trangthai3);
            this.grTrangThai.Controls.Add(this.trangthai2);
            this.grTrangThai.Controls.Add(this.trangthai1);
            this.grTrangThai.Controls.Add(this.trangthai0);
            this.grTrangThai.Controls.Add(this.rdTrangThaiChitiet);
            this.grTrangThai.Controls.Add(this.rdAllTrangThai);
            this.grTrangThai.Location = new System.Drawing.Point(14, 136);
            this.grTrangThai.Name = "grTrangThai";
            this.grTrangThai.Size = new System.Drawing.Size(656, 77);
            this.grTrangThai.TabIndex = 17;
            this.grTrangThai.TabStop = false;
            this.grTrangThai.Text = "Trạng thái";
            // 
            // trangthai4
            // 
            this.trangthai4.AutoSize = true;
            this.trangthai4.Location = new System.Drawing.Point(541, 44);
            this.trangthai4.Name = "trangthai4";
            this.trangthai4.Size = new System.Drawing.Size(80, 17);
            this.trangthai4.TabIndex = 0;
            this.trangthai4.Text = "checkBox1";
            this.trangthai4.UseVisualStyleBackColor = true;
            // 
            // trangthai3
            // 
            this.trangthai3.AutoSize = true;
            this.trangthai3.Location = new System.Drawing.Point(410, 44);
            this.trangthai3.Name = "trangthai3";
            this.trangthai3.Size = new System.Drawing.Size(80, 17);
            this.trangthai3.TabIndex = 1;
            this.trangthai3.Text = "checkBox1";
            this.trangthai3.UseVisualStyleBackColor = true;
            // 
            // trangthai2
            // 
            this.trangthai2.AutoSize = true;
            this.trangthai2.Location = new System.Drawing.Point(279, 44);
            this.trangthai2.Name = "trangthai2";
            this.trangthai2.Size = new System.Drawing.Size(80, 17);
            this.trangthai2.TabIndex = 2;
            this.trangthai2.Text = "checkBox1";
            this.trangthai2.UseVisualStyleBackColor = true;
            // 
            // trangthai1
            // 
            this.trangthai1.AutoSize = true;
            this.trangthai1.Location = new System.Drawing.Point(148, 45);
            this.trangthai1.Name = "trangthai1";
            this.trangthai1.Size = new System.Drawing.Size(80, 17);
            this.trangthai1.TabIndex = 3;
            this.trangthai1.Text = "checkBox1";
            this.trangthai1.UseVisualStyleBackColor = true;
            // 
            // trangthai0
            // 
            this.trangthai0.AutoSize = true;
            this.trangthai0.Location = new System.Drawing.Point(17, 45);
            this.trangthai0.Name = "trangthai0";
            this.trangthai0.Size = new System.Drawing.Size(80, 17);
            this.trangthai0.TabIndex = 4;
            this.trangthai0.Text = "checkBox1";
            this.trangthai0.UseVisualStyleBackColor = true;
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
            // frmLoc
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 268);
            this.Controls.Add(this.grTrangThai);
            this.Controls.Add(this.grMucDo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm công việc";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.grMucDo.ResumeLayout(false);
            this.grMucDo.PerformLayout();
            this.grTrangThai.ResumeLayout(false);
            this.grTrangThai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grMucDo;
        private System.Windows.Forms.RadioButton rdAllMucDo;
        private System.Windows.Forms.GroupBox grTrangThai;
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
        private System.Windows.Forms.CheckBox trangthai4;
    }
}