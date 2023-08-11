
namespace VoucherV1.Forms.ATC
{
    partial class Add_atc_details_Form
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
            this.container = new System.Windows.Forms.Panel();
            this.cmb_atc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_atc_description = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.rtb_percent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.container.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(386, 42);
            this.panel2.TabIndex = 13;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(288, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 38);
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
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ATC DETAILS";
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Controls.Add(this.rtb_percent);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.cmb_atc);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.rtb_atc_description);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.label7);
            this.container.Controls.Add(this.btn_save);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(386, 327);
            this.container.TabIndex = 14;
            // 
            // cmb_atc
            // 
            this.cmb_atc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_atc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_atc.FormattingEnabled = true;
            this.cmb_atc.Location = new System.Drawing.Point(26, 85);
            this.cmb_atc.Name = "cmb_atc";
            this.cmb_atc.Size = new System.Drawing.Size(339, 23);
            this.cmb_atc.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "ATC NAME";
            // 
            // rtb_atc_description
            // 
            this.rtb_atc_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_atc_description.Location = new System.Drawing.Point(26, 203);
            this.rtb_atc_description.Name = "rtb_atc_description";
            this.rtb_atc_description.Size = new System.Drawing.Size(339, 69);
            this.rtb_atc_description.TabIndex = 23;
            this.rtb_atc_description.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "DESCRIPTION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "BRANCH NAME";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(264, 279);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 28);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // rtb_percent
            // 
            this.rtb_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_percent.Location = new System.Drawing.Point(25, 141);
            this.rtb_percent.Name = "rtb_percent";
            this.rtb_percent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtb_percent.Size = new System.Drawing.Size(339, 26);
            this.rtb_percent.TabIndex = 27;
            this.rtb_percent.Text = "";
            this.rtb_percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtb_percent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "PERCENT";
            // 
            // add_atc_details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 327);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.container);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "add_atc_details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_atc_details_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.RichTextBox rtb_atc_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_atc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_percent;
        private System.Windows.Forms.Label label2;
    }
}