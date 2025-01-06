using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace SysLogit.Utility
{
    public class GenerateReports
    {
        public void GenerateExcelFile(string filePath, DataGridView dataGridView)
        {
            // Use EPPlus to create an Excel file
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Inventory");

                // Add column headers
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                   
                }

                // Add rows and data
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        var cellValue = dataGridView.Rows[row].Cells[col].Value;
                        worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : "";
                    }
                }

                // Auto-fit columns
                worksheet.Columns().AdjustToContents();

                // Save the file
                workbook.SaveAs(filePath);
            }
        }

    }
}
