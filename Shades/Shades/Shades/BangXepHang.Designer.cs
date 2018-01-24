namespace Shades
{
    partial class frmBang_Xep_Hang
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
            this.lsvBangXepHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvBangXepHang
            // 
            this.lsvBangXepHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvBangXepHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBangXepHang.Location = new System.Drawing.Point(0, 0);
            this.lsvBangXepHang.Name = "lsvBangXepHang";
            this.lsvBangXepHang.Size = new System.Drawing.Size(284, 261);
            this.lsvBangXepHang.TabIndex = 0;
            this.lsvBangXepHang.UseCompatibleStateImageBehavior = false;
            // 
            // frmBang_Xep_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lsvBangXepHang);
            this.Name = "frmBang_Xep_Hang";
            this.Text = "BangXepHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvBangXepHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}