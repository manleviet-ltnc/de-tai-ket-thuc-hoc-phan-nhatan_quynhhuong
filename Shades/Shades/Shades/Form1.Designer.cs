namespace Shades
{
    partial class Form1
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
            this.btnMau = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMau
            // 
            this.btnMau.Location = new System.Drawing.Point(197, 12);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(75, 26);
            this.btnMau.TabIndex = 0;
            this.btnMau.Text = "Chọn màu";
            this.btnMau.UseVisualStyleBackColor = true;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(13, 13);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnMau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button button1;
    }
}

