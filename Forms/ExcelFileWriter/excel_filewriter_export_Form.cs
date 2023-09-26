using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Class;
using VoucherV1.Object;
using VoucherV1.Properties;

namespace VoucherV1.Forms.ExcelFileWriter
{
    public partial class Excel_filewriter_export_Form : Form
    {
        List<XLSFileWriter> dataList;

        public Excel_filewriter_export_Form(List<XLSFileWriter> dataList)
        {
            InitializeComponent();
            this.dataList = dataList;
        }

        private void Excel_filewriter_export_Form_Load(object sender, EventArgs e)
        {
            PopulateToFileWriterDataGridView();
        }

        private void PopulateToFileWriterDataGridView()
        {
            foreach (XLSFileWriter writer in dataList)
            {
                dgv_fileWriter.Rows.Add(writer.IsSelfService, writer.CheckAmount, writer.SourceAccount, writer.IsPayeeAccountOnly, writer.CheckDate, "", "",
                    writer.PayeeName, "", "", "", "", "", "", "", "", "", "", writer.Particulars, writer.Remarks);
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Excel_filewriter_export_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                voucher_path_Form vpf = new voucher_path_Form();
                vpf.ShowDialog();
            }
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            string sheetName = "Corporate Check XLS FileWriter";

            ExportDataGridViewToExcel(dgv_fileWriter, sheetName);
        }

        private void ExportDataGridViewToExcel(DataGridView dataGridView, string sheetName)
        {
            // Create a new DataTable to store the data from the DataGridView
            var dataTable = new System.Data.DataTable();

            // Add columns to the DataTable based on DataGridView columns
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string)); // Change the typeof() to match your data type
            }

            // Add data rows to the DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            // Save the DataTable to Excel using the existing method mentioned before
            SaveDataTableToExcel(dataTable, sheetName);
        }

        private void SaveDataTableToExcel(System.Data.DataTable dataTable, string sheetName)
        {
            string path = Settings.Default["Excel"].ToString();
            string filePath = @path;
            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Add a new worksheet to the Excel package
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                // Write the column headers to the worksheet
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Write the data to the worksheet
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                    }
                }

                File.WriteAllBytes(filePath + "Corporate_Check_XLS_FileWriter.xlsx", package.GetAsByteArray());
                System.Diagnostics.Process.Start(filePath);
            }

            bool exportSuccess =  AutofitExcelColumns(filePath + "Corporate_Check_XLS_FileWriter.xlsx", sheetName);

            if (exportSuccess)
            {
                UpdateVoucherStatusExportTrue();
            }
            else
            {
                MessageBox.Show("Export to Excel failed!", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AutofitExcelColumns(string filePath, string sheetName)
        {
            FileInfo file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                ExcelRange headerRow = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column];

                // Set protection options for the header row
                headerRow.Style.Locked = true;
                headerRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                headerRow.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(41, 128, 185));

                

                double numericValue;
                if (double.TryParse(worksheet.Cells[2, 2, worksheet.Dimension.End.Row, 2].Text, out numericValue))
                {
                    worksheet.Cells[2, 2, worksheet.Dimension.End.Row, 2].Value = numericValue;
                }


                worksheet.Cells[2, 2, worksheet.Dimension.End.Row, 2].Style.Numberformat.Format = "General";
                worksheet.Cells[2, 2, worksheet.Dimension.End.Row, 2].Style.Numberformat.Format = "#,##0.00";

                headerRow.Style.Font.Color.SetColor(Color.White);
                headerRow.Style.Font.Bold = true;

                // Protect the worksheet (optional - to prevent other modifications)
                //worksheet.Protection.IsProtected = true;
                //worksheet.Protection.AllowSelectLockedCells = true;

                // Autofit all columns in the worksheet
                worksheet.Cells.AutoFitColumns();
              
                try
                {
                    // ... (code to export DataGridView to Excel as shown in the previous responses)
                    package.Save();
                    return true;
                }
                catch (Exception ex)
                {
                    // Handle the exception, log, or display an error message
                    Console.WriteLine("Error exporting to Excel: " + ex.Message);

                    // Export failed
                    return false;
                }
            }
        }

        private void UpdateVoucherStatusExportTrue()
        {
            Voucher_Class vc = new Voucher_Class
            {
                Database = ""
            };

            foreach (XLSFileWriter writer in dataList)
            {
                vc.UpdateVoucherIsExport(writer.Remarks);
            }
        }
    }
}
