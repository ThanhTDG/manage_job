
namespace ctk43_Nhom1_Manage_Job
{
    partial class frmDangKy
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
				this.button6 = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.mstbKey = new System.Windows.Forms.MaskedTextBox();
				this.SuspendLayout();
				// 
				// button1
				// 
				this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.button1.ForeColor = System.Drawing.Color.Crimson;
				this.button1.Location = new System.Drawing.Point(350, 73);
				this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
				this.button1.Name = "button1";
				this.button1.Size = new System.Drawing.Size(131, 33);
				this.button1.TabIndex = 144;
				this.button1.Text = "Hủy";
				this.button1.UseVisualStyleBackColor = true;
				this.button1.Click += new System.EventHandler(this.button1_Click);
				// 
				// button6
				// 
				this.button6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.button6.ForeColor = System.Drawing.Color.SteelBlue;
				this.button6.Location = new System.Drawing.Point(43, 73);
				this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
				this.button6.Name = "button6";
				this.button6.Size = new System.Drawing.Size(131, 33);
				this.button6.TabIndex = 143;
				this.button6.Text = "Lưu";
				this.button6.UseVisualStyleBackColor = true;
				this.button6.Click += new System.EventHandler(this.button6_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(43, 28);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(103, 17);
				this.label1.TabIndex = 145;
				this.label1.Text = "Key bản quyền";
				// 
				// mstbKey
				// 
				this.mstbKey.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
				this.mstbKey.Location = new System.Drawing.Point(167, 28);
				this.mstbKey.Mask = "000-000-000";
				this.mstbKey.Name = "mstbKey";
				this.mstbKey.Size = new System.Drawing.Size(314, 22);
				this.mstbKey.TabIndex = 146;
				this.mstbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
				this.mstbKey.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
				// 
				// frmDangKy
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(507, 118);
				this.Controls.Add(this.mstbKey);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.button1);
				this.Controls.Add(this.button6);
				this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
				this.MaximizeBox = false;
				this.Name = "frmDangKy";
				this.Text = "Đăng Ký";
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.MaskedTextBox mstbKey;
	 }
}