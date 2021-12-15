namespace ctk43_Nhom1_Manage_Job.myUserControl
{
    partial class UscThongBao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grCV = new System.Windows.Forms.GroupBox();
            this.grMoTa = new System.Windows.Forms.GroupBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.lbpercent = new System.Windows.Forms.Label();
            this.pcbTienDo = new System.Windows.Forms.ProgressBar();
            this.ckbFinish = new System.Windows.Forms.CheckBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTienDo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grCV.SuspendLayout();
            this.grMoTa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grCV
            // 
            this.grCV.Controls.Add(this.grMoTa);
            this.grCV.Controls.Add(this.lbpercent);
            this.grCV.Controls.Add(this.pcbTienDo);
            this.grCV.Controls.Add(this.ckbFinish);
            this.grCV.Controls.Add(this.txtTime);
            this.grCV.Controls.Add(this.lbTime);
            this.grCV.Controls.Add(this.lbTienDo);
            this.grCV.Controls.Add(this.txtName);
            this.grCV.Controls.Add(this.label2);
            this.grCV.Controls.Add(this.label1);
            this.grCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCV.Location = new System.Drawing.Point(0, 0);
            this.grCV.Name = "grCV";
            this.grCV.Size = new System.Drawing.Size(351, 199);
            this.grCV.TabIndex = 0;
            this.grCV.TabStop = false;
            this.grCV.Text = "groupBox1";
            // 
            // grMoTa
            // 
            this.grMoTa.Controls.Add(this.txtMota);
            this.grMoTa.Location = new System.Drawing.Point(6, 122);
            this.grMoTa.Name = "grMoTa";
            this.grMoTa.Size = new System.Drawing.Size(332, 71);
            this.grMoTa.TabIndex = 8;
            this.grMoTa.TabStop = false;
            this.grMoTa.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMota.Location = new System.Drawing.Point(3, 16);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(326, 52);
            this.txtMota.TabIndex = 0;
            // 
            // lbpercent
            // 
            this.lbpercent.AutoSize = true;
            this.lbpercent.Location = new System.Drawing.Point(302, 77);
            this.lbpercent.Name = "lbpercent";
            this.lbpercent.Size = new System.Drawing.Size(33, 13);
            this.lbpercent.TabIndex = 7;
            this.lbpercent.Text = "100%";
            // 
            // pcbTienDo
            // 
            this.pcbTienDo.Location = new System.Drawing.Point(100, 74);
            this.pcbTienDo.Name = "pcbTienDo";
            this.pcbTienDo.Size = new System.Drawing.Size(202, 20);
            this.pcbTienDo.TabIndex = 6;
            // 
            // ckbFinish
            // 
            this.ckbFinish.AutoSize = true;
            this.ckbFinish.Location = new System.Drawing.Point(256, 101);
            this.ckbFinish.Name = "ckbFinish";
            this.ckbFinish.Size = new System.Drawing.Size(82, 17);
            this.ckbFinish.TabIndex = 5;
            this.ckbFinish.Text = "Hoàn thành";
            this.ckbFinish.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(100, 101);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(141, 20);
            this.txtTime.TabIndex = 4;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(6, 105);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(93, 13);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Thời gian kết thúc";
            // 
            // lbTienDo
            // 
            this.lbTienDo.AutoSize = true;
            this.lbTienDo.Location = new System.Drawing.Point(6, 77);
            this.lbTienDo.Name = "lbTienDo";
            this.lbTienDo.Size = new System.Drawing.Size(44, 13);
            this.lbTienDo.TabIndex = 3;
            this.lbTienDo.Text = "Tiến độ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông báo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc";
            // 
            // UscThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grCV);
            this.Name = "UscThongBao";
            this.Size = new System.Drawing.Size(351, 199);
            this.grCV.ResumeLayout(false);
            this.grCV.PerformLayout();
            this.grMoTa.ResumeLayout(false);
            this.grMoTa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grCV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grMoTa;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label lbpercent;
        private System.Windows.Forms.ProgressBar pcbTienDo;
        private System.Windows.Forms.CheckBox ckbFinish;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTienDo;
    }
}
