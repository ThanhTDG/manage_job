﻿namespace ctk43_Nhom1_Manage_Job
{
    partial class frmMain
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
				this.components = new System.ComponentModel.Container();
				this.label1 = new System.Windows.Forms.Label();
				this.menuStrip1 = new System.Windows.Forms.MenuStrip();
				this.GhiChutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.tsmiThongKe = new System.Windows.Forms.ToolStripMenuItem();
				this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.kíchHoạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.ctmSetting = new System.Windows.Forms.ToolStripMenuItem();
				this.grbDSCongViec = new System.Windows.Forms.GroupBox();
				this.tvwDSCongViec = new System.Windows.Forms.TreeView();
				this.ctxMenuDSCongViec = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
				this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
				this.btnThemCongViec = new System.Windows.Forms.Button();
				this.label2 = new System.Windows.Forms.Label();
				this.groupBox2 = new System.Windows.Forms.GroupBox();
				this.tvwChuDe = new System.Windows.Forms.TreeView();
				this.ctxMenuTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
				this.SuaChuDeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
				this.XoaChuDeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
				this.btnThemChuDe = new System.Windows.Forms.Button();
				this.txtTimKiemTenCV = new System.Windows.Forms.TextBox();
				this.lbChucNang = new System.Windows.Forms.ListBox();
				this.tabControl1 = new System.Windows.Forms.TabControl();
				this.tabPage1 = new System.Windows.Forms.TabPage();
				this.tabPage2 = new System.Windows.Forms.TabPage();
				this.lvDSGhiChu = new System.Windows.Forms.ListView();
				this.btnThongBao = new System.Windows.Forms.Button();
				this.button2 = new System.Windows.Forms.Button();
				this.pictureBox1 = new System.Windows.Forms.PictureBox();
				this.menuStrip1.SuspendLayout();
				this.grbDSCongViec.SuspendLayout();
				this.ctxMenuDSCongViec.SuspendLayout();
				this.groupBox2.SuspendLayout();
				this.ctxMenuTreeView.SuspendLayout();
				this.tabControl1.SuspendLayout();
				this.tabPage1.SuspendLayout();
				this.tabPage2.SuspendLayout();
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.ForeColor = System.Drawing.Color.DarkCyan;
				this.label1.Location = new System.Drawing.Point(444, 30);
				this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(536, 38);
				this.label1.TabIndex = 0;
				this.label1.Text = "Ứng Dụng Quản Lý Nhắc Việc";
				this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				// menuStrip1
				// 
				this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GhiChutoolStripMenuItem,
            this.tsmiThongKe,
            this.hỗTrợToolStripMenuItem,
            this.ctmSetting});
				this.menuStrip1.Location = new System.Drawing.Point(0, 0);
				this.menuStrip1.Name = "menuStrip1";
				this.menuStrip1.Size = new System.Drawing.Size(1368, 30);
				this.menuStrip1.TabIndex = 1;
				this.menuStrip1.Text = "menuStrip1";
				// 
				// GhiChutoolStripMenuItem
				// 
				this.GhiChutoolStripMenuItem.Name = "GhiChutoolStripMenuItem";
				this.GhiChutoolStripMenuItem.Size = new System.Drawing.Size(112, 26);
				this.GhiChutoolStripMenuItem.Text = "Thêm ghi chú";
				this.GhiChutoolStripMenuItem.Click += new System.EventHandler(this.GhiChutoolStripMenuItem_Click);
				// 
				// tsmiThongKe
				// 
				this.tsmiThongKe.Name = "tsmiThongKe";
				this.tsmiThongKe.Size = new System.Drawing.Size(84, 26);
				this.tsmiThongKe.Text = "Thống kê";
				this.tsmiThongKe.Click += new System.EventHandler(this.tsmiThongKe_Click);
				// 
				// hỗTrợToolStripMenuItem
				// 
				this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kíchHoạtToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
				this.hỗTrợToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
				this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
				this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
				// 
				// kíchHoạtToolStripMenuItem
				// 
				this.kíchHoạtToolStripMenuItem.Name = "kíchHoạtToolStripMenuItem";
				this.kíchHoạtToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
				this.kíchHoạtToolStripMenuItem.Text = "Kích hoạt";
				// 
				// thôngTinToolStripMenuItem
				// 
				this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
				this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
				this.thôngTinToolStripMenuItem.Text = "Thông tin";
				// 
				// ctmSetting
				// 
				this.ctmSetting.Name = "ctmSetting";
				this.ctmSetting.Size = new System.Drawing.Size(81, 26);
				this.ctmSetting.Text = "Thiết lập";
				this.ctmSetting.Click += new System.EventHandler(this.ctmSetting_Click);
				// 
				// grbDSCongViec
				// 
				this.grbDSCongViec.Controls.Add(this.tvwDSCongViec);
				this.grbDSCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
				this.grbDSCongViec.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.grbDSCongViec.ForeColor = System.Drawing.Color.Red;
				this.grbDSCongViec.Location = new System.Drawing.Point(4, 4);
				this.grbDSCongViec.Margin = new System.Windows.Forms.Padding(4);
				this.grbDSCongViec.Name = "grbDSCongViec";
				this.grbDSCongViec.Padding = new System.Windows.Forms.Padding(4);
				this.grbDSCongViec.Size = new System.Drawing.Size(1025, 525);
				this.grbDSCongViec.TabIndex = 3;
				this.grbDSCongViec.TabStop = false;
				this.grbDSCongViec.Text = "Danh sách công việc";
				// 
				// tvwDSCongViec
				// 
				this.tvwDSCongViec.CheckBoxes = true;
				this.tvwDSCongViec.ContextMenuStrip = this.ctxMenuDSCongViec;
				this.tvwDSCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
				this.tvwDSCongViec.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.tvwDSCongViec.Indent = 19;
				this.tvwDSCongViec.ItemHeight = 30;
				this.tvwDSCongViec.Location = new System.Drawing.Point(4, 26);
				this.tvwDSCongViec.Margin = new System.Windows.Forms.Padding(4);
				this.tvwDSCongViec.Name = "tvwDSCongViec";
				this.tvwDSCongViec.Size = new System.Drawing.Size(1017, 495);
				this.tvwDSCongViec.TabIndex = 0;
				// 
				// ctxMenuDSCongViec
				// 
				this.ctxMenuDSCongViec.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.ctxMenuDSCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.markToolStripMenuItem});
				this.ctxMenuDSCongViec.Name = "ctxtMenuListView";
				this.ctxMenuDSCongViec.Size = new System.Drawing.Size(221, 106);
				// 
				// addToolStripMenuItem
				// 
				this.addToolStripMenuItem.Name = "addToolStripMenuItem";
				this.addToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
				this.addToolStripMenuItem.Text = "Tạo";
				this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
				// 
				// modifyToolStripMenuItem
				// 
				this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
				this.modifyToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
				this.modifyToolStripMenuItem.Text = "Sửa";
				this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
				// 
				// deleteToolStripMenuItem
				// 
				this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
				this.deleteToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
				this.deleteToolStripMenuItem.Text = "Xóa";
				this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
				// 
				// toolStripSeparator1
				// 
				this.toolStripSeparator1.Name = "toolStripSeparator1";
				this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
				// 
				// markToolStripMenuItem
				// 
				this.markToolStripMenuItem.Name = "markToolStripMenuItem";
				this.markToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
				this.markToolStripMenuItem.Text = "Đánh dấu hoàn thành";
				this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
				// 
				// btnThemCongViec
				// 
				this.btnThemCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				this.btnThemCongViec.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnThemCongViec.ForeColor = System.Drawing.Color.DodgerBlue;
				this.btnThemCongViec.Location = new System.Drawing.Point(16, 380);
				this.btnThemCongViec.Margin = new System.Windows.Forms.Padding(4);
				this.btnThemCongViec.Name = "btnThemCongViec";
				this.btnThemCongViec.Size = new System.Drawing.Size(283, 33);
				this.btnThemCongViec.TabIndex = 5;
				this.btnThemCongViec.Text = "Thêm Công Việc Mới";
				this.btnThemCongViec.UseVisualStyleBackColor = true;
				this.btnThemCongViec.Click += new System.EventHandler(this.btnThemCongViec_Click);
				// 
				// label2
				// 
				this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.Location = new System.Drawing.Point(76, 92);
				this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(163, 48);
				this.label2.TabIndex = 9;
				this.label2.Text = "Nhóm 1";
				this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				// 
				// groupBox2
				// 
				this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				this.groupBox2.Controls.Add(this.tvwChuDe);
				this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.groupBox2.Location = new System.Drawing.Point(16, 421);
				this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
				this.groupBox2.Name = "groupBox2";
				this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
				this.groupBox2.Size = new System.Drawing.Size(281, 242);
				this.groupBox2.TabIndex = 12;
				this.groupBox2.TabStop = false;
				this.groupBox2.Text = "Chủ đề";
				// 
				// tvwChuDe
				// 
				this.tvwChuDe.ContextMenuStrip = this.ctxMenuTreeView;
				this.tvwChuDe.Dock = System.Windows.Forms.DockStyle.Bottom;
				this.tvwChuDe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.tvwChuDe.ForeColor = System.Drawing.Color.Green;
				this.tvwChuDe.FullRowSelect = true;
				this.tvwChuDe.Location = new System.Drawing.Point(4, 26);
				this.tvwChuDe.Margin = new System.Windows.Forms.Padding(4);
				this.tvwChuDe.Name = "tvwChuDe";
				this.tvwChuDe.Size = new System.Drawing.Size(273, 212);
				this.tvwChuDe.TabIndex = 13;
				this.tvwChuDe.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwChuDe_AfterSelect);
				// 
				// ctxMenuTreeView
				// 
				this.ctxMenuTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
				this.ctxMenuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaChuDeToolStripMenuItem2,
            this.XoaChuDeToolStripMenuItem2});
				this.ctxMenuTreeView.Name = "ctxMenuTreeView";
				this.ctxMenuTreeView.Size = new System.Drawing.Size(105, 52);
				// 
				// SuaChuDeToolStripMenuItem2
				// 
				this.SuaChuDeToolStripMenuItem2.Name = "SuaChuDeToolStripMenuItem2";
				this.SuaChuDeToolStripMenuItem2.Size = new System.Drawing.Size(104, 24);
				this.SuaChuDeToolStripMenuItem2.Text = "Sửa";
				this.SuaChuDeToolStripMenuItem2.Click += new System.EventHandler(this.SuaChuDeToolStripMenuItem2_Click);
				// 
				// XoaChuDeToolStripMenuItem2
				// 
				this.XoaChuDeToolStripMenuItem2.Name = "XoaChuDeToolStripMenuItem2";
				this.XoaChuDeToolStripMenuItem2.Size = new System.Drawing.Size(104, 24);
				this.XoaChuDeToolStripMenuItem2.Text = "Xóa";
				this.XoaChuDeToolStripMenuItem2.Click += new System.EventHandler(this.XoaChuDeToolStripMenuItem2_Click);
				// 
				// btnThemChuDe
				// 
				this.btnThemChuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
				this.btnThemChuDe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnThemChuDe.ForeColor = System.Drawing.Color.DodgerBlue;
				this.btnThemChuDe.Location = new System.Drawing.Point(16, 671);
				this.btnThemChuDe.Margin = new System.Windows.Forms.Padding(4);
				this.btnThemChuDe.Name = "btnThemChuDe";
				this.btnThemChuDe.Size = new System.Drawing.Size(283, 33);
				this.btnThemChuDe.TabIndex = 13;
				this.btnThemChuDe.Text = "Thêm Chủ Đề";
				this.btnThemChuDe.UseVisualStyleBackColor = true;
				this.btnThemChuDe.Click += new System.EventHandler(this.btnThemChuDe_Click);
				// 
				// txtTimKiemTenCV
				// 
				this.txtTimKiemTenCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
				this.txtTimKiemTenCV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txtTimKiemTenCV.Location = new System.Drawing.Point(949, 102);
				this.txtTimKiemTenCV.Margin = new System.Windows.Forms.Padding(4);
				this.txtTimKiemTenCV.Name = "txtTimKiemTenCV";
				this.txtTimKiemTenCV.Size = new System.Drawing.Size(397, 29);
				this.txtTimKiemTenCV.TabIndex = 14;
				this.txtTimKiemTenCV.TextChanged += new System.EventHandler(this.txtTimKiemTenCV_TextChanged);
				// 
				// lbChucNang
				// 
				this.lbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
				this.lbChucNang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lbChucNang.ForeColor = System.Drawing.Color.Green;
				this.lbChucNang.FormattingEnabled = true;
				this.lbChucNang.ItemHeight = 21;
				this.lbChucNang.Items.AddRange(new object[] {
            "Công việc hôm nay",
            "Công việc ngày mai",
            "Công việc quan trọng"});
				this.lbChucNang.Location = new System.Drawing.Point(16, 160);
				this.lbChucNang.Margin = new System.Windows.Forms.Padding(4);
				this.lbChucNang.Name = "lbChucNang";
				this.lbChucNang.Size = new System.Drawing.Size(276, 193);
				this.lbChucNang.TabIndex = 16;
				this.lbChucNang.SelectedIndexChanged += new System.EventHandler(this.lbChucNang_SelectedIndexChanged);
				// 
				// tabControl1
				// 
				this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
				this.tabControl1.Controls.Add(this.tabPage1);
				this.tabControl1.Controls.Add(this.tabPage2);
				this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.tabControl1.Location = new System.Drawing.Point(311, 140);
				this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
				this.tabControl1.Name = "tabControl1";
				this.tabControl1.SelectedIndex = 0;
				this.tabControl1.Size = new System.Drawing.Size(1041, 567);
				this.tabControl1.TabIndex = 17;
				// 
				// tabPage1
				// 
				this.tabPage1.Controls.Add(this.grbDSCongViec);
				this.tabPage1.Location = new System.Drawing.Point(4, 30);
				this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
				this.tabPage1.Name = "tabPage1";
				this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
				this.tabPage1.Size = new System.Drawing.Size(1033, 533);
				this.tabPage1.TabIndex = 0;
				this.tabPage1.Text = "Công Việc";
				this.tabPage1.UseVisualStyleBackColor = true;
				// 
				// tabPage2
				// 
				this.tabPage2.Controls.Add(this.lvDSGhiChu);
				this.tabPage2.Location = new System.Drawing.Point(4, 30);
				this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
				this.tabPage2.Name = "tabPage2";
				this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
				this.tabPage2.Size = new System.Drawing.Size(1033, 533);
				this.tabPage2.TabIndex = 1;
				this.tabPage2.Text = "Ghi chú";
				this.tabPage2.UseVisualStyleBackColor = true;
				// 
				// lvDSGhiChu
				// 
				this.lvDSGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
				this.lvDSGhiChu.HideSelection = false;
				this.lvDSGhiChu.Location = new System.Drawing.Point(4, 4);
				this.lvDSGhiChu.Margin = new System.Windows.Forms.Padding(4);
				this.lvDSGhiChu.Name = "lvDSGhiChu";
				this.lvDSGhiChu.Size = new System.Drawing.Size(1025, 525);
				this.lvDSGhiChu.TabIndex = 0;
				this.lvDSGhiChu.UseCompatibleStateImageBehavior = false;
				// 
				// btnThongBao
				// 
				this.btnThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
				this.btnThongBao.Image = global::ctk43_Nhom1_Manage_Job.Properties.Resources.bell;
				this.btnThongBao.Location = new System.Drawing.Point(1288, 39);
				this.btnThongBao.Margin = new System.Windows.Forms.Padding(4);
				this.btnThongBao.Name = "btnThongBao";
				this.btnThongBao.Size = new System.Drawing.Size(60, 55);
				this.btnThongBao.TabIndex = 15;
				this.btnThongBao.UseVisualStyleBackColor = true;
				this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
				// 
				// button2
				// 
				this.button2.Image = global::ctk43_Nhom1_Manage_Job.Properties.Resources.searchv2;
				this.button2.Location = new System.Drawing.Point(247, 92);
				this.button2.Margin = new System.Windows.Forms.Padding(4);
				this.button2.Name = "button2";
				this.button2.Size = new System.Drawing.Size(52, 48);
				this.button2.TabIndex = 8;
				this.button2.UseVisualStyleBackColor = true;
				// 
				// pictureBox1
				// 
				this.pictureBox1.Image = global::ctk43_Nhom1_Manage_Job.Properties.Resources.LOGOKHOA;
				this.pictureBox1.Location = new System.Drawing.Point(16, 92);
				this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
				this.pictureBox1.Name = "pictureBox1";
				this.pictureBox1.Size = new System.Drawing.Size(52, 48);
				this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				this.pictureBox1.TabIndex = 7;
				this.pictureBox1.TabStop = false;
				// 
				// frmMain
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(1368, 722);
				this.Controls.Add(this.tabControl1);
				this.Controls.Add(this.lbChucNang);
				this.Controls.Add(this.btnThongBao);
				this.Controls.Add(this.txtTimKiemTenCV);
				this.Controls.Add(this.btnThemChuDe);
				this.Controls.Add(this.groupBox2);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.button2);
				this.Controls.Add(this.pictureBox1);
				this.Controls.Add(this.btnThemCongViec);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.menuStrip1);
				this.MainMenuStrip = this.menuStrip1;
				this.Margin = new System.Windows.Forms.Padding(4);
				this.Name = "frmMain";
				this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				this.Text = "Quản lý nhắc việc";
				this.Load += new System.EventHandler(this.frmMain_Load);
				this.menuStrip1.ResumeLayout(false);
				this.menuStrip1.PerformLayout();
				this.grbDSCongViec.ResumeLayout(false);
				this.ctxMenuDSCongViec.ResumeLayout(false);
				this.groupBox2.ResumeLayout(false);
				this.ctxMenuTreeView.ResumeLayout(false);
				this.tabControl1.ResumeLayout(false);
				this.tabPage1.ResumeLayout(false);
				this.tabPage2.ResumeLayout(false);
				((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grbDSCongViec;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDSCongViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvwChuDe;
        private System.Windows.Forms.Button btnThemChuDe;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongKe;
        private System.Windows.Forms.ToolStripMenuItem kíchHoạtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuTreeView;
        private System.Windows.Forms.ToolStripMenuItem SuaChuDeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem XoaChuDeToolStripMenuItem2;
        private System.Windows.Forms.TextBox txtTimKiemTenCV;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.TreeView tvwDSCongViec;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ListBox lbChucNang;
        private System.Windows.Forms.ToolStripMenuItem GhiChutoolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvDSGhiChu;
        private System.Windows.Forms.ToolStripMenuItem ctmSetting;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}