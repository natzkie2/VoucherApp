
namespace VoucherV1.Forms
{
    partial class Main_container_Form
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_bills = new System.Windows.Forms.Button();
            this.btn_menu_voucher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.btn_bills);
            this.panelTop.Controls.Add(this.btn_menu_voucher);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.btn_settings);
            this.panelTop.Controls.Add(this.lbl_datetime);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btn_logout);
            this.panelTop.Controls.Add(this.lbl_user);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.pictureBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1364, 74);
            this.panelTop.TabIndex = 3;
            // 
            // btn_bills
            // 
            this.btn_bills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bills.FlatAppearance.BorderSize = 0;
            this.btn_bills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_bills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_bills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bills.ForeColor = System.Drawing.Color.White;
            this.btn_bills.Image = global::VoucherV1.Properties.Resources.paycheque_16px;
            this.btn_bills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bills.Location = new System.Drawing.Point(874, 26);
            this.btn_bills.Name = "btn_bills";
            this.btn_bills.Size = new System.Drawing.Size(82, 23);
            this.btn_bills.TabIndex = 14;
            this.btn_bills.Text = "      BILL";
            this.btn_bills.UseVisualStyleBackColor = true;
            this.btn_bills.Click += new System.EventHandler(this.Btn_bills_Click);
            // 
            // btn_menu_voucher
            // 
            this.btn_menu_voucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_voucher.FlatAppearance.BorderSize = 0;
            this.btn_menu_voucher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_menu_voucher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_menu_voucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_voucher.ForeColor = System.Drawing.Color.White;
            this.btn_menu_voucher.Image = global::VoucherV1.Properties.Resources.voucher_16px;
            this.btn_menu_voucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_voucher.Location = new System.Drawing.Point(962, 26);
            this.btn_menu_voucher.Name = "btn_menu_voucher";
            this.btn_menu_voucher.Size = new System.Drawing.Size(96, 23);
            this.btn_menu_voucher.TabIndex = 13;
            this.btn_menu_voucher.Text = "      VOUCHER";
            this.btn_menu_voucher.UseVisualStyleBackColor = true;
            this.btn_menu_voucher.Click += new System.EventHandler(this.Btn_menu_voucher_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::VoucherV1.Properties.Resources.museum_16px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1064, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "      VENDOR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::VoucherV1.Properties.Resources.checked_user_male_16px;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(1150, 26);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(103, 23);
            this.btn_settings.TabIndex = 11;
            this.btn_settings.Text = "      PREFERENCE";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datetime.ForeColor = System.Drawing.Color.White;
            this.lbl_datetime.Location = new System.Drawing.Point(324, 43);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(279, 19);
            this.lbl_datetime.TabIndex = 10;
            this.lbl_datetime.Text = "USER: NAME";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "|";
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::VoucherV1.Properties.Resources.logout_16px;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(1259, 26);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 23);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "      LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(118, 43);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(179, 19);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "USER: NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "VOUCHER SYSTEM v1";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::VoucherV1.Properties.Resources.xystema_full_logo_color;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(97, 52);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 74);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1364, 692);
            this.panelControls.TabIndex = 4;
            // 
            // Main_container_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_container_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_container_Form_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_menu_voucher;
        private System.Windows.Forms.Button btn_bills;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Panel panelControls;
    }
}