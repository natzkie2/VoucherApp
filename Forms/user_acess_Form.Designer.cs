
namespace VoucherV1
{
    partial class User_access_Form
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
            this.label_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.cmb_username = new System.Windows.Forms.ComboBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.cmb_database = new System.Windows.Forms.ComboBox();
            this.link_label = new System.Windows.Forms.LinkLabel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.Red;
            this.label_time.Location = new System.Drawing.Point(293, 31);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(201, 23);
            this.label_time.TabIndex = 19;
            this.label_time.Text = "label2";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::VoucherV1.Properties.Resources.xystema_full_logo_color;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 160);
            this.label1.TabIndex = 18;
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_login.Location = new System.Drawing.Point(212, 201);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(282, 33);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // cmb_username
            // 
            this.cmb_username.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_username.FormattingEnabled = true;
            this.cmb_username.Location = new System.Drawing.Point(212, 111);
            this.cmb_username.Name = "cmb_username";
            this.cmb_username.Size = new System.Drawing.Size(282, 29);
            this.cmb_username.TabIndex = 16;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // cmb_database
            // 
            this.cmb_database.Enabled = false;
            this.cmb_database.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_database.FormattingEnabled = true;
            this.cmb_database.Location = new System.Drawing.Point(212, 71);
            this.cmb_database.Name = "cmb_database";
            this.cmb_database.Size = new System.Drawing.Size(282, 29);
            this.cmb_database.TabIndex = 22;
            // 
            // link_label
            // 
            this.link_label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_label.Location = new System.Drawing.Point(212, 240);
            this.link_label.Name = "link_label";
            this.link_label.Size = new System.Drawing.Size(282, 17);
            this.link_label.TabIndex = 21;
            this.link_label.TabStop = true;
            this.link_label.Text = "Create an account...";
            this.link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_label_LinkClicked);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tb_password.Location = new System.Drawing.Point(212, 152);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(282, 27);
            this.tb_password.TabIndex = 20;
            this.tb_password.Text = "Enter password here...";
            this.tb_password.Click += new System.EventHandler(this.Tb_password_Click);
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_password_KeyDown);
            // 
            // User_access_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 288);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cmb_username);
            this.Controls.Add(this.cmb_database);
            this.Controls.Add(this.link_label);
            this.Controls.Add(this.tb_password);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_access_Form";
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.User_access_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_login;
        private System.Windows.Forms.ComboBox cmb_username;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ComboBox cmb_database;
        private System.Windows.Forms.LinkLabel link_label;
        private System.Windows.Forms.TextBox tb_password;
    }
}

