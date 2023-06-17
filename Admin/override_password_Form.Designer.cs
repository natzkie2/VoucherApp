namespace VoucherV1.Admin
{
    partial class Override_password_form
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
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_access = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(189, 87);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(299, 32);
            this.tb_password.TabIndex = 7;
            this.tb_password.Text = "Enter password here...";
            this.tb_password.Click += new System.EventHandler(this.Tb_password_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Access";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_access
            // 
            this.btn_access.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_access.Location = new System.Drawing.Point(189, 125);
            this.btn_access.Name = "btn_access";
            this.btn_access.Size = new System.Drawing.Size(299, 33);
            this.btn_access.TabIndex = 9;
            this.btn_access.Text = "CONFIRM";
            this.btn_access.UseSelectable = true;
            this.btn_access.Click += new System.EventHandler(this.Btn_access_Click);
            // 
            // Override_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 186);
            this.Controls.Add(this.btn_access);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Override_password_form";
            this.Resizable = false;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Override_password_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_access;
    }
}