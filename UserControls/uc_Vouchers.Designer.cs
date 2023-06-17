
namespace VoucherV1.UserControls
{
    partial class Uc_Vouchers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtp_voucher_history = new MetroFramework.Controls.MetroTabPage();
            this.panel_vendor_center = new System.Windows.Forms.Panel();
            this.panel_bills_right = new System.Windows.Forms.Panel();
            this.dgv_voucher_history = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_search_vendor = new MetroFramework.Controls.MetroTextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.metroTabControl.SuspendLayout();
            this.mtp_voucher_history.SuspendLayout();
            this.panel_vendor_center.SuspendLayout();
            this.panel_bills_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voucher_history)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.mtp_voucher_history);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1364, 692);
            this.metroTabControl.TabIndex = 6;
            this.metroTabControl.UseSelectable = true;
            // 
            // mtp_voucher_history
            // 
            this.mtp_voucher_history.Controls.Add(this.panel_vendor_center);
            this.mtp_voucher_history.Controls.Add(this.panel2);
            this.mtp_voucher_history.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtp_voucher_history.HorizontalScrollbarBarColor = false;
            this.mtp_voucher_history.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_voucher_history.HorizontalScrollbarSize = 0;
            this.mtp_voucher_history.Location = new System.Drawing.Point(4, 38);
            this.mtp_voucher_history.Name = "mtp_voucher_history";
            this.mtp_voucher_history.Size = new System.Drawing.Size(1356, 650);
            this.mtp_voucher_history.TabIndex = 0;
            this.mtp_voucher_history.Text = "HISTORY";
            this.mtp_voucher_history.VerticalScrollbarBarColor = false;
            this.mtp_voucher_history.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_voucher_history.VerticalScrollbarSize = 0;
            // 
            // panel_vendor_center
            // 
            this.panel_vendor_center.BackColor = System.Drawing.Color.White;
            this.panel_vendor_center.Controls.Add(this.panel_bills_right);
            this.panel_vendor_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vendor_center.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_vendor_center.Location = new System.Drawing.Point(0, 34);
            this.panel_vendor_center.Name = "panel_vendor_center";
            this.panel_vendor_center.Size = new System.Drawing.Size(1356, 616);
            this.panel_vendor_center.TabIndex = 3;
            // 
            // panel_bills_right
            // 
            this.panel_bills_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bills_right.Controls.Add(this.dgv_voucher_history);
            this.panel_bills_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bills_right.Location = new System.Drawing.Point(0, 0);
            this.panel_bills_right.Name = "panel_bills_right";
            this.panel_bills_right.Size = new System.Drawing.Size(1356, 616);
            this.panel_bills_right.TabIndex = 13;
            // 
            // dgv_voucher_history
            // 
            this.dgv_voucher_history.AllowUserToAddRows = false;
            this.dgv_voucher_history.AllowUserToResizeColumns = false;
            this.dgv_voucher_history.AllowUserToResizeRows = false;
            this.dgv_voucher_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_voucher_history.BackgroundColor = System.Drawing.Color.White;
            this.dgv_voucher_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_voucher_history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_voucher_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_voucher_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_voucher_history.ColumnHeadersHeight = 30;
            this.dgv_voucher_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_voucher_history.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_voucher_history.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_voucher_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_voucher_history.EnableHeadersVisualStyles = false;
            this.dgv_voucher_history.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_voucher_history.Location = new System.Drawing.Point(0, 0);
            this.dgv_voucher_history.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_voucher_history.Name = "dgv_voucher_history";
            this.dgv_voucher_history.ReadOnly = true;
            this.dgv_voucher_history.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_voucher_history.RowHeadersVisible = false;
            this.dgv_voucher_history.RowHeadersWidth = 51;
            this.dgv_voucher_history.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_voucher_history.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_voucher_history.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_voucher_history.RowTemplate.Height = 30;
            this.dgv_voucher_history.RowTemplate.ReadOnly = true;
            this.dgv_voucher_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_voucher_history.Size = new System.Drawing.Size(1352, 612);
            this.dgv_voucher_history.TabIndex = 13;
            this.dgv_voucher_history.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_voucher_history_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.tb_search_vendor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 34);
            this.panel2.TabIndex = 2;
            // 
            // tb_search_vendor
            // 
            // 
            // 
            // 
            this.tb_search_vendor.CustomButton.Image = null;
            this.tb_search_vendor.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.tb_search_vendor.CustomButton.Name = "";
            this.tb_search_vendor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_search_vendor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_search_vendor.CustomButton.TabIndex = 1;
            this.tb_search_vendor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search_vendor.CustomButton.UseSelectable = true;
            this.tb_search_vendor.CustomButton.Visible = false;
            this.tb_search_vendor.DisplayIcon = true;
            this.tb_search_vendor.Icon = global::VoucherV1.Properties.Resources.search_16px;
            this.tb_search_vendor.Lines = new string[0];
            this.tb_search_vendor.Location = new System.Drawing.Point(927, 6);
            this.tb_search_vendor.MaxLength = 32767;
            this.tb_search_vendor.Name = "tb_search_vendor";
            this.tb_search_vendor.PasswordChar = '\0';
            this.tb_search_vendor.PromptText = "Search";
            this.tb_search_vendor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_search_vendor.SelectedText = "";
            this.tb_search_vendor.SelectionLength = 0;
            this.tb_search_vendor.SelectionStart = 0;
            this.tb_search_vendor.ShortcutsEnabled = true;
            this.tb_search_vendor.Size = new System.Drawing.Size(426, 23);
            this.tb_search_vendor.TabIndex = 10;
            this.tb_search_vendor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search_vendor.UseSelectable = true;
            this.tb_search_vendor.WaterMark = "Search";
            this.tb_search_vendor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_search_vendor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(7, 5);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 24);
            this.btn_refresh.TabIndex = 31;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // Uc_Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Uc_Vouchers";
            this.Size = new System.Drawing.Size(1364, 692);
            this.Load += new System.EventHandler(this.Uc_Vouchers_Load);
            this.metroTabControl.ResumeLayout(false);
            this.mtp_voucher_history.ResumeLayout(false);
            this.panel_vendor_center.ResumeLayout(false);
            this.panel_bills_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voucher_history)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage mtp_voucher_history;
        private System.Windows.Forms.Panel panel_vendor_center;
        private System.Windows.Forms.Panel panel_bills_right;
        private System.Windows.Forms.DataGridView dgv_voucher_history;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox tb_search_vendor;
        private System.Windows.Forms.Button btn_refresh;
    }
}
