
namespace VoucherV1.Forms
{
    partial class voucher_path_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_directory_voucher = new System.Windows.Forms.RichTextBox();
            this.btn_voucher_save = new System.Windows.Forms.Button();
            this.btn_voucher_open = new System.Windows.Forms.Button();
            this.btn_check_open = new System.Windows.Forms.Button();
            this.btn_check_save = new System.Windows.Forms.Button();
            this.tb_directory_check = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 36);
            this.panel2.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(399, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 33);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "[ CLOSE ]";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "SET PATH";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "VOUCHER PATH:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_directory_voucher
            // 
            this.tb_directory_voucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_directory_voucher.Enabled = false;
            this.tb_directory_voucher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_directory_voucher.Location = new System.Drawing.Point(144, 65);
            this.tb_directory_voucher.Margin = new System.Windows.Forms.Padding(2);
            this.tb_directory_voucher.Name = "tb_directory_voucher";
            this.tb_directory_voucher.Size = new System.Drawing.Size(322, 71);
            this.tb_directory_voucher.TabIndex = 20;
            this.tb_directory_voucher.Text = "";
            // 
            // btn_voucher_save
            // 
            this.btn_voucher_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_voucher_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_voucher_save.FlatAppearance.BorderSize = 0;
            this.btn_voucher_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voucher_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voucher_save.ForeColor = System.Drawing.Color.White;
            this.btn_voucher_save.Location = new System.Drawing.Point(349, 147);
            this.btn_voucher_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_voucher_save.Name = "btn_voucher_save";
            this.btn_voucher_save.Size = new System.Drawing.Size(117, 24);
            this.btn_voucher_save.TabIndex = 31;
            this.btn_voucher_save.Text = "SAVE";
            this.btn_voucher_save.UseVisualStyleBackColor = false;
            this.btn_voucher_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_voucher_open
            // 
            this.btn_voucher_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_voucher_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_voucher_open.FlatAppearance.BorderSize = 0;
            this.btn_voucher_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voucher_open.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voucher_open.ForeColor = System.Drawing.Color.White;
            this.btn_voucher_open.Location = new System.Drawing.Point(228, 147);
            this.btn_voucher_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_voucher_open.Name = "btn_voucher_open";
            this.btn_voucher_open.Size = new System.Drawing.Size(117, 24);
            this.btn_voucher_open.TabIndex = 32;
            this.btn_voucher_open.Text = "OPEN";
            this.btn_voucher_open.UseVisualStyleBackColor = false;
            this.btn_voucher_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // btn_check_open
            // 
            this.btn_check_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_check_open.FlatAppearance.BorderSize = 0;
            this.btn_check_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check_open.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_open.ForeColor = System.Drawing.Color.White;
            this.btn_check_open.Location = new System.Drawing.Point(228, 264);
            this.btn_check_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_check_open.Name = "btn_check_open";
            this.btn_check_open.Size = new System.Drawing.Size(117, 24);
            this.btn_check_open.TabIndex = 36;
            this.btn_check_open.Text = "OPEN";
            this.btn_check_open.UseVisualStyleBackColor = false;
            this.btn_check_open.Click += new System.EventHandler(this.Btn_check_open_Click);
            // 
            // btn_check_save
            // 
            this.btn_check_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_check_save.FlatAppearance.BorderSize = 0;
            this.btn_check_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check_save.ForeColor = System.Drawing.Color.White;
            this.btn_check_save.Location = new System.Drawing.Point(349, 264);
            this.btn_check_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_check_save.Name = "btn_check_save";
            this.btn_check_save.Size = new System.Drawing.Size(117, 24);
            this.btn_check_save.TabIndex = 35;
            this.btn_check_save.Text = "SAVE";
            this.btn_check_save.UseVisualStyleBackColor = false;
            this.btn_check_save.Click += new System.EventHandler(this.Btn_check_save_Click);
            // 
            // tb_directory_check
            // 
            this.tb_directory_check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_directory_check.Enabled = false;
            this.tb_directory_check.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_directory_check.Location = new System.Drawing.Point(144, 182);
            this.tb_directory_check.Margin = new System.Windows.Forms.Padding(2);
            this.tb_directory_check.Name = "tb_directory_check";
            this.tb_directory_check.Size = new System.Drawing.Size(322, 71);
            this.tb_directory_check.TabIndex = 34;
            this.tb_directory_check.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHECK PATH:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // voucher_path_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 310);
            this.ControlBox = false;
            this.Controls.Add(this.btn_check_open);
            this.Controls.Add(this.btn_check_save);
            this.Controls.Add(this.tb_directory_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voucher_open);
            this.Controls.Add(this.btn_voucher_save);
            this.Controls.Add(this.tb_directory_voucher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "voucher_path_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Voucher_path_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_directory_voucher;
        private System.Windows.Forms.Button btn_voucher_save;
        private System.Windows.Forms.Button btn_voucher_open;
        private System.Windows.Forms.Button btn_check_open;
        private System.Windows.Forms.Button btn_check_save;
        private System.Windows.Forms.RichTextBox tb_directory_check;
        private System.Windows.Forms.Label label1;
    }
}