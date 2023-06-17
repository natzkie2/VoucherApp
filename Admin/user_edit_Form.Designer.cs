namespace VoucherV1.Admin
{
    partial class User_edit_Form
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.tb_override = new System.Windows.Forms.TextBox();
            this.label_override = new System.Windows.Forms.Label();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_roles = new System.Windows.Forms.Label();
            this.label_role = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(272, 414);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(90, 30);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "UPDATE";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 48);
            this.panel1.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(303, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 44);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "[ CLOSE ]";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "EDIT ACCOUNT / PERSONAL DETAILS";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(366, 99);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 23;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // tb_override
            // 
            this.tb_override.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_override.Location = new System.Drawing.Point(24, 209);
            this.tb_override.Margin = new System.Windows.Forms.Padding(2);
            this.tb_override.Name = "tb_override";
            this.tb_override.PasswordChar = '*';
            this.tb_override.Size = new System.Drawing.Size(338, 23);
            this.tb_override.TabIndex = 22;
            // 
            // label_override
            // 
            this.label_override.AutoSize = true;
            this.label_override.Location = new System.Drawing.Point(21, 189);
            this.label_override.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_override.Name = "label_override";
            this.label_override.Size = new System.Drawing.Size(125, 15);
            this.label_override.TabIndex = 21;
            this.label_override.Text = "OVERRIDE PASSWORD";
            // 
            // tb_confirm
            // 
            this.tb_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_confirm.Location = new System.Drawing.Point(24, 153);
            this.tb_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.PasswordChar = '*';
            this.tb_confirm.Size = new System.Drawing.Size(338, 23);
            this.tb_confirm.TabIndex = 20;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Location = new System.Drawing.Point(24, 95);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(338, 23);
            this.tb_password.TabIndex = 19;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Location = new System.Drawing.Point(24, 40);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(338, 23);
            this.tb_username.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "CONFIRM PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "USERNAME";
            // 
            // lbl_roles
            // 
            this.lbl_roles.AutoSize = true;
            this.lbl_roles.Location = new System.Drawing.Point(83, 386);
            this.lbl_roles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_roles.Name = "lbl_roles";
            this.lbl_roles.Size = new System.Drawing.Size(34, 15);
            this.lbl_roles.TabIndex = 29;
            this.lbl_roles.Text = "ROLE";
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(21, 386);
            this.label_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(34, 15);
            this.label_role.TabIndex = 28;
            this.label_role.Text = "ROLE";
            // 
            // tb_lastname
            // 
            this.tb_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lastname.Location = new System.Drawing.Point(24, 344);
            this.tb_lastname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(338, 23);
            this.tb_lastname.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "LAST NAME";
            // 
            // tb_firstname
            // 
            this.tb_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_firstname.Location = new System.Drawing.Point(24, 289);
            this.tb_firstname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(338, 23);
            this.tb_firstname.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "FIRST NAME";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.lbl_roles);
            this.container.Controls.Add(this.btn_edit);
            this.container.Controls.Add(this.label_role);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.tb_lastname);
            this.container.Controls.Add(this.label3);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.tb_username);
            this.container.Controls.Add(this.tb_firstname);
            this.container.Controls.Add(this.tb_password);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.tb_confirm);
            this.container.Controls.Add(this.checkBox);
            this.container.Controls.Add(this.label_override);
            this.container.Controls.Add(this.tb_override);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 48);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(390, 472);
            this.container.TabIndex = 30;
            // 
            // User_edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 520);
            this.ControlBox = false;
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "User_edit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_edit_Form_FormClosed);
            this.Load += new System.EventHandler(this.User_edit_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox tb_override;
        private System.Windows.Forms.Label label_override;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_roles;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel container;
    }
}