using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;

namespace Services
{
    public class Reader
    {   
        public void readXls(String filePath)
        {
            var workbook = new WorkBook(filePath);
            var sheet = workbook.DefaultWorkSheet;
            var i = 0;
            foreach (var column in sheet.Columns)
            {
                var row = column.Value;
                i++;
            }
        }

        public void createXls()
        {
            var workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            var sheet = workbook.CreateWorkSheet("toto");

            sheet["A1"].Value = "Hello";
            sheet["A2"].Value = "World";

            workbook.SaveAs(@"C:\Users\storm\Documents\Cours\C#\Melu\test.xlsx");
        }
    }
}
